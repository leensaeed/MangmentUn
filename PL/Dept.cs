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
    public partial class Dept : Form
    {
        MangmentEntities1 DB;
        Department dept;
        public int Id { set; get; }

        DeleteMessage delete;
        AddMessage added;
        ErrorMessage error;
        EditMessage edit;
        private void LoadStudent()
        {
            try
            {
                DB = new MangmentEntities1();
                dataS.DataSource = DB.Students.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadDepartment()
        {
            try
            {
                DB = new MangmentEntities1();
                dataS.DataSource = DB.Departments.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Dept()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (DeptName.Text == "")
                {
                error = new ErrorMessage();
                error.Show();
                }
                else
                {
                    DB = new MangmentEntities1();
                    dept = new Department();
                
                    dept.DName = DeptName.Text;
                    //dept.Students =;
                    //dept.Subjects =;
                    DB.Entry(dept).State = EntityState.Added;
                    DB.SaveChanges();
                    added = new AddMessage();
                    added.Show();
                    DeptName.Text = "";
               
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
                if(DeptName.Text == "")
                {
                    error = new ErrorMessage();
                    error.Show();
                }
                else
                {
                    DB = new MangmentEntities1();
                    dept = new Department();
                    dept.Id = Convert.ToInt16(dataS.CurrentRow.Cells[0].Value);
                    dept.DName = DeptName.Text.ToString();
                    DB.Entry(dept).State = EntityState.Modified;
                    DB.SaveChanges();
                    edit = new EditMessage();
                    edit.Show();
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
                dept = new Department();
                dept.Id = Convert.ToInt16(dataS.CurrentRow.Cells[0].Value);
                DB.Entry(dept).State = EntityState.Deleted;
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
           DeptName.Text = Convert.ToString(dataS.CurrentRow.Cells[1].Value);
        }

        private void DataS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = Convert.ToInt16(dataS.CurrentRow.Cells[0].Value);
        }

       
        private void Student_Click(object sender, EventArgs e)
        {
            STd s = new STd();
            s.Show();
            this.Hide();
            LoadStudent();
        }

        private void Dept_Activated(object sender, EventArgs e)
        {
            LoadDepartment();
        }


        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DS s = new DS();
            s.Show();
            this.Close();
        }
    }
}
