﻿namespace WindowsFormsApplication1
{
    partial class Anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 309);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 70);
            this.panel1.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Silver;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button7.ImageIndex = 1;
            this.button7.ImageList = this.ımageList1;
            this.button7.Location = new System.Drawing.Point(643, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 55);
            this.button7.TabIndex = 6;
            this.button7.Text = "Çıkış";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "icon10-2.png");
            this.ımageList1.Images.SetKeyName(1, "indir (1).jpeg");
            this.ımageList1.Images.SetKeyName(2, "indir (1).png");
            this.ımageList1.Images.SetKeyName(3, "indir (2).png");
            this.ımageList1.Images.SetKeyName(4, "indir.jpeg");
            this.ımageList1.Images.SetKeyName(5, "indir.png");
            this.ımageList1.Images.SetKeyName(6, "istockphoto-842425106-612x612.jpg");
            this.ımageList1.Images.SetKeyName(7, "ekle.png");
            this.ımageList1.Images.SetKeyName(8, "temizle.png");
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Silver;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.ImageIndex = 2;
            this.button5.ImageList = this.ımageList1;
            this.button5.Location = new System.Drawing.Point(479, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 55);
            this.button5.TabIndex = 4;
            this.button5.Text = "Sözleşme";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.ImageIndex = 6;
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(3, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(251, 55);
            this.button2.TabIndex = 1;
            this.button2.Text = "Müşteri Ekle/Listele";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Silver;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.ImageIndex = 4;
            this.button4.ImageList = this.ımageList1;
            this.button4.Location = new System.Drawing.Point(373, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 55);
            this.button4.TabIndex = 3;
            this.button4.Text = "Araç Listeleme";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.ImageIndex = 5;
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(267, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 55);
            this.button3.TabIndex = 2;
            this.button3.Text = "Araç Kayıt";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.BB;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(755, 379);
            this.Controls.Add(this.panel1);
            this.MinimizeBox = false;
            this.Name = "Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList ımageList1;
    }
}

