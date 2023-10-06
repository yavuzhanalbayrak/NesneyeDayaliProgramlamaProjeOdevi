
namespace Nesneye_Dayalı_Programlama_Proje_Ödevi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnBasla = new System.Windows.Forms.Button();
            this.resim = new System.Windows.Forms.PictureBox();
            this.lblSure = new System.Windows.Forms.Label();
            this.btnNarenciye = new System.Windows.Forms.Button();
            this.btnKati = new System.Windows.Forms.Button();
            this.lblGramaj = new System.Windows.Forms.Label();
            this.lblVC = new System.Windows.Forms.Label();
            this.lblVA = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMeyveadi = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPS = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.listName = new System.Windows.Forms.ListBox();
            this.listGramaj = new System.Windows.Forms.ListBox();
            this.listVA = new System.Windows.Forms.ListBox();
            this.listPS = new System.Windows.Forms.ListBox();
            this.listVC = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnYeniMeyve = new System.Windows.Forms.Button();
            this.lblTA = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.lblTPS = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.resim)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBasla
            // 
            this.btnBasla.BackColor = System.Drawing.Color.PaleGreen;
            this.btnBasla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBasla.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBasla.Location = new System.Drawing.Point(38, 268);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(100, 34);
            this.btnBasla.TabIndex = 0;
            this.btnBasla.Text = "Başla";
            this.btnBasla.UseVisualStyleBackColor = false;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // resim
            // 
            this.resim.Location = new System.Drawing.Point(16, 12);
            this.resim.Name = "resim";
            this.resim.Size = new System.Drawing.Size(143, 143);
            this.resim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resim.TabIndex = 1;
            this.resim.TabStop = false;
            // 
            // lblSure
            // 
            this.lblSure.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSure.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSure.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSure.Location = new System.Drawing.Point(311, 34);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(100, 23);
            this.lblSure.TabIndex = 3;
            this.lblSure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNarenciye
            // 
            this.btnNarenciye.BackColor = System.Drawing.Color.MediumPurple;
            this.btnNarenciye.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNarenciye.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNarenciye.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNarenciye.Location = new System.Drawing.Point(33, 347);
            this.btnNarenciye.Name = "btnNarenciye";
            this.btnNarenciye.Size = new System.Drawing.Size(75, 45);
            this.btnNarenciye.TabIndex = 4;
            this.btnNarenciye.Text = "Narenciye Sıkacağı";
            this.btnNarenciye.UseVisualStyleBackColor = false;
            this.btnNarenciye.Click += new System.EventHandler(this.btnNarenciye_Click);
            // 
            // btnKati
            // 
            this.btnKati.BackColor = System.Drawing.Color.MediumPurple;
            this.btnKati.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKati.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKati.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnKati.Location = new System.Drawing.Point(33, 398);
            this.btnKati.Name = "btnKati";
            this.btnKati.Size = new System.Drawing.Size(75, 40);
            this.btnKati.TabIndex = 5;
            this.btnKati.Text = "Katı Meyve Sıkacağı";
            this.btnKati.UseVisualStyleBackColor = false;
            this.btnKati.Click += new System.EventHandler(this.btnKati_Click);
            // 
            // lblGramaj
            // 
            this.lblGramaj.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGramaj.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGramaj.Location = new System.Drawing.Point(156, 386);
            this.lblGramaj.Name = "lblGramaj";
            this.lblGramaj.Size = new System.Drawing.Size(62, 23);
            this.lblGramaj.TabIndex = 8;
            this.lblGramaj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVC
            // 
            this.lblVC.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVC.Location = new System.Drawing.Point(326, 386);
            this.lblVC.Name = "lblVC";
            this.lblVC.Size = new System.Drawing.Size(62, 23);
            this.lblVC.TabIndex = 9;
            this.lblVC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVA
            // 
            this.lblVA.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVA.Location = new System.Drawing.Point(241, 386);
            this.lblVA.Name = "lblVA";
            this.lblVA.Size = new System.Drawing.Size(62, 23);
            this.lblVA.TabIndex = 10;
            this.lblVA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Italic);
            this.label7.Location = new System.Drawing.Point(153, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Gramaj";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Italic);
            this.label5.Location = new System.Drawing.Point(317, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Vitamin C";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Italic);
            this.label6.Location = new System.Drawing.Point(228, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "Vitamin A";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMeyveadi
            // 
            this.lblMeyveadi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMeyveadi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMeyveadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeyveadi.Location = new System.Drawing.Point(12, 184);
            this.lblMeyveadi.Name = "lblMeyveadi";
            this.lblMeyveadi.Size = new System.Drawing.Size(147, 30);
            this.lblMeyveadi.TabIndex = 17;
            this.lblMeyveadi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMeyveadi.Click += new System.EventHandler(this.lblMeyveadi_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Italic);
            this.label9.Location = new System.Drawing.Point(328, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "Süre";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPS
            // 
            this.lblPS.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPS.Location = new System.Drawing.Point(411, 386);
            this.lblPS.Name = "lblPS";
            this.lblPS.Size = new System.Drawing.Size(62, 23);
            this.lblPS.TabIndex = 20;
            this.lblPS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Italic);
            this.label11.Location = new System.Drawing.Point(409, 353);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 33);
            this.label11.TabIndex = 21;
            this.label11.Text = "Püre-Sıvı Gramajı";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listName
            // 
            this.listName.FormattingEnabled = true;
            this.listName.Location = new System.Drawing.Point(198, 113);
            this.listName.Name = "listName";
            this.listName.Size = new System.Drawing.Size(67, 212);
            this.listName.TabIndex = 22;
            // 
            // listGramaj
            // 
            this.listGramaj.FormattingEnabled = true;
            this.listGramaj.Location = new System.Drawing.Point(262, 113);
            this.listGramaj.Name = "listGramaj";
            this.listGramaj.Size = new System.Drawing.Size(67, 212);
            this.listGramaj.TabIndex = 23;
            // 
            // listVA
            // 
            this.listVA.FormattingEnabled = true;
            this.listVA.Location = new System.Drawing.Point(329, 113);
            this.listVA.Name = "listVA";
            this.listVA.Size = new System.Drawing.Size(67, 212);
            this.listVA.TabIndex = 24;
            // 
            // listPS
            // 
            this.listPS.FormattingEnabled = true;
            this.listPS.Location = new System.Drawing.Point(463, 113);
            this.listPS.Name = "listPS";
            this.listPS.Size = new System.Drawing.Size(82, 212);
            this.listPS.TabIndex = 25;
            // 
            // listVC
            // 
            this.listVC.FormattingEnabled = true;
            this.listVC.Location = new System.Drawing.Point(396, 113);
            this.listVC.Name = "listVC";
            this.listVC.Size = new System.Drawing.Size(67, 212);
            this.listVC.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(480, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 33);
            this.label12.TabIndex = 30;
            this.label12.Text = "Püre-Sıvı Gramajı(gr)";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(305, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 28);
            this.label13.TabIndex = 29;
            this.label13.Text = "Vitamin A(iu)";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(390, 76);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 23);
            this.label14.TabIndex = 28;
            this.label14.Text = "Vitamin C(mg)";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(235, 76);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 23);
            this.label15.TabIndex = 27;
            this.label15.Text = "Gramaj(gr)";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(178, 76);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 23);
            this.label16.TabIndex = 31;
            this.label16.Text = "Meyve";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 32;
            this.label1.Text = "Meyvenin Adı";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnYeniMeyve
            // 
            this.btnYeniMeyve.BackColor = System.Drawing.Color.Gold;
            this.btnYeniMeyve.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYeniMeyve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYeniMeyve.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnYeniMeyve.Location = new System.Drawing.Point(26, 228);
            this.btnYeniMeyve.Name = "btnYeniMeyve";
            this.btnYeniMeyve.Size = new System.Drawing.Size(121, 34);
            this.btnYeniMeyve.TabIndex = 18;
            this.btnYeniMeyve.Text = "Yeni Meyve";
            this.btnYeniMeyve.UseVisualStyleBackColor = false;
            this.btnYeniMeyve.Click += new System.EventHandler(this.btnYeniMeyve_Click_1);
            // 
            // lblTA
            // 
            this.lblTA.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTA.Location = new System.Drawing.Point(651, 168);
            this.lblTA.Name = "lblTA";
            this.lblTA.Size = new System.Drawing.Size(62, 29);
            this.lblTA.TabIndex = 33;
            this.lblTA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTC
            // 
            this.lblTC.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTC.Location = new System.Drawing.Point(651, 215);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(62, 29);
            this.lblTC.TabIndex = 34;
            this.lblTC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTPS
            // 
            this.lblTPS.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTPS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTPS.Location = new System.Drawing.Point(651, 268);
            this.lblTPS.Name = "lblTPS";
            this.lblTPS.Size = new System.Drawing.Size(62, 29);
            this.lblTPS.TabIndex = 35;
            this.lblTPS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(651, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 23);
            this.label8.TabIndex = 36;
            this.label8.Text = "Toplam";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(551, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 28);
            this.label10.TabIndex = 37;
            this.label10.Text = "Vitamin A(iu)";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(551, 218);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 23);
            this.label17.TabIndex = 38;
            this.label17.Text = "Vitamin C(mg)";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(562, 268);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 33);
            this.label18.TabIndex = 39;
            this.label18.Text = "Püre-Sıvı Gramajı(gr)";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(595, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 40);
            this.button1.TabIndex = 40;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(722, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTPS);
            this.Controls.Add(this.lblTC);
            this.Controls.Add(this.lblTA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.listVC);
            this.Controls.Add(this.listPS);
            this.Controls.Add(this.listVA);
            this.Controls.Add(this.listGramaj);
            this.Controls.Add(this.listName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblPS);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnYeniMeyve);
            this.Controls.Add(this.lblMeyveadi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblVA);
            this.Controls.Add(this.lblVC);
            this.Controls.Add(this.lblGramaj);
            this.Controls.Add(this.btnKati);
            this.Controls.Add(this.btnNarenciye);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.resim);
            this.Controls.Add(this.btnBasla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.PictureBox resim;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Button btnNarenciye;
        private System.Windows.Forms.Button btnKati;
        private System.Windows.Forms.Label lblGramaj;
        private System.Windows.Forms.Label lblVC;
        private System.Windows.Forms.Label lblVA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMeyveadi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPS;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox listName;
        private System.Windows.Forms.ListBox listGramaj;
        private System.Windows.Forms.ListBox listVA;
        private System.Windows.Forms.ListBox listPS;
        private System.Windows.Forms.ListBox listVC;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnYeniMeyve;
        private System.Windows.Forms.Label lblTA;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label lblTPS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button1;
    }
}

