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
    public partial class Parinti : Form
    {
        public Parinti()
        {
            InitializeComponent();
        }

        int id = 0;

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (id == 1)
            {
                informatii.Visible = false;
                waltDisney.Visible = true;
                parks.Visible = true;
                id = 0;
            }
            else if (id == 0)
            {
                Cuprins cuprins = new Cuprins();
                cuprins.Show();
                this.Hide();
            }
        }

        private void Parinti_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = new Bitmap(@"Imagini/parents.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            close.BackColor = Color.Transparent;
            back.BackColor = Color.Transparent;
            waltDisney.BackColor = Color.Transparent;
            parks.BackColor = Color.Transparent;
            waltDisney.ForeColor = Color.White;
            parks.ForeColor = Color.White;
        }

        private void waltDisney_Click(object sender, EventArgs e)
        {
            id = 1;
            waltDisney.Visible = false;
            parks.Visible = false;
            informatii.Visible = true;
            informatii.LoadFile(@"Parinti/Walt-Disney.pdf");
            informatii.Location = new Point(10, 25);
            informatii.Size = new Size(775, 415);
        }

        private void parks_Click(object sender, EventArgs e)
        {
            id = 1;
            waltDisney.Visible = false;
            parks.Visible = false;
            informatii.Visible = true;
            informatii.LoadFile(@"Parinti/Disneyland.pdf");
            informatii.Location = new Point(10, 25);
            informatii.Size = new Size(775, 415);
        }
    }
}
