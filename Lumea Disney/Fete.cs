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
    public partial class Fete : Form
    {
        public Fete()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void Plasare()
        {
            poveste.Size = new Size(775, 400);
            poveste.Location = new Point(10, 35);

            film.Size = new Size(775, 400);
            film.Location = new Point(10, 35);
        }

        private void back_Click(object sender, EventArgs e)
        {
            Cuprins cuprins = new Cuprins();
            cuprins.Show();
            this.Hide();
        }

        private void Fete_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = new Bitmap(@"Imagini/miniMouse.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            Plasare();
        }

        private void aliceStory_Click(object sender, EventArgs e)
        {
            film.URL = "";
            poveste.Visible = true;
            film.Visible = false;
            poveste.LoadFile(@"Fete/Povesti/Alice-in-Tara-Minunilor.pdf");
        }

        private void aliceMovie_Click(object sender, EventArgs e)
        {
            poveste.Visible = false;
            film.Visible = true;
            film.URL = @"Fete/Film/alice.mp4";
        }

        private void aliceAnimation_Click(object sender, EventArgs e)
        {
            poveste.Visible = false;
            film.Visible = true;
            film.URL = @"Fete/Animatie/alice.mp4";
        }

        private void zapadaStory_Click(object sender, EventArgs e)
        {
            film.URL = "";
            poveste.Visible = true;
            film.Visible = false;
            poveste.LoadFile(@"Fete/Povesti/Alba.pdf");
        }

        private void zapadaMovie_Click(object sender, EventArgs e)
        {
            poveste.Visible = false;
            film.Visible = true;
            film.URL = @"Fete/Film/alba-ca-zapada.mp4";
        }

        private void zapadaAnimation_Click(object sender, EventArgs e)
        {
            poveste.Visible = false;
            film.Visible = true;
            film.URL = @"Fete/Animatie/alba-ca-zapada.mp4";
        }

        private void cenusareasaStory_Click(object sender, EventArgs e)
        {
            film.URL = "";
            poveste.Visible = true;
            film.Visible = false;
            poveste.LoadFile(@"Fete/Povesti/Cenusereasa.pdf");
        }

        private void cenusareasaAnimation_Click(object sender, EventArgs e)
        {
            poveste.Visible = false;
            film.Visible = true;
            film.URL = @"Fete/Animatie/cenusareasa.mp4";
        }

        private void cenusareasaMovie_Click(object sender, EventArgs e)
        {
            poveste.Visible = false;
            film.Visible = true;
            film.URL = @"Fete/Film/cenusareasa.mp4";
        }

        private void beautyStory_Click(object sender, EventArgs e)
        {
            film.URL = "";
            poveste.Visible = true;
            film.Visible = false;
            poveste.LoadFile(@"Fete/Povesti/Frumoasa-din-Padurea-Adormita.pdf");
        }

        private void beautyMovie_Click(object sender, EventArgs e)
        {
            poveste.Visible = false;
            film.Visible = true;
            film.URL = "";
        }

        private void beautyBeastStory_Click(object sender, EventArgs e)
        {
            film.URL = "";
            poveste.Visible = true;
            film.Visible = false;
            poveste.LoadFile(@"Fete/Povesti/Frumoasa-si-Bestia.pdf");
        }

        private void beautyBeastMovie_Click(object sender, EventArgs e)
        {
            poveste.Visible = false;
            film.Visible = true;
            film.URL = @"Fete/Film/beauty-beast.mp4";
        }

        private void frozenMovie_Click(object sender, EventArgs e)
        {
            poveste.Visible = false;
            film.Visible = true;
            film.URL = "";
        }

        private void rapunzelStory_Click(object sender, EventArgs e)
        {
            film.URL = "";
            poveste.Visible = true;
            film.Visible = false;
            poveste.LoadFile(@"Fete/Povesti/Rapunzel.pdf");
        }

        private void rapunzelMovie_Click(object sender, EventArgs e)
        {
            poveste.Visible = false;
            film.Visible = true;
            film.URL = "";
        }

        private void rapunzelAnimation_Click(object sender, EventArgs e)
        {
            poveste.Visible = false;
            film.Visible = true;
            film.URL = @"Fete/Animatie/rapunzel.mp4";
        }

        private void sirenStory_Click(object sender, EventArgs e)
        {
            film.URL = "";
            poveste.Visible = true;
            film.Visible = false;
            poveste.LoadFile(@"Fete/Povesti/Mica-Sirena.pdf");
        }

        private void sirenMovie_Click(object sender, EventArgs e)
        {
            poveste.Visible = false;
            film.Visible = true;
            film.URL = @"Fete/Film/siren.mp4";
        }

        private void sirenAnimation_Click(object sender, EventArgs e)
        {
            poveste.Visible = false;
            film.Visible = true;
            film.URL = @"Fete/Animatie/siren.mp4";
        }

        private void frozenAnimation_Click(object sender, EventArgs e)
        {
            poveste.Visible = false;
            film.Visible = true;
            film.URL = @"Fete/Animatie/frozen.mp4";
        }

        private void beautyBeastAnimation_Click(object sender, EventArgs e)
        {
            poveste.Visible = false;
            film.Visible = true;
            film.URL = "";
        }

        private void beautyAnimation_Click(object sender, EventArgs e)
        {
            poveste.Visible = false;
            film.Visible = true;
            film.URL = "";
        }
    }
}
