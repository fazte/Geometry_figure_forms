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
        int a1;
        int b1;
        int r;
        int t;
        int s;
        int l;
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
                label2.Text = ("Введите 3 координаты ");
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
            l = Convert.ToInt32(numericUpDown1.Text);
            var Pen = new Pen(colorDialog2.Color, l);
            if (comboBox1.SelectedItem.ToString() == ("Треугольник"))
            {
                string[] ss = textBox2.Text.Split(' ');
                try
                {
                    a = Convert.ToInt32(ss[0]);
                    b = Convert.ToInt32(ss[1]);
                    c = Convert.ToInt32(ss[2]);
                    d = Convert.ToInt32(ss[3]);
                    f = Convert.ToInt32(ss[4]);
                    t = Convert.ToInt32(ss[5]);
                }
                catch (Exception) { }            
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
                Graphics g = panel2.CreateGraphics();
                g.DrawEllipse(Pen, 120, 120, r, r);


            }
            else
            if (comboBox1.SelectedItem.ToString() == ("Отрезок"))
            {
                string[] ss = textBox2.Text.Split(' ');
                s = Convert.ToInt32(ss[0]);
                Graphics g = panel2.CreateGraphics();
                g.DrawLine(Pen, 80, 80, s, s);
            }
            else
            if (comboBox1.SelectedItem.ToString() == ("Прямоугольник"))
            {
                string[] ss = textBox2.Text.Split(' ');
                a1 = Convert.ToInt32(ss[0]);
                b1 = Convert.ToInt32(ss[1]);
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
            g.Clear(Color.White);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            colorDialog2.ShowDialog();
            btColor.BackColor = colorDialog2.Color;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(panel2.Width, panel2.Height);
            panel1.DrawToBitmap(bm, new System.Drawing.Rectangle(0, 0, bm.Width, bm.Height));

            SaveFileDialog sfd = new SaveFileDialog();

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                bm.Save(sfd.FileName + ".bmp");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                panel2.BackgroundImage = Image.FromFile(ofd.FileName);
            }
            ofd.Dispose();
        }
    }
}
