using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;


namespace Painttransparent
{

    public partial class Drawing_transparent : Form
    {
        enum options
        {
            Line,
            Rectangle,
            Elipse,
            Spray
        };
        #region moje_zmienne
        int which_option;
        bool pressed_down = false;
        Point mouse = new Point(0, 0);
        bool fill = false;
        Bitmap sprejowa = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        Bitmap pulpet = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        Color kolorek = Color.Blue;
        Color ramka = Color.Blue;
        private Random _rnd = new Random();
        #endregion
        public Drawing_transparent()
        {
            InitializeComponent();

            TransparencyKey = Color.Aqua; //przezroczytosc lewej strony
            BackColor = Color.Aqua;

            which_option = (int)options.Line; //linia ustawiona domyslnie
            Bitmap nbit = new System.Drawing.Bitmap(pictureBox1.Width, pictureBox1.Height); 
            pictureBox1.BackgroundImage = new System.Drawing.Bitmap(pictureBox1.Width, pictureBox1.Height); 
            pictureBox1.Image = new System.Drawing.Bitmap(pictureBox1.Width, pictureBox1.Height);

            pictureBox1.Image = sprejowa;
        }

        #region decision buttons
        private void Linia_Click(object sender, EventArgs e)
        {
            which_option = (int)options.Line;
        }

        private void Prostokąt_Click(object sender, EventArgs e)
        {
            which_option = (int)options.Rectangle;
        }

        private void Elipsa_Click(object sender, EventArgs e)
        {
            which_option = (int)options.Elipse;
        }
        private void Spray_Click(object sender, EventArgs e)
        {
            which_option = (int)options.Spray;
        }
        #endregion
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

            if (pressed_down)
            {
                pictureBox1.Refresh();
                pictureBox1.Update();
                using (Graphics g = pictureBox1.CreateGraphics())
                {
                    if (which_option == (int)options.Rectangle)
                    {
                        if (fill == false)
                        {
                            var pen_r = new Pen(ramka, 2);
                            g.DrawRectangle(pen_r, mouse.X, mouse.Y, e.X - mouse.X, e.Y - mouse.Y);
                            pen_r.Dispose();
                        }
                        else
                        {
                            var pen_r = new Pen(ramka, 2);
                            g.DrawRectangle(pen_r, mouse.X, mouse.Y, e.X - mouse.X, e.Y - mouse.Y);
                            pen_r.Dispose();
                            var brush_r = new SolidBrush(kolorek);
                            g.FillRectangle(brush_r, mouse.X, mouse.Y, e.X - mouse.X, e.Y - mouse.Y);
                            brush_r.Dispose();
                        }
                    }
                    else if (which_option == (int)options.Line)
                    {
                        var pen_l = new Pen(ramka, 2);
                        g.DrawLine(pen_l, mouse.X, mouse.Y, e.X, e.Y);
                        pen_l.Dispose();
                    }
                    else if (which_option == (int)options.Elipse)
                    {
                        if (fill == false)
                        {
                            var pen_e = new Pen(ramka, 2);
                            g.DrawEllipse(pen_e, mouse.X, mouse.Y, e.X - mouse.X, e.Y - mouse.Y);
                            pen_e.Dispose();
                        }
                        else
                        {
                            var brush_e = new SolidBrush(kolorek);
                            g.FillEllipse(brush_e, mouse.X, mouse.Y, e.X - mouse.X, e.Y - mouse.Y);
                            brush_e.Dispose();
                            var pen_e = new Pen(ramka, 2);
                            g.DrawEllipse(pen_e, mouse.X, mouse.Y, e.X - mouse.X, e.Y - mouse.Y);
                            pen_e.Dispose();
                        }
                    }
                }
                if (which_option == (int)options.Spray)
                {
                    using (Bitmap nowabit = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb))
                    {
                        using (Graphics g = Graphics.FromImage(nowabit))
                        {
                            {

                                double mean = 0;
                                double stdDev = 7;
                                Random rand = new Random();
                                double u1 = rand.NextDouble(); //these are uniform(0,1) random doubles
                                double u2 = rand.NextDouble();
                                double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) *
                                             Math.Sin(2.0 * Math.PI * u2); //random normal(0,1)
                                double randNormal =
                                             mean + stdDev * randStdNormal; //random normal(mean,stdDev^2)
                                double randNormal2 =
                                            mean + stdDev * randStdNormal; //random normal(mean,stdDev^2)
                                for (int i = 0; i < 50; ++i)
                                {
                                    u1 = rand.NextDouble(); //these are uniform(0,1) random doubles
                                    u2 = rand.NextDouble();
                                    randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) *
                                                Math.Sin(2.0 * Math.PI * u2); //random normal(0,1)
                                    randNormal =
                                                mean + stdDev * randStdNormal; //random normal(mean,stdDev^2)

                                    u1 = rand.NextDouble(); //these are uniform(0,1) random doubles
                                    u2 = rand.NextDouble();
                                    randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) *Math.Sin(2.0 * Math.PI * u2); //random normal(0,1)
                                    randNormal2 = mean + stdDev * randStdNormal; //random normal(mean,stdDev^2)

                                    var pen_s = new Pen(ramka, 1);
                                    g.DrawEllipse(pen_s, new Rectangle(e.X - (int)randNormal, e.Y -(int)randNormal2, 1, 1));
                                    pen_s.Dispose();
                                }
                                }

                                using (var zapisz = Graphics.FromImage(pulpet))
                                zapisz.DrawImageUnscaled(nowabit, 0, 0);
                        }

                    }
                }
            }

            }
        

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Cross;
            pressed_down = true;
            mouse.X = e.X;
            mouse.Y = e.Y;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (pressed_down)
            {
                using(Bitmap nowabit = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb))
                using (Graphics g = Graphics.FromImage(nowabit))
                {
                    if (which_option == (int)options.Rectangle)
                    {
                        if (fill == false)
                        {
                            var pen_r = new Pen(ramka, 2);
                            g.DrawRectangle(pen_r, mouse.X, mouse.Y, e.X - mouse.X, e.Y - mouse.Y);
                            pen_r.Dispose();
                        }
                        else
                        {
                            var pen_r = new Pen(ramka, 2);
                            g.DrawRectangle(pen_r, mouse.X, mouse.Y, e.X - mouse.X, e.Y - mouse.Y);
                            pen_r.Dispose();
                            var brush_r = new SolidBrush(kolorek);
                            g.FillRectangle(brush_r, mouse.X, mouse.Y, e.X - mouse.X, e.Y - mouse.Y);
                            brush_r.Dispose();
                        }
                    }
                    else if (which_option == (int)options.Line)
                    {
                        var pen_l = new Pen(ramka, 2);
                        g.DrawLine(pen_l, mouse.X, mouse.Y, e.X, e.Y);
                        pen_l.Dispose();
                    }
                    else if (which_option == (int)options.Elipse)
                    {
                        if (fill == false)
                        {
                            var pen_e = new Pen(ramka, 2);
                            g.DrawEllipse(pen_e, mouse.X, mouse.Y, e.X - mouse.X, e.Y - mouse.Y);
                            pen_e.Dispose();
                        }
                        else
                        {
                            var brush_e = new SolidBrush(kolorek);
                            g.FillEllipse(brush_e, mouse.X, mouse.Y, e.X - mouse.X, e.Y - mouse.Y);
                            var pen_e = new Pen(ramka, 2);
                            g.DrawEllipse(pen_e, mouse.X, mouse.Y, e.X - mouse.X, e.Y - mouse.Y);
                            pen_e.Dispose();
                            brush_e.Dispose();
                        }
                    }
                    else if (which_option == (int)options.Spray)
                    {
                        double mean = 0;
                        double stdDev = 7;
                        Random rand = new Random();
                        double u1 = rand.NextDouble(); //these are uniform(0,1) random doubles
                        double u2 = rand.NextDouble();
                        double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) *
                                     Math.Sin(2.0 * Math.PI * u2); //random normal(0,1)
                        double randNormal =
                                     mean + stdDev * randStdNormal; //random normal(mean,stdDev^2)
                        double randNormal2 =
                                    mean + stdDev * randStdNormal; //random normal(mean,stdDev^2)
                        for (int i = 0; i < 50; ++i)
                        {
                             u1 = rand.NextDouble(); //these are uniform(0,1) random doubles
                             u2 = rand.NextDouble();
                             randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) *Math.Sin(2.0 * Math.PI * u2); //random normal(0,1)
                             randNormal = mean + stdDev * randStdNormal; //random normal(mean,stdDev^2)
                            u1 = rand.NextDouble(); //these are uniform(0,1) random doubles
                            u2 = rand.NextDouble();
                            randStdNormal= Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2); //random normal(0,1)
                            randNormal2 =mean + stdDev * randStdNormal; //random normal(mean,stdDev^2)
                            var pen_s = new Pen(ramka, 2);
                            g.DrawEllipse(pen_s, new Rectangle(e.X + (int)randNormal, e.Y + (int)randNormal2 , 1, 1));
                            pen_s.Dispose();
                        }
                    }
                            using (var zapisz = Graphics.FromImage(pulpet))
                        zapisz.DrawImageUnscaled(nowabit, 0, 0);

                    pictureBox1.BackgroundImage = pulpet;
                    //pulpet = nowabit;
                    pictureBox1.Invalidate();
                }
            }
            mouse.X = e.X;
            mouse.Y = e.Y;
            pictureBox1.Invalidate();
            pressed_down = false;

        }

        #region SAVE&LOAD
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Images|*.png;*";
            ImageFormat format = ImageFormat.Png;
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pulpet.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }


        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "PNG(*.PNG)|*.PNG";
            if (f.ShowDialog() == DialogResult.OK)
            {
                Image tiffImage = Image.FromFile(f.FileName, true);
                pictureBox1.BackgroundImage = tiffImage;
            }
        }

        #endregion

        private void Wypełnienie_SelectedIndexChanged(object sender, EventArgs e) 
        {
            if (Wypełnienie.Text == "Z wypełnieniem")
            {
                fill = true;
            }
            else fill = false;
        }


        private void Fill_color_Click(object sender, EventArgs e)
        {
           ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                kolorek = dlg.Color;
            }
        }

        private void Frame_color_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                ramka = dlg.Color;
            }
        }

        private void Drawing_transparent_Move(object sender, EventArgs e)
        {

            Bitmap p = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Rectangle section = new Rectangle(pictureBox1.Location.X, pictureBox1.Location.Y, pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(p);


            g.DrawImage(pulpet, 0, 0, section, GraphicsUnit.Pixel);
            pictureBox1.Image = null;

        }

        private void pictureBox1_Move(object sender, EventArgs e)
        {
            
        }
    }
}


