using System;
using System.Drawing;
using System.Windows.Forms;

using static Figury;
using System.Drawing.Drawing2D;

namespace Projekt2
{
    public partial class Slajd : Form
    {
        private Graphics Rysownica;
        Punkt[] TFG;
        private int IndexTFG;
        private int[] indexy;
        private int margin = 20;
        public Slajd()
        {
            InitializeComponent();
            PicBoxSl.Image = new Bitmap(PicBoxSl.Width, PicBoxSl.Height);
            Rysownica = Graphics.FromImage(PicBoxSl.Image);
            LbInpSl.Text = IndexTFG.ToString();
        }

        
        Boolean Sprawdz(out int x)
        {
            x = 1;
            if (textBox1.Text.Length == 0)
            {
                ErrorInfoSl.SetError(textBox1, $"Error: Brak znaku");
                return false;
            }else if (!int.TryParse(textBox1.Text, out x))
            {
                ErrorInfoSl.SetError(textBox1, $"Error: Niedozwolony znak");
                return false;
            }
            else
                ErrorInfoSl.Dispose();

            return true;
        }
        
        private void ButStartSl_Click(object sender, EventArgs e)
        {
            var x = 1;
            if(!Sprawdz(out x))
                return;
            if (ListaSl.CheckedItems.Count == 0)
            {
                MessageBox.Show(@"Trzeba wybrać jakąś figurę");
                return;
            }
            TFG = new Punkt[x];
            indexy = new int[ListaSl.CheckedItems.Count];
            for (int i = 0; i < indexy.Length; i++)
            {
                indexy[i] = ListaSl.CheckedIndices[i];
            }

            Rysowanie();
            Przyciski(true);
            PicBoxSl.Refresh();
        }

        private void Rysowanie()
        {
            Random random = new Random();
            for (int i = 0; i < TFG.Length; i++)
            {
                switch (indexy[random.Next(0, indexy.Length)])
                {
                    case 0:
                        TFG[i] = new Punkt(random.Next(0, PicBoxSl.Width - margin), random.Next(0, PicBoxSl.Height - margin));
                        break;
                    case 1:
                        TFG[i] = new Linia(random.Next(0, PicBoxSl.Width - margin), random.Next(0, PicBoxSl.Height - margin), random.Next(0, PicBoxSl.Width - margin), random.Next(0, PicBoxSl.Height - margin));
                        break;
                    case 2:
                        TFG[i] = new Elipsa(random.Next(0, PicBoxSl.Width - margin), random.Next(0, PicBoxSl.Height - margin), random.Next(0, 150), random.Next(0, 150));
                        break;
                    case 3:
                        TFG[i] = new Okrag(random.Next(0, PicBoxSl.Width - margin), random.Next(0, PicBoxSl.Height - margin), random.Next(0, 150));
                        break;
                    case 4:
                        TFG[i] = new Prostokat(random.Next(0, PicBoxSl.Width - margin), random.Next(0, PicBoxSl.Height - margin), random.Next(0, 150), random.Next(0, 150));
                        break;
                    case 5:
                        TFG[i] = new Kwadrat(random.Next(0, PicBoxSl.Width - margin), random.Next(0, PicBoxSl.Height - margin), random.Next(0, 150));
                        break;
                    case 6:
                        TFG[i] = new KoloJednoBarwne(random.Next(0, PicBoxSl.Width - margin), random.Next(0, PicBoxSl.Height - margin), random.Next(0, 150));
                        break;
                }
                TFG[i].Draw(Rysownica);
            }
        }
        
        private void Przyciski(bool stan)
        {
            ButStartSl.Enabled = !stan;
            ButPrzesS.Enabled = stan;
            ButLosSl.Enabled = stan;
            ButZmianSl.Enabled = stan;
            ButStopSl.Enabled = stan;
            ButStPokSl.Enabled = stan;
            ButStoPokSl.Enabled = stan;
            RadButAutSl.Enabled = false;
            RadButManSl.Enabled = false;
            ButPrzSl.Enabled = false;
            ButPopSl.Enabled = false;
            ButRes.Enabled = stan;
        }

        private void Delete()
        {
            Rysownica.Clear(PicBoxSl.BackColor);
            PicBoxSl.Refresh();
        }
        
        private void Slajd_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ButRes_Click(object sender, EventArgs e)
        {
            Delete();
            Przyciski(false);
        }

        private void ButPrzesS_Click(object sender, EventArgs e)
        {
            
            Delete();
            Random random = new Random();
            foreach (var element in TFG)
            {
                element.Move(PicBoxSl, Rysownica, random.Next(0, PicBoxSl.Width - margin), random.Next(0, PicBoxSl.Height - margin));
            }
            PicBoxSl.Refresh();
        }

        private void ButLosSl_Click(object sender, EventArgs e)
        {
            Delete();
            Rysowanie();
            PicBoxSl.Refresh();
        }

        private void ButZmianSl_Click(object sender, EventArgs e)
        {
            Delete();
            Random random = new Random();
            DashStyle Styl;
            Color Kolor;
            int Grubosc;
            foreach (var element in TFG)
            {
                Kolor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                switch (random.Next(0, 4))
                {
                    case 0:
                        Styl = DashStyle.Dot;
                        break;
                    case 1:
                        Styl = DashStyle.Dash;
                        break;
                    case 2:
                        Styl = DashStyle.Solid;
                        break;
                    case 3:
                        Styl = DashStyle.DashDot;
                        break;
                    case 4:
                        Styl = DashStyle.DashDotDot;
                        break;
                    default:
                        Styl = DashStyle.Solid;
                        break;
                }

                Grubosc = random.Next(2, 15);
                element.ChangeStyle(Kolor, Styl, Grubosc);
                element.Draw(Rysownica);
            }
            PicBoxSl.Refresh();
        }

        private void ButLosSl_Click_1(object sender, EventArgs e)
        {
            Delete();
            Rysowanie();
            PicBoxSl.Refresh();
        }

        private void ButStPokSl_Click(object sender, EventArgs e)
        {
            RadButAutSl.Enabled = true;
            RadButManSl.Enabled = true;
        }

        private void ButStoPokSl_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {
                Delete();
                Przyciski(false);
                IndexTFG = 0;
                LbInpSl.Text = IndexTFG.ToString();
                Timer.Enabled = false;
                RadButAutSl.Checked = false;
                RadButAutSl.Checked = false;
                ButStPokSl.Enabled = true;
                PicBoxSl.Refresh();
            }
            
        }

        private void RadButManSl_CheckedChanged(object sender, EventArgs e)
        {
            Timer.Enabled = false;
            Delete();
            ButPrzSl.Enabled = true;
            ButPopSl.Enabled = true;
            TFG[IndexTFG].DrawCenter(PicBoxSl, Rysownica);
            LbInpSl.Text = IndexTFG.ToString();
            PicBoxSl.Refresh();
        }

        private void ButPrzSl_Click(object sender, EventArgs e)
        {
            Delete();
            IndexTFG += 1;
            if (IndexTFG >= TFG.Length)
                IndexTFG = 0;
            TFG[IndexTFG].DrawCenter(PicBoxSl, Rysownica);
            LbInpSl.Text = IndexTFG.ToString();
            PicBoxSl.Refresh();
        }

        private void ButPopSl_Click(object sender, EventArgs e)
        {
            Delete();
            IndexTFG -= 1;
            if (IndexTFG < 0)
                IndexTFG = TFG.Length - 1;
            TFG[IndexTFG].DrawCenter(PicBoxSl, Rysownica);
            LbInpSl.Text = IndexTFG.ToString();
            PicBoxSl.Refresh();
        }

        private void RadButAutSl_CheckedChanged(object sender, EventArgs e)
        {
            Timer.Enabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Delete();
            if (IndexTFG >= TFG.Length)
                IndexTFG = 0;
            TFG[IndexTFG].DrawCenter(PicBoxSl, Rysownica);
            LbInpSl.Text = IndexTFG.ToString();
            PicBoxSl.Refresh();
            IndexTFG += 1;
        }

        private void ButStopSl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stop");
        }

        private void ButPowSl_Click(object sender, EventArgs e)
        {
            var form = new Main();
            Hide();
            form.Show();
        }
    }
}