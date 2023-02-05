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

namespace Akbil_projesi.Super_user_forms
{
    public partial class CheckHealthForm : Form
    {
        public CheckHealthForm()
        {
            InitializeComponent();
        }

        string[] problems = new string[6];
        int problemCount = 0;

        private void CheckHealthForm_Load(object sender, EventArgs e)
        {
            DialogResult myDialog = MessageBox.Show("Sistem taramasını başlatmak ister misiniz ?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (myDialog == DialogResult.Yes)
            {
                try { progressBar1.ForeColor = Color.Green; ; sqlConnection con = new sqlConnection(); progressBar1.Value += 20; }
                catch { progressBar1.ForeColor = Color.Red; progressBar1.Value = 20; problems[problemCount] = "Veri tabanına bağlanılamıyor"; problemCount++; }

                try { serialPort1.PortName = "COM3"; serialPort1.BaudRate = 9600; serialPort1.Open(); serialPort1.Write("0"); progressBar1.ForeColor = Color.Green; progressBar1.Value += 20; }
                catch { progressBar1.ForeColor = Color.Red; progressBar1.Value = 20; problems[problemCount] = "Seri haberleşme gerçekleştirilemiyor"; problemCount++; }

                try
                {
                    serialPort1.Write("s");

                    DialogResult dialog = MessageBox.Show("Sistemden ses geldi mi ?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialog == DialogResult.Yes) { progressBar1.ForeColor = Color.Green; progressBar1.Value += 20; } else { progressBar1.ForeColor = Color.Red; progressBar1.Value += 20; problems[problemCount] = "Hoparlör çalışmıyor"; problemCount++; }

                }
                catch { }

                try
                {
                    serialPort1.Write("t");

                    DialogResult dialog = MessageBox.Show("Ekrana 'Test' yazısı geldi mi ?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialog == DialogResult.Yes) { progressBar1.ForeColor = Color.Green; progressBar1.Value += 20; } else { progressBar1.ForeColor = Color.Red; progressBar1.Value += 20; problems[problemCount] = "LCD ekran çalışmıyor"; problemCount++; }

                }
                catch { }

                try
                {
                    serialPort1.Write("c");

                    DialogResult dialog = MessageBox.Show("Ekrana saat bilgisi geldi mi ?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialog == DialogResult.Yes) { progressBar1.ForeColor = Color.Green; progressBar1.Value += 20; } else { progressBar1.ForeColor = Color.Red; progressBar1.Value += 20; problems[problemCount] = "Saat çalışmıyor"; problemCount++; }

                }
                catch { }

                try { serialPort1.Write("0"); } catch { }

                if (problemCount == 0) { MessageBox.Show("Sisteminizde herhangi bir sorun yok.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else { listBox1.Visible = true; for (int i = 0; i < problemCount; i++) { listBox1.Items.Add(problems[i]); } }
            }
        }
    }
}
