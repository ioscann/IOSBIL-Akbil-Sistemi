using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.SqlClient;

namespace Akbil_projesi.Super_user_forms
{
    public partial class BussForm : Form
    {
        public BussForm()
        {
            InitializeComponent();
        }

        string cardID;

        double student = 2.5;

        double adult = 5;

        bool useable;

        sqlConnection con = new sqlConnection();

        sqlConnection con2 = new sqlConnection();

        void Try() { try { serialPort1.Open(); timer1.Start(); } catch { MessageBox.Show("Lütfen portları kontrol ediniz !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); } }

        void myCountQuery()
        {
            try
            {
                SqlCommand command = new SqlCommand("select * from TBLUSERS where CARDUID = @p1", con.connection());
                command.Parameters.AddWithValue("@p1", code.Text);
                SqlDataReader dr = command.ExecuteReader();

                if (dr.Read()) { useable = true; con.connection().Close(); } else { useable = false; con.connection().Close(); }
            }
            catch { MessageBox.Show("Veri tabanına bağlanılamıyor ! Lütfen internete bağlı olduğunuzdan emin olun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void BussForm_Load(object sender, EventArgs e)
        {
            try { serialPort1.Open(); serialPort1.Write("0"); timer1.Start(); }
            catch
            {
                DialogResult dialog = MessageBox.Show("Cihazın bağlı olduğu port okunamıyor ! Tekrar denemek ister misiniz ?", "Hata", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dialog == DialogResult.Yes) { timer1.Stop();  Try(); }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen == true)
                {
                    cardID = serialPort1.ReadExisting().ToString();
                    if (cardID != "")
                    {
                        code.Text = cardID;

                        myCountQuery();

                        if (useable == true)
                        {
                            SqlCommand command = new SqlCommand("select * from TBLUSERS where CARDUID = @p1", con.connection());
                            command.Parameters.AddWithValue("@p1", code.Text);
                            SqlDataReader dr = command.ExecuteReader();

                            if (dr.Read())
                            {
                                string name = dr[1].ToString();
                                string surname = dr[2].ToString();
                                double balance = Convert.ToDouble(dr[8].ToString());
                                double currentBalance;
                                string status;

                                if (dr[7].ToString() == "True")
                                {
                                    status = "Öğrenci";

                                    if (balance < 2.5) { MessageBox.Show("Yetersiz bakiye !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                                    else
                                    {
                                        SqlCommand command2 = new SqlCommand("update TBLUSERS set BALANCE = @p1 where CARDUID = @p2", con2.connection());
                                        currentBalance = balance - student;
                                        command2.Parameters.AddWithValue("@p1", currentBalance);
                                        command2.Parameters.AddWithValue("@p2", code.Text);
                                        command2.ExecuteNonQuery();

                                        lblName.Text = name;
                                        lblSurname.Text = surname;
                                        lblStatus.Text = status;
                                        lblBalance.Text = student.ToString();
                                        lblCurrentBalance.Text = currentBalance.ToString();

                                        MessageBox.Show("Ücret alımı başarılı !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                                else
                                {
                                    status = "Tam";

                                    if (balance < 5) { MessageBox.Show("Yetersiz bakiye !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                                    else
                                    {
                                        SqlCommand command2 = new SqlCommand("update TBLUSERS set BALANCE = @p1 where CARDUID = @p2", con2.connection());
                                        currentBalance = balance - adult;
                                        command2.Parameters.AddWithValue("@p1", currentBalance);
                                        command2.Parameters.AddWithValue("@p2", code.Text);
                                        command2.ExecuteNonQuery();

                                        lblName.Text = name;
                                        lblSurname.Text = surname;
                                        lblStatus.Text = status;
                                        lblBalance.Text = student.ToString();
                                        lblCurrentBalance.Text = currentBalance.ToString();

                                        MessageBox.Show("Ücret alımı başarılı !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                            }
                        }
                        else { MessageBox.Show("Tanımsız kart !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                }
                else { timer1.Stop(); Try(); timer1.Start(); }
            }
            catch { timer1.Stop(); MessageBox.Show("Kart okuyucuya erişilemiyor !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); Try(); }
        }
    }
}
