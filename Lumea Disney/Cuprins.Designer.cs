namespace Lumea_Disney
{
    partial class Cuprins
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
            this.close = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Label();
            this.boys = new System.Windows.Forms.Label();
            this.girls = new System.Windows.Forms.Label();
            this.parents = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.AutoSize = true;
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
            this.back.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(744, -3);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(34, 23);
            this.back.TabIndex = 1;
            this.back.Text = "<-";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // boys
            // 
            this.boys.AutoSize = true;
            this.boys.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boys.Location = new System.Drawing.Point(167, 212);
            this.boys.Name = "boys";
            this.boys.Size = new System.Drawing.Size(64, 28);
            this.boys.TabIndex = 2;
            this.boys.Text = "Baieti";
            this.boys.Click += new System.EventHandler(this.boys_Click);
            // 
            // girls
            // 
            this.girls.AutoSize = true;
            this.girls.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.girls.Location = new System.Drawing.Point(378, 296);
            this.girls.Name = "girls";
            this.girls.Size = new System.Drawing.Size(50, 28);
            this.girls.TabIndex = 3;
            this.girls.Text = "Fete";
            this.girls.Click += new System.EventHandler(this.girls_Click);
            // 
            // parents
            // 
            this.parents.AutoSize = true;
            this.parents.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parents.Location = new System.Drawing.Point(573, 212);
            this.parents.Name = "parents";
            this.parents.Size = new System.Drawing.Size(73, 28);
            this.parents.TabIndex = 4;
            this.parents.Text = "Parinti";
            this.parents.Click += new System.EventHandler(this.parents_Click);
            // 
            // Cuprins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.parents);
            this.Controls.Add(this.girls);
            this.Controls.Add(this.boys);
            this.Controls.Add(this.back);
            this.Controls.Add(this.close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cuprins";
            this.Text = "Cuprins";
            this.Load += new System.EventHandler(this.Cuprins_Load);
            //this.Click += new System.EventHandler(this.Cuprins_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label back;
        private System.Windows.Forms.Label boys;
        private System.Windows.Forms.Label girls;
        private System.Windows.Forms.Label parents;
    }
}