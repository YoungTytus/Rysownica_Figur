using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static Figury;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;

namespace Projekt2
{
    public partial class Mysz : Form
    {
        Graphics Rysownica;
        Point Punkt;
        List<Punkt> Lista = new List<Punkt>();
        private int IndexTFG;
        private Color Kolor = Color.Black;
        private Color KolorWypelnienia;
        private DashStyle Styl = DashStyle.Solid;
        private int Grubosc = 10;
        public Mysz()
        {
            
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
            PicBoxMysz.Image = new Bitmap(PicBoxMysz.Width, PicBoxMysz.Height);
            Rysownica = Graphics.FromImage(PicBoxMysz.Image);
            trackBar1.Minimum = 1;
            trackBar1.Maximum = 20;
            trackBar1.Value = Grubosc;
            InpKolor.BackColor = Kolor;
            InpKolorWyp.BackColor = KolorWypelnienia;
            comboBox1.Text = Styl.ToString();
            label2.Text = Grubosc.ToString();

        }

        private void ButPowMy_Click(object sender, EventArgs e)
        {
            var form = new Main();
            Hide();
            form.Show();
        }

        private void Mysz_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void PicBoxMysz_MouseMove(object sender, MouseEventArgs e)
        {
            LabMyX.Text = e.X.ToString();
            LabMyY.Text = e.Y.ToString();
            if (e.Button == MouseButtons.Right)
            {
                new Punkt(e.X, e.Y, Kolor).Draw(Rysownica);
                PicBoxMysz.Refresh();
            }
        }

        private void PicBoxMysz_MouseLeave(object sender, EventArgs e)
        {
            LabMyX.Text = "";
            LabMyY.Text = "";
        }

        private void PicBoxMysz_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Punkt = e.Location;
            }
        }

        private void PicBoxMysz_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (RadPunkt.Checked)
                {
                    Lista.Add(new Punkt(Punkt.X, Punkt.Y));
                    Lista.Last().ChangeStyle(Kolor, Styl, Grubosc);
                    Lista.Last().Draw(Rysownica);
                }else if (RadElip.Checked)
                {
                    int width = e.X - Punkt.X; 
                    int height = e.Y - Punkt.Y; 
                    Lista.Add(new Elipsa(Punkt.X, Punkt.Y, width, height));
                    Lista.Last().ChangeStyle(Kolor, Styl, Grubosc, KolorWypelnienia);
                    Lista.Last().Draw(Rysownica);
                }else if (RadioKolo.Checked)
                {
                    int radius = (int) Math.Sqrt(Math.Pow(e.X - Punkt.X, 2) + Math.Pow(e.Y - Punkt.Y, 2));
                    Lista.Add(new KoloJednoBarwne(Punkt.X, Punkt.Y, radius, Color.Black));
                    Lista.Last().ChangeStyle(Kolor, Styl, Grubosc, KolorWypelnienia);
                    Lista.Last().Draw(Rysownica);
                }else if (RadiKwad.Checked)
                {
                    int width = e.X - Punkt.X;
                    Lista.Add(new Kwadrat(Punkt.X, Punkt.Y, width));
                    Lista.Last().ChangeStyle(Kolor, Styl, Grubosc, KolorWypelnienia);
                    Lista.Last().Draw(Rysownica);
                }else if (RadioOkrag.Checked)
                {
                    int radius = (int) Math.Sqrt(Math.Pow(e.X - Punkt.X, 2) + Math.Pow(e.Y - Punkt.Y, 2));
                    Lista.Add(new Okrag(Punkt.X, Punkt.Y, radius));
                    Lista.Last().ChangeStyle(Kolor, Styl, Grubosc, KolorWypelnienia);
                    Lista.Last().Draw(Rysownica);
                }else if (RadProsto.Checked)
                {
                    int width = e.X - Punkt.X; 
                    int height = e.Y - Punkt.Y; 
                    Lista.Add(new Prostokat(Punkt.X, Punkt.Y, width, height));
                    Lista.Last().ChangeStyle(Kolor, Styl, Grubosc, KolorWypelnienia);
                    Lista.Last().Draw(Rysownica);
                }
                else if (RadioLinia.Checked)
                {
                    Lista.Add(new Linia(Punkt.X, Punkt.Y, e.X, e.Y));
                    Lista.Last().ChangeStyle(Kolor, Styl, Grubosc, KolorWypelnienia);
                    Lista.Last().Draw(Rysownica);
                }
            }

            ButStPokSl.Enabled = true;
            PicBoxMysz.Refresh();
        }
        private void Delete()
        {
            Rysownica.Clear(PicBoxMysz.BackColor);
            PicBoxMysz.Refresh();
        }
        
        private void ButReset_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void ButResList_Click(object sender, EventArgs e)
        {
            Lista = new List<Punkt>();
        }

        private void ButStPokSl_Click(object sender, EventArgs e)
        {
            RadButAutSl.Enabled = true;
            RadButManSl.Enabled = true;
            Delete();
            IndexTFG = 0;
            Timer.Enabled = false;
            LbInpSl.Text = IndexTFG.ToString();
            RadButAutSl.Checked = false;
            RadButAutSl.Checked = false;
            ButStPokSl.Enabled = true;
            PicBoxMysz.Refresh();
            ButStPokSl.Enabled = false;
            ButStoPokSl.Enabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Delete();
            if (IndexTFG >= Lista.Count)
                IndexTFG = 0;
            Lista[IndexTFG].DrawCenter(PicBoxMysz, Rysownica);
            LbInpSl.Text = IndexTFG.ToString();
            PicBoxMysz.Refresh();
            IndexTFG += 1;
        }

        private void ButStoPokSl_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {
                Delete();
                IndexTFG = 0;
                LbInpSl.Text = IndexTFG.ToString();
                Timer.Enabled = false;
                RadButAutSl.Checked = false;
                RadButManSl.Checked = false;
                ButStPokSl.Enabled = true;
                PicBoxMysz.Refresh();
            }
            
        }

        private void RadButManSl_CheckedChanged(object sender, EventArgs e)
        {
            Timer.Enabled = false;
            Delete();
            ButPrzSl.Enabled = true;
            ButPopSl.Enabled = true;
            Lista[IndexTFG].DrawCenter(PicBoxMysz, Rysownica);
            LbInpSl.Text = IndexTFG.ToString();
            PicBoxMysz.Refresh();
        }

        private void ButPrzSl_Click(object sender, EventArgs e)
        {
            Delete();
            IndexTFG += 1;
            if (IndexTFG >= Lista.Count)
                IndexTFG = 0;
            Lista[IndexTFG].DrawCenter(PicBoxMysz, Rysownica);
            LbInpSl.Text = IndexTFG.ToString();
            PicBoxMysz.Refresh();
        }

        private void ButPopSl_Click(object sender, EventArgs e)
        {
            Delete();
            IndexTFG -= 1;
            if (IndexTFG < 0)
                IndexTFG = Lista.Count - 1;
            Lista[IndexTFG].DrawCenter(PicBoxMysz, Rysownica);
            LbInpSl.Text = IndexTFG.ToString();
            PicBoxMysz.Refresh();
        }

        private void RadButAutSl_CheckedChanged(object sender, EventArgs e)
        {
            Timer.Enabled = true;
        }

        private void ButSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog=new SaveFileDialog();
            dialog.Filter = @"bitmap file (*.bmp)|*.bmp";
            dialog.FilterIndex = 1;
            dialog.RestoreDirectory = true;
            dialog.InitialDirectory = @"C:\\";
            dialog.Title = @"Bitmap";
            if (dialog.ShowDialog()==DialogResult.OK)
            {
                int width = Convert.ToInt32(PicBoxMysz.Width); 
                int height = Convert.ToInt32(PicBoxMysz.Height); 
                using(Bitmap bmp = new Bitmap(width, height))
                {
                    PicBoxMysz.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                    bmp.Save(dialog.FileName, ImageFormat.Jpeg);
                }
            }
        }

        private void ButLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = @"bitmap file (*.bmp)|*.bmp";
            dialog.FilterIndex = 1;
            dialog.RestoreDirectory = true;
            dialog.InitialDirectory = @"C:\\";
            if (dialog.ShowDialog()==DialogResult.OK)
            {

            }
        }

        private void ButKol_Click(object sender, EventArgs e)
        {
            ColorDialog kolordialog = new ColorDialog();  
            kolordialog.AllowFullOpen = false;

            if (kolordialog.ShowDialog() == DialogResult.OK)  
            {  
                Kolor = kolordialog.Color;
            }

            InpKolor.BackColor = Kolor;
        }

        private void ButStyl_Click(object sender, EventArgs e)
        {
            ColorDialog kolordialog = new ColorDialog();  
            kolordialog.AllowFullOpen = false;

            if (kolordialog.ShowDialog() == DialogResult.OK)  
            {  
                KolorWypelnienia = kolordialog.Color;
            } 
            InpKolorWyp.BackColor = KolorWypelnienia;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case @"Dash":
                    Styl = DashStyle.Dash;
                    break;
                case @"Solid":
                    Styl = DashStyle.Solid;
                    break;
                case @"Dot":
                    Styl = DashStyle.Dot;
                    break;
                    
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            
            Grubosc = trackBar1.Value;
            label2.Text = Grubosc.ToString();
        }
    }
}