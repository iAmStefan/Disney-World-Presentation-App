namespace Lumea_Disney
{
    partial class Fete
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fete));
            this.close = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.filmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alice = new System.Windows.Forms.ToolStripMenuItem();
            this.aliceStory = new System.Windows.Forms.ToolStripMenuItem();
            this.aliceAnimation = new System.Windows.Forms.ToolStripMenuItem();
            this.aliceMovie = new System.Windows.Forms.ToolStripMenuItem();
            this.zapada = new System.Windows.Forms.ToolStripMenuItem();
            this.zapadaStory = new System.Windows.Forms.ToolStripMenuItem();
            this.zapadaAnimation = new System.Windows.Forms.ToolStripMenuItem();
            this.zapadaMovie = new System.Windows.Forms.ToolStripMenuItem();
            this.cenusareasa = new System.Windows.Forms.ToolStripMenuItem();
            this.cenusareasaStory = new System.Windows.Forms.ToolStripMenuItem();
            this.cenusareasaAnimation = new System.Windows.Forms.ToolStripMenuItem();
            this.cenusareasaMovie = new System.Windows.Forms.ToolStripMenuItem();
            this.beauty = new System.Windows.Forms.ToolStripMenuItem();
            this.beautyStory = new System.Windows.Forms.ToolStripMenuItem();
            this.beautyAnimation = new System.Windows.Forms.ToolStripMenuItem();
            this.beautyMovie = new System.Windows.Forms.ToolStripMenuItem();
            this.beautyBeast = new System.Windows.Forms.ToolStripMenuItem();
            this.beautyBeastStory = new System.Windows.Forms.ToolStripMenuItem();
            this.beautyBeastAnimation = new System.Windows.Forms.ToolStripMenuItem();
            this.beautyBeastMovie = new System.Windows.Forms.ToolStripMenuItem();
            this.frozen = new System.Windows.Forms.ToolStripMenuItem();
            this.frozenAnimation = new System.Windows.Forms.ToolStripMenuItem();
            this.frozenMovie = new System.Windows.Forms.ToolStripMenuItem();
            this.rapunzel = new System.Windows.Forms.ToolStripMenuItem();
            this.rapunzelStory = new System.Windows.Forms.ToolStripMenuItem();
            this.rapunzelAnimation = new System.Windows.Forms.ToolStripMenuItem();
            this.rapunzelMovie = new System.Windows.Forms.ToolStripMenuItem();
            this.siren = new System.Windows.Forms.ToolStripMenuItem();
            this.sirenStory = new System.Windows.Forms.ToolStripMenuItem();
            this.sirenAnimation = new System.Windows.Forms.ToolStripMenuItem();
            this.sirenMovie = new System.Windows.Forms.ToolStripMenuItem();
            this.poveste = new AxAcroPDFLib.AxAcroPDF();
            this.film = new AxWMPLib.AxWindowsMediaPlayer();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poveste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.film)).BeginInit();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.BackColor = System.Drawing.Color.White;
            this.close.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(779, -2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(23, 23);
            this.close.TabIndex = 0;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.BackColor = System.Drawing.Color.White;
            this.back.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(742, -3);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(34, 23);
            this.back.TabIndex = 1;
            this.back.Text = "<-";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filmeToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 24);
            this.menu.TabIndex = 2;
            this.menu.Text = "menuStrip1";
            // 
            // filmeToolStripMenuItem
            // 
            this.filmeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alice,
            this.zapada,
            this.cenusareasa,
            this.beauty,
            this.beautyBeast,
            this.frozen,
            this.rapunzel,
            this.siren});
            this.filmeToolStripMenuItem.Name = "filmeToolStripMenuItem";
            this.filmeToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.filmeToolStripMenuItem.Text = "Filme";
            // 
            // alice
            // 
            this.alice.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aliceStory,
            this.aliceAnimation,
            this.aliceMovie});
            this.alice.Name = "alice";
            this.alice.Size = new System.Drawing.Size(241, 22);
            this.alice.Text = "Alice in Tara Minunilor";
            // 
            // aliceStory
            // 
            this.aliceStory.Name = "aliceStory";
            this.aliceStory.Size = new System.Drawing.Size(180, 22);
            this.aliceStory.Text = "Poveste";
            this.aliceStory.Click += new System.EventHandler(this.aliceStory_Click);
            // 
            // aliceAnimation
            // 
            this.aliceAnimation.Name = "aliceAnimation";
            this.aliceAnimation.Size = new System.Drawing.Size(180, 22);
            this.aliceAnimation.Text = "Animatie";
            this.aliceAnimation.Click += new System.EventHandler(this.aliceAnimation_Click);
            // 
            // aliceMovie
            // 
            this.aliceMovie.Name = "aliceMovie";
            this.aliceMovie.Size = new System.Drawing.Size(180, 22);
            this.aliceMovie.Text = "Film";
            this.aliceMovie.Click += new System.EventHandler(this.aliceMovie_Click);
            // 
            // zapada
            // 
            this.zapada.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zapadaStory,
            this.zapadaAnimation,
            this.zapadaMovie});
            this.zapada.Name = "zapada";
            this.zapada.Size = new System.Drawing.Size(241, 22);
            this.zapada.Text = "Alba ca Zapada";
            // 
            // zapadaStory
            // 
            this.zapadaStory.Name = "zapadaStory";
            this.zapadaStory.Size = new System.Drawing.Size(180, 22);
            this.zapadaStory.Text = "Poveste";
            this.zapadaStory.Click += new System.EventHandler(this.zapadaStory_Click);
            // 
            // zapadaAnimation
            // 
            this.zapadaAnimation.Name = "zapadaAnimation";
            this.zapadaAnimation.Size = new System.Drawing.Size(180, 22);
            this.zapadaAnimation.Text = "Animatie";
            this.zapadaAnimation.Click += new System.EventHandler(this.zapadaAnimation_Click);
            // 
            // zapadaMovie
            // 
            this.zapadaMovie.Name = "zapadaMovie";
            this.zapadaMovie.Size = new System.Drawing.Size(180, 22);
            this.zapadaMovie.Text = "Film";
            this.zapadaMovie.Click += new System.EventHandler(this.zapadaMovie_Click);
            // 
            // cenusareasa
            // 
            this.cenusareasa.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cenusareasaStory,
            this.cenusareasaAnimation,
            this.cenusareasaMovie});
            this.cenusareasa.Name = "cenusareasa";
            this.cenusareasa.Size = new System.Drawing.Size(241, 22);
            this.cenusareasa.Text = "Cenusareasa";
            // 
            // cenusareasaStory
            // 
            this.cenusareasaStory.Name = "cenusareasaStory";
            this.cenusareasaStory.Size = new System.Drawing.Size(180, 22);
            this.cenusareasaStory.Text = "Poveste";
            this.cenusareasaStory.Click += new System.EventHandler(this.cenusareasaStory_Click);
            // 
            // cenusareasaAnimation
            // 
            this.cenusareasaAnimation.Name = "cenusareasaAnimation";
            this.cenusareasaAnimation.Size = new System.Drawing.Size(180, 22);
            this.cenusareasaAnimation.Text = "Animatie";
            this.cenusareasaAnimation.Click += new System.EventHandler(this.cenusareasaAnimation_Click);
            // 
            // cenusareasaMovie
            // 
            this.cenusareasaMovie.Name = "cenusareasaMovie";
            this.cenusareasaMovie.Size = new System.Drawing.Size(180, 22);
            this.cenusareasaMovie.Text = "Film";
            this.cenusareasaMovie.Click += new System.EventHandler(this.cenusareasaMovie_Click);
            // 
            // beauty
            // 
            this.beauty.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beautyStory,
            this.beautyAnimation,
            this.beautyMovie});
            this.beauty.Name = "beauty";
            this.beauty.Size = new System.Drawing.Size(241, 22);
            this.beauty.Text = "Fumoasa din Padurea Adormita";
            // 
            // beautyStory
            // 
            this.beautyStory.Name = "beautyStory";
            this.beautyStory.Size = new System.Drawing.Size(180, 22);
            this.beautyStory.Text = "Poveste";
            this.beautyStory.Click += new System.EventHandler(this.beautyStory_Click);
            // 
            // beautyAnimation
            // 
            this.beautyAnimation.Name = "beautyAnimation";
            this.beautyAnimation.Size = new System.Drawing.Size(180, 22);
            this.beautyAnimation.Text = "Animatie";
            this.beautyAnimation.Click += new System.EventHandler(this.beautyAnimation_Click);
            // 
            // beautyMovie
            // 
            this.beautyMovie.Name = "beautyMovie";
            this.beautyMovie.Size = new System.Drawing.Size(180, 22);
            this.beautyMovie.Text = "Film";
            this.beautyMovie.Click += new System.EventHandler(this.beautyMovie_Click);
            // 
            // beautyBeast
            // 
            this.beautyBeast.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beautyBeastStory,
            this.beautyBeastAnimation,
            this.beautyBeastMovie});
            this.beautyBeast.Name = "beautyBeast";
            this.beautyBeast.Size = new System.Drawing.Size(241, 22);
            this.beautyBeast.Text = "Frumoasa si Bestia";
            // 
            // beautyBeastStory
            // 
            this.beautyBeastStory.Name = "beautyBeastStory";
            this.beautyBeastStory.Size = new System.Drawing.Size(180, 22);
            this.beautyBeastStory.Text = "Poveste";
            this.beautyBeastStory.Click += new System.EventHandler(this.beautyBeastStory_Click);
            // 
            // beautyBeastAnimation
            // 
            this.beautyBeastAnimation.Name = "beautyBeastAnimation";
            this.beautyBeastAnimation.Size = new System.Drawing.Size(180, 22);
            this.beautyBeastAnimation.Text = "Animatie";
            this.beautyBeastAnimation.Click += new System.EventHandler(this.beautyBeastAnimation_Click);
            // 
            // beautyBeastMovie
            // 
            this.beautyBeastMovie.Name = "beautyBeastMovie";
            this.beautyBeastMovie.Size = new System.Drawing.Size(180, 22);
            this.beautyBeastMovie.Text = "Film";
            this.beautyBeastMovie.Click += new System.EventHandler(this.beautyBeastMovie_Click);
            // 
            // frozen
            // 
            this.frozen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frozenAnimation,
            this.frozenMovie});
            this.frozen.Name = "frozen";
            this.frozen.Size = new System.Drawing.Size(241, 22);
            this.frozen.Text = "Frozen";
            // 
            // frozenAnimation
            // 
            this.frozenAnimation.Name = "frozenAnimation";
            this.frozenAnimation.Size = new System.Drawing.Size(180, 22);
            this.frozenAnimation.Text = "Animatie";
            this.frozenAnimation.Click += new System.EventHandler(this.frozenAnimation_Click);
            // 
            // frozenMovie
            // 
            this.frozenMovie.Name = "frozenMovie";
            this.frozenMovie.Size = new System.Drawing.Size(180, 22);
            this.frozenMovie.Text = "Film";
            this.frozenMovie.Click += new System.EventHandler(this.frozenMovie_Click);
            // 
            // rapunzel
            // 
            this.rapunzel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rapunzelStory,
            this.rapunzelAnimation,
            this.rapunzelMovie});
            this.rapunzel.Name = "rapunzel";
            this.rapunzel.Size = new System.Drawing.Size(241, 22);
            this.rapunzel.Text = "Rapunzel";
            // 
            // rapunzelStory
            // 
            this.rapunzelStory.Name = "rapunzelStory";
            this.rapunzelStory.Size = new System.Drawing.Size(180, 22);
            this.rapunzelStory.Text = "Poveste";
            this.rapunzelStory.Click += new System.EventHandler(this.rapunzelStory_Click);
            // 
            // rapunzelAnimation
            // 
            this.rapunzelAnimation.Name = "rapunzelAnimation";
            this.rapunzelAnimation.Size = new System.Drawing.Size(180, 22);
            this.rapunzelAnimation.Text = "Animatie";
            this.rapunzelAnimation.Click += new System.EventHandler(this.rapunzelAnimation_Click);
            // 
            // rapunzelMovie
            // 
            this.rapunzelMovie.Name = "rapunzelMovie";
            this.rapunzelMovie.Size = new System.Drawing.Size(180, 22);
            this.rapunzelMovie.Text = "Film";
            this.rapunzelMovie.Click += new System.EventHandler(this.rapunzelMovie_Click);
            // 
            // siren
            // 
            this.siren.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sirenStory,
            this.sirenAnimation,
            this.sirenMovie});
            this.siren.Name = "siren";
            this.siren.Size = new System.Drawing.Size(241, 22);
            this.siren.Text = "Mica Sirena";
            // 
            // sirenStory
            // 
            this.sirenStory.Name = "sirenStory";
            this.sirenStory.Size = new System.Drawing.Size(180, 22);
            this.sirenStory.Text = "Poveste";
            this.sirenStory.Click += new System.EventHandler(this.sirenStory_Click);
            // 
            // sirenAnimation
            // 
            this.sirenAnimation.Name = "sirenAnimation";
            this.sirenAnimation.Size = new System.Drawing.Size(180, 22);
            this.sirenAnimation.Text = "Animatie";
            this.sirenAnimation.Click += new System.EventHandler(this.sirenAnimation_Click);
            // 
            // sirenMovie
            // 
            this.sirenMovie.Name = "sirenMovie";
            this.sirenMovie.Size = new System.Drawing.Size(180, 22);
            this.sirenMovie.Text = "Film";
            this.sirenMovie.Click += new System.EventHandler(this.sirenMovie_Click);
            // 
            // poveste
            // 
            this.poveste.Enabled = true;
            this.poveste.Location = new System.Drawing.Point(0, 428);
            this.poveste.Name = "poveste";
            this.poveste.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("poveste.OcxState")));
            this.poveste.Size = new System.Drawing.Size(192, 192);
            this.poveste.TabIndex = 3;
            this.poveste.Visible = false;
            // 
            // film
            // 
            this.film.Enabled = true;
            this.film.Location = new System.Drawing.Point(0, 428);
            this.film.Name = "film";
            this.film.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("film.OcxState")));
            this.film.Size = new System.Drawing.Size(75, 23);
            this.film.TabIndex = 4;
            this.film.Visible = false;
            // 
            // Fete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.film);
            this.Controls.Add(this.poveste);
            this.Controls.Add(this.back);
            this.Controls.Add(this.close);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menu;
            this.Name = "Fete";
            this.Text = "Fete";
            this.Load += new System.EventHandler(this.Fete_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poveste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.film)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label back;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem filmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alice;
        private System.Windows.Forms.ToolStripMenuItem zapada;
        private System.Windows.Forms.ToolStripMenuItem cenusareasa;
        private System.Windows.Forms.ToolStripMenuItem beauty;
        private System.Windows.Forms.ToolStripMenuItem beautyBeast;
        private System.Windows.Forms.ToolStripMenuItem frozen;
        private System.Windows.Forms.ToolStripMenuItem rapunzel;
        private System.Windows.Forms.ToolStripMenuItem siren;
        private System.Windows.Forms.ToolStripMenuItem aliceStory;
        private System.Windows.Forms.ToolStripMenuItem aliceAnimation;
        private System.Windows.Forms.ToolStripMenuItem aliceMovie;
        private System.Windows.Forms.ToolStripMenuItem zapadaStory;
        private System.Windows.Forms.ToolStripMenuItem zapadaAnimation;
        private System.Windows.Forms.ToolStripMenuItem zapadaMovie;
        private System.Windows.Forms.ToolStripMenuItem cenusareasaStory;
        private System.Windows.Forms.ToolStripMenuItem cenusareasaAnimation;
        private System.Windows.Forms.ToolStripMenuItem cenusareasaMovie;
        private System.Windows.Forms.ToolStripMenuItem beautyStory;
        private System.Windows.Forms.ToolStripMenuItem beautyAnimation;
        private System.Windows.Forms.ToolStripMenuItem beautyMovie;
        private System.Windows.Forms.ToolStripMenuItem beautyBeastStory;
        private System.Windows.Forms.ToolStripMenuItem beautyBeastAnimation;
        private System.Windows.Forms.ToolStripMenuItem frozenAnimation;
        private System.Windows.Forms.ToolStripMenuItem frozenMovie;
        private System.Windows.Forms.ToolStripMenuItem rapunzelStory;
        private System.Windows.Forms.ToolStripMenuItem rapunzelAnimation;
        private System.Windows.Forms.ToolStripMenuItem rapunzelMovie;
        private System.Windows.Forms.ToolStripMenuItem sirenStory;
        private System.Windows.Forms.ToolStripMenuItem sirenAnimation;
        private System.Windows.Forms.ToolStripMenuItem sirenMovie;
        private AxAcroPDFLib.AxAcroPDF poveste;
        private AxWMPLib.AxWindowsMediaPlayer film;
        private System.Windows.Forms.ToolStripMenuItem beautyBeastMovie;
    }
}