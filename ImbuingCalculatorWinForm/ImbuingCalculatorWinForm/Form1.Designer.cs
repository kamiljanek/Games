
using System;
using System.Drawing;

namespace ImbuingCalculatorWinForm
{
    public partial class Form1
    {
        
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnLifeLeech = new System.Windows.Forms.Button();
            this.txtGoldTokenPrice = new System.Windows.Forms.TextBox();
            this.btnManaLeech = new System.Windows.Forms.Button();
            this.btnCritical = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlFormLoader = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnLifeLeech);
            this.panel1.Controls.Add(this.txtGoldTokenPrice);
            this.panel1.Controls.Add(this.btnManaLeech);
            this.panel1.Controls.Add(this.btnCritical);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 500);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ImbuingCalculatorWinForm.Properties.Resources.gold_token1;
            this.pictureBox2.Location = new System.Drawing.Point(12, 458);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // btnLifeLeech
            // 
            this.btnLifeLeech.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLifeLeech.FlatAppearance.BorderSize = 0;
            this.btnLifeLeech.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLifeLeech.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLifeLeech.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnLifeLeech.Image = ((System.Drawing.Image)(resources.GetObject("btnLifeLeech.Image")));
            this.btnLifeLeech.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLifeLeech.Location = new System.Drawing.Point(0, 270);
            this.btnLifeLeech.Name = "btnLifeLeech";
            this.btnLifeLeech.Size = new System.Drawing.Size(200, 45);
            this.btnLifeLeech.TabIndex = 4;
            this.btnLifeLeech.Text = "Life Leech";
            this.btnLifeLeech.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLifeLeech.UseVisualStyleBackColor = true;
            this.btnLifeLeech.Click += new System.EventHandler(this.btnLifeLeech_Click);
            this.btnLifeLeech.Leave += new System.EventHandler(this.btnLifeLeech_Leave);
            // 
            // txtGoldTokenPrice
            // 
            this.txtGoldTokenPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtGoldTokenPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGoldTokenPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtGoldTokenPrice.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtGoldTokenPrice.Location = new System.Drawing.Point(49, 464);
            this.txtGoldTokenPrice.Multiline = true;
            this.txtGoldTokenPrice.Name = "txtGoldTokenPrice";
            this.txtGoldTokenPrice.PlaceholderText = "Gold Token price...";
            this.txtGoldTokenPrice.Size = new System.Drawing.Size(117, 20);
            this.txtGoldTokenPrice.TabIndex = 4;
            this.txtGoldTokenPrice.TextChanged += new System.EventHandler(this.txtGoldTokenPrice_TextChanged);
            // 
            // btnManaLeech
            // 
            this.btnManaLeech.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManaLeech.FlatAppearance.BorderSize = 0;
            this.btnManaLeech.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManaLeech.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnManaLeech.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnManaLeech.Image = ((System.Drawing.Image)(resources.GetObject("btnManaLeech.Image")));
            this.btnManaLeech.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnManaLeech.Location = new System.Drawing.Point(0, 225);
            this.btnManaLeech.Name = "btnManaLeech";
            this.btnManaLeech.Size = new System.Drawing.Size(200, 45);
            this.btnManaLeech.TabIndex = 3;
            this.btnManaLeech.Text = "Mana Leech";
            this.btnManaLeech.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnManaLeech.UseVisualStyleBackColor = true;
            this.btnManaLeech.Click += new System.EventHandler(this.btnManaLeech_Click);
            this.btnManaLeech.Leave += new System.EventHandler(this.btnManaLeech_Leave);
            // 
            // btnCritical
            // 
            this.btnCritical.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCritical.FlatAppearance.BorderSize = 0;
            this.btnCritical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCritical.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCritical.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCritical.Image = ((System.Drawing.Image)(resources.GetObject("btnCritical.Image")));
            this.btnCritical.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCritical.Location = new System.Drawing.Point(0, 180);
            this.btnCritical.Name = "btnCritical";
            this.btnCritical.Size = new System.Drawing.Size(200, 45);
            this.btnCritical.TabIndex = 2;
            this.btnCritical.Text = "Critical";
            this.btnCritical.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCritical.UseVisualStyleBackColor = true;
            this.btnCritical.Click += new System.EventHandler(this.btnCritical_Click);
            this.btnCritical.Leave += new System.EventHandler(this.btnCritical_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlNav);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 180);
            this.panel2.TabIndex = 0;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(300, 300);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(300, 80);
            this.pnlNav.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(12, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Imbuing Calculator";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(80, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(415, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(23, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblTitle.Location = new System.Drawing.Point(21, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(207, 25);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Critical Imbuement";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblTitle);
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 120);
            this.panel3.TabIndex = 6;
            // 
            // pnlFormLoader
            // 
            this.pnlFormLoader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormLoader.Location = new System.Drawing.Point(200, 120);
            this.pnlFormLoader.Name = "pnlFormLoader";
            this.pnlFormLoader.Size = new System.Drawing.Size(450, 380);
            this.pnlFormLoader.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(650, 500);
            this.Controls.Add(this.pnlFormLoader);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

     
        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnLifeLeech;
        private System.Windows.Forms.Button btnManaLeech;
        private System.Windows.Forms.Button btnCritical;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtGoldTokenPrice;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlFormLoader;
        
    }
}

