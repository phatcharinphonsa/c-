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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lblId.Enabled = false;
            lblName.Enabled = false;
            lblYear.Enabled = false;
            lblDepart.Enabled = false;

            lblId.Text = "";
            lblName.Text = "";
            lblYear.Text = "";
            lblDepart.Text = "";

            btnShow.Enabled = false;

            lblShowId.Text = "";
            lblShowName.Text = "";
            lblShowYear.Text = "";
            lblShowDepart.Text = "";
        }

        private void lblShowId_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            textId.Enabled = true;
            textName.Enabled = true;
            textYear.Enabled = true;
            textDepart.Enabled = true;

            textId.Text = "";
            textName.Text = "";
            textYear.Text = "";
            textDepart.Text = "";

            btnAdd.Enabled = false;
            btnShow.Enabled = true;
            btnClear.Enabled = false;
            btnClose.Enabled = false;

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int ID, year;
            string name, depart;
            ID = Int32.Parse(textId.Text);
            name = textName.Text;
            year = Int32.Parse(textYear.Text);
            depart = textDepart.Text;

            lblShowId.Text = ID.ToString();
            lblShowName.Text = name.ToString();
            lblShowYear.Text = year.ToString();
            lblShowDepart.Text = depart.ToString();

            textId.Enabled = false;
            textName.Enabled = false;
            textYear.Enabled = false;
            textDepart.Enabled = false;

            btnAdd.Enabled = true;
            btnShow.Enabled = false;
            btnClear.Enabled = true;
            btnClose.Enabled = true;


        }

        private void textId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textName.Focus();
            }
        }

        private void textName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textYear.Focus();

            }
        }

        private void textYear_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textDepart.Focus();

            }
        }

        private void btnClaer_Click(object sender, EventArgs e)
        {

            textId.Text = "";
            textName.Text = "";
            textYear.Text = "";
            textDepart.Text = "";

            lblShowId.Text = "";
            lblShowName.Text = "";
            lblShowYear.Text = "";
            lblShowDepart.Text = "";

            textId.Enabled = true;
            textName.Enabled = true;
            textYear.Enabled = true;
            textDepart.Enabled = true;





        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textDepart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnShow.Focus();
            }

        }
    }
}



