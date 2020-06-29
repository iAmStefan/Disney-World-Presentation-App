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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = new Bitmap(@"Imagini/start.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            highSchool.BackColor = Color.Transparent;
            disneyWorld.BackColor = Color.Transparent;
            start.BackColor = Color.Transparent;
            stop.BackColor = Color.Transparent;
            name.BackColor = Color.Transparent;
            highSchool.ForeColor = Color.White;
            disneyWorld.ForeColor = Color.White;
            start.ForeColor = Color.White;
            stop.ForeColor = Color.White;
            name.ForeColor = Color.White;
        }

        private void start_Click_1(object sender, EventArgs e)
        {
            Cuprins cuprins = new Cuprins();
            cuprins.Show();
            this.Hide();
        }

        private void stop_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
