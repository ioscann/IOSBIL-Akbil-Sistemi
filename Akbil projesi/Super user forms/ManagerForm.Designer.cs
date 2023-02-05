namespace Akbil_projesi.Super_user_forms
{
    partial class ManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCloseCancel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtCloseSurname = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCloseName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lblCloseCardInfo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.code = new System.Windows.Forms.Label();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.lblAddCardInfo = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rdStudent = new System.Windows.Forms.RadioButton();
            this.rdAdult = new System.Windows.Forms.RadioButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtAddSurname = new System.Windows.Forms.TextBox();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLoadSurname = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtLoadName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lblLoadCardInfo = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnPill = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.txtLoadedBalance = new System.Windows.Forms.TextBox();
            this.txtCurrentBalance = new System.Windows.Forms.TextBox();
            this.rdCard = new System.Windows.Forms.RadioButton();
            this.rdCash = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 411);
            this.panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCloseCancel);
            this.groupBox3.Controls.Add(this.btnClose);
            this.groupBox3.Controls.Add(this.txtCloseSurname);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtCloseName);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.lblCloseCardInfo);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(691, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(314, 411);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kart Kapatma";
            // 
            // btnCloseCancel
            // 
            this.btnCloseCancel.Location = new System.Drawing.Point(10, 186);
            this.btnCloseCancel.Name = "btnCloseCancel";
            this.btnCloseCancel.Size = new System.Drawing.Size(287, 33);
            this.btnCloseCancel.TabIndex = 21;
            this.btnCloseCancel.Text = "İptal";
            this.btnCloseCancel.UseVisualStyleBackColor = true;
            this.btnCloseCancel.Click += new System.EventHandler(this.btnCloseCancel_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(10, 147);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(287, 33);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Kartı kapat";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtCloseSurname
            // 
            this.txtCloseSurname.Enabled = false;
            this.txtCloseSurname.Location = new System.Drawing.Point(90, 106);
            this.txtCloseSurname.Name = "txtCloseSurname";
            this.txtCloseSurname.Size = new System.Drawing.Size(207, 27);
            this.txtCloseSurname.TabIndex = 19;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 109);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 20);
            this.label16.TabIndex = 18;
            this.label16.Text = "Soyad:";
            // 
            // txtCloseName
            // 
            this.txtCloseName.Enabled = false;
            this.txtCloseName.Location = new System.Drawing.Point(90, 69);
            this.txtCloseName.Name = "txtCloseName";
            this.txtCloseName.Size = new System.Drawing.Size(207, 27);
            this.txtCloseName.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 73);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 20);
            this.label15.TabIndex = 16;
            this.label15.Text = "Ad:";
            // 
            // lblCloseCardInfo
            // 
            this.lblCloseCardInfo.AutoSize = true;
            this.lblCloseCardInfo.ForeColor = System.Drawing.Color.Red;
            this.lblCloseCardInfo.Location = new System.Drawing.Point(134, 36);
            this.lblCloseCardInfo.Name = "lblCloseCardInfo";
            this.lblCloseCardInfo.Size = new System.Drawing.Size(92, 20);
            this.lblCloseCardInfo.TabIndex = 15;
            this.lblCloseCardInfo.Text = "Erişilemedi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Kart bilgisi:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.code);
            this.groupBox2.Controls.Add(this.btnAddCancel);
            this.groupBox2.Controls.Add(this.lblAddCardInfo);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.rdStudent);
            this.groupBox2.Controls.Add(this.rdAdult);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.txtUserName);
            this.groupBox2.Controls.Add(this.txtAddSurname);
            this.groupBox2.Controls.Add(this.txtAddName);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(336, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 411);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yeni Kart Ekleme";
            // 
            // code
            // 
            this.code.AutoSize = true;
            this.code.Location = new System.Drawing.Point(341, 369);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(0, 20);
            this.code.TabIndex = 16;
            this.code.Visible = false;
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.Location = new System.Drawing.Point(10, 283);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(331, 33);
            this.btnAddCancel.TabIndex = 15;
            this.btnAddCancel.Text = "İptal";
            this.btnAddCancel.UseVisualStyleBackColor = true;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // lblAddCardInfo
            // 
            this.lblAddCardInfo.AutoSize = true;
            this.lblAddCardInfo.ForeColor = System.Drawing.Color.Red;
            this.lblAddCardInfo.Location = new System.Drawing.Point(128, 212);
            this.lblAddCardInfo.Name = "lblAddCardInfo";
            this.lblAddCardInfo.Size = new System.Drawing.Size(92, 20);
            this.lblAddCardInfo.TabIndex = 14;
            this.lblAddCardInfo.Text = "Erişilemedi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Kart bilgisi:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(10, 244);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(331, 33);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Kayıt";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rdStudent
            // 
            this.rdStudent.AutoSize = true;
            this.rdStudent.Location = new System.Drawing.Point(252, 176);
            this.rdStudent.Name = "rdStudent";
            this.rdStudent.Size = new System.Drawing.Size(89, 24);
            this.rdStudent.TabIndex = 11;
            this.rdStudent.TabStop = true;
            this.rdStudent.Text = "Öğrenci";
            this.rdStudent.UseVisualStyleBackColor = true;
            // 
            // rdAdult
            // 
            this.rdAdult.AutoSize = true;
            this.rdAdult.Location = new System.Drawing.Point(116, 176);
            this.rdAdult.Name = "rdAdult";
            this.rdAdult.Size = new System.Drawing.Size(88, 24);
            this.rdAdult.TabIndex = 10;
            this.rdAdult.TabStop = true;
            this.rdAdult.Text = "Yetişkin";
            this.rdAdult.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(116, 144);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(225, 27);
            this.txtPassword.TabIndex = 9;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(116, 109);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(225, 27);
            this.txtUserName.TabIndex = 8;
            // 
            // txtAddSurname
            // 
            this.txtAddSurname.Location = new System.Drawing.Point(116, 73);
            this.txtAddSurname.Name = "txtAddSurname";
            this.txtAddSurname.Size = new System.Drawing.Size(225, 27);
            this.txtAddSurname.TabIndex = 7;
            // 
            // txtAddName
            // 
            this.txtAddName.Location = new System.Drawing.Point(116, 36);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(225, 27);
            this.txtAddName.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Durum:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Şifre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Kullanıcı adı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLoadSurname);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txtLoadName);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.lblLoadCardInfo);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btnPill);
            this.groupBox1.Controls.Add(this.btnPayment);
            this.groupBox1.Controls.Add(this.txtLoadedBalance);
            this.groupBox1.Controls.Add(this.txtCurrentBalance);
            this.groupBox1.Controls.Add(this.rdCard);
            this.groupBox1.Controls.Add(this.rdCash);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 411);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bakiye Yükleme-Sorgulama";
            // 
            // txtLoadSurname
            // 
            this.txtLoadSurname.Enabled = false;
            this.txtLoadSurname.Location = new System.Drawing.Point(154, 103);
            this.txtLoadSurname.Name = "txtLoadSurname";
            this.txtLoadSurname.Size = new System.Drawing.Size(159, 27);
            this.txtLoadSurname.TabIndex = 20;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 106);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 20);
            this.label18.TabIndex = 19;
            this.label18.Text = "Soyad:";
            // 
            // txtLoadName
            // 
            this.txtLoadName.Enabled = false;
            this.txtLoadName.Location = new System.Drawing.Point(154, 66);
            this.txtLoadName.Name = "txtLoadName";
            this.txtLoadName.Size = new System.Drawing.Size(159, 27);
            this.txtLoadName.TabIndex = 18;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 69);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 20);
            this.label17.TabIndex = 17;
            this.label17.Text = "Ad:";
            // 
            // lblLoadCardInfo
            // 
            this.lblLoadCardInfo.AutoSize = true;
            this.lblLoadCardInfo.ForeColor = System.Drawing.Color.Red;
            this.lblLoadCardInfo.Location = new System.Drawing.Point(150, 36);
            this.lblLoadCardInfo.Name = "lblLoadCardInfo";
            this.lblLoadCardInfo.Size = new System.Drawing.Size(92, 20);
            this.lblLoadCardInfo.TabIndex = 15;
            this.lblLoadCardInfo.Text = "Erişilemedi";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 20);
            this.label12.TabIndex = 14;
            this.label12.Text = "Kart bilgisi:";
            // 
            // btnPill
            // 
            this.btnPill.Enabled = false;
            this.btnPill.Location = new System.Drawing.Point(10, 283);
            this.btnPill.Name = "btnPill";
            this.btnPill.Size = new System.Drawing.Size(303, 33);
            this.btnPill.TabIndex = 8;
            this.btnPill.Text = "Dekont";
            this.btnPill.UseVisualStyleBackColor = true;
            this.btnPill.Click += new System.EventHandler(this.btnPill_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(10, 244);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(303, 33);
            this.btnPayment.TabIndex = 7;
            this.btnPayment.Text = "Ödeme";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // txtLoadedBalance
            // 
            this.txtLoadedBalance.Location = new System.Drawing.Point(154, 177);
            this.txtLoadedBalance.Name = "txtLoadedBalance";
            this.txtLoadedBalance.Size = new System.Drawing.Size(159, 27);
            this.txtLoadedBalance.TabIndex = 6;
            // 
            // txtCurrentBalance
            // 
            this.txtCurrentBalance.Enabled = false;
            this.txtCurrentBalance.Location = new System.Drawing.Point(154, 141);
            this.txtCurrentBalance.Name = "txtCurrentBalance";
            this.txtCurrentBalance.Size = new System.Drawing.Size(159, 27);
            this.txtCurrentBalance.TabIndex = 5;
            // 
            // rdCard
            // 
            this.rdCard.AutoSize = true;
            this.rdCard.Location = new System.Drawing.Point(252, 210);
            this.rdCard.Name = "rdCard";
            this.rdCard.Size = new System.Drawing.Size(61, 24);
            this.rdCard.TabIndex = 4;
            this.rdCard.TabStop = true;
            this.rdCard.Text = "Kart";
            this.rdCard.UseVisualStyleBackColor = true;
            // 
            // rdCash
            // 
            this.rdCash.AutoSize = true;
            this.rdCash.Location = new System.Drawing.Point(154, 212);
            this.rdCash.Name = "rdCash";
            this.rdCash.Size = new System.Drawing.Size(68, 24);
            this.rdCash.TabIndex = 3;
            this.rdCash.TabStop = true;
            this.rdCash.Text = "Nakit";
            this.rdCash.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ödeme yöntemi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Yüklenecek tutar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mevcut bakiye:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 411);
            this.Controls.Add(this.panel1);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAddCardInfo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RadioButton rdStudent;
        private System.Windows.Forms.RadioButton rdAdult;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtAddSurname;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblLoadCardInfo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnPill;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.TextBox txtLoadedBalance;
        private System.Windows.Forms.TextBox txtCurrentBalance;
        private System.Windows.Forms.RadioButton rdCard;
        private System.Windows.Forms.RadioButton rdCash;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtCloseSurname;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtCloseName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblCloseCardInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLoadSurname;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtLoadName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnCloseCancel;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label code;
    }
}