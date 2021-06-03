
namespace toolboxPBL3
{
    partial class Account
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.affterLogin1 = new toolboxPBL3.AffterLogin();
            this.SuspendLayout();
            // 
            // affterLogin1
            // 
            this.affterLogin1.BackColor = System.Drawing.Color.AliceBlue;
            this.affterLogin1.Location = new System.Drawing.Point(0, 0);
            this.affterLogin1.Name = "affterLogin1";
            this.affterLogin1.Size = new System.Drawing.Size(628, 173);
            this.affterLogin1.TabIndex = 0;
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.affterLogin1);
            this.Name = "Account";
            this.Size = new System.Drawing.Size(628, 176);
            this.ResumeLayout(false);

        }

        #endregion

        private AffterLogin affterLogin1;
    }
}
