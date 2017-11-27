namespace Banka
{
    partial class Form1
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
            this.lblCircular = new System.Windows.Forms.Label();
            this.lblOrtCircular = new System.Windows.Forms.Label();
            this.txtOrtSureCircular = new System.Windows.Forms.TextBox();
            this.btnOrtSureCircular = new System.Windows.Forms.Button();
            this.BtnMusteri = new System.Windows.Forms.Button();
            this.txtCircular = new System.Windows.Forms.TextBox();
            this.lblPriority1 = new System.Windows.Forms.Label();
            this.btnMusteri2 = new System.Windows.Forms.Button();
            this.txtPriority1 = new System.Windows.Forms.TextBox();
            this.btnOrtPriority = new System.Windows.Forms.Button();
            this.txtOrtPriority2 = new System.Windows.Forms.TextBox();
            this.lblOrtPriority2 = new System.Windows.Forms.Label();
            this.txtPriority2 = new System.Windows.Forms.TextBox();
            this.btnMusteri3 = new System.Windows.Forms.Button();
            this.lblPriority2 = new System.Windows.Forms.Label();
            this.btnKisalan1 = new System.Windows.Forms.Button();
            this.txtKisalan1 = new System.Windows.Forms.TextBox();
            this.txtKisalan2 = new System.Windows.Forms.TextBox();
            this.btnKisalan2 = new System.Windows.Forms.Button();
            this.lblOrt2 = new System.Windows.Forms.Label();
            this.txtOrtPriority1 = new System.Windows.Forms.TextBox();
            this.btnOrtPriority1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCircular
            // 
            this.lblCircular.AutoSize = true;
            this.lblCircular.Location = new System.Drawing.Point(16, 9);
            this.lblCircular.Name = "lblCircular";
            this.lblCircular.Size = new System.Drawing.Size(89, 14);
            this.lblCircular.TabIndex = 0;
            this.lblCircular.Text = "Dairesel Kuyruk";
            // 
            // lblOrtCircular
            // 
            this.lblOrtCircular.AutoSize = true;
            this.lblOrtCircular.Location = new System.Drawing.Point(16, 383);
            this.lblOrtCircular.Name = "lblOrtCircular";
            this.lblOrtCircular.Size = new System.Drawing.Size(82, 14);
            this.lblOrtCircular.TabIndex = 2;
            this.lblOrtCircular.Text = "Ortalama Süre:";
            // 
            // txtOrtSureCircular
            // 
            this.txtOrtSureCircular.Location = new System.Drawing.Point(104, 380);
            this.txtOrtSureCircular.Name = "txtOrtSureCircular";
            this.txtOrtSureCircular.Size = new System.Drawing.Size(49, 22);
            this.txtOrtSureCircular.TabIndex = 3;
            // 
            // btnOrtSureCircular
            // 
            this.btnOrtSureCircular.Location = new System.Drawing.Point(163, 379);
            this.btnOrtSureCircular.Name = "btnOrtSureCircular";
            this.btnOrtSureCircular.Size = new System.Drawing.Size(71, 23);
            this.btnOrtSureCircular.TabIndex = 4;
            this.btnOrtSureCircular.Text = "Süre Hesapla";
            this.btnOrtSureCircular.UseVisualStyleBackColor = true;
            this.btnOrtSureCircular.Click += new System.EventHandler(this.btnOrtSureCircular_Click);
            // 
            // BtnMusteri
            // 
            this.BtnMusteri.Location = new System.Drawing.Point(19, 23);
            this.BtnMusteri.Name = "BtnMusteri";
            this.BtnMusteri.Size = new System.Drawing.Size(94, 23);
            this.BtnMusteri.TabIndex = 5;
            this.BtnMusteri.Text = "Müşteri Ekle";
            this.BtnMusteri.UseVisualStyleBackColor = true;
            this.BtnMusteri.Click += new System.EventHandler(this.BtnMusteri_Click);
            // 
            // txtCircular
            // 
            this.txtCircular.Location = new System.Drawing.Point(19, 53);
            this.txtCircular.Multiline = true;
            this.txtCircular.Name = "txtCircular";
            this.txtCircular.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCircular.Size = new System.Drawing.Size(215, 320);
            this.txtCircular.TabIndex = 6;
            // 
            // lblPriority1
            // 
            this.lblPriority1.AutoSize = true;
            this.lblPriority1.Location = new System.Drawing.Point(254, 9);
            this.lblPriority1.Name = "lblPriority1";
            this.lblPriority1.Size = new System.Drawing.Size(192, 14);
            this.lblPriority1.TabIndex = 7;
            this.lblPriority1.Text = "Öncelikli Kuyruk(Küçükten Büyüğe)";
            // 
            // btnMusteri2
            // 
            this.btnMusteri2.Location = new System.Drawing.Point(257, 24);
            this.btnMusteri2.Name = "btnMusteri2";
            this.btnMusteri2.Size = new System.Drawing.Size(93, 23);
            this.btnMusteri2.TabIndex = 8;
            this.btnMusteri2.Text = "Sırala";
            this.btnMusteri2.UseVisualStyleBackColor = true;
            this.btnMusteri2.Click += new System.EventHandler(this.btnMusteri2_Click);
            // 
            // txtPriority1
            // 
            this.txtPriority1.Location = new System.Drawing.Point(259, 53);
            this.txtPriority1.Multiline = true;
            this.txtPriority1.Name = "txtPriority1";
            this.txtPriority1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPriority1.Size = new System.Drawing.Size(189, 319);
            this.txtPriority1.TabIndex = 9;
            // 
            // btnOrtPriority
            // 
            this.btnOrtPriority.Location = new System.Drawing.Point(937, 379);
            this.btnOrtPriority.Name = "btnOrtPriority";
            this.btnOrtPriority.Size = new System.Drawing.Size(127, 23);
            this.btnOrtPriority.TabIndex = 18;
            this.btnOrtPriority.Text = "Süre Hesapla";
            this.btnOrtPriority.UseVisualStyleBackColor = true;
            this.btnOrtPriority.Click += new System.EventHandler(this.btnOrtPriority_Click);
            // 
            // txtOrtPriority2
            // 
            this.txtOrtPriority2.Location = new System.Drawing.Point(770, 380);
            this.txtOrtPriority2.Name = "txtOrtPriority2";
            this.txtOrtPriority2.Size = new System.Drawing.Size(161, 22);
            this.txtOrtPriority2.TabIndex = 17;
            // 
            // lblOrtPriority2
            // 
            this.lblOrtPriority2.AutoSize = true;
            this.lblOrtPriority2.Location = new System.Drawing.Point(682, 383);
            this.lblOrtPriority2.Name = "lblOrtPriority2";
            this.lblOrtPriority2.Size = new System.Drawing.Size(82, 14);
            this.lblOrtPriority2.TabIndex = 16;
            this.lblOrtPriority2.Text = "Ortalama Süre:";
            // 
            // txtPriority2
            // 
            this.txtPriority2.Location = new System.Drawing.Point(671, 52);
            this.txtPriority2.Multiline = true;
            this.txtPriority2.Name = "txtPriority2";
            this.txtPriority2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPriority2.Size = new System.Drawing.Size(189, 322);
            this.txtPriority2.TabIndex = 15;
            // 
            // btnMusteri3
            // 
            this.btnMusteri3.Location = new System.Drawing.Point(671, 24);
            this.btnMusteri3.Name = "btnMusteri3";
            this.btnMusteri3.Size = new System.Drawing.Size(93, 23);
            this.btnMusteri3.TabIndex = 14;
            this.btnMusteri3.Text = "Sırala";
            this.btnMusteri3.UseVisualStyleBackColor = true;
            this.btnMusteri3.Click += new System.EventHandler(this.btnMusteri3_Click);
            // 
            // lblPriority2
            // 
            this.lblPriority2.AutoSize = true;
            this.lblPriority2.Location = new System.Drawing.Point(668, 6);
            this.lblPriority2.Name = "lblPriority2";
            this.lblPriority2.Size = new System.Drawing.Size(192, 14);
            this.lblPriority2.TabIndex = 13;
            this.lblPriority2.Text = "Öncelikli Kuyruk(Büyükten Küçüğe)";
            // 
            // btnKisalan1
            // 
            this.btnKisalan1.Location = new System.Drawing.Point(466, 24);
            this.btnKisalan1.Name = "btnKisalan1";
            this.btnKisalan1.Size = new System.Drawing.Size(182, 23);
            this.btnKisalan1.TabIndex = 19;
            this.btnKisalan1.Text = "Kısalan Süreleri Bul";
            this.btnKisalan1.UseVisualStyleBackColor = true;
            this.btnKisalan1.Click += new System.EventHandler(this.btnKisalan1_Click);
            // 
            // txtKisalan1
            // 
            this.txtKisalan1.Location = new System.Drawing.Point(466, 53);
            this.txtKisalan1.Multiline = true;
            this.txtKisalan1.Name = "txtKisalan1";
            this.txtKisalan1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKisalan1.Size = new System.Drawing.Size(182, 321);
            this.txtKisalan1.TabIndex = 20;
            // 
            // txtKisalan2
            // 
            this.txtKisalan2.Location = new System.Drawing.Point(882, 52);
            this.txtKisalan2.Multiline = true;
            this.txtKisalan2.Name = "txtKisalan2";
            this.txtKisalan2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKisalan2.Size = new System.Drawing.Size(182, 322);
            this.txtKisalan2.TabIndex = 22;
            // 
            // btnKisalan2
            // 
            this.btnKisalan2.Location = new System.Drawing.Point(882, 23);
            this.btnKisalan2.Name = "btnKisalan2";
            this.btnKisalan2.Size = new System.Drawing.Size(182, 23);
            this.btnKisalan2.TabIndex = 21;
            this.btnKisalan2.Text = "Kısalan Süreleri Bul";
            this.btnKisalan2.UseVisualStyleBackColor = true;
            this.btnKisalan2.Click += new System.EventHandler(this.btnKisalan2_Click);
            // 
            // lblOrt2
            // 
            this.lblOrt2.AutoSize = true;
            this.lblOrt2.Location = new System.Drawing.Point(254, 383);
            this.lblOrt2.Name = "lblOrt2";
            this.lblOrt2.Size = new System.Drawing.Size(82, 14);
            this.lblOrt2.TabIndex = 10;
            this.lblOrt2.Text = "Ortalama Süre:";
            // 
            // txtOrtPriority1
            // 
            this.txtOrtPriority1.Location = new System.Drawing.Point(342, 380);
            this.txtOrtPriority1.Name = "txtOrtPriority1";
            this.txtOrtPriority1.Size = new System.Drawing.Size(188, 22);
            this.txtOrtPriority1.TabIndex = 11;
            // 
            // btnOrtPriority1
            // 
            this.btnOrtPriority1.Location = new System.Drawing.Point(536, 379);
            this.btnOrtPriority1.Name = "btnOrtPriority1";
            this.btnOrtPriority1.Size = new System.Drawing.Size(112, 23);
            this.btnOrtPriority1.TabIndex = 12;
            this.btnOrtPriority1.Text = "Süre Hesapla";
            this.btnOrtPriority1.UseVisualStyleBackColor = true;
            this.btnOrtPriority1.Click += new System.EventHandler(this.btnOrtPriority1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 406);
            this.Controls.Add(this.txtKisalan2);
            this.Controls.Add(this.btnKisalan2);
            this.Controls.Add(this.txtKisalan1);
            this.Controls.Add(this.btnKisalan1);
            this.Controls.Add(this.btnOrtPriority);
            this.Controls.Add(this.txtOrtPriority2);
            this.Controls.Add(this.lblOrtPriority2);
            this.Controls.Add(this.txtPriority2);
            this.Controls.Add(this.btnMusteri3);
            this.Controls.Add(this.lblPriority2);
            this.Controls.Add(this.btnOrtPriority1);
            this.Controls.Add(this.txtOrtPriority1);
            this.Controls.Add(this.lblOrt2);
            this.Controls.Add(this.txtPriority1);
            this.Controls.Add(this.btnMusteri2);
            this.Controls.Add(this.lblPriority1);
            this.Controls.Add(this.txtCircular);
            this.Controls.Add(this.BtnMusteri);
            this.Controls.Add(this.btnOrtSureCircular);
            this.Controls.Add(this.txtOrtSureCircular);
            this.Controls.Add(this.lblOrtCircular);
            this.Controls.Add(this.lblCircular);
            this.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCircular;
        private System.Windows.Forms.Label lblOrtCircular;
        private System.Windows.Forms.TextBox txtOrtSureCircular;
        private System.Windows.Forms.Button btnOrtSureCircular;
        private System.Windows.Forms.Button BtnMusteri;
        private System.Windows.Forms.TextBox txtCircular;
        private System.Windows.Forms.Label lblPriority1;
        private System.Windows.Forms.Button btnMusteri2;
        private System.Windows.Forms.TextBox txtPriority1;
        private System.Windows.Forms.Button btnOrtPriority;
        private System.Windows.Forms.TextBox txtOrtPriority2;
        private System.Windows.Forms.Label lblOrtPriority2;
        private System.Windows.Forms.TextBox txtPriority2;
        private System.Windows.Forms.Button btnMusteri3;
        private System.Windows.Forms.Label lblPriority2;
        private System.Windows.Forms.Button btnKisalan1;
        private System.Windows.Forms.TextBox txtKisalan1;
        private System.Windows.Forms.TextBox txtKisalan2;
        private System.Windows.Forms.Button btnKisalan2;
        private System.Windows.Forms.Label lblOrt2;
        private System.Windows.Forms.TextBox txtOrtPriority1;
        private System.Windows.Forms.Button btnOrtPriority1;
    }
}

