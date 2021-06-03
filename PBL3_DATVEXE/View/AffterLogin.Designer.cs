
namespace PBL3_DATVEXE.View
{
    partial class AffterLogin
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonAccount1 = new PBL3_DATVEXE.View.buttonAccount();
            this.buttonSearch1 = new PBL3_DATVEXE.View.buttonSearch();
            this.countdowncs1 = new PBL3_DATVEXE.View.countdowncs();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(41, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chào bạn! ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBox2.Image = global::PBL3_DATVEXE.Properties.Resources.bus;
            this.pictureBox2.Location = new System.Drawing.Point(28, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(166, 170);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 620);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonAccount1
            // 
            this.buttonAccount1.BackColor = System.Drawing.Color.White;
            this.buttonAccount1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buttonAccount1.Location = new System.Drawing.Point(0, 332);
            this.buttonAccount1.Name = "buttonAccount1";
            this.buttonAccount1.Size = new System.Drawing.Size(223, 60);
            this.buttonAccount1.TabIndex = 4;
            this.buttonAccount1.Click += new System.EventHandler(this.buttonAccount1_Click);
            // 
            // buttonSearch1
            // 
            this.buttonSearch1.BackColor = System.Drawing.Color.White;
            this.buttonSearch1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buttonSearch1.Location = new System.Drawing.Point(2, 260);
            this.buttonSearch1.Name = "buttonSearch1";
            this.buttonSearch1.Size = new System.Drawing.Size(221, 66);
            this.buttonSearch1.TabIndex = 3;
            this.buttonSearch1.Click += new System.EventHandler(this.buttonSearch1_Click);
            // 
            // countdowncs1
            // 
            this.countdowncs1.BackColor = System.Drawing.Color.Transparent;
            this.countdowncs1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.countdowncs1.Location = new System.Drawing.Point(423, 23);
            this.countdowncs1.Name = "countdowncs1";
            this.countdowncs1.Size = new System.Drawing.Size(75, 72);
            this.countdowncs1.TabIndex = 6;
            // 
            // AffterLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1215, 608);
            this.Controls.Add(this.countdowncs1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonAccount1);
            this.Controls.Add(this.buttonSearch1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AffterLogin";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private buttonSearch buttonSearch1;
        private buttonAccount buttonAccount1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private countdowncs countdowncs1;
    }
}