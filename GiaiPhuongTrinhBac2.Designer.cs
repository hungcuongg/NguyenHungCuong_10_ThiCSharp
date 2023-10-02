namespace NguyenHungCuong_30_ThiCSharp
{
    partial class GiaiPhuongTrinhBac2
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblPT = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsoa = new System.Windows.Forms.TextBox();
            this.txtsob = new System.Windows.Forms.TextBox();
            this.txtsoc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.trbsob = new System.Windows.Forms.TrackBar();
            this.trbsoc = new System.Windows.Forms.TrackBar();
            this.trbsoa = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblkq = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.trbsob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbsoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbsoa)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(76, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(561, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "ỨNG DỤNG GIẢI PHƯƠNG TRÌNH BẬC 2";
            // 
            // lblPT
            // 
            this.lblPT.AutoSize = true;
            this.lblPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPT.ForeColor = System.Drawing.Color.Red;
            this.lblPT.Location = new System.Drawing.Point(232, 40);
            this.lblPT.Name = "lblPT";
            this.lblPT.Size = new System.Drawing.Size(220, 31);
            this.lblPT.TabIndex = 1;
            this.lblPT.Text = "ax2 + bx + c = 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập a";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhập b";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nhập c";
            // 
            // txtsoa
            // 
            this.txtsoa.Location = new System.Drawing.Point(121, 113);
            this.txtsoa.Name = "txtsoa";
            this.txtsoa.Size = new System.Drawing.Size(113, 20);
            this.txtsoa.TabIndex = 5;
            // 
            // txtsob
            // 
            this.txtsob.Location = new System.Drawing.Point(121, 170);
            this.txtsob.Name = "txtsob";
            this.txtsob.Size = new System.Drawing.Size(113, 20);
            this.txtsob.TabIndex = 6;
            // 
            // txtsoc
            // 
            this.txtsoc.Location = new System.Drawing.Point(121, 227);
            this.txtsoc.Name = "txtsoc";
            this.txtsoc.Size = new System.Drawing.Size(113, 20);
            this.txtsoc.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(238, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 58);
            this.button1.TabIndex = 8;
            this.button1.Text = "GIẢI PHƯƠNG TRÌNH";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trbsob
            // 
            this.trbsob.Location = new System.Drawing.Point(262, 165);
            this.trbsob.Minimum = -10;
            this.trbsob.Name = "trbsob";
            this.trbsob.Size = new System.Drawing.Size(351, 45);
            this.trbsob.TabIndex = 11;
            this.trbsob.Scroll += new System.EventHandler(this.trbsob_Scroll);
            // 
            // trbsoc
            // 
            this.trbsoc.Location = new System.Drawing.Point(262, 227);
            this.trbsoc.Minimum = -10;
            this.trbsoc.Name = "trbsoc";
            this.trbsoc.Size = new System.Drawing.Size(351, 45);
            this.trbsoc.TabIndex = 12;
            this.trbsoc.Scroll += new System.EventHandler(this.trbsoc_Scroll);
            // 
            // trbsoa
            // 
            this.trbsoa.Location = new System.Drawing.Point(262, 108);
            this.trbsoa.Minimum = -10;
            this.trbsoa.Name = "trbsoa";
            this.trbsoa.Size = new System.Drawing.Size(351, 45);
            this.trbsoa.TabIndex = 13;
            this.trbsoa.Scroll += new System.EventHandler(this.trbsoa_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.lblkq);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 359);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 166);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "";
            this.groupBox1.Text = "KẾT QUẢ";
            // 
            // lblkq
            // 
            this.lblkq.AutoSize = true;
            this.lblkq.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkq.Location = new System.Drawing.Point(51, 40);
            this.lblkq.Name = "lblkq";
            this.lblkq.Size = new System.Drawing.Size(331, 33);
            this.lblkq.TabIndex = 0;
            this.lblkq.Text = "Hãy bấm giải phương trình";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Lime;
            this.progressBar1.Location = new System.Drawing.Point(82, 78);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(531, 23);
            this.progressBar1.TabIndex = 16;
            // 
            // GiaiPhuongTrinhBac2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(685, 566);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.trbsoa);
            this.Controls.Add(this.trbsoc);
            this.Controls.Add(this.trbsob);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtsoc);
            this.Controls.Add(this.txtsob);
            this.Controls.Add(this.txtsoa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPT);
            this.Controls.Add(this.label1);
            this.Name = "GiaiPhuongTrinhBac2";
            this.Text = "GiaiPhuongTrinhBac2";
            this.Load += new System.EventHandler(this.GiaiPhuongTrinhBac2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trbsob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbsoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbsoa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsoa;
        private System.Windows.Forms.TextBox txtsob;
        private System.Windows.Forms.TextBox txtsoc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar trbsob;
        private System.Windows.Forms.TrackBar trbsoc;
        private System.Windows.Forms.TrackBar trbsoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblkq;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}