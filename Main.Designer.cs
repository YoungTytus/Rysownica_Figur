namespace Projekt2
{
    partial class Main
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
            this.ButStartRand = new System.Windows.Forms.Button();
            this.ButStartMysz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButStartRand
            // 
            this.ButStartRand.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.ButStartRand.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ButStartRand.Location = new System.Drawing.Point(201, 224);
            this.ButStartRand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButStartRand.Name = "ButStartRand";
            this.ButStartRand.Size = new System.Drawing.Size(259, 96);
            this.ButStartRand.TabIndex = 0;
            this.ButStartRand.Text = "Prezentacja figur geometrycznych ze slajderem";
            this.ButStartRand.UseVisualStyleBackColor = true;
            this.ButStartRand.Click += new System.EventHandler(this.ButStartRand_Click);
            // 
            // ButStartMysz
            // 
            this.ButStartMysz.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.ButStartMysz.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ButStartMysz.Location = new System.Drawing.Point(489, 224);
            this.ButStartMysz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButStartMysz.Name = "ButStartMysz";
            this.ButStartMysz.Size = new System.Drawing.Size(259, 96);
            this.ButStartMysz.TabIndex = 1;
            this.ButStartMysz.Text = "Prezentacja figur geometrycznych i linii przy użyciu myszy";
            this.ButStartMysz.UseVisualStyleBackColor = true;
            this.ButStartMysz.Click += new System.EventHandler(this.ButStartMysz_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (32)))), ((int) (((byte) (32)))), ((int) (((byte) (32)))));
            this.BackgroundImage = global::Projekt2.Properties.Resources.pngegg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.ButStartMysz);
            this.Controls.Add(this.ButStartRand);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.Text = "Prezenter figur geometrycznych";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button ButStartMysz;

        private System.Windows.Forms.Button ButStartRand;

        #endregion
    }
}