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
    public partial class SUB : Form
    {
        MangmentEntities1 DB;
        Subject sub;
        Department dept;
        public int Id { set; get; }


        DeleteMessage delete;
        AddMessage added;
        ErrorMessage error;
        EditMessage edit;
        private void LoadSubject()
        {
            try
            {
                DB = new MangmentEntities1();
                dataS.DataSource = DB.Subjects.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadDept()
        {
            try
            {
                DB = new MangmentEntities1();
                var data = DB.Departments.Select(x => x.DName).ToList();
                comboDept.Items.AddRange(data.ToArray());
            }
            catch { }

        }
       

        public SUB()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (SName.Text == "" || comboTerm.Text == "" || comboYear.Text == "" || Degree.Text == "" || comboDept.Text == "")
                {
                    error = new ErrorMessage();
                    error.Show();
                }
                else
                {
                    DB = new MangmentEntities1();
                    sub = new Subject();

                    sub.Year = Convert.ToInt16(comboYear.Text);
                    sub.Term = Convert.ToInt16(comboTerm.Text);
                    sub.Degree = Convert.ToInt32(Degree.Text);
                    sub.SName = SName.Text;
                    var data = DB.Departments.Where(x => x.DName == comboDept.Text).FirstOrDefault();
                    sub.DepartmentId = data.Id;
                    DB.Entry(sub).State = EntityState.Added;
                    DB.SaveChanges();
                    added = new AddMessage();
                    added.Show();
                    comboDept.Text = comboTerm.Text = comboYear.Text = Degree.Text = SName.Text = "";
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
                if (SName.Text == "" || comboTerm.Text == "" || comboYear.Text == "" || Degree.Text == "" || comboDept.Text == "")
                {
                    error = new ErrorMessage();
                    error.Show();
                }
                else
                {
                    DB = new MangmentEntities1();
                    sub = new Subject();
                    sub.Id = Id;
                    sub.Year = Convert.ToInt16(comboYear.Text);
                    sub.Term = Convert.ToInt16(comboTerm.Text);
                    sub.Degree = Convert.ToInt32(Degree.Text);
                    sub.SName = SName.Text;
                    var data = DB.Departments.Where(x => x.DName == comboDept.Text).FirstOrDefault();
                    sub.DepartmentId = data.Id;
                    DB.Entry(sub).State = EntityState.Modified;
                    DB.SaveChanges();
                    edit = new EditMessage();
                    edit.Show();
                    comboDept.Text = comboTerm.Text = comboYear.Text = Degree.Text = SName.Text = "";
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
                sub = new Subject();
                sub.Id = Convert.ToInt16(dataS.CurrentRow.Cells[0].Value);
                DB.Entry(sub).State = EntityState.Deleted;
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
            int id = Convert.ToInt32(dataS.CurrentRow.Cells[1].Value);
            var dep = DB.Departments.Where(x => x.Id == id).FirstOrDefault();
            comboDept.Text = dep.DName.ToString();
            SName.Text = Convert.ToString(dataS.CurrentRow.Cells[2].Value);
            comboTerm.Text = dataS.CurrentRow.Cells[3].Value.ToString();
            comboYear.Text = dataS.CurrentRow.Cells[4].Value.ToString();
            Degree.Text = dataS.CurrentRow.Cells[5].Value.ToString();
        }

        private void DataS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = Convert.ToInt16(dataS.CurrentRow.Cells[0].Value);
        }
       

        private void SUB_Activated(object sender, EventArgs e)
        {
            LoadSubject();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DS s = new DS();
            s.Show();
            this.Close();
        }

        private void SUB_Load(object sender, EventArgs e)
        {
            LoadDept();
        }
    }
}
