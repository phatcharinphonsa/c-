using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            String stdID;
            String name;
            String sector;
            String year;

            String faculty = "" ;
            String major = "" ;
            String subject = "" ;

            stdID = tb1.Text;
            name = tb2.Text;
            sector = tb3.Text;
            year = tb4.Text;

            if (fty1.Checked)
            {
                faculty = fty1.Text;
            }
            else if (fty2.Checked)
            {
                faculty = fty2.Text;
            } //------------------------------------- คณะ

            if (mj1.Checked)
            {
                major = mj1.Text;
            }
            else if (mj2.Checked)
            {
                major = mj2.Text;
            }
            else if (mj3.Checked)
            {
                major = mj3.Text;
            }
            else if (mj4.Checked)
            {
                major = mj4.Text;
            } //------------------------------------- สาขาวิชา

            if (chk1.Checked == true)
            {
                subject = subject + (chk1.Text + "\n");
            }
            else
            {
                subject = subject + "";
            }

            if (chk2.Checked == true)
            {
                subject = subject + (chk2.Text + "\n");
            }
            else
            {
                subject = subject + "";
            }

            if (chk3.Checked == true)
            {
                subject = subject + (chk3.Text + "\n");
            }
            else
            {
                subject = subject + "";
            }
            if (chk4.Checked == true)
            {
                subject = subject + (chk4.Text + "\n");
            }
            else
            {
                subject = subject + "";
            }
            if (chk5.Checked == true)
            {
                subject = subject + (chk5.Text + "\n");
            }
            else
            {
                subject = subject + "";
            }

            if (chk6.Checked == true)
            {
                subject = subject + (chk6.Text + "\n");
            }
            else
            {
                subject = subject + "";
            }

            if (chk7.Checked == true)
            {
                subject = subject + (chk7.Text + "\n");
            }
            else
            {
                subject = subject + "";
            } //-----------------------------------------วิชาที่เลือกลงทะเบียน

            lbl1.Text = "รหัสนักศึกษา : " + stdID + "\nชื่อ-นามสกุล : " + name + "\nประจำปีการศึกษา : " + sector + " / " + year + "\nคณะ : " + faculty + "\nสาขาวิชา : " + major + "\nรายวิชาที่ลงทะเบียน :" + "\n" + subject;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            tb1.Text = "";
            tb2.Text = "";
            tb3.Text = "";
            tb4.Text = "";

            lbl1.Text = "";

            fty1.Checked = true;
            fty2.Checked = false;

            mj1.Checked = false;
            mj2.Checked = false;
            mj3.Checked = false;
            mj4.Checked = false;

            chk1.Checked = false;
            chk2.Checked = false;
            chk3.Checked = false;
            chk4.Checked = false;
            chk5.Checked = false;
            chk6.Checked = false;
            chk7.Checked = false;
        }

        private void tb1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char T = e.KeyChar;
            if (!!char.IsLetter(T))
            {
                e.Handled = true;
            }
        }

        private void tb3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char T = e.KeyChar;
            if (!!char.IsLetter(T))
            {
                e.Handled = true;
            }
        }

        private void tb4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char T = e.KeyChar;
            if (!!char.IsLetter(T))
            {
                e.Handled = true;
            }
        }

        private void fty1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tb1.Focus();
            }
        }

        private void tb1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tb2.Focus();
            }
        }

        private void tb2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tb3.Focus();
            }
        }

        private void tb3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tb4.Focus();
            }
        }

        private void tb4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                fty1.Focus();
            }
        }
    }
}
