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


namespace Akbil_projesi
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string cardID;

        public static string userName;

        themeClass theme = new themeClass();
                                                        
        sqlConnection con = new sqlConnection();

        void clear()
        {
            txtUserName.Text = ""; 
            txtPassword.Text = ""; 
            cardID = ""; 
            code.Text = ""; 
            lblSituasion.Text = "Erişilemedi";
            lblSituasion.ForeColor = Color.Red;
        }

        void Try() { try { serialPort1.BaudRate = 9600; serialPort1.Open(); timer1.Start(); } catch { MessageBox.Show("Lütfen portları kontrol ediniz !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); } }

        private void Form1_Load(object sender, EventArgs e)
        {
            theme.themeDark(this);
            theme.labelsColorWhite(this);
            lblSituasion.ForeColor = Color.Red;
            try { serialPort1.PortName = "COM3"; serialPort1.BaudRate = 9600; serialPort1.Open(); serialPort1.Write("0"); }
            catch { MessageBox.Show("Cihazın bağlı olduğu port okunamıyor !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); Application.Exit(); }            
            timer1.Interval = 20;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                cardID = serialPort1.ReadExisting().ToString();
                if (cardID != "") { lblSituasion.Text = "Erişildi"; lblSituasion.ForeColor = Color.GreenYellow; code.Text = cardID; }              
            }
            catch { timer1.Stop(); MessageBox.Show("Kart okuyucuya erişilemiyor !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); Try(); }
        }

        private void btnAgain_Click(object sender, EventArgs e)
        {
            cardID = "";
            code.Text = "";
            lblSituasion.Text = "Erişilemedi"; 
            lblSituasion.ForeColor = Color.Red;
            timer1.Start();        
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" && txtPassword.Text != "" && code.Text != "")
            {
                try
                {
                    SqlCommand command = new SqlCommand("select * from TBLUSERS where USERNAME = @p1 and PASSWORD = @p2 and CARDUID = @p3", con.connection());
                    command.Parameters.AddWithValue("@p1", txtUserName.Text);
                    command.Parameters.AddWithValue("@p2", txtPassword.Text);
                    command.Parameters.AddWithValue("@p3", code.Text);
                    SqlDataReader dr = command.ExecuteReader();

                    if (dr.Read())
                    {
                        userName = txtUserName.Text;
                        if (dr[6].ToString() == "True") { serialPort1.Write("1"); timer1.Stop(); serialPort1.Close(); this.Hide(); Super_user_forms.SuperUserForm frm = new Super_user_forms.SuperUserForm(); frm.ShowDialog();   }
                    }
                    else { clear(); serialPort1.Write("2"); MessageBox.Show("Bilgilerinize ait bir hesaba rastlamadık !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                    con.connection().Close();
                }
                catch { MessageBox.Show("Veritabanına bağlanılamıyor. Lütfen internete bağlı olduğunuzdan emin olun !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else { MessageBox.Show("Lütfen hiçbir alanı boş bırakmayınız ve kartınızı okutmayı unutmayınız !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
    }
}
