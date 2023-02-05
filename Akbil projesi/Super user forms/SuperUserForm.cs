using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO.Ports;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Akbil_projesi.Super_user_forms
{
    public partial class SuperUserForm : MaterialForm
    {
        public SuperUserForm()
        {
            InitializeComponent();
        }

        sqlConnection con = new sqlConnection();

        themeClass theme = new themeClass();

        string[] formList = { "ManagerForm", "BussForm", "CheckHealthForm", "ScreenForm", "SettingsForm" ,"HomeForm" };

        void checkForms()
        {
            for (int i=0;i<formList.Length;i++)
            {
                Form f = Application.OpenForms[formList[i]];

                if (f != null) { f.Close(); }
            }           
        }

        void openHome()
        {
            panel2.Controls.Clear();
            HomeForm frm = new HomeForm();
            frm.TopLevel = false;
            panel2.Controls.Add(frm);
            frm.Show();
            frm.Dock = DockStyle.Fill;
            frm.BringToFront();
        }
 
        private void SuperUserForm_Load(object sender, EventArgs e) { lblUserName.Text = Form1.userName; openHome(); }

        private void btnHome_Click(object sender, EventArgs e) { checkForms(); openHome(); }

        private void btnUser_Click(object sender, EventArgs e)
        {
            checkForms();
            panel2.Controls.Clear();
            BussForm frm = new BussForm();
            frm.TopLevel = false;
            panel2.Controls.Add(frm);
            frm.Show();
            frm.Dock = DockStyle.Fill;
            frm.BringToFront();
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            checkForms();
            panel2.Controls.Clear();
            ManagerForm frm = new ManagerForm();
            frm.TopLevel = false;
            panel2.Controls.Add(frm);
            frm.Show();
            frm.Dock = DockStyle.Fill;
            frm.BringToFront();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            checkForms();
            panel2.Controls.Clear();
            SettingsForm frm = new SettingsForm();
            frm.TopLevel = false;
            panel2.Controls.Add(frm);
            frm.Show();
            frm.Dock = DockStyle.Fill;
            frm.BringToFront();           
        }

        private void btnScreen_Click(object sender, EventArgs e)
        {
            checkForms();
            panel2.Controls.Clear();
            ScreenForm frm = new ScreenForm();
            frm.TopLevel = false;
            panel2.Controls.Add(frm);
            frm.Show();
            frm.Dock = DockStyle.Fill;
            frm.BringToFront();
        }

        private void btnCheckHealth_Click(object sender, EventArgs e)
        {
            checkForms();
            panel2.Controls.Clear();
            CheckHealthForm frm = new CheckHealthForm();
            frm.TopLevel = false;
            panel2.Controls.Add(frm);
            frm.Show();
            frm.Dock = DockStyle.Fill;
            frm.BringToFront();
        }

        private void SuperUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Gerçekten çıkış yapmak istiyor musunuz ?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.No) { e.Cancel = true; } else { e.Cancel = false; }
        }
    }
}
