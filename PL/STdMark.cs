using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace MangmentUn.PL
{
    public partial class STdMark : Form
    {
        MangmentEntities1 DB;
        StudentMark stdMark;

        public int Id { set; get; }


        DeleteMessage delete;
        AddMessage added;
        ErrorMessage error;
        EditMessage edit;

        private void LoadStudentMarks()
        {
            try
            {
                DB = new MangmentEntities1();
                dataS.DataSource = DB.StudentMarks.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadStudent()
        {
            try
            {
                DB = new MangmentEntities1();
                dataStd.DataSource = DB.Students.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadExam()
        {
            try
            {
                DB = new MangmentEntities1();
                dataExam.DataSource = DB.Exams.ToList();
                Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadExamToCombo()
        {
            try
            {
                DB = new MangmentEntities1();
                var data = DB.Exams.Select(x => x.Id.ToString()).ToList();
                comboBox1.Items.AddRange(data.ToArray());
                comboBox2.Items.AddRange(data.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       
        public STdMark()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            
            if (Mark.Text == "")
            {
                error = new ErrorMessage();
                error.Show();
            }
            else
            {

                try
                {
                    DB = new MangmentEntities1();
                    stdMark = new StudentMark();
                    int Mark2 = Convert.ToInt32(Mark.Text);
                    stdMark.Mark = Mark2;
                    stdMark.StudentId = Convert.ToInt32(dataStd.CurrentRow.Cells[0].Value);
                    stdMark.ExamId = Convert.ToInt32(dataStd.CurrentRow.Cells[0].Value);
                    DB.Entry(stdMark).State = EntityState.Added;
                    DB.SaveChanges();
                    added = new AddMessage();
                    added.Show();
                    Mark.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        private void Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (Mark.Text == "")
                {
                    error = new ErrorMessage();
                    error.Show();
                }
                else
                {
                    DB = new MangmentEntities1();
                    stdMark = new StudentMark();
                    stdMark.Id = Id;
                    stdMark.Mark = Convert.ToInt32(Mark.Text);
                    stdMark.StudentId = Convert.ToInt32(dataStd.CurrentRow.Cells[0].Value);
                    stdMark.ExamId = Convert.ToInt32(dataStd.CurrentRow.Cells[0].Value);
                    DB.Entry(stdMark).State = EntityState.Modified;
                    DB.SaveChanges();
                    edit = new EditMessage();
                    edit.Show();
                    Mark.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DB = new MangmentEntities1();
            stdMark = new StudentMark();
            stdMark.Id = Convert.ToInt16(dataS.CurrentRow.Cells[0].Value);
            DB.Entry(stdMark).State = EntityState.Deleted;
            DB.SaveChanges();
            delete = new DeleteMessage();
            delete.Show();
        }

        private void Data_DoubleClick(object sender, EventArgs e)
        {
            
           
        }

        private void DataS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = Convert.ToInt16(dataS.CurrentRow.Cells[0].Value);
            Mark.Text = dataS.CurrentRow.Cells[3].Value.ToString();
        }

        private void DataS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = Convert.ToInt16(dataS.CurrentRow.Cells[0].Value);
        }


        private void STdMark_Activated(object sender, EventArgs e)
        {
            LoadStudentMarks();
            LoadExam();
            LoadStudent();
        }


        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DS s = new DS();
            s.Show();
            this.Close();
        }

        private void STdMark_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("All");
            LoadExam();
            LoadStudent();
            LoadExamToCombo();
        }

        private void ComboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "All")
                {
                    LoadStudentMarks();
                }
                else
                {
                    DB = new MangmentEntities1();
                    dataS.DataSource = DB.StudentMarks.ToList().FindAll(x => x.ExamId.ToString() == comboBox1.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ComboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {

            try
            {
                DB = new MangmentEntities1();
                dataS.DataSource = DB.StudentMarks.ToList().FindAll(x => x.ExamId.ToString() != comboBox2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
