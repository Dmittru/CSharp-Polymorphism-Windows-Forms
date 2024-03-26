
using System;
using System.Numerics;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace Lab3
{

    class Program
    {
        public static Figure[] figures =
        {
            new Rectangle()
            {
                Color = Color.Green,
                Position = new Point(30, 30),
                Name = "Прямоугольник А",
                Height = 45,
                Width = 66
            },
            new Circle()
            {
                Color = Color.Black,
                Position = new Point(90, 90),
                Name = "Прямоугольник Б",
                Radius = 50,

            },
            new Decagon()
            {
                Color = Color.Blue,
                Position = new Point(150, 150),
                Name = "Прямоугольник Б",
                Side = 35,
                Radius = 68
            },
            new Rhomb()
            {
                Color = Color.Pink,
                Position = new Point(220, 220),
                Name = "Ромб",
                Side = 37,
                Height = 70
            },
            new Trapezoid()
            {
                Color = Color.Orange,
                Position = new Point(290, 290),
                Name = "Ромб",
                TopBase = 70,
                BottomBase = 60,
                Height = 15
            },
            new Triangle()
            {
                Color = Color.Purple,
                Position = new Point(360, 360),
                Name = "Ромб",
                Base = 70,
                Height = 60

            }
        };

        static void Main(string[] args)
        {
            Form frm = new Form()
            {
                Size = new Size(800, 800),
                StartPosition = FormStartPosition.CenterScreen
            };

            frm.Paint += Frm_Paint;

            Application.Run(frm);
        }

        private static void Frm_Paint(object sender, PaintEventArgs e)
        {
            foreach (Figure f in figures)
            {
                f.Draw(e.Graphics);
            }
        }
    }
}


