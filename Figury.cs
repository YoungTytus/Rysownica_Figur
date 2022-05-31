using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class Figury
{
    public class Punkt
    {
        protected int X;
        protected int Y;
        protected int Grubosc = 5;
        protected Color Kolor;
        protected DashStyle Styl;

        public Punkt(int x, int y)
        {
            X = x;
            Y = y;
            Kolor = Color.Black;
            Styl = DashStyle.Solid;
        }
        public Punkt(int x, int y, Color Kolor): this(x, y)
        {
            X = x;
            Y = y;
            Kolor = Color.Black;
        }

        public Punkt(int x, int y, Color Kolor, DashStyle Styl) : this(x, y)
        {
            this.Kolor = Kolor;
            this.Styl = Styl;
        }

        private void UpdateLoc(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public virtual void Draw(Graphics Rysownica)
        {
            using (SolidBrush Brush = new SolidBrush(Kolor))
            {
                Rysownica.FillEllipse(Brush, X - Grubosc / 2, Y - Grubosc / 2, Grubosc, Grubosc);
            }
        }

        public virtual void Move(Control Kontrolka, Graphics Rysownica, int x, int y)
        {
            UpdateLoc(x, y);
            Draw(Rysownica);
        }

        public virtual void DrawCenter(Control Kontrolka, Graphics Rysownica)
        {
            UpdateLoc(Kontrolka.Width / 2 - Grubosc / 2, Kontrolka.Height / 2 - Grubosc / 2);
            Draw(Rysownica);
        }
        public virtual void ChangeStyle(Color Kolor, DashStyle Styl, int Grubosc)
        {
            this.Kolor = Kolor;
            this.Styl = Styl;
            this.Grubosc = Grubosc;
        }
        public virtual void ChangeStyle(Color Kolor, DashStyle Styl, int Grubosc, Color KolorWypelnienia)
        {
            this.Kolor = Kolor;
            this.Styl = Styl;
            this.Grubosc = Grubosc;
        }
       

    }
    public class Linia : Punkt
    {
        protected int Xk;
        protected int Yk;

        public Linia(int x, int y, int Xk, int Yk) : base(x, y)
        {
            this.Xk = Xk;
            this.Yk = Yk;
        }
        public Linia(int x, int y, int Xk, int Yk, Color Kolor, DashStyle Styl) : this(x, y, Xk, Yk)
        {
            this.Kolor = Kolor;
            this.Styl = Styl;
        }

        public override void Draw(Graphics Rysownica)
        {
            using (Pen pen = new Pen(Kolor, Grubosc))
            {
                pen.DashStyle = Styl;
                Rysownica.DrawLine(pen,  X, Y, Xk, Yk);
            }
        }
        public override void DrawCenter(Control Kontrolka, Graphics Rysownica)
        {
            UpdateLoc(Kontrolka.Width / 2, Kontrolka.Height / 2);
            Draw(Rysownica);
        }

       
        private void UpdateLoc(int X, int Y)
        {
            int pomcX, pomcY;
            pomcX = this.X;
            pomcY = this.Y;
            this.X = X;
            this.Y = Y;
            pomcX = (this.X - pomcX)*-1;
            pomcY = (this.Y - pomcY)*-1;
            this.Xk = Xk + pomcX;
            this.Yk = Yk + pomcY;
        }
        public override void Move(Control Kontrolka, Graphics Rysownica, int x, int y)
        {
            UpdateLoc(x, y);
            Draw(Rysownica);
        }

        public override void ChangeStyle(Color Kolor, DashStyle Styl, int Grubosc)
        {
            this.Kolor = Kolor;
            this.Styl = Styl;
            this.Grubosc = Grubosc;
        }
        public override void ChangeStyle(Color Kolor, DashStyle Styl, int Grubosc, Color KolorWypelnienia)
        {
            this.Kolor = Kolor;
            this.Styl = Styl;
            this.Grubosc = Grubosc;
        }
    }

    public class Elipsa : Punkt
    {
        protected int Xk;
        protected int Yk;
        protected Color KolorWypelnienia;

        public Elipsa(int x, int y, int Xk, int Yk) : base(x, y)
        {
            this.Xk = Xk;
            this.Yk = Yk;
        }

        public Elipsa(int x, int y, int Xk, int Yk, Color Kolor) : this(x, y, Xk, Yk)
        {
            this.Kolor = Kolor;
        }
        public Elipsa(int x, int y, int Xk, int Yk, Color Kolor, DashStyle Styl, Color KolorWypelnienia) : this(x, y, Xk, Yk, Kolor)
        {
            this.Styl = Styl;
            this.KolorWypelnienia = KolorWypelnienia;
        }
        
        public override void Draw(Graphics Rysownica)
        {
            using (Pen pen = new Pen(Kolor, Grubosc))
            {
                pen.DashStyle = Styl;
                Rysownica.DrawEllipse(pen,  X, Y, Xk, Yk);
            }
            using (SolidBrush brush = new SolidBrush(KolorWypelnienia))
            {
                
                Rysownica.FillEllipse(brush, X > Xk? X - 1: X + 1, Y > Yk? Y - 1: Y + 1, X > Xk? Xk + 1: Xk - 1, Y > Yk? Yk + 1: Yk - 1);
            }
        }
        private void UpdateLoc(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public override void Move(Control Kontrolka, Graphics Rysownica, int x, int y)
        {
            UpdateLoc(x, y);
            Draw(Rysownica);
        }
        public override void DrawCenter(Control Kontrolka, Graphics Rysownica)
        {
            UpdateLoc(Kontrolka.Width / 2 - Xk / 2, Kontrolka.Height / 2 - Yk / 2);
            Draw(Rysownica);
        }
        public override void ChangeStyle(Color Kolor, DashStyle Styl, int Grubosc)
        {
            this.Kolor = Kolor;
            this.Styl = Styl;
            this.Grubosc = Grubosc;
        }
        public override void ChangeStyle(Color Kolor, DashStyle Styl, int Grubosc, Color KolorWypelnienia)
        {
            this.Kolor = Kolor;
            this.Styl = Styl;
            this.Grubosc = Grubosc;
            this.KolorWypelnienia = KolorWypelnienia;
        }
    }

    public class Okrag : Punkt
    {
        protected int radius;

        public Okrag(int x, int y, int radius) : base(x, y)
        {
            this.radius = radius;
        }

        public Okrag(int x, int y, int radius, Color Kolor) : this(x, y, radius)
        {
            this.Kolor = Kolor;
        }

        public Okrag(int x, int y, int radius, Color Kolor, DashStyle Styl) : this(x, y, radius, Kolor)
        {
            this.Styl = Styl;
        }

        public override void Draw(Graphics Rysownica)
        {
            using (Pen pen = new Pen(Kolor, Grubosc))
            {
                pen.DashStyle = Styl;
                Rysownica.DrawEllipse(pen, X - radius, Y - radius, radius + radius, radius + radius);
            }
            
        }
        private void UpdateLoc(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
            
            
        }
        public override void Move(Control Kontrolka, Graphics Rysownica, int x, int y)
        {
            UpdateLoc(x, y);
            Draw(Rysownica);
        }
        public override void DrawCenter(Control Kontrolka, Graphics Rysownica)
        {
            UpdateLoc(Kontrolka.Width / 2, Kontrolka.Height / 2);
            Draw(Rysownica);
        }
        public override void ChangeStyle(Color Kolor, DashStyle Styl, int Grubosc)
        {
            this.Kolor = Kolor;
            this.Styl = Styl;
            this.Grubosc = Grubosc;
        }
        public override void ChangeStyle(Color Kolor, DashStyle Styl, int Grubosc, Color KolorWypelnienia)
        {
            this.Kolor = Kolor;
            this.Styl = Styl;
            this.Grubosc = Grubosc;
        }
    }

    public class Prostokat : Punkt
        {
            protected int widht;
            protected int height;
            protected Color KolorWypelnienia;

            public Prostokat(int x, int y, int widht, int height) : base(x, y)
            {
                this.widht = widht;
                this.height = height;
            }
            public Prostokat(int x, int y, int widht, int height, Color Kolor) : this(x, y, widht, height)
            {
                this.Kolor = Kolor;
            }
            public Prostokat(int x, int y, int widht, int height, Color Kolor, DashStyle Styl, Color KolorWypelnienia) : this(x, y, widht, height, Kolor)
            {
                this.Styl = Styl;
                this.KolorWypelnienia = KolorWypelnienia;
            }
            public override void Draw(Graphics Rysownica)
            {
                using (Pen pen = new Pen(Kolor, Grubosc))
                {
                    pen.DashStyle = Styl;
                    Rysownica.DrawRectangle(pen,  X, Y, widht, height);
                }
                using (SolidBrush brush = new SolidBrush(KolorWypelnienia))
                {
                
                    Rysownica.FillRectangle(brush, X > widht? X - 1: X + 1, Y > height? Y - 1: Y + 1, X > widht? widht + 1: widht - 1, Y > height? height + 1: height - 1);
                }
            }
            private void UpdateLoc(int X, int Y)
            {
                this.X = X;
                this.Y = Y;
                
            }
            public override void Move(Control Kontrolka, Graphics Rysownica, int x, int y)
            {
                UpdateLoc(x, y);
                Draw(Rysownica);
            }
            public override void DrawCenter(Control Kontrolka, Graphics Rysownica)
            {
                UpdateLoc(Kontrolka.Width / 2 - widht / 2, Kontrolka.Height / 2 - height / 2);
                Draw(Rysownica);
            }
            public override void ChangeStyle(Color Kolor, DashStyle Styl, int Grubosc)
            {
                this.Kolor = Kolor;
                this.Styl = Styl;
                this.Grubosc = Grubosc;
            }
            public override void ChangeStyle(Color Kolor, DashStyle Styl, int Grubosc, Color KolorWypelnienia)
            {
                this.Kolor = Kolor;
                this.Styl = Styl;
                this.Grubosc = Grubosc;
                this.KolorWypelnienia = KolorWypelnienia;
            }
        }

    public class Kwadrat : Punkt
    {
        protected int width;
        protected Color KolorWypelnienia;

        public Kwadrat(int x, int y, int width) : base(x, y)
        {
            this.width = width;
        }

        public Kwadrat(int x, int y, int width, Color Kolor, DashStyle Styl) : this(x, y, width)
        {
            this.Kolor = Kolor;
            this.Styl = Styl;
        }

        public Kwadrat(int x, int y, int width, Color Kolor, DashStyle Styl, Color KolorWypelnienia) : this(x, y, width,
            Kolor, Styl)
        {
            this.KolorWypelnienia = KolorWypelnienia;
        }

        public override void Draw(Graphics Rysownica)
        {
            using (Pen pen = new Pen(Kolor, Grubosc))
            {
                pen.DashStyle = Styl;
                Rysownica.DrawRectangle(pen, X, Y, width, width);
            }
            using (SolidBrush brush = new SolidBrush(KolorWypelnienia))
            {
                
                Rysownica.FillRectangle(brush, X > width? X - 1: X + 1, Y > width? Y - 1: Y + 1, X > width? width + 1: width - 1, Y > width? width + 1: width - 1);
            }
        }
        private void UpdateLoc(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public override void Move(Control Kontrolka, Graphics Rysownica, int x, int y)
        {
            UpdateLoc(x, y);
            Draw(Rysownica);
        }
        
        public override void DrawCenter(Control Kontrolka, Graphics Rysownica)
        {
            UpdateLoc(Kontrolka.Width / 2 - width / 2, Kontrolka.Height / 2 - width / 2);
            Draw(Rysownica);
        }
        
        public override void ChangeStyle(Color Kolor, DashStyle Styl, int Grubosc)
        {
            this.Kolor = Kolor;
            this.Styl = Styl;
            this.Grubosc = Grubosc;
        }
        public override void ChangeStyle(Color Kolor, DashStyle Styl, int Grubosc, Color KolorWypelnienia)
        {
            this.Kolor = Kolor;
            this.Styl = Styl;
            this.Grubosc = Grubosc;
            this.KolorWypelnienia = KolorWypelnienia;
        }
    }

    public class KoloJednoBarwne : Okrag
    {
        protected Color KolorWypelnienia;
        public KoloJednoBarwne(int x, int y, int radius) : base(x, y, radius)
        {
            KolorWypelnienia = Kolor;
        }
        public KoloJednoBarwne(int x, int y, int radius, Color Kolor) : this(x, y, radius)
        {
            this.Kolor = Kolor;
            KolorWypelnienia = Kolor;
        }
        public override void Draw(Graphics Rysownica)
        {
            using (Pen pen = new Pen(Kolor, Grubosc))
            {
                pen.DashStyle = Styl;
                Rysownica.DrawEllipse(pen, X - radius, Y - radius, radius + radius, radius + radius);
            }
    
            Kolor = KolorWypelnienia;
            using (SolidBrush brush = new SolidBrush(KolorWypelnienia))
            {
                
                Rysownica.FillEllipse(brush, X - radius + 1, Y - radius + 1, radius + radius - 1, radius + radius - 1);
            }
            
        }
        private void UpdateLoc(int X, int Y)
        {
            this.X = X;
            this.Y = Y;

        }
        public override void Move(Control Kontrolka, Graphics Rysownica, int x, int y)
        {
            UpdateLoc(x, y);
            Draw(Rysownica);
        }
        public override void DrawCenter(Control Kontrolka, Graphics Rysownica)
        {
            UpdateLoc(Kontrolka.Width / 2, Kontrolka.Height / 2);
            Draw(Rysownica);
        }
        public override void ChangeStyle(Color Kolor, DashStyle Styl, int Grubosc)
        {
            this.Kolor = Kolor;
            KolorWypelnienia = Kolor;
            this.Styl = Styl;
            this.Grubosc = Grubosc;
        }
        public override void ChangeStyle(Color Kolor, DashStyle Styl, int Grubosc, Color KolorWypelnienia)
        {
            this.Styl = Styl;
            this.Grubosc = Grubosc;
            this.KolorWypelnienia = KolorWypelnienia;
            this.Kolor = KolorWypelnienia;
        }
    }

}