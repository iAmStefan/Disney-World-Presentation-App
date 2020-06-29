namespace Lumea_Disney
{
    partial class Main
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
            this.disneyWorld = new System.Windows.Forms.Label();
            this.highSchool = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Label();
            this.stop = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // disneyWorld
            // 
            this.disneyWorld.AutoSize = true;
            this.disneyWorld.Font = new System.Drawing.Font("Monotype Corsiva", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disneyWorld.Location = new System.Drawing.Point(134, 29);
            this.disneyWorld.Name = "disneyWorld";
            this.disneyWorld.Size = new System.Drawing.Size(540, 117);
            this.disneyWorld.TabIndex = 2;
            this.disneyWorld.Text = "Lumea Disney";
            // 
            // highSchool
            // 
            this.highSchool.AutoSize = true;
            this.highSchool.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highSchool.Location = new System.Drawing.Point(12, 9);
            this.highSchool.Name = "highSchool";
            this.highSchool.Size = new System.Drawing.Size(265, 22);
            this.highSchool.TabIndex = 3;
            this.highSchool.Text = "Colegiul National ,,Gheorghe Titeica\"";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(344, 146);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(104, 25);
            this.name.TabIndex = 4;
            this.name.Text = "Raea Loreta";
            // 
            // start
            // 
            this.start.AutoSize = true;
            this.start.Font = new System.Drawing.Font("Monotype Corsiva", 21F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(197, 335);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(66, 34);
            this.start.TabIndex = 5;
            this.start.Text = "Start";
            this.start.Click += new System.EventHandler(this.start_Click_1);
            // 
            // stop
            // 
            this.stop.AutoSize = true;
            this.stop.Font = new System.Drawing.Font("Monotype Corsiva", 21F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop.Location = new System.Drawing.Point(543, 335);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(60, 34);
            this.stop.TabIndex = 6;
            this.stop.Text = "Stop";
            this.stop.Click += new System.EventHandler(this.stop_Click_1);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Controls.Add(this.name);
            this.Controls.Add(this.highSchool);
            this.Controls.Add(this.disneyWorld);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Lumea Disney";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label disneyWorld;
        private System.Windows.Forms.Label highSchool;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label start;
        private System.Windows.Forms.Label stop;
    }
}

