
namespace PBL3_DATVEXE.View
{
    partial class Mainapp
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureTimve = new System.Windows.Forms.PictureBox();
            this.pictureTk = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbtimve = new System.Windows.Forms.GroupBox();
            this.searchTicket1 = new toolboxPBL3.SearchTicket();
            this.gbtaikhoan = new System.Windows.Forms.GroupBox();
            this.account1 = new toolboxPBL3.Account();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTimve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTk)).BeginInit();
            this.gbtimve.SuspendLayout();
            this.gbtaikhoan.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(714, 727);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::PBL3_DATVEXE.Properties.Resources.vecuatoi;
            this.pictureBox2.Location = new System.Drawing.Point(35, 653);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(78, 73);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::PBL3_DATVEXE.Properties.Resources.ThongBao;
            this.pictureBox3.Location = new System.Drawing.Point(225, 653);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(78, 73);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureTimve
            // 
            this.pictureTimve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureTimve.Image = global::PBL3_DATVEXE.Properties.Resources.TIMVE;
            this.pictureTimve.Location = new System.Drawing.Point(406, 653);
            this.pictureTimve.Name = "pictureTimve";
            this.pictureTimve.Size = new System.Drawing.Size(78, 73);
            this.pictureTimve.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTimve.TabIndex = 1;
            this.pictureTimve.TabStop = false;
            this.pictureTimve.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureTk
            // 
            this.pictureTk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureTk.Image = global::PBL3_DATVEXE.Properties.Resources.TaiKhoan1;
            this.pictureTk.Location = new System.Drawing.Point(600, 653);
            this.pictureTk.Name = "pictureTk";
            this.pictureTk.Size = new System.Drawing.Size(78, 73);
            this.pictureTk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTk.TabIndex = 1;
            this.pictureTk.TabStop = false;
            this.pictureTk.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // gbtimve
            // 
            this.gbtimve.CausesValidation = false;
            this.gbtimve.Controls.Add(this.gbtaikhoan);
            this.gbtimve.Controls.Add(this.searchTicket1);
            this.gbtimve.Location = new System.Drawing.Point(0, 0);
            this.gbtimve.Name = "gbtimve";
            this.gbtimve.Size = new System.Drawing.Size(714, 648);
            this.gbtimve.TabIndex = 2;
            this.gbtimve.TabStop = false;
            this.gbtimve.Visible = false;
            // 
            // searchTicket1
            // 
            this.searchTicket1.BackColor = System.Drawing.Color.White;
            this.searchTicket1.Location = new System.Drawing.Point(0, 5);
            this.searchTicket1.Name = "searchTicket1";
            this.searchTicket1.Size = new System.Drawing.Size(721, 624);
            this.searchTicket1.TabIndex = 0;
            // 
            // gbtaikhoan
            // 
            this.gbtaikhoan.Controls.Add(this.account1);
            this.gbtaikhoan.Location = new System.Drawing.Point(0, 5);
            this.gbtaikhoan.Name = "gbtaikhoan";
            this.gbtaikhoan.Size = new System.Drawing.Size(714, 643);
            this.gbtaikhoan.TabIndex = 1;
            this.gbtaikhoan.TabStop = false;
            this.gbtaikhoan.Visible = false;
            // 
            // account1
            // 
            this.account1.BackColor = System.Drawing.Color.White;
            this.account1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.account1.Location = new System.Drawing.Point(0, 4);
            this.account1.Name = "account1";
            this.account1.Size = new System.Drawing.Size(721, 624);
            this.account1.TabIndex = 0;
            // 
            // Mainapp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(712, 721);
            this.Controls.Add(this.gbtimve);
            this.Controls.Add(this.pictureTk);
            this.Controls.Add(this.pictureTimve);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Mainapp";
            this.Text = "Mainapp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTimve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTk)).EndInit();
            this.gbtimve.ResumeLayout(false);
            this.gbtaikhoan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureTimve;
        private System.Windows.Forms.PictureBox pictureTk;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbtimve;
        private System.Windows.Forms.GroupBox gbtaikhoan;
        private toolboxPBL3.Account account1;
        private toolboxPBL3.SearchTicket searchTicket1;
    }
}