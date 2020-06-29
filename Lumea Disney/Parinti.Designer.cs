namespace Lumea_Disney
{
    partial class Parinti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parinti));
            this.close = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Label();
            this.waltDisney = new System.Windows.Forms.Label();
            this.parks = new System.Windows.Forms.Label();
            this.informatii = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)(this.informatii)).BeginInit();
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
            this.back.Location = new System.Drawing.Point(745, -2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(34, 23);
            this.back.TabIndex = 1;
            this.back.Text = "<-";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // waltDisney
            // 
            this.waltDisney.AutoSize = true;
            this.waltDisney.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waltDisney.Location = new System.Drawing.Point(139, 348);
            this.waltDisney.Name = "waltDisney";
            this.waltDisney.Size = new System.Drawing.Size(108, 25);
            this.waltDisney.TabIndex = 2;
            this.waltDisney.Text = "Walt Disney";
            this.waltDisney.Click += new System.EventHandler(this.waltDisney_Click);
            // 
            // parks
            // 
            this.parks.AutoSize = true;
            this.parks.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parks.Location = new System.Drawing.Point(420, 348);
            this.parks.Name = "parks";
            this.parks.Size = new System.Drawing.Size(208, 25);
            this.parks.TabIndex = 3;
            this.parks.Text = "Disney World and Resorts";
            this.parks.Click += new System.EventHandler(this.parks_Click);
            // 
            // informatii
            // 
            this.informatii.Enabled = true;
            this.informatii.Location = new System.Drawing.Point(10, 385);
            this.informatii.Name = "informatii";
            this.informatii.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("informatii.OcxState")));
            this.informatii.Size = new System.Drawing.Size(132, 55);
            this.informatii.TabIndex = 4;
            this.informatii.Visible = false;
            // 
            // Parinti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.informatii);
            this.Controls.Add(this.parks);
            this.Controls.Add(this.waltDisney);
            this.Controls.Add(this.back);
            this.Controls.Add(this.close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Parinti";
            this.Text = "Parinti";
            this.Load += new System.EventHandler(this.Parinti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.informatii)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label back;
        private System.Windows.Forms.Label waltDisney;
        private System.Windows.Forms.Label parks;
        private AxAcroPDFLib.AxAcroPDF informatii;
    }
}