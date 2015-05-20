namespace SysClinic.View
{
    partial class MdiPrincipal
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
            this.stStPrincipal = new System.Windows.Forms.StatusStrip();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // stStPrincipal
            // 
            this.stStPrincipal.Location = new System.Drawing.Point(0, 457);
            this.stStPrincipal.Name = "stStPrincipal";
            this.stStPrincipal.Size = new System.Drawing.Size(851, 22);
            this.stStPrincipal.TabIndex = 1;
            this.stStPrincipal.Text = "statusStrip1";
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(851, 24);
            this.menuPrincipal.TabIndex = 2;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // MdiPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 479);
            this.Controls.Add(this.stStPrincipal);
            this.Controls.Add(this.menuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "MdiPrincipal";
            this.Text = "SysClinic";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip stStPrincipal;
        private System.Windows.Forms.MenuStrip menuPrincipal;
    }
}