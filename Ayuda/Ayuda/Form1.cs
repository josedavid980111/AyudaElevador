using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayuda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            vieja = 1;
            nueva = 1;
            x = 63;
            y = 347;
            contador = 0;
            Button1.BackColor = Color.Red;
            Button2.BackColor = Color.CadetBlue;
            Button3.BackColor = Color.CadetBlue;
            Button4.BackColor = Color.CadetBlue;
            Button5.BackColor = Color.CadetBlue;
        }

        int a, vieja, nueva, contador, x, y;


        private void button1_Click(object sender, EventArgs e)
        {
            nueva = 1;
            Timer1.Interval = 5;
            Timer1.Start();
            Button1.BackColor = Color.CadetBlue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nueva = 2;
            Timer1.Start();
            Timer1.Interval = 5;
            Button2.BackColor = Color.CadetBlue;
        }


        private void Button3_Click(object sender, EventArgs e)
        {
            nueva = 3;
            Timer1.Start();
            Timer1.Interval = 5;
            Button3.BackColor = Color.CadetBlue;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            nueva = 4;
            Timer1.Start();
            Timer1.Interval = 5;
            Button3.BackColor = Color.CadetBlue;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            nueva = 5;
            Timer1.Start();
            Timer1.Interval = 5;
            Button5.BackColor = Color.CadetBlue;
        }
        


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (nueva > vieja)
            {
                contador = (nueva - vieja) * 65;
                a = a + 1;
                Label1.Location = new Point(x, y - a);
                if (a == contador)
                {
                    Timer1.Stop();
                    y = y - a;
                    a = 0;
                    if (nueva == 1)
                    {
                        Button1.BackColor = Color.Red;
                    }

                    else if (nueva == 2)
                    {
                        Button2.BackColor = Color.Red;
                    }

                    else if (nueva == 3)
                    {
                        Button3.BackColor = Color.Red;
                    }

                    else if (nueva == 4)
                    {
                        Button4.BackColor = Color.Red;
                    }

                    else if (nueva == 5)
                    {
                        Button5.BackColor = Color.Red;
                    }





                    if (vieja == 1)
                    {
                        Button1.BackColor = Color.CadetBlue;
                    }

                    else if (vieja == 2)
                    {
                        Button2.BackColor = Color.CadetBlue;
                    }

                    else if (vieja == 3)
                    {
                        Button3.BackColor = Color.CadetBlue;
                    }

                    else if (vieja == 4)
                    {
                        Button4.BackColor = Color.CadetBlue;
                    }

                    else if (vieja == 5)
                    {
                        Button5.BackColor = Color.CadetBlue;
                    }




                    vieja = nueva;
                }
            }

            if (nueva < vieja)
            {
                contador = (vieja - nueva) * 65;
                a = a + 1;
                Label1.Location = new Point(x, y + a);
                if (a == contador)
                {
                    Timer1.Stop();
                    y = y + a;
                    a = 0;
                    if (nueva == 1)
                    {
                        Button1.BackColor = Color.Red;
                    }

                    else if (nueva == 2)
                    {
                        Button2.BackColor = Color.Red;
                    }

                    else if (nueva == 3)
                    {
                        Button3.BackColor = Color.Red;
                    }

                    else if (nueva == 4)
                    {
                        Button4.BackColor = Color.Red;
                    }

                    else if (nueva == 5)
                    {
                        Button5.BackColor = Color.Red;
                    }





                    if (vieja == 1)
                    {
                        Button1.BackColor = Color.CadetBlue;
                    }

                    else if (vieja == 2)
                    {
                        Button2.BackColor = Color.CadetBlue;
                    }

                    else if (vieja == 3)
                    {
                        Button3.BackColor = Color.CadetBlue;
                    }

                    else if (vieja == 4)
                    {
                        Button4.BackColor = Color.CadetBlue;
                    }

                    else if (vieja == 5)
                    {
                        Button5.BackColor = Color.CadetBlue;
                    }



                    vieja = nueva;
                }
            }


        }


    }


}
