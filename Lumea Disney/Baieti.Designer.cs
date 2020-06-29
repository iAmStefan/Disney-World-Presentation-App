namespace Lumea_Disney
{
    partial class Baieti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Baieti));
            this.close = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Label();
            this.poveste = new AxAcroPDFLib.AxAcroPDF();
            this.film = new AxWMPLib.AxWindowsMediaPlayer();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.filmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pan = new System.Windows.Forms.ToolStripMenuItem();
            this.panStory = new System.Windows.Forms.ToolStripMenuItem();
            this.panAnimation = new System.Windows.Forms.ToolStripMenuItem();
            this.panMovie = new System.Windows.Forms.ToolStripMenuItem();
            this.jungle = new System.Windows.Forms.ToolStripMenuItem();
            this.jungleStory = new System.Windows.Forms.ToolStripMenuItem();
            this.jungleAnimation = new System.Windows.Forms.ToolStripMenuItem();
            this.jungleMovie = new System.Windows.Forms.ToolStripMenuItem();
            this.pinocchio = new System.Windows.Forms.ToolStripMenuItem();
            this.pinocchioStory = new System.Windows.Forms.ToolStripMenuItem();
            this.pinocchioMovie = new System.Windows.Forms.ToolStripMenuItem();
            this.hood = new System.Windows.Forms.ToolStripMenuItem();
            this.hoodMovie = new System.Windows.Forms.ToolStripMenuItem();
            this.dumbo = new System.Windows.Forms.ToolStripMenuItem();
            this.dumboStory = new System.Windows.Forms.ToolStripMenuItem();
            this.dumboMovie = new System.Windows.Forms.ToolStripMenuItem();
            this.dalmatian = new System.Windows.Forms.ToolStripMenuItem();
            this.dalmationAnimation = new System.Windows.Forms.ToolStripMenuItem();
            this.aladdin = new System.Windows.Forms.ToolStripMenuItem();
            this.aladdinStory = new System.Windows.Forms.ToolStripMenuItem();
            this.aladdinMovie = new System.Windows.Forms.ToolStripMenuItem();
            this.tarzanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarzanStory = new System.Windows.Forms.ToolStripMenuItem();
            this.tarzanAnimation = new System.Windows.Forms.ToolStripMenuItem();
            this.tarzanMovie = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.poveste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.film)).BeginInit();
            this.menu.SuspendLayout();
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
            this.back.Location = new System.Drawing.Point(742, -2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(34, 23);
            this.back.TabIndex = 1;
            this.back.Text = "<-";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // poveste
            // 
            this.poveste.Enabled = true;
            this.poveste.Location = new System.Drawing.Point(10, 410);
            this.poveste.Name = "poveste";
            this.poveste.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("poveste.OcxState")));
            this.poveste.Size = new System.Drawing.Size(192, 192);
            this.poveste.TabIndex = 2;
            this.poveste.Visible = false;
            // 
            // film
            // 
            this.film.Enabled = true;
            this.film.Location = new System.Drawing.Point(10, 410);
            this.film.Name = "film";
            this.film.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("film.OcxState")));
            this.film.Size = new System.Drawing.Size(75, 23);
            this.film.TabIndex = 3;
            this.film.Visible = false;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filmeToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 24);
            this.menu.TabIndex = 4;
            this.menu.Text = "menu";
            // 
            // filmeToolStripMenuItem
            // 
            this.filmeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pan,
            this.jungle,
            this.pinocchio,
            this.hood,
            this.dumbo,
            this.dalmatian,
            this.aladdin,
            this.tarzanToolStripMenuItem});
            this.filmeToolStripMenuItem.Name = "filmeToolStripMenuItem";
            this.filmeToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.filmeToolStripMenuItem.Text = "Filme";
            // 
            // pan
            // 
            this.pan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.panStory,
            this.panAnimation,
            this.panMovie});
            this.pan.Name = "pan";
            this.pan.Size = new System.Drawing.Size(180, 22);
            this.pan.Text = "Peter Pan";
            // 
            // panStory
            // 
            this.panStory.Name = "panStory";
            this.panStory.Size = new System.Drawing.Size(122, 22);
            this.panStory.Text = "Poveste";
            this.panStory.Click += new System.EventHandler(this.panStory_Click);
            // 
            // panAnimation
            // 
            this.panAnimation.Name = "panAnimation";
            this.panAnimation.Size = new System.Drawing.Size(122, 22);
            this.panAnimation.Text = "Animatie";
            this.panAnimation.Click += new System.EventHandler(this.panAnimation_Click);
            // 
            // panMovie
            // 
            this.panMovie.Name = "panMovie";
            this.panMovie.Size = new System.Drawing.Size(122, 22);
            this.panMovie.Text = "Film";
            this.panMovie.Click += new System.EventHandler(this.panMovie_Click);
            // 
            // jungle
            // 
            this.jungle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jungleStory,
            this.jungleAnimation,
            this.jungleMovie});
            this.jungle.Name = "jungle";
            this.jungle.Size = new System.Drawing.Size(180, 22);
            this.jungle.Text = "Cartea junglei";
            // 
            // jungleStory
            // 
            this.jungleStory.Name = "jungleStory";
            this.jungleStory.Size = new System.Drawing.Size(122, 22);
            this.jungleStory.Text = "Poveste";
            this.jungleStory.Click += new System.EventHandler(this.jungleStory_Click);
            // 
            // jungleAnimation
            // 
            this.jungleAnimation.Name = "jungleAnimation";
            this.jungleAnimation.Size = new System.Drawing.Size(122, 22);
            this.jungleAnimation.Text = "Animatie";
            this.jungleAnimation.Click += new System.EventHandler(this.jungleAnimation_Click);
            // 
            // jungleMovie
            // 
            this.jungleMovie.Name = "jungleMovie";
            this.jungleMovie.Size = new System.Drawing.Size(122, 22);
            this.jungleMovie.Text = "Film";
            this.jungleMovie.Click += new System.EventHandler(this.jungleMovie_Click);
            // 
            // pinocchio
            // 
            this.pinocchio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pinocchioStory,
            this.pinocchioMovie});
            this.pinocchio.Name = "pinocchio";
            this.pinocchio.Size = new System.Drawing.Size(180, 22);
            this.pinocchio.Text = "Pinocchio";
            // 
            // pinocchioStory
            // 
            this.pinocchioStory.Name = "pinocchioStory";
            this.pinocchioStory.Size = new System.Drawing.Size(115, 22);
            this.pinocchioStory.Text = "Poveste";
            this.pinocchioStory.Click += new System.EventHandler(this.pinocchioStory_Click);
            // 
            // pinocchioMovie
            // 
            this.pinocchioMovie.Name = "pinocchioMovie";
            this.pinocchioMovie.Size = new System.Drawing.Size(115, 22);
            this.pinocchioMovie.Text = "Film";
            this.pinocchioMovie.Click += new System.EventHandler(this.pinocchioMovie_Click);
            // 
            // hood
            // 
            this.hood.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hoodMovie});
            this.hood.Name = "hood";
            this.hood.Size = new System.Drawing.Size(180, 22);
            this.hood.Text = "Robin Hood";
            // 
            // hoodMovie
            // 
            this.hoodMovie.Name = "hoodMovie";
            this.hoodMovie.Size = new System.Drawing.Size(97, 22);
            this.hoodMovie.Text = "Film";
            this.hoodMovie.Click += new System.EventHandler(this.hoodMovie_Click);
            // 
            // dumbo
            // 
            this.dumbo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dumboStory,
            this.dumboMovie});
            this.dumbo.Name = "dumbo";
            this.dumbo.Size = new System.Drawing.Size(180, 22);
            this.dumbo.Text = "Dumbo";
            // 
            // dumboStory
            // 
            this.dumboStory.Name = "dumboStory";
            this.dumboStory.Size = new System.Drawing.Size(115, 22);
            this.dumboStory.Text = "Poveste";
            this.dumboStory.Click += new System.EventHandler(this.dumboStory_Click);
            // 
            // dumboMovie
            // 
            this.dumboMovie.Name = "dumboMovie";
            this.dumboMovie.Size = new System.Drawing.Size(115, 22);
            this.dumboMovie.Text = "Film";
            this.dumboMovie.Click += new System.EventHandler(this.dumboMovie_Click);
            // 
            // dalmatian
            // 
            this.dalmatian.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dalmationAnimation});
            this.dalmatian.Name = "dalmatian";
            this.dalmatian.Size = new System.Drawing.Size(180, 22);
            this.dalmatian.Text = "101 Dalmatirni";
            // 
            // dalmationAnimation
            // 
            this.dalmationAnimation.Name = "dalmationAnimation";
            this.dalmationAnimation.Size = new System.Drawing.Size(180, 22);
            this.dalmationAnimation.Text = "Animatie";
            this.dalmationAnimation.Click += new System.EventHandler(this.dalmationAnimation_Click);
            // 
            // aladdin
            // 
            this.aladdin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aladdinStory,
            this.aladdinMovie});
            this.aladdin.Name = "aladdin";
            this.aladdin.Size = new System.Drawing.Size(180, 22);
            this.aladdin.Text = "Aladdin";
            // 
            // aladdinStory
            // 
            this.aladdinStory.Name = "aladdinStory";
            this.aladdinStory.Size = new System.Drawing.Size(180, 22);
            this.aladdinStory.Text = "Poveste";
            this.aladdinStory.Click += new System.EventHandler(this.aladdinStory_Click);
            // 
            // aladdinMovie
            // 
            this.aladdinMovie.Name = "aladdinMovie";
            this.aladdinMovie.Size = new System.Drawing.Size(180, 22);
            this.aladdinMovie.Text = "Film";
            this.aladdinMovie.Click += new System.EventHandler(this.aladdinMovie_Click);
            // 
            // tarzanToolStripMenuItem
            // 
            this.tarzanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tarzanStory,
            this.tarzanAnimation,
            this.tarzanMovie});
            this.tarzanToolStripMenuItem.Name = "tarzanToolStripMenuItem";
            this.tarzanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tarzanToolStripMenuItem.Text = "Tarzan";
            // 
            // tarzanStory
            // 
            this.tarzanStory.Name = "tarzanStory";
            this.tarzanStory.Size = new System.Drawing.Size(180, 22);
            this.tarzanStory.Text = "Poveste";
            this.tarzanStory.Click += new System.EventHandler(this.tarzanStory_Click);
            // 
            // tarzanAnimation
            // 
            this.tarzanAnimation.Name = "tarzanAnimation";
            this.tarzanAnimation.Size = new System.Drawing.Size(180, 22);
            this.tarzanAnimation.Text = "Animatie";
            this.tarzanAnimation.Click += new System.EventHandler(this.tarzanAnimation_Click);
            // 
            // tarzanMovie
            // 
            this.tarzanMovie.Name = "tarzanMovie";
            this.tarzanMovie.Size = new System.Drawing.Size(180, 22);
            this.tarzanMovie.Text = "Film";
            this.tarzanMovie.Click += new System.EventHandler(this.tarzanMovie_Click);
            // 
            // Baieti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.film);
            this.Controls.Add(this.poveste);
            this.Controls.Add(this.back);
            this.Controls.Add(this.close);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menu;
            this.Name = "Baieti";
            this.Text = "Baieti";
            this.Load += new System.EventHandler(this.Baieti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.poveste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.film)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label back;
        private AxAcroPDFLib.AxAcroPDF poveste;
        private AxWMPLib.AxWindowsMediaPlayer film;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem filmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pan;
        private System.Windows.Forms.ToolStripMenuItem panStory;
        private System.Windows.Forms.ToolStripMenuItem panAnimation;
        private System.Windows.Forms.ToolStripMenuItem panMovie;
        private System.Windows.Forms.ToolStripMenuItem jungle;
        private System.Windows.Forms.ToolStripMenuItem jungleStory;
        private System.Windows.Forms.ToolStripMenuItem jungleAnimation;
        private System.Windows.Forms.ToolStripMenuItem jungleMovie;
        private System.Windows.Forms.ToolStripMenuItem pinocchio;
        private System.Windows.Forms.ToolStripMenuItem pinocchioStory;
        private System.Windows.Forms.ToolStripMenuItem pinocchioMovie;
        private System.Windows.Forms.ToolStripMenuItem hood;
        private System.Windows.Forms.ToolStripMenuItem hoodMovie;
        private System.Windows.Forms.ToolStripMenuItem dumbo;
        private System.Windows.Forms.ToolStripMenuItem dumboStory;
        private System.Windows.Forms.ToolStripMenuItem dumboMovie;
        private System.Windows.Forms.ToolStripMenuItem dalmatian;
        private System.Windows.Forms.ToolStripMenuItem dalmationAnimation;
        private System.Windows.Forms.ToolStripMenuItem aladdin;
        private System.Windows.Forms.ToolStripMenuItem aladdinStory;
        private System.Windows.Forms.ToolStripMenuItem aladdinMovie;
        private System.Windows.Forms.ToolStripMenuItem tarzanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarzanStory;
        private System.Windows.Forms.ToolStripMenuItem tarzanAnimation;
        private System.Windows.Forms.ToolStripMenuItem tarzanMovie;
    }
}