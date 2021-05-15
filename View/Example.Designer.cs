
namespace PBL3_DATVEXE.View
{
    partial class Example
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.liststicket1 = new toolboxPBL3.Liststicket();
            this.SuspendLayout();
            // 
            // liststicket1
            // 
            this.liststicket1.Location = new System.Drawing.Point(-8, 31);
            this.liststicket1.Name = "liststicket1";
            this.liststicket1.Size = new System.Drawing.Size(721, 624);
            this.liststicket1.TabIndex = 0;
            // 
            // Example
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(712, 768);
            this.Controls.Add(this.liststicket1);
            this.Name = "Example";
            this.Text = "Example";
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private toolboxPBL3.Liststicket liststicket1;
    }
}