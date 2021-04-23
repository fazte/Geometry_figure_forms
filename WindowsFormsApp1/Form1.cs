using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int a;
        int b;
        int c;
        int d;
        int f;
        int g;
        int a1;
        int b1;
        int r;
        int t;
        int s;
        int p;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == ("Треугольник"))
            {
                label2.Text = ("Введите 6 координат ");
            }
            else if (comboBox1.SelectedItem.ToString() == ("Прямоугольник"))
            {
                label2.Text = ("Введите ширину и длину фигуры");
            }
            else if (comboBox1.SelectedItem.ToString() == ("Круг"))
            {
                label2.Text = ("Введите Radius Круга");
            }
            else if (comboBox1.SelectedItem.ToString() == ("Отрезок"))
            {
                label2.Text = ("Введите Координату начала отрезка");
            }

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {}

        private void Button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem.ToString() == ("Треугольник"))
            {
                string[] ss = textBox2.Text.Split(' ');
                a = Convert.ToInt32(ss[0]);
                b = Convert.ToInt32(ss[1]);
                c = Convert.ToInt32(ss[2]);
                d = Convert.ToInt32(ss[3]);
                f = Convert.ToInt32(ss[4]);
                t = Convert.ToInt32(ss[5]);
                var Pen = new Pen(Color.White, 5);
                Graphics g = panel2.CreateGraphics();
                g.DrawLine(Pen, a, b, c, d);
                g.DrawLine(Pen, c, d, f, t);
                g.DrawLine(Pen, f, t, a, b);
            }
            else
            if (comboBox1.SelectedItem.ToString() == ("Круг"))
            {
                string[] ss = textBox2.Text.Split(' ');
                r = Convert.ToInt32(ss[0]);
                var Pen = new Pen(Color.White, 5);
                Graphics g = panel2.CreateGraphics();
                g.DrawEllipse(Pen, 120, 120, r, r);


            }
            else
            if (comboBox1.SelectedItem.ToString() == ("Отрезок"))
            {
                string[] ss = textBox2.Text.Split(' ');
                s = Convert.ToInt32(ss[0]);
                var Pen = new Pen(Color.White, 5);
                Graphics g = panel2.CreateGraphics();
                g.DrawLine(Pen, 80, 80, s, s);
            }
            else
            if (comboBox1.SelectedItem.ToString() == ("Прямоугольник"))
            {
                string[] ss = textBox2.Text.Split(' ');
                a1 = Convert.ToInt32(ss[0]);
                b1 = Convert.ToInt32(ss[1]);
                var Pen = new Pen(Color.White, 5);
                Graphics g = panel2.CreateGraphics();
                g.DrawRectangle(Pen, 100, 100, a1, b1);


            }
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = panel2.CreateGraphics();
            g.Clear(Color.Black);
        }
    }
}
