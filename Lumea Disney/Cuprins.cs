using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lumea_Disney
{
    public partial class Cuprins : Form
    {
        public Cuprins()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void Cuprins_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = new Bitmap(@"Imagini/cuprins.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            close.BackColor = Color.Transparent;
            back.BackColor = Color.Transparent;
            boys.BackColor = Color.Transparent;
            girls.BackColor = Color.Transparent;
            parents.BackColor = Color.Transparent;
            boys.ForeColor = Color.White;
            girls.ForeColor = Color.White;
            parents.ForeColor = Color.White;
        }

        //private void Cuprins_Click(object sender, EventArgs e)
        //{
        //    MouseEventArgs point = (MouseEventArgs)e;
        //    if (point.X > 70 && point.X < 250 && point.Y > 100 && point.Y < 430)
        //    {

        //    }
        //    else if (point.X > 265 && point.X < 495 && point.Y > 25 && point.Y < 430)
        //    {

        //    }
        //    else if (point.X > 530 && point.X < 730 && point.Y > 50 && point.Y < 430)
        //    {

        //    }
        //}

        private void boys_Click(object sender, EventArgs e)
        {
            Baieti baieti = new Baieti();
            baieti.Show();
            this.Hide();
        }

        private void girls_Click(object sender, EventArgs e)
        {
            Fete fete = new Fete();
            fete.Show();
            this.Hide();
        }

        private void parents_Click(object sender, EventArgs e)
        {
            Parinti parinti = new Parinti();
            parinti.Show();
            this.Hide();
        }
    }
}
