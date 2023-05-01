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
    public partial class SUBLEC : Form
    {
        MangmentEntities1 DB;
        //Student std;
        Subject sub;
        SubjectLecture subLec;
        public int Id { set; get; }


        DeleteMessage delete;
        AddMessage added;
        ErrorMessage error;
        EditMessage edit;
        private void LoadSubjectLecture()
        {
            try
            {
                DB = new MangmentEntities1();
                dataS.DataSource = DB.SubjectLectures.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadSubject()
        {
            try
            {
                DB = new MangmentEntities1();
                dataSub.DataSource = DB.Subjects.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadSubjectToCombo()
        {
            try
            {
                DB = new MangmentEntities1();
                var data = DB.Subjects.Select(x => x.Id.ToString()).ToList();
                comboBox1.Items.AddRange(data.ToArray());
            }
            catch { }

        }

        public SUBLEC()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (Title.Text == "" || Content.Text == "")
                {
                    error = new ErrorMessage();
                    error.Show();
                }
                else
                {
                    DB = new MangmentEntities1();
                    subLec = new SubjectLecture();
                    subLec.Content = Content.Text;
                    subLec.Tittle = Title.Text;
                    //var data = DB.Subjects.Where(x => x.SName == comboSub.Text).FirstOrDefault();
                    //subLec.SubjectId = data.Id;
                    subLec.SubjectId = Convert.ToInt16(dataSub.CurrentRow.Cells[0].Value);
                    DB.Entry(subLec).State = EntityState.Added;
                    DB.SaveChanges();
                    added = new AddMessage();
                    added.Show();
                    Content.Text = Title.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    

        private void Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (Title.Text == "" || Content.Text == "")
                {
                    error = new ErrorMessage();
                    error.Show();
                }
                else
                {
                    DB = new MangmentEntities1();
                    sub = new Subject();
                    subLec.Id = Id;
                    subLec.Content = Content.Text;
                    subLec.Tittle = Title.Text;
                    //var data = DB.Subjects.Where(x => x.SName == comboSub.Text).FirstOrDefault();
                    //subLec.SubjectId = data.Id;
                    subLec.SubjectId = Convert.ToInt16(dataSub.CurrentRow.Cells[0].Value);
                    DB.Entry(subLec).State = EntityState.Modified;
                    DB.SaveChanges();
                    edit = new EditMessage();
                    edit.Show();
                    Content.Text = Title.Text = "";
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
            try
            {
                DB = new MangmentEntities1();
                subLec = new SubjectLecture();
                subLec.Id = Convert.ToInt16(dataS.CurrentRow.Cells[0].Value);
                DB.Entry(subLec).State = EntityState.Deleted;
                DB.SaveChanges();
                delete = new DeleteMessage();
                delete.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Data_DoubleClick(object sender, EventArgs e)
        {
            
           
        }

        private void DataS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = Convert.ToInt16(dataS.CurrentRow.Cells[0].Value);
            Title.Text = dataS.CurrentRow.Cells[2].Value.ToString();
            Content.Text = Convert.ToString(dataS.CurrentRow.Cells[3].Value);
        }

        private void DataS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = Convert.ToInt16(dataS.CurrentRow.Cells[0].Value);
        }

        private void SUBLEC_Activated(object sender, EventArgs e)
        {
            LoadSubjectLecture();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DS s = new DS();
            s.Show();
            this.Close();
        }

        private void SUBLEC_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("All");
            LoadSubject();
            LoadSubjectToCombo();
        }

        private void Content_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "All")
                {
                    LoadSubjectLecture();
                    var cnt = DB.SubjectLectures.ToList().Count();
                    cntLec.Text = cnt.ToString();
                }
                else
                {
                    DB = new MangmentEntities1();
                    dataS.DataSource = DB.SubjectLectures.ToList().FindAll(x => x.SubjectId.ToString() == comboBox1.Text);
                    var cnt= DB.SubjectLectures.ToList().FindAll(x => x.SubjectId.ToString() == comboBox1.Text).Count();
                    cntLec.Text = cnt.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
