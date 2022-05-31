using System.ComponentModel;

namespace Projekt2
{
    partial class Mysz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.ButPowMy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LabMyX = new System.Windows.Forms.Label();
            this.LabMyY = new System.Windows.Forms.Label();
            this.PicBoxMysz = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioLinia = new System.Windows.Forms.RadioButton();
            this.RadProsto = new System.Windows.Forms.RadioButton();
            this.RadioOkrag = new System.Windows.Forms.RadioButton();
            this.RadiKwad = new System.Windows.Forms.RadioButton();
            this.RadioKolo = new System.Windows.Forms.RadioButton();
            this.RadElip = new System.Windows.Forms.RadioButton();
            this.RadPunkt = new System.Windows.Forms.RadioButton();
            this.ButReset = new System.Windows.Forms.Button();
            this.ButResList = new System.Windows.Forms.Button();
            this.LbInpSl = new System.Windows.Forms.Label();
            this.Lb = new System.Windows.Forms.Label();
            this.ButPrzSl = new System.Windows.Forms.Button();
            this.ButStPokSl = new System.Windows.Forms.Button();
            this.RadButManSl = new System.Windows.Forms.RadioButton();
            this.RadButAutSl = new System.Windows.Forms.RadioButton();
            this.ButPopSl = new System.Windows.Forms.Button();
            this.GrBoxSl = new System.Windows.Forms.GroupBox();
            this.ButStoPokSl = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.ButSave = new System.Windows.Forms.Button();
            this.ButLoad = new System.Windows.Forms.Button();
            this.ButKol = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.InpKolorWyp = new System.Windows.Forms.TextBox();
            this.InpKolor = new System.Windows.Forms.TextBox();
            this.ButKolorWyp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.PicBoxMysz)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.GrBoxSl.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButPowMy
            // 
            this.ButPowMy.Location = new System.Drawing.Point(811, 14);
            this.ButPowMy.Name = "ButPowMy";
            this.ButPowMy.Size = new System.Drawing.Size(106, 31);
            this.ButPowMy.TabIndex = 0;
            this.ButPowMy.Text = "Powrót";
            this.ButPowMy.UseVisualStyleBackColor = true;
            this.ButPowMy.Click += new System.EventHandler(this.ButPowMy_Click);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(150, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Współrzędne (X,Y) myszy:";
            // 
            // LabMyX
            // 
            this.LabMyX.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.LabMyX.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabMyX.Location = new System.Drawing.Point(314, 22);
            this.LabMyX.Name = "LabMyX";
            this.LabMyX.Size = new System.Drawing.Size(47, 23);
            this.LabMyX.TabIndex = 2;
            // 
            // LabMyY
            // 
            this.LabMyY.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.LabMyY.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabMyY.Location = new System.Drawing.Point(367, 22);
            this.LabMyY.Name = "LabMyY";
            this.LabMyY.Size = new System.Drawing.Size(47, 23);
            this.LabMyY.TabIndex = 3;
            // 
            // PicBoxMysz
            // 
            this.PicBoxMysz.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (224)))), ((int) (((byte) (224)))), ((int) (((byte) (224)))));
            this.PicBoxMysz.Location = new System.Drawing.Point(24, 56);
            this.PicBoxMysz.Name = "PicBoxMysz";
            this.PicBoxMysz.Size = new System.Drawing.Size(613, 341);
            this.PicBoxMysz.TabIndex = 4;
            this.PicBoxMysz.TabStop = false;
            this.PicBoxMysz.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PicBoxMysz_MouseDown);
            this.PicBoxMysz.MouseLeave += new System.EventHandler(this.PicBoxMysz_MouseLeave);
            this.PicBoxMysz.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PicBoxMysz_MouseMove);
            this.PicBoxMysz.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PicBoxMysz_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadioLinia);
            this.groupBox1.Controls.Add(this.RadProsto);
            this.groupBox1.Controls.Add(this.RadioOkrag);
            this.groupBox1.Controls.Add(this.RadiKwad);
            this.groupBox1.Controls.Add(this.RadioKolo);
            this.groupBox1.Controls.Add(this.RadElip);
            this.groupBox1.Controls.Add(this.RadPunkt);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(663, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 208);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wybierz pędzel";
            // 
            // RadioLinia
            // 
            this.RadioLinia.Location = new System.Drawing.Point(10, 158);
            this.RadioLinia.Name = "RadioLinia";
            this.RadioLinia.Size = new System.Drawing.Size(85, 27);
            this.RadioLinia.TabIndex = 6;
            this.RadioLinia.TabStop = true;
            this.RadioLinia.Text = "Linia";
            this.RadioLinia.UseVisualStyleBackColor = true;
            // 
            // RadProsto
            // 
            this.RadProsto.Location = new System.Drawing.Point(10, 134);
            this.RadProsto.Name = "RadProsto";
            this.RadProsto.Size = new System.Drawing.Size(85, 27);
            this.RadProsto.TabIndex = 5;
            this.RadProsto.TabStop = true;
            this.RadProsto.Text = "Prostokąt";
            this.RadProsto.UseVisualStyleBackColor = true;
            // 
            // RadioOkrag
            // 
            this.RadioOkrag.Location = new System.Drawing.Point(10, 111);
            this.RadioOkrag.Name = "RadioOkrag";
            this.RadioOkrag.Size = new System.Drawing.Size(85, 27);
            this.RadioOkrag.TabIndex = 4;
            this.RadioOkrag.TabStop = true;
            this.RadioOkrag.Text = "Okrąg";
            this.RadioOkrag.UseVisualStyleBackColor = true;
            // 
            // RadiKwad
            // 
            this.RadiKwad.Location = new System.Drawing.Point(10, 87);
            this.RadiKwad.Name = "RadiKwad";
            this.RadiKwad.Size = new System.Drawing.Size(85, 27);
            this.RadiKwad.TabIndex = 3;
            this.RadiKwad.TabStop = true;
            this.RadiKwad.Text = "Kwadrat";
            this.RadiKwad.UseVisualStyleBackColor = true;
            // 
            // RadioKolo
            // 
            this.RadioKolo.Location = new System.Drawing.Point(10, 64);
            this.RadioKolo.Name = "RadioKolo";
            this.RadioKolo.Size = new System.Drawing.Size(62, 27);
            this.RadioKolo.TabIndex = 2;
            this.RadioKolo.TabStop = true;
            this.RadioKolo.Text = "Koło";
            this.RadioKolo.UseVisualStyleBackColor = true;
            // 
            // RadElip
            // 
            this.RadElip.Location = new System.Drawing.Point(10, 42);
            this.RadElip.Name = "RadElip";
            this.RadElip.Size = new System.Drawing.Size(62, 27);
            this.RadElip.TabIndex = 1;
            this.RadElip.TabStop = true;
            this.RadElip.Text = "Elipsa";
            this.RadElip.UseVisualStyleBackColor = true;
            // 
            // RadPunkt
            // 
            this.RadPunkt.Location = new System.Drawing.Point(10, 19);
            this.RadPunkt.Name = "RadPunkt";
            this.RadPunkt.Size = new System.Drawing.Size(62, 27);
            this.RadPunkt.TabIndex = 0;
            this.RadPunkt.TabStop = true;
            this.RadPunkt.Text = "Punkt";
            this.RadPunkt.UseVisualStyleBackColor = true;
            // 
            // ButReset
            // 
            this.ButReset.Location = new System.Drawing.Point(24, 15);
            this.ButReset.Name = "ButReset";
            this.ButReset.Size = new System.Drawing.Size(51, 31);
            this.ButReset.TabIndex = 6;
            this.ButReset.Text = "Reset";
            this.ButReset.UseVisualStyleBackColor = true;
            this.ButReset.Click += new System.EventHandler(this.ButReset_Click);
            // 
            // ButResList
            // 
            this.ButResList.Location = new System.Drawing.Point(81, 11);
            this.ButResList.Name = "ButResList";
            this.ButResList.Size = new System.Drawing.Size(63, 39);
            this.ButResList.TabIndex = 7;
            this.ButResList.Text = "Reset Lista";
            this.ButResList.UseVisualStyleBackColor = true;
            this.ButResList.Click += new System.EventHandler(this.ButResList_Click);
            // 
            // LbInpSl
            // 
            this.LbInpSl.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.LbInpSl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbInpSl.Location = new System.Drawing.Point(413, 423);
            this.LbInpSl.Name = "LbInpSl";
            this.LbInpSl.Size = new System.Drawing.Size(44, 41);
            this.LbInpSl.TabIndex = 26;
            this.LbInpSl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lb
            // 
            this.Lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lb.Location = new System.Drawing.Point(394, 403);
            this.Lb.Name = "Lb";
            this.Lb.Size = new System.Drawing.Size(95, 15);
            this.Lb.TabIndex = 25;
            this.Lb.Text = "Numer Figury";
            // 
            // ButPrzSl
            // 
            this.ButPrzSl.Enabled = false;
            this.ButPrzSl.Location = new System.Drawing.Point(507, 406);
            this.ButPrzSl.Name = "ButPrzSl";
            this.ButPrzSl.Size = new System.Drawing.Size(87, 22);
            this.ButPrzSl.TabIndex = 23;
            this.ButPrzSl.Text = "Nastepny";
            this.ButPrzSl.UseVisualStyleBackColor = true;
            this.ButPrzSl.Click += new System.EventHandler(this.ButPrzSl_Click);
            // 
            // ButStPokSl
            // 
            this.ButStPokSl.Enabled = false;
            this.ButStPokSl.Location = new System.Drawing.Point(12, 403);
            this.ButStPokSl.Name = "ButStPokSl";
            this.ButStPokSl.Size = new System.Drawing.Size(119, 25);
            this.ButStPokSl.TabIndex = 20;
            this.ButStPokSl.Text = "Włącz pokaz";
            this.ButStPokSl.UseVisualStyleBackColor = true;
            this.ButStPokSl.Click += new System.EventHandler(this.ButStPokSl_Click);
            // 
            // RadButManSl
            // 
            this.RadButManSl.Location = new System.Drawing.Point(120, 20);
            this.RadButManSl.Name = "RadButManSl";
            this.RadButManSl.Size = new System.Drawing.Size(104, 24);
            this.RadButManSl.TabIndex = 1;
            this.RadButManSl.Text = "Manualny";
            this.RadButManSl.UseVisualStyleBackColor = true;
            this.RadButManSl.CheckedChanged += new System.EventHandler(this.RadButManSl_CheckedChanged);
            // 
            // RadButAutSl
            // 
            this.RadButAutSl.Location = new System.Drawing.Point(6, 20);
            this.RadButAutSl.Name = "RadButAutSl";
            this.RadButAutSl.Size = new System.Drawing.Size(104, 24);
            this.RadButAutSl.TabIndex = 0;
            this.RadButAutSl.Text = "Automatyczny";
            this.RadButAutSl.UseVisualStyleBackColor = true;
            this.RadButAutSl.CheckedChanged += new System.EventHandler(this.RadButAutSl_CheckedChanged);
            // 
            // ButPopSl
            // 
            this.ButPopSl.Enabled = false;
            this.ButPopSl.Location = new System.Drawing.Point(507, 434);
            this.ButPopSl.Name = "ButPopSl";
            this.ButPopSl.Size = new System.Drawing.Size(87, 22);
            this.ButPopSl.TabIndex = 24;
            this.ButPopSl.Text = "Poprzedni";
            this.ButPopSl.UseVisualStyleBackColor = true;
            this.ButPopSl.Click += new System.EventHandler(this.ButPopSl_Click);
            // 
            // GrBoxSl
            // 
            this.GrBoxSl.Controls.Add(this.RadButManSl);
            this.GrBoxSl.Controls.Add(this.RadButAutSl);
            this.GrBoxSl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GrBoxSl.Location = new System.Drawing.Point(137, 398);
            this.GrBoxSl.Name = "GrBoxSl";
            this.GrBoxSl.Size = new System.Drawing.Size(239, 50);
            this.GrBoxSl.TabIndex = 22;
            this.GrBoxSl.TabStop = false;
            this.GrBoxSl.Text = "Pokaz figur";
            // 
            // ButStoPokSl
            // 
            this.ButStoPokSl.Enabled = false;
            this.ButStoPokSl.Location = new System.Drawing.Point(12, 434);
            this.ButStoPokSl.Name = "ButStoPokSl";
            this.ButStoPokSl.Size = new System.Drawing.Size(119, 23);
            this.ButStoPokSl.TabIndex = 21;
            this.ButStoPokSl.Text = "Wyłącz pokaz";
            this.ButStoPokSl.UseVisualStyleBackColor = true;
            this.ButStoPokSl.Click += new System.EventHandler(this.ButStoPokSl_Click);
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // ButSave
            // 
            this.ButSave.Location = new System.Drawing.Point(613, 406);
            this.ButSave.Name = "ButSave";
            this.ButSave.Size = new System.Drawing.Size(87, 22);
            this.ButSave.TabIndex = 27;
            this.ButSave.Text = "Zapisz";
            this.ButSave.UseVisualStyleBackColor = true;
            this.ButSave.Click += new System.EventHandler(this.ButSave_Click);
            // 
            // ButLoad
            // 
            this.ButLoad.Location = new System.Drawing.Point(613, 434);
            this.ButLoad.Name = "ButLoad";
            this.ButLoad.Size = new System.Drawing.Size(87, 22);
            this.ButLoad.TabIndex = 28;
            this.ButLoad.Text = "Wczytaj";
            this.ButLoad.UseVisualStyleBackColor = true;
            this.ButLoad.Click += new System.EventHandler(this.ButLoad_Click);
            // 
            // ButKol
            // 
            this.ButKol.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ButKol.Location = new System.Drawing.Point(10, 20);
            this.ButKol.Name = "ButKol";
            this.ButKol.Size = new System.Drawing.Size(84, 25);
            this.ButKol.TabIndex = 29;
            this.ButKol.Text = "Kolor";
            this.ButKol.UseVisualStyleBackColor = true;
            this.ButKol.Click += new System.EventHandler(this.ButKol_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.trackBar1);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.InpKolorWyp);
            this.groupBox2.Controls.Add(this.InpKolor);
            this.groupBox2.Controls.Add(this.ButKolorWyp);
            this.groupBox2.Controls.Add(this.ButKol);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(664, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 132);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Atrybuty";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(158, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 41);
            this.label2.TabIndex = 36;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(117, 51);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(125, 45);
            this.trackBar1.TabIndex = 35;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {"Dash", "Solid", "Dot"});
            this.comboBox1.Location = new System.Drawing.Point(117, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(95, 23);
            this.comboBox1.TabIndex = 34;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // InpKolorWyp
            // 
            this.InpKolorWyp.Enabled = false;
            this.InpKolorWyp.Location = new System.Drawing.Point(10, 105);
            this.InpKolorWyp.Name = "InpKolorWyp";
            this.InpKolorWyp.Size = new System.Drawing.Size(84, 21);
            this.InpKolorWyp.TabIndex = 33;
            // 
            // InpKolor
            // 
            this.InpKolor.Enabled = false;
            this.InpKolor.Location = new System.Drawing.Point(10, 51);
            this.InpKolor.Name = "InpKolor";
            this.InpKolor.Size = new System.Drawing.Size(84, 21);
            this.InpKolor.TabIndex = 32;
            // 
            // ButKolorWyp
            // 
            this.ButKolorWyp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButKolorWyp.Location = new System.Drawing.Point(10, 78);
            this.ButKolorWyp.Name = "ButKolorWyp";
            this.ButKolorWyp.Size = new System.Drawing.Size(84, 25);
            this.ButKolorWyp.TabIndex = 30;
            this.ButKolorWyp.Text = "Wypełnienie";
            this.ButKolorWyp.UseVisualStyleBackColor = true;
            this.ButKolorWyp.Click += new System.EventHandler(this.ButStyl_Click);
            // 
            // Mysz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (32)))), ((int) (((byte) (32)))), ((int) (((byte) (32)))));
            this.ClientSize = new System.Drawing.Size(929, 472);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ButLoad);
            this.Controls.Add(this.ButSave);
            this.Controls.Add(this.LbInpSl);
            this.Controls.Add(this.Lb);
            this.Controls.Add(this.ButPrzSl);
            this.Controls.Add(this.ButStPokSl);
            this.Controls.Add(this.ButPopSl);
            this.Controls.Add(this.GrBoxSl);
            this.Controls.Add(this.ButStoPokSl);
            this.Controls.Add(this.ButResList);
            this.Controls.Add(this.ButReset);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PicBoxMysz);
            this.Controls.Add(this.LabMyY);
            this.Controls.Add(this.LabMyX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButPowMy);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Mysz";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mysz_FormClosing_1);
            ((System.ComponentModel.ISupportInitialize) (this.PicBoxMysz)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.GrBoxSl.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.trackBar1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TrackBar trackBar1;

        private System.Windows.Forms.RadioButton RadioOkrag;
        private System.Windows.Forms.RadioButton RadProsto;
        private System.Windows.Forms.RadioButton RadioLinia;

        private System.Windows.Forms.ComboBox comboBox1;

        private System.Windows.Forms.TextBox InpKolor;
        private System.Windows.Forms.TextBox InpKolorWyp;

        private System.Windows.Forms.Button ButKol;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ButKolorWyp;

        private System.Windows.Forms.Button ButSave;
        private System.Windows.Forms.Button ButLoad;

        private System.Windows.Forms.Timer Timer;

        private System.Windows.Forms.Label LbInpSl;
        private System.Windows.Forms.Label Lb;
        private System.Windows.Forms.Button ButPrzSl;
        private System.Windows.Forms.Button ButStPokSl;
        private System.Windows.Forms.RadioButton RadButManSl;
        private System.Windows.Forms.RadioButton RadButAutSl;
        private System.Windows.Forms.Button ButPopSl;
        private System.Windows.Forms.GroupBox GrBoxSl;
        private System.Windows.Forms.Button ButStoPokSl;

        private System.Windows.Forms.RadioButton RadiKwad;

        private System.Windows.Forms.RadioButton RadioKolo;

        private System.Windows.Forms.RadioButton RadElip;

        private System.Windows.Forms.Button ButResList;

        private System.Windows.Forms.Button ButReset;

        private System.Windows.Forms.RadioButton RadPunkt;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.PictureBox PicBoxMysz;

        private System.Windows.Forms.Label LabMyX;

        private System.Windows.Forms.Label LabMyY;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button ButPowMy;

        #endregion
    }
}