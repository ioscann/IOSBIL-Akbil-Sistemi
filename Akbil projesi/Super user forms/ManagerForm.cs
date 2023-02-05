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
using Microsoft.PointOfService;

namespace Akbil_projesi.Super_user_forms
{
    public partial class ManagerForm : MaterialForm
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        int cardCount = 0;

        string cardID;

        string loadCancelRadioMode;

        string addRadioMode;

        bool useable = false;

        PosPrinter posPrinter;

        sqlConnection con = new sqlConnection();

        themeClass theme = new themeClass();

        SuperUserForm frm = new SuperUserForm();

        void myCountQuery()
        {
            try
            {
                SqlCommand command = new SqlCommand("select * from TBLUSERS where CARDUID = @p1", con.connection());
                command.Parameters.AddWithValue("@p1", code.Text);
                SqlDataReader dr = command.ExecuteReader();

                if (!dr.Read()) { useable = true; con.connection().Close(); } else { useable = false; con.connection().Close(); }
            }
            catch { MessageBox.Show("Veri tabanına bağlanılamıyor ! Lütfen internete bağlı olduğunuzdan emin olun.","Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        void myInfoQuery()
        {
            try
            {
                SqlCommand command = new SqlCommand("select NAME,SURNAME,BALANCE from TBLUSERS where CARDUID = @p1", con.connection());
                command.Parameters.AddWithValue("@p1", code.Text);
                SqlDataReader dr = command.ExecuteReader();

                if (dr.Read())
                {
                    txtLoadName.Text = dr[0].ToString(); txtLoadSurname.Text = dr[1].ToString(); txtCurrentBalance.Text = dr[2].ToString();
                    txtCloseName.Text = dr[0].ToString(); txtCloseSurname.Text = dr[1].ToString();
                    con.connection().Close();
                }
                else
                {
                    txtLoadName.Text = ""; txtLoadSurname.Text = ""; txtCurrentBalance.Text = "";
                    txtCloseName.Text = ""; txtCloseSurname.Text = "";
                    con.connection().Close();
                }
            }
            catch { MessageBox.Show("Bilgileriniz ekrana getirilemiyor ! Lütfen internete bağlı olduğunuzdan emin olun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        void checkCardCount()
        {
            try
            {
                SqlCommand command = new SqlCommand("select * from TBLUSERS where CARDUID = @p1", con.connection());
                command.Parameters.AddWithValue("@p1", code.Text);
                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read()) { cardCount++; } con.connection().Close();
            }
            catch { MessageBox.Show("Kart kontrolü işlemi şu an yapılamıyor! Lütfen internet bağlantınız olduğundan emin olduktan sonra işleminizi tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        void checkLoadRadioButtons()
        {
            if (rdCash.Checked == true ) { loadCancelRadioMode = "cash"; }
            else if (rdCard.Checked == true) { loadCancelRadioMode = "card"; }
            else if (rdCard.Checked == false && rdCash.Checked == false) { loadCancelRadioMode = ""; }
        }

        void checkAddRadioButtons()
        {
            if (rdAdult.Checked == true) { addRadioMode = "adult"; }
            else if (rdStudent.Checked == true) { addRadioMode = "student"; }
            else if (rdAdult.Checked == false && rdStudent.Checked == false) { addRadioMode = ""; }
        }

        void loadCloseClear()
        {
            txtLoadName.Text = ""; txtLoadSurname.Text = ""; txtCurrentBalance.Text = ""; txtLoadedBalance.Text = ""; code.Text = ""; lblCloseCardInfo.Text = "Erişilemedi"; lblCloseCardInfo.ForeColor = Color.Red;
            txtCloseName.Text = ""; txtCloseSurname.Text = ""; cardID = ""; lblLoadCardInfo.Text = "Erişilemedi"; lblLoadCardInfo.ForeColor = Color.Red; rdCard.Checked = false; rdCash.Checked = false; loadCancelRadioMode = "";
        }

        void addClear() { txtAddName.Text = ""; txtAddSurname.Text = ""; txtUserName.Text = ""; txtPassword.Text = ""; rdAdult.Checked = false; rdStudent.Checked = false; lblAddCardInfo.Text = "Erişilemedi"; lblAddCardInfo.ForeColor = Color.Red; code.Text = ""; cardID = ""; }

        private void ManagerForm_Load(object sender, EventArgs e)
        { 
            try { serialPort1.Open(); serialPort1.Write("0"); timer1.Start(); }
            catch
            {
                DialogResult dialog = MessageBox.Show("Cihazın bağlı olduğu port okunamıyor ! Tekrar denemek ister misiniz ?", "Hata", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dialog == DialogResult.Yes) { Try(); }
            }
        }

        void Try() { try { serialPort1.BaudRate = 9600; serialPort1.Open(); timer1.Start(); } catch { MessageBox.Show("Lütfen portları kontrol ediniz !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); } }

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

                        if (useable == false)
                        {
                            lblLoadCardInfo.Text = "Erişildi"; lblLoadCardInfo.ForeColor = Color.GreenYellow; code.Text = cardID;
                            lblCloseCardInfo.Text = "Erişildi"; lblCloseCardInfo.ForeColor = Color.GreenYellow; code.Text = cardID;
                            lblAddCardInfo.Text = "Erişilemedi"; lblAddCardInfo.ForeColor = Color.Red; code.Text = cardID;
                            myInfoQuery();
                        }
                        else
                        {
                            lblLoadCardInfo.Text = "Erişilemedi"; lblLoadCardInfo.ForeColor = Color.Red; code.Text = cardID;
                            lblCloseCardInfo.Text = "Erişilemedi"; lblCloseCardInfo.ForeColor = Color.Red; code.Text = cardID;
                            lblAddCardInfo.Text = "Erişildi"; lblAddCardInfo.ForeColor = Color.GreenYellow; code.Text = cardID;
                            myInfoQuery();
                        }
                    }
                    else {  }
                }
                else { timer1.Stop(); Try(); timer1.Start(); }
            }
            catch { timer1.Stop(); MessageBox.Show("Kart okuyucuya erişilemiyor !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); Try(); }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (txtLoadName.Text != "" && txtLoadSurname.Text != "" && code.Text != "" && txtLoadedBalance.Text != "" )
            {
                checkLoadRadioButtons();

                if (loadCancelRadioMode != "")
                {
                  
                        SqlCommand command = new SqlCommand("update TBLUSERS set BALANCE = @p1 where CARDUID = @p2", con.connection());
                        double currentBalance = Convert.ToDouble(txtCurrentBalance.Text);
                        double loadedBalance = Convert.ToDouble(txtLoadedBalance.Text);
                        double lastBalance = currentBalance + loadedBalance;
                        command.Parameters.AddWithValue("@p1", lastBalance);
                        command.Parameters.AddWithValue("@p2", code.Text);
                        command.ExecuteNonQuery();
                        con.connection().Close();

                        SqlCommand command2 = new SqlCommand("insert into TBLPAYMENTS values (@p1,@p2,@p3,@p4,@p5)", con.connection());
                        command2.Parameters.AddWithValue("@p1", txtLoadName.Text);
                        command2.Parameters.AddWithValue("@p2", txtLoadSurname.Text);
                        command2.Parameters.AddWithValue("@p3", txtLoadedBalance.Text);
                        command2.Parameters.AddWithValue("@p4", lastBalance);
                        command2.Parameters.AddWithValue("@p5", loadCancelRadioMode);
                        command2.ExecuteNonQuery();
                        con.connection().Close();

                        loadCloseClear();
                        btnPill.Enabled = true;
                        btnPayment.Enabled = false;
                        MessageBox.Show("Ödeme başarılı bir şekilde gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                   
                }
                else { MessageBox.Show("Lütfen ödeme yöntemini seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            else { MessageBox.Show("Lütfen kullanıcının kartını okutunuz ve boş bir alan bırakmayınız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void btnPill_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("select top 1 * from TBLPAYMENTS order by ID desc",con.connection());
                SqlDataReader dr = command.ExecuteReader();

                if (dr.Read())
                {
                    string name = dr[1].ToString();
                    string surname = dr[2].ToString();
                    string loadedBalance = dr[3].ToString();
                    string currentBalance = dr[4].ToString();
                    string paymentMethod;
                    if (dr[5].ToString() == "Cash") { paymentMethod = "Nakit";  } else { paymentMethod = "Kart"; }

                    var explorer = new PosExplorer();
                    var deviceInfo = explorer.GetDevice(DeviceType.PosPrinter);
                    if (deviceInfo == null)
                    {
                        MessageBox.Show("Yazıcı bulunamadı!");
                        return;
                    }

                    posPrinter = (PosPrinter)explorer.CreateInstance(deviceInfo);
                    posPrinter.Open();
                    posPrinter.Claim(500);
                    posPrinter.DeviceEnabled = true;

                    posPrinter.StatusUpdateEvent += (s, evt) =>
                    {
                        if (evt.Status == PosPrinter.StatusCoverOpen)
                        {
                            MessageBox.Show("Yazıcının kağıt kapağı açıldı");
                        }
                        if (evt.Status == PosPrinter.StatusCoverOK)
                        {
                            MessageBox.Show("Yazıcının kağıt kapağı kapandı");
                        }
                        if (evt.Status == PosPrinter.StatusJournalCartridgeEmpty)
                        {
                            MessageBox.Show("Yazıcının kartuşu bitmek üzere");
                        }

                        //istediğin eventleri yakalayabilirsin bir sürü var
                    };

                    posPrinter.PrintNormal(PrinterStation.Slip, "İOSBİL BAKİYE YÜKLEME NOKTASI" + Environment.NewLine);
                    posPrinter.PrintNormal(PrinterStation.Slip, "********************************************************************" + Environment.NewLine);
                    posPrinter.PrintNormal(PrinterStation.Slip, "KART SAHİBİ ADI :   " + name + Environment.NewLine);
                    posPrinter.PrintNormal(PrinterStation.Slip, "KART SAHİBİ SOYADI   : " + surname + Environment.NewLine);
                    posPrinter.PrintNormal(PrinterStation.Slip, "YÜKLENEN BAKİYE   : " + loadedBalance + Environment.NewLine);
                    posPrinter.PrintNormal(PrinterStation.Slip, "MEVCUT BAKİYE   : " + currentBalance + Environment.NewLine);
                    posPrinter.PrintNormal(PrinterStation.Slip, "ÖDEME TÜRÜ :   " + paymentMethod + Environment.NewLine);
                    posPrinter.PrintNormal(PrinterStation.Slip, "********************************************************************" + Environment.NewLine);
                    posPrinter.PrintBarCode(PrinterStation.Slip, "123456789", BarCodeSymbology.Ean128, 40, 200, 1, BarCodeTextPosition.Above);
                    //ne yazdırmak istiyorsan buraya

                    posPrinter.CutPaper(100); //kağıdı tam kes, 100 yerine 50 yazarsan yarısına kadar keser

                    btnPill.Enabled = false;
                    btnPayment.Enabled = true;
                }
            }
            catch { MessageBox.Show("Dekont yazdırma işlemi gerçekleştirilemyior ! Lütfen yazııcının cihazınıza bağlı olduğuna ve internet bağlantınız olduğundan emin olun."); }
        }

        private void btnCloseCancel_Click(object sender, EventArgs e) { loadCloseClear(); }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (txtCloseName.Text != "" && txtCloseSurname.Text != "" && code.Text != "")
            {
                DialogResult dialog = MessageBox.Show("Gerçekten bu kartı sistemden silmek istiyor musunuz ? Eğer silerseniz kartı kullanmak için tekrar kartı sisteme tanıtmanız gerekir.", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
                if (dialog == DialogResult.Yes)
                {
                    try
                    {
                        SqlCommand command = new SqlCommand("delete from TBLUSERS where CARDUID = @p1", con.connection());
                        command.Parameters.AddWithValue("@p1", code.Text);
                        command.ExecuteNonQuery();
                        loadCloseClear();
                        MessageBox.Show("Bu kayıt sistemden başarı ile silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch { MessageBox.Show("Kayıt silinemedi! Lütfen internet bağlantınız olduğundan emin olduktan sonra tekrar deneyin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
            else { MessageBox.Show("Lütfen silmek istediğiniz kartı okutunuz !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); } 
        }

        private void btnAddCancel_Click(object sender, EventArgs e) { addClear(); }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAddName.Text != "" && txtAddSurname.Text != "" && txtUserName.Text != "" && txtPassword.Text != "" && code.Text != "" )
            {
                checkCardCount();

                if (cardCount == 0)
                {
                    checkAddRadioButtons();

                    if (addRadioMode != "")
                    {
                        try
                        {
                            SqlCommand command = new SqlCommand("insert into TBLUSERS values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", con.connection());
                            command.Parameters.AddWithValue("@p1",txtAddName.Text);
                            command.Parameters.AddWithValue("@p2", txtAddSurname.Text);
                            command.Parameters.AddWithValue("@p3", txtUserName.Text);
                            command.Parameters.AddWithValue("@p4", txtPassword.Text);
                            command.Parameters.AddWithValue("@p5", code.Text);
                            command.Parameters.AddWithValue("@p6", false);
                            if (rdAdult.Checked == true) { command.Parameters.AddWithValue("@p7", false); }
                            else { command.Parameters.AddWithValue("@p7", true); }
                            command.Parameters.AddWithValue("@p8", 0.ToString());
                            command.Parameters.AddWithValue("@p9", "Koyu");
                            command.ExecuteNonQuery();
                            addClear();
                            MessageBox.Show("Yeni kayıt ekleme işlemi başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch { MessageBox.Show("Yeni kayıt ekleme işlemi gerçekleştirilemedi! Lütfen internet bağlantınız olduğundan emin olduktan sonra tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                    else { MessageBox.Show("Durum bilgisi seçilmek zorundadır !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else { MessageBox.Show("Bir kart birden fazla kişiye kayıt edilemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); cardCount = 0; }
            }
            else { MessageBox.Show("Yeni kart kayıtı yapılırken hiçbir alan boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
