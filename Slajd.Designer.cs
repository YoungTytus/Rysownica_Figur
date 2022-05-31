using System.ComponentModel;

namespace Projekt2
{
    partial class Slajd
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ustawieniaKoloruToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stylLiniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rozmiarFigurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ButPowSl = new System.Windows.Forms.Button();
            this.LabLiczGeo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ButStartSl = new System.Windows.Forms.Button();
            this.ButPrzesS = new System.Windows.Forms.Button();
            this.ButLosSl = new System.Windows.Forms.Button();
            this.ButZmianSl = new System.Windows.Forms.Button();
            this.LabOpisSl = new System.Windows.Forms.Label();
            this.ListaSl = new System.Windows.Forms.CheckedListBox();
            this.ButRes = new System.Windows.Forms.Button();
            this.PicBoxSl = new System.Windows.Forms.PictureBox();
            this.ErrorInfoSl = new System.Windows.Forms.ErrorProvider(this.components);
            this.ButStopSl = new System.Windows.Forms.Button();
            this.ButStPokSl = new System.Windows.Forms.Button();
            this.ButStoPokSl = new System.Windows.Forms.Button();
            this.GrBoxSl = new System.Windows.Forms.GroupBox();
            this.RadButManSl = new System.Windows.Forms.RadioButton();
            this.RadButAutSl = new System.Windows.Forms.RadioButton();
            this.ButPrzSl = new System.Windows.Forms.Button();
            this.ButPopSl = new System.Windows.Forms.Button();
            this.Lb = new System.Windows.Forms.Label();
            this.LbInpSl = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.PicBoxSl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.ErrorInfoSl)).BeginInit();
            this.GrBoxSl.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.plikToolStripMenuItem, this.ustawieniaKoloruToolStripMenuItem, this.stylLiniToolStripMenuItem, this.rozmiarFigurToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(933, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // ustawieniaKoloruToolStripMenuItem
            // 
            this.ustawieniaKoloruToolStripMenuItem.Name = "ustawieniaKoloruToolStripMenuItem";
            this.ustawieniaKoloruToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.ustawieniaKoloruToolStripMenuItem.Text = "Ustawienia Koloru";
            // 
            // stylLiniToolStripMenuItem
            // 
            this.stylLiniToolStripMenuItem.Name = "stylLiniToolStripMenuItem";
            this.stylLiniToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.stylLiniToolStripMenuItem.Text = "Styl lini";
            // 
            // rozmiarFigurToolStripMenuItem
            // 
            this.rozmiarFigurToolStripMenuItem.Name = "rozmiarFigurToolStripMenuItem";
            this.rozmiarFigurToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.rozmiarFigurToolStripMenuItem.Text = "Rozmiar figur";
            // 
            // ButPowSl
            // 
            this.ButPowSl.Location = new System.Drawing.Point(857, 27);
            this.ButPowSl.Name = "ButPowSl";
            this.ButPowSl.Size = new System.Drawing.Size(64, 32);
            this.ButPowSl.TabIndex = 1;
            this.ButPowSl.Text = "Powrót";
            this.ButPowSl.UseVisualStyleBackColor = true;
            this.ButPowSl.Click += new System.EventHandler(this.ButPowSl_Click);
            // 
            // LabLiczGeo
            // 
            this.LabLiczGeo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabLiczGeo.Location = new System.Drawing.Point(12, 27);
            this.LabLiczGeo.Name = "LabLiczGeo";
            this.LabLiczGeo.Size = new System.Drawing.Size(106, 21);
            this.LabLiczGeo.TabIndex = 2;
            this.LabLiczGeo.Text = "Podaj liczbę figur";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(86, 21);
            this.textBox1.TabIndex = 3;
            // 
            // ButStartSl
            // 
            this.ButStartSl.Location = new System.Drawing.Point(21, 78);
            this.ButStartSl.Name = "ButStartSl";
            this.ButStartSl.Size = new System.Drawing.Size(87, 22);
            this.ButStartSl.TabIndex = 4;
            this.ButStartSl.Text = "Start";
            this.ButStartSl.UseVisualStyleBackColor = true;
            this.ButStartSl.Click += new System.EventHandler(this.ButStartSl_Click);
            // 
            // ButPrzesS
            // 
            this.ButPrzesS.Enabled = false;
            this.ButPrzesS.Location = new System.Drawing.Point(12, 106);
            this.ButPrzesS.Name = "ButPrzesS";
            this.ButPrzesS.Size = new System.Drawing.Size(106, 24);
            this.ButPrzesS.TabIndex = 5;
            this.ButPrzesS.Text = "Przesunięcie";
            this.ButPrzesS.UseVisualStyleBackColor = true;
            this.ButPrzesS.Click += new System.EventHandler(this.ButPrzesS_Click);
            // 
            // ButLosSl
            // 
            this.ButLosSl.Enabled = false;
            this.ButLosSl.Location = new System.Drawing.Point(12, 136);
            this.ButLosSl.Name = "ButLosSl";
            this.ButLosSl.Size = new System.Drawing.Size(106, 49);
            this.ButLosSl.TabIndex = 6;
            this.ButLosSl.Text = "Wylosowanie nowych figur";
            this.ButLosSl.UseVisualStyleBackColor = true;
            this.ButLosSl.Click += new System.EventHandler(this.ButLosSl_Click_1);
            // 
            // ButZmianSl
            // 
            this.ButZmianSl.Enabled = false;
            this.ButZmianSl.Location = new System.Drawing.Point(12, 190);
            this.ButZmianSl.Name = "ButZmianSl";
            this.ButZmianSl.Size = new System.Drawing.Size(105, 42);
            this.ButZmianSl.TabIndex = 7;
            this.ButZmianSl.Text = "Zmiana atrybutów";
            this.ButZmianSl.UseVisualStyleBackColor = true;
            this.ButZmianSl.Click += new System.EventHandler(this.ButZmianSl_Click);
            // 
            // LabOpisSl
            // 
            this.LabOpisSl.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LabOpisSl.Location = new System.Drawing.Point(754, 62);
            this.LabOpisSl.Name = "LabOpisSl";
            this.LabOpisSl.Size = new System.Drawing.Size(167, 75);
            this.LabOpisSl.TabIndex = 8;
            this.LabOpisSl.Text = "Zaznacz figury geometryczne które mają być losowane i wyświetlane na planszy graf" + "icznej";
            this.LabOpisSl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListaSl
            // 
            this.ListaSl.FormattingEnabled = true;
            this.ListaSl.Items.AddRange(new object[] {"Punkt", "Linia", "Elipsa", "Ogrąg", "Prostokąt", "Kwadrat", "Koło jednobarwne"});
            this.ListaSl.Location = new System.Drawing.Point(754, 140);
            this.ListaSl.Name = "ListaSl";
            this.ListaSl.Size = new System.Drawing.Size(167, 116);
            this.ListaSl.TabIndex = 9;
            // 
            // ButRes
            // 
            this.ButRes.Enabled = false;
            this.ButRes.Location = new System.Drawing.Point(775, 262);
            this.ButRes.Name = "ButRes";
            this.ButRes.Size = new System.Drawing.Size(118, 29);
            this.ButRes.TabIndex = 10;
            this.ButRes.Text = "Resetuj";
            this.ButRes.UseVisualStyleBackColor = true;
            this.ButRes.Click += new System.EventHandler(this.ButRes_Click);
            // 
            // PicBoxSl
            // 
            this.PicBoxSl.BackColor = System.Drawing.Color.Gray;
            this.PicBoxSl.Location = new System.Drawing.Point(124, 62);
            this.PicBoxSl.Name = "PicBoxSl";
            this.PicBoxSl.Size = new System.Drawing.Size(596, 379);
            this.PicBoxSl.TabIndex = 11;
            this.PicBoxSl.TabStop = false;
            // 
            // ErrorInfoSl
            // 
            this.ErrorInfoSl.ContainerControl = this;
            // 
            // ButStopSl
            // 
            this.ButStopSl.Enabled = false;
            this.ButStopSl.Location = new System.Drawing.Point(20, 255);
            this.ButStopSl.Name = "ButStopSl";
            this.ButStopSl.Size = new System.Drawing.Size(87, 22);
            this.ButStopSl.TabIndex = 12;
            this.ButStopSl.Text = "Stop";
            this.ButStopSl.UseVisualStyleBackColor = true;
            this.ButStopSl.Click += new System.EventHandler(this.ButStopSl_Click);
            // 
            // ButStPokSl
            // 
            this.ButStPokSl.Enabled = false;
            this.ButStPokSl.Location = new System.Drawing.Point(12, 303);
            this.ButStPokSl.Name = "ButStPokSl";
            this.ButStPokSl.Size = new System.Drawing.Size(105, 42);
            this.ButStPokSl.TabIndex = 13;
            this.ButStPokSl.Text = "Włącz pokaz";
            this.ButStPokSl.UseVisualStyleBackColor = true;
            this.ButStPokSl.Click += new System.EventHandler(this.ButStPokSl_Click);
            // 
            // ButStoPokSl
            // 
            this.ButStoPokSl.Enabled = false;
            this.ButStoPokSl.Location = new System.Drawing.Point(12, 351);
            this.ButStoPokSl.Name = "ButStoPokSl";
            this.ButStoPokSl.Size = new System.Drawing.Size(105, 42);
            this.ButStoPokSl.TabIndex = 14;
            this.ButStoPokSl.Text = "Wyłącz pokaz";
            this.ButStoPokSl.UseVisualStyleBackColor = true;
            this.ButStoPokSl.Click += new System.EventHandler(this.ButStoPokSl_Click);
            // 
            // GrBoxSl
            // 
            this.GrBoxSl.Controls.Add(this.RadButManSl);
            this.GrBoxSl.Controls.Add(this.RadButAutSl);
            this.GrBoxSl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GrBoxSl.Location = new System.Drawing.Point(28, 444);
            this.GrBoxSl.Name = "GrBoxSl";
            this.GrBoxSl.Size = new System.Drawing.Size(239, 50);
            this.GrBoxSl.TabIndex = 15;
            this.GrBoxSl.TabStop = false;
            this.GrBoxSl.Text = "Pokaz figur";
            // 
            // RadButManSl
            // 
            this.RadButManSl.Location = new System.Drawing.Point(129, 20);
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
            // ButPrzSl
            // 
            this.ButPrzSl.Enabled = false;
            this.ButPrzSl.Location = new System.Drawing.Point(397, 447);
            this.ButPrzSl.Name = "ButPrzSl";
            this.ButPrzSl.Size = new System.Drawing.Size(87, 22);
            this.ButPrzSl.TabIndex = 16;
            this.ButPrzSl.Text = "Nastepny";
            this.ButPrzSl.UseVisualStyleBackColor = true;
            this.ButPrzSl.Click += new System.EventHandler(this.ButPrzSl_Click);
            // 
            // ButPopSl
            // 
            this.ButPopSl.Enabled = false;
            this.ButPopSl.Location = new System.Drawing.Point(397, 475);
            this.ButPopSl.Name = "ButPopSl";
            this.ButPopSl.Size = new System.Drawing.Size(87, 22);
            this.ButPopSl.TabIndex = 17;
            this.ButPopSl.Text = "Poprzedni";
            this.ButPopSl.UseVisualStyleBackColor = true;
            this.ButPopSl.Click += new System.EventHandler(this.ButPopSl_Click);
            // 
            // Lb
            // 
            this.Lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lb.Location = new System.Drawing.Point(285, 449);
            this.Lb.Name = "Lb";
            this.Lb.Size = new System.Drawing.Size(95, 15);
            this.Lb.TabIndex = 18;
            this.Lb.Text = "Numer Figury";
            // 
            // LbInpSl
            // 
            this.LbInpSl.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.LbInpSl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbInpSl.Location = new System.Drawing.Point(304, 469);
            this.LbInpSl.Name = "LbInpSl";
            this.LbInpSl.Size = new System.Drawing.Size(44, 41);
            this.LbInpSl.TabIndex = 19;
            this.LbInpSl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Slajd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (32)))), ((int) (((byte) (32)))), ((int) (((byte) (32)))));
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.LbInpSl);
            this.Controls.Add(this.Lb);
            this.Controls.Add(this.ButPopSl);
            this.Controls.Add(this.ButPrzSl);
            this.Controls.Add(this.GrBoxSl);
            this.Controls.Add(this.ButStoPokSl);
            this.Controls.Add(this.ButStPokSl);
            this.Controls.Add(this.ButStopSl);
            this.Controls.Add(this.PicBoxSl);
            this.Controls.Add(this.ButRes);
            this.Controls.Add(this.ListaSl);
            this.Controls.Add(this.LabOpisSl);
            this.Controls.Add(this.ButZmianSl);
            this.Controls.Add(this.ButLosSl);
            this.Controls.Add(this.ButPrzesS);
            this.Controls.Add(this.ButStartSl);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LabLiczGeo);
            this.Controls.Add(this.ButPowSl);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Slajd";
            this.Text = "Slajd";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Slajd_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.PicBoxSl)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.ErrorInfoSl)).EndInit();
            this.GrBoxSl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Timer Timer;


        private System.Windows.Forms.Label LbInpSl;

        private System.Windows.Forms.Button ButPrzSl;
        private System.Windows.Forms.Button ButPopSl;
        private System.Windows.Forms.Label Lb;

        private System.Windows.Forms.Button ButStopSl;
        private System.Windows.Forms.Button ButStPokSl;
        private System.Windows.Forms.Button ButStoPokSl;
        private System.Windows.Forms.GroupBox GrBoxSl;
        private System.Windows.Forms.RadioButton RadButAutSl;
        private System.Windows.Forms.RadioButton RadButManSl;

        private System.Windows.Forms.ErrorProvider ErrorInfoSl;

        private System.Windows.Forms.PictureBox PicBoxSl;

        private System.Windows.Forms.Button ButRes;

        private System.Windows.Forms.CheckedListBox ListaSl;

        private System.Windows.Forms.Label LabLiczGeo;
        private System.Windows.Forms.Button ButStartSl;
        private System.Windows.Forms.Button ButPrzesS;
        private System.Windows.Forms.Button ButLosSl;
        private System.Windows.Forms.Button ButZmianSl;

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Label LabOpisSl;

        private System.Windows.Forms.Button ButPowSl;

        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ustawieniaKoloruToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stylLiniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rozmiarFigurToolStripMenuItem;

        private System.Windows.Forms.MenuStrip menuStrip1;

        #endregion
    }
}