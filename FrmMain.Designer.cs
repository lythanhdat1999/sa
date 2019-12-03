namespace Doancuoiky.View
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnHH = new System.Windows.Forms.Button();
            this.btnKH = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHH
            // 
            this.btnHH.BackColor = System.Drawing.Color.Lime;
            this.btnHH.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHH.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnHH.Location = new System.Drawing.Point(360, 56);
            this.btnHH.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnHH.Name = "btnHH";
            this.btnHH.Size = new System.Drawing.Size(212, 30);
            this.btnHH.TabIndex = 1;
            this.btnHH.Text = "Quản Lý Hàng Hóa";
            this.btnHH.UseVisualStyleBackColor = false;
            this.btnHH.Click += new System.EventHandler(this.btnHH_Click);
            // 
            // btnKH
            // 
            this.btnKH.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnKH.BackColor = System.Drawing.Color.Lime;
            this.btnKH.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKH.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnKH.Location = new System.Drawing.Point(50, 56);
            this.btnKH.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnKH.Name = "btnKH";
            this.btnKH.Size = new System.Drawing.Size(227, 30);
            this.btnKH.TabIndex = 2;
            this.btnKH.Text = "Quản lý Khách Hàng";
            this.btnKH.UseVisualStyleBackColor = false;
            this.btnKH.Click += new System.EventHandler(this.btnKH_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button1.Location = new System.Drawing.Point(641, 56);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Quản Lý Hóa Đơn";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(917, 143);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnKH);
            this.Controls.Add(this.btnHH);
            this.Font = new System.Drawing.Font("Elephant", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "FrmMain";
            this.Text = "Quản Lý ";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHH;
        private System.Windows.Forms.Button btnKH;
        private System.Windows.Forms.Button button1;
    }
}