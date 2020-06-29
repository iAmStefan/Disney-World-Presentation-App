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
    public partial class Baieti : Form
    {
        public Baieti()
        {
            InitializeComponent();
        }

        void Plasare()
        {
            poveste.Size = new Size(775, 400);
            poveste.Location = new Point(10, 35);

            film.Size = new Size(775, 400);
            film.Location = new Point(10, 35);
        }

        private void Baieti_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = new Bitmap(@"Imagini/mickeyMouse.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            Plasare();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Cuprins cuprins = new Cuprins();
            cuprins.Show();
            this.Hide();
        }

        private void panStory_Click(object sender, EventArgs e)
        {
            film.URL = "";
            poveste.Visible = true;
            film.Visible = false;
            poveste.LoadFile(@"Baieti/Povesti/Peter-Pan.pdf");
        }

        private void panMovie_Click(object sender, EventArgs e)
        {
            poveste.Visible = false;
            film.Visible = true;
            film.URL = @"Baieti/Film/peter-pan.mp4";
        }

        private void panAnimation_Click(object sender, EventArgs e)
        {
            poveste.Visible = false;
            film.Visible = true;
            film.URL = @"Baieti/Animatie/peter-pan.mp4";
        }

        private void jungleStory_Click(object sender, EventArgs e)
        {
            film.URL = "";
            poveste.Visible = true;
            film.Visible = false;
            poveste.LoadFile(@"Baieti/Povesti/cartea-junglei.pdf");
        }

        private void jungleMovie_Click(object sender, EventArgs e)
        {
            poveste.Visible = false;
            film.Visible = true;
            film.URL = @"Baieti/Film/cartea-junglei.mp4";
        }

        private void jungleAnimation_Click(object sender, EventArgs e)
        {
            poveste.Visible = false;
            film.Visible = true;
            film.URL = @"Baieti/Animatie/cartea-junglei.mp4";
        }

        private void pinocchioStory_Click(object sender, EventArgs e)
        {
            film.URL = "";
            poveste.Visible = true;
            film.Visible = false;
            poveste.LoadFile(@"Baieti/Povesti/Povestea-lui-Pinocchio.pdf");
        }

        private void pinocchioMovie_Click(object sender, EventArgs e)
        {
            poveste.Visible = false;
            film.Visible = true;
            film.URL = @"Baieti/Film/pinocchio.mp4";
        }

        private void hoodMovie_Click(object sender, EventArgs e)
        {
            poveste.Visible = false;
            film.Visible = true;
            film.URL = @"Baieti/Film/robin-hood.mp4";
        }

        private void dumboStory_Click(object sender, EventArgs e)
        {
            film.URL = "";
            poveste.Visible = true;
            film.Visible = false;
            poveste.LoadFile(@"Baieti/Povesti/Dumbo.pdf");
        }

        private void dumboMovie_Click(object sender, EventArgs e)
        {
            poveste.Visible = false;
            film.Visible = true;
            film.URL = @"Baieti/Film/dumbo.mp4";
        }

        private void dalmationAnimation_Click(object sender, EventArgs e)
        {
            poveste.Visible = false;
            film.Visible = true;
            film.URL = @"Baieti/Animatie/dalmatian.mp4";
        }

        private void aladdinStory_Click(object sender, EventArgs e)
        {
            film.URL = "";
            poveste.Visible = true;
            film.Visible = false;
            poveste.LoadFile(@"Baieti/Povesti/Aladin-si-lampa-fermecata.pdf");
        }

        private void aladdinMovie_Click(object sender, EventArgs e)
        {
            poveste.Visible = false;
            film.Visible = true;
            film.URL = @"Baieti/Film/aladdin.mp4";
        }

        private void tarzanStory_Click(object sender, EventArgs e)
        {
            film.URL = "";
            poveste.Visible = true;
            film.Visible = false;
            poveste.LoadFile(@"Baieti/Povesti/Tarzan.pdf");
        }

        private void tarzanAnimation_Click(object sender, EventArgs e)
        {
            poveste.Visible = false;
            film.Visible = true;
            film.URL = @"Baieti/Animatie/tarzan.mp4";
        }

        private void tarzanMovie_Click(object sender, EventArgs e)
        {
            poveste.Visible = false;
            film.Visible = true;
            film.URL = @"Baieti/Film/tarzan.mp4";
        }
    }
}
