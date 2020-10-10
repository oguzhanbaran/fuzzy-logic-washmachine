namespace _163311052_bm
{
    partial class b_mantık
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(b_mantık));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalistir = new System.Windows.Forms.Button();
            this.numericKirlilik = new System.Windows.Forms.NumericUpDown();
            this.numericMiktar = new System.Windows.Forms.NumericUpDown();
            this.mamdaniDegerleri = new System.Windows.Forms.ListBox();
            this.lblKirlilikGoster = new System.Windows.Forms.Label();
            this.lblMiktarGoster = new System.Windows.Forms.Label();
            this.lblHassaslikGoster = new System.Windows.Forms.Label();
            this.lblKirlilik = new System.Windows.Forms.Label();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.lblHassaslik = new System.Windows.Forms.Label();
            this.numericHassaslik = new System.Windows.Forms.NumericUpDown();
            this.kuralList = new System.Windows.Forms.ListView();
            this.donusHiziLbl = new System.Windows.Forms.Label();
            this.sureLbl = new System.Windows.Forms.Label();
            this.deterjanLbl = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.hassaslikTrc = new System.Windows.Forms.TrackBar();
            this.miktarTrc = new System.Windows.Forms.TrackBar();
            this.kirlilikTrc = new System.Windows.Forms.TrackBar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericKirlilik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMiktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHassaslik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hassaslikTrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miktarTrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kirlilikTrc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCalistir);
            this.groupBox1.Controls.Add(this.numericKirlilik);
            this.groupBox1.Controls.Add(this.numericMiktar);
            this.groupBox1.Controls.Add(this.mamdaniDegerleri);
            this.groupBox1.Controls.Add(this.lblKirlilikGoster);
            this.groupBox1.Controls.Add(this.lblMiktarGoster);
            this.groupBox1.Controls.Add(this.lblHassaslikGoster);
            this.groupBox1.Controls.Add(this.lblKirlilik);
            this.groupBox1.Controls.Add(this.lblMiktar);
            this.groupBox1.Controls.Add(this.lblHassaslik);
            this.groupBox1.Controls.Add(this.numericHassaslik);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(396, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 526);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş Değerleri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mamdani Değerleri";
            // 
            // btnCalistir
            // 
            this.btnCalistir.Location = new System.Drawing.Point(54, 246);
            this.btnCalistir.Name = "btnCalistir";
            this.btnCalistir.Size = new System.Drawing.Size(154, 59);
            this.btnCalistir.TabIndex = 11;
            this.btnCalistir.Text = "Çalıştır";
            this.btnCalistir.UseVisualStyleBackColor = true;
            this.btnCalistir.Click += new System.EventHandler(this.BtnCalistir_Click);
            // 
            // numericKirlilik
            // 
            this.numericKirlilik.DecimalPlaces = 2;
            this.numericKirlilik.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericKirlilik.Location = new System.Drawing.Point(102, 162);
            this.numericKirlilik.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericKirlilik.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericKirlilik.Name = "numericKirlilik";
            this.numericKirlilik.Size = new System.Drawing.Size(120, 21);
            this.numericKirlilik.TabIndex = 10;
            this.numericKirlilik.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericKirlilik.ValueChanged += new System.EventHandler(this.NumericValueChanged);
            // 
            // numericMiktar
            // 
            this.numericMiktar.DecimalPlaces = 2;
            this.numericMiktar.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericMiktar.Location = new System.Drawing.Point(102, 101);
            this.numericMiktar.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericMiktar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericMiktar.Name = "numericMiktar";
            this.numericMiktar.Size = new System.Drawing.Size(120, 21);
            this.numericMiktar.TabIndex = 9;
            this.numericMiktar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericMiktar.ValueChanged += new System.EventHandler(this.NumericValueChanged);
            // 
            // mamdaniDegerleri
            // 
            this.mamdaniDegerleri.FormattingEnabled = true;
            this.mamdaniDegerleri.ItemHeight = 15;
            this.mamdaniDegerleri.Location = new System.Drawing.Point(31, 340);
            this.mamdaniDegerleri.Name = "mamdaniDegerleri";
            this.mamdaniDegerleri.Size = new System.Drawing.Size(201, 169);
            this.mamdaniDegerleri.TabIndex = 2;
            // 
            // lblKirlilikGoster
            // 
            this.lblKirlilikGoster.AutoSize = true;
            this.lblKirlilikGoster.Location = new System.Drawing.Point(99, 202);
            this.lblKirlilikGoster.Name = "lblKirlilikGoster";
            this.lblKirlilikGoster.Size = new System.Drawing.Size(0, 15);
            this.lblKirlilikGoster.TabIndex = 8;
            // 
            // lblMiktarGoster
            // 
            this.lblMiktarGoster.AutoSize = true;
            this.lblMiktarGoster.Location = new System.Drawing.Point(99, 137);
            this.lblMiktarGoster.Name = "lblMiktarGoster";
            this.lblMiktarGoster.Size = new System.Drawing.Size(0, 15);
            this.lblMiktarGoster.TabIndex = 7;
            // 
            // lblHassaslikGoster
            // 
            this.lblHassaslikGoster.AutoSize = true;
            this.lblHassaslikGoster.Location = new System.Drawing.Point(101, 67);
            this.lblHassaslikGoster.Name = "lblHassaslikGoster";
            this.lblHassaslikGoster.Size = new System.Drawing.Size(0, 15);
            this.lblHassaslikGoster.TabIndex = 6;
            // 
            // lblKirlilik
            // 
            this.lblKirlilik.AutoSize = true;
            this.lblKirlilik.Location = new System.Drawing.Point(27, 164);
            this.lblKirlilik.Name = "lblKirlilik";
            this.lblKirlilik.Size = new System.Drawing.Size(72, 15);
            this.lblKirlilik.TabIndex = 5;
            this.lblKirlilik.Text = "Kirlilik     :";
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Location = new System.Drawing.Point(28, 103);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(71, 15);
            this.lblMiktar.TabIndex = 4;
            this.lblMiktar.Text = "Miktar     :";
            // 
            // lblHassaslik
            // 
            this.lblHassaslik.AutoSize = true;
            this.lblHassaslik.Location = new System.Drawing.Point(28, 34);
            this.lblHassaslik.Name = "lblHassaslik";
            this.lblHassaslik.Size = new System.Drawing.Size(73, 15);
            this.lblHassaslik.TabIndex = 3;
            this.lblHassaslik.Text = "Hassaslık:";
            // 
            // numericHassaslik
            // 
            this.numericHassaslik.DecimalPlaces = 2;
            this.numericHassaslik.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericHassaslik.Location = new System.Drawing.Point(104, 32);
            this.numericHassaslik.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericHassaslik.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericHassaslik.Name = "numericHassaslik";
            this.numericHassaslik.Size = new System.Drawing.Size(120, 21);
            this.numericHassaslik.TabIndex = 0;
            this.numericHassaslik.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericHassaslik.ValueChanged += new System.EventHandler(this.NumericValueChanged);
            // 
            // kuralList
            // 
            this.kuralList.HideSelection = false;
            this.kuralList.Location = new System.Drawing.Point(664, 12);
            this.kuralList.Name = "kuralList";
            this.kuralList.Size = new System.Drawing.Size(535, 497);
            this.kuralList.TabIndex = 1;
            this.kuralList.UseCompatibleStateImageBehavior = false;
            // 
            // donusHiziLbl
            // 
            this.donusHiziLbl.AutoSize = true;
            this.donusHiziLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donusHiziLbl.Location = new System.Drawing.Point(62, 38);
            this.donusHiziLbl.Name = "donusHiziLbl";
            this.donusHiziLbl.Size = new System.Drawing.Size(101, 20);
            this.donusHiziLbl.TabIndex = 3;
            this.donusHiziLbl.Text = "Dönüş Hızı:";
            // 
            // sureLbl
            // 
            this.sureLbl.AutoSize = true;
            this.sureLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sureLbl.Location = new System.Drawing.Point(62, 95);
            this.sureLbl.Name = "sureLbl";
            this.sureLbl.Size = new System.Drawing.Size(57, 20);
            this.sureLbl.TabIndex = 4;
            this.sureLbl.Text = "Süre :";
            // 
            // deterjanLbl
            // 
            this.deterjanLbl.AutoSize = true;
            this.deterjanLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deterjanLbl.Location = new System.Drawing.Point(62, 155);
            this.deterjanLbl.Name = "deterjanLbl";
            this.deterjanLbl.Size = new System.Drawing.Size(141, 20);
            this.deterjanLbl.TabIndex = 5;
            this.deterjanLbl.Text = "Deterjan Miktarı:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::_163311052_bm.Properties.Resources.kirlilikGraph;
            this.pictureBox3.Location = new System.Drawing.Point(12, 503);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(378, 188);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::_163311052_bm.Properties.Resources.miktarGraph;
            this.pictureBox2.Location = new System.Drawing.Point(12, 258);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(378, 188);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_163311052_bm.Properties.Resources.hassaslikGraph;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.pictureBox7);
            this.groupBox2.Controls.Add(this.pictureBox5);
            this.groupBox2.Controls.Add(this.pictureBox6);
            this.groupBox2.Controls.Add(this.sureLbl);
            this.groupBox2.Controls.Add(this.donusHiziLbl);
            this.groupBox2.Controls.Add(this.deterjanLbl);
            this.groupBox2.Location = new System.Drawing.Point(664, 526);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(535, 216);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Çıkış Değerleri";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.InitialImage")));
            this.pictureBox7.Location = new System.Drawing.Point(18, 146);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(38, 38);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 10;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.InitialImage")));
            this.pictureBox5.Location = new System.Drawing.Point(18, 86);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(38, 38);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.InitialImage")));
            this.pictureBox6.Location = new System.Drawing.Point(18, 29);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(38, 38);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(414, 564);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(231, 161);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // hassaslikTrc
            // 
            this.hassaslikTrc.Enabled = false;
            this.hassaslikTrc.LargeChange = 1;
            this.hassaslikTrc.Location = new System.Drawing.Point(50, 207);
            this.hassaslikTrc.Maximum = 100;
            this.hassaslikTrc.Minimum = 10;
            this.hassaslikTrc.Name = "hassaslikTrc";
            this.hassaslikTrc.Size = new System.Drawing.Size(298, 45);
            this.hassaslikTrc.TabIndex = 14;
            this.hassaslikTrc.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.hassaslikTrc.Value = 10;
            // 
            // miktarTrc
            // 
            this.miktarTrc.Enabled = false;
            this.miktarTrc.LargeChange = 1;
            this.miktarTrc.Location = new System.Drawing.Point(50, 452);
            this.miktarTrc.Maximum = 100;
            this.miktarTrc.Minimum = 10;
            this.miktarTrc.Name = "miktarTrc";
            this.miktarTrc.Size = new System.Drawing.Size(298, 45);
            this.miktarTrc.TabIndex = 15;
            this.miktarTrc.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.miktarTrc.Value = 10;
            // 
            // kirlilikTrc
            // 
            this.kirlilikTrc.Enabled = false;
            this.kirlilikTrc.LargeChange = 1;
            this.kirlilikTrc.Location = new System.Drawing.Point(50, 697);
            this.kirlilikTrc.Maximum = 100;
            this.kirlilikTrc.Minimum = 10;
            this.kirlilikTrc.Name = "kirlilikTrc";
            this.kirlilikTrc.Size = new System.Drawing.Size(298, 45);
            this.kirlilikTrc.TabIndex = 16;
            this.kirlilikTrc.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.kirlilikTrc.Value = 10;
            // 
            // b_mantık
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1211, 751);
            this.Controls.Add(this.kirlilikTrc);
            this.Controls.Add(this.miktarTrc);
            this.Controls.Add(this.hassaslikTrc);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kuralList);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "b_mantık";
            this.Text = "Bulanık Çamaşır Makinesi";
            this.Load += new System.EventHandler(this.B_mantık_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericKirlilik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMiktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHassaslik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hassaslikTrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miktarTrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kirlilikTrc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericHassaslik;
        private System.Windows.Forms.Label lblKirlilikGoster;
        private System.Windows.Forms.Label lblMiktarGoster;
        private System.Windows.Forms.Label lblHassaslikGoster;
        private System.Windows.Forms.Label lblKirlilik;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.Label lblHassaslik;
        private System.Windows.Forms.NumericUpDown numericKirlilik;
        private System.Windows.Forms.NumericUpDown numericMiktar;
        private System.Windows.Forms.Button btnCalistir;
        private System.Windows.Forms.ListView kuralList;
        private System.Windows.Forms.ListBox mamdaniDegerleri;
        private System.Windows.Forms.Label donusHiziLbl;
        private System.Windows.Forms.Label sureLbl;
        private System.Windows.Forms.Label deterjanLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TrackBar hassaslikTrc;
        private System.Windows.Forms.TrackBar miktarTrc;
        private System.Windows.Forms.TrackBar kirlilikTrc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

