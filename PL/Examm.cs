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
    public partial class Examm : Form
    {
        MangmentEntities1 DB;
        Exam ex;
        public int Id { set; get; }


        DeleteMessage delete;
        AddMessage added;
        //ErrorMessage error;
        EditMessage edit;

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

        private void LoadExam()
        {
            try
            {
                DB = new MangmentEntities1();
                dataS.DataSource = DB.Exams.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public Examm()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                DB = new MangmentEntities1();
                ex = new Exam();
                DateTime dt = dateExam.Value;
                ex.SubjectId = Convert.ToInt32(dataSub.CurrentRow.Cells[0].Value);
                ex.Term = Convert.ToInt16(dataSub.CurrentRow.Cells[3].Value);
                ex.Date = dt;
                DB.Entry(ex).State = EntityState.Added;
                DB.SaveChanges();
                added = new AddMessage();
                added.Show();
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
                DB = new MangmentEntities1();
                ex = new Exam();
                DateTime dt = dateExam.Value;
                ex.Id = Id;
                ex.SubjectId = Convert.ToInt32(dataSub.CurrentRow.Cells[0].Value);
                ex.Term = Convert.ToInt16(dataSub.CurrentRow.Cells[3].Value);
                ex.Date = dt;
                DB.Entry(ex).State = EntityState.Modified;
                DB.SaveChanges();
                edit = new EditMessage();
                edit.Show();
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
            ex = new Exam();
            ex.Id = Convert.ToInt16(dataS.CurrentRow.Cells[0].Value);
            DB.Entry(ex).State = EntityState.Deleted;
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
        }

        private void DataS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = Convert.ToInt16(dataS.CurrentRow.Cells[0].Value);
        }
      
       
        private void Examm_Activated(object sender, EventArgs e)
        {
            LoadExam();
        }
        
        private void Examm_Load(object sender, EventArgs e)
        {
            LoadSubject();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DS s = new DS();
            s.Show();
            this.Close();
        }
    }
}
