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
    public partial class DS : Form
    {
        MangmentEntities1 DB;
        Student std;
        Subject sub;
        public DS()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


        private void Student_Click(object sender, EventArgs e)
        {
            STd std = new STd();
            std.Show();
            this.Hide();
        }

        private void DS_Activated(object sender, EventArgs e)
        {
           
        }

        private void Department_Click(object sender, EventArgs e)
        {
            Dept d = new Dept();
            d.Show();
            this.Hide();
        }
   
        private void Exam_Click(object sender, EventArgs e)
        {
            Examm ex = new Examm();
            ex.Show();
            this.Hide();
        }

        private void StudentMark_Click(object sender, EventArgs e)
        {
            STdMark stdm = new STdMark();
            stdm.Show();
            this.Hide();
        }

        private void Subject_Click(object sender, EventArgs e)
        {
            SUB s = new SUB();
            s.Show();
            this.Hide();
        }

        private void SubjectLecture_Click(object sender, EventArgs e)
        {
            SUBLEC sl = new SUBLEC();
            sl.Show();
            this.Hide();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void DS_Load(object sender, EventArgs e)
        {
           
            try
            {
                DB = new MangmentEntities1();
                var cnt=DB.Students.ToList().Count();
                cntStd.Text = cnt.ToString();
            }
            catch { }
            try
            {
                DB = new MangmentEntities1();
                var cnt = DB.Subjects.ToList().Count();
                cntSub.Text = cnt.ToString();
            }
            catch { }
            try
            {
                DB = new MangmentEntities1();
                var cnt = DB.Departments.ToList().Count();
                cntDept.Text = cnt.ToString();
            }
            catch { }
            try
            {
                DB = new MangmentEntities1();
                var cnt = DB.Subjects.Select(x=>x.Id).ToList();
                //var cnt2 = DB.Subjects.Select(x=>x.SName).ToList();
                
                foreach (var item in cnt)
                {

                    var cnt1 = DB.SubjectLectures.ToList().FindAll(x => x.SubjectId.ToString() == item.ToString()).Count();
                    cntLec.Text +=cnt1.ToString() + "\n";
                }


            }
            catch { }

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
