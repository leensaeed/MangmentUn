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
    public partial class STd : Form
    {
        MangmentEntities1 DB;
        Student std;
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
        public void LoadDept()
        {
            try
            {
                DB = new MangmentEntities1();
                dept = new Department();
                var data = DB.Departments.Select(x => x.Id.ToString()).ToList();
                //var data = DB.Departments.Select(x => x.DName.ToString()).ToList();
                comboBox1.Items.AddRange(data.ToArray());
            }
            catch { }
        }
        public void LoadDeptTOcombo()
        {
            try
            {
                DB = new MangmentEntities1();
                dept = new Department();
                var data = DB.Departments.Select(x => x.DName).ToList();
                comboDept.Items.AddRange(data.ToArray());
            }
            catch { }
        }
        public STd()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {

            try
            {
                if (FirstName.Text == "" || LastName.Text == "" || Email.Text == "" || Phone.Text == "" || comboDept.Text == "")
                {
                    error = new ErrorMessage();
                    error.Show();
                }
                else
                {
                    DB = new MangmentEntities1();
                    std = new Student();
                    dept = new Department();
                    DateTime dt = RDate.Value;
                    std.FirstName = FirstName.Text;
                    std.LastName = LastName.Text;
                    std.Email = Email.Text;
                    std.Phone = Phone.Text;
                    std.RegisterDate = dt;
                    var data = DB.Departments.Where(x => x.DName == comboDept.Text).FirstOrDefault();

                    std.DepartmentId = Convert.ToInt32(data.Id);
                    DB.Entry(std).State = EntityState.Added;
                    DB.SaveChanges();
                    added = new AddMessage();
                    added.Show();
                    FirstName.Text = LastName.Text = comboDept.Text = Email.Text = Phone.Text = "";
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
                if (FirstName.Text == "" || LastName.Text == "" || Email.Text == "" || Phone.Text == "" || comboDept.Text == "")
                {
                    error = new ErrorMessage();
                    error.Show();
                }
                else
                {
                    DB = new MangmentEntities1();
                    std = new Student();
                    DateTime dt = RDate.Value;
                    std.Id = Id;
                    std.FirstName = FirstName.Text;
                    std.LastName = LastName.Text;
                    std.Email = Email.Text;
                    std.Phone = Phone.Text;
                    std.RegisterDate = dt;
                    var dataD = DB.Departments.Where(x => x.DName == comboDept.Text).FirstOrDefault();
                    std.DepartmentId = dataD.Id;
                    DB.Entry(std).State = EntityState.Modified;
                    DB.SaveChanges();
                    edit = new EditMessage();
                    edit.Show();
                    FirstName.Text = LastName.Text = comboDept.Text = Email.Text = Phone.Text = "";
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
            std = new Student();
            std.Id = Convert.ToInt16(dataS.CurrentRow.Cells[0].Value);
            DB.Entry(std).State = EntityState.Deleted;
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
            FirstName.Text = Convert.ToString(dataS.CurrentRow.Cells[1].Value);
            LastName.Text = dataS.CurrentRow.Cells[2].Value.ToString();
            Email.Text = dataS.CurrentRow.Cells[3].Value.ToString();
            Phone.Text = dataS.CurrentRow.Cells[4].Value.ToString();
            RDate.Text = dataS.CurrentRow.Cells[5].Value.ToString();
            int id = Convert.ToInt32(dataS.CurrentRow.Cells[6].Value);
            var dep = DB.Departments.Where(x => x.Id == id).FirstOrDefault();
            comboDept.Text = dep.DName.ToString();
        }

        private void DataS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = Convert.ToInt16(dataS.CurrentRow.Cells[0].Value);
        }


        private void STd_Activated(object sender, EventArgs e)
        {
            LoadStudent();
        }



        private void StdLocation_Click(object sender, EventArgs e)
        {

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DS s = new DS();
            s.Show();
            this.Close();
        }

        private void STd_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("All");
            LoadDept();
            LoadDeptTOcombo();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ComboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text== "All")
                {
                    LoadStudent();
                }
                else
                {
                    //var data = DB.Departments.Where(x => x.DName == comboBox1.Text).FirstOrDefault();
                    //dataS.DataSource = DB.Students.ToList().FindAll(x => x.DepartmentId == data.Id);
                    DB = new MangmentEntities1();    
                    dataS.DataSource = DB.Students.ToList().FindAll(x => x.DepartmentId.ToString() == comboBox1.Text);
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
              //  dataS.DataSource = DB.Students.ToList().FindAll(x => x. == Convert.ToInt32(comboBox1.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BottomBar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
