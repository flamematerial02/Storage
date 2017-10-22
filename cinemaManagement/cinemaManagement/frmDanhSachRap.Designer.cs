/*
 * User: Administrator
 * Date: 10/13/2017
 *
 */
namespace cinemaManagement
{
	partial class HTRap
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnTimKiem = new System.Windows.Forms.Button();
			this.tbTenRap = new System.Windows.Forms.TextBox();
			this.tbMaRap = new System.Windows.Forms.TextBox();
			this.lblTenRap = new System.Windows.Forms.Label();
			this.lblMaRap = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.AutoSize = true;
			this.groupBox1.Controls.Add(this.btnTimKiem);
			this.groupBox1.Controls.Add(this.tbTenRap);
			this.groupBox1.Controls.Add(this.tbMaRap);
			this.groupBox1.Controls.Add(this.lblTenRap);
			this.groupBox1.Controls.Add(this.lblMaRap);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(180, 130);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tìm kiếm";
			// 
			// btnTimKiem
			// 
			this.btnTimKiem.Location = new System.Drawing.Point(99, 88);
			this.btnTimKiem.Name = "btnTimKiem";
			this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
			this.btnTimKiem.TabIndex = 4;
			this.btnTimKiem.Text = "Tìm Kiếm";
			this.btnTimKiem.UseVisualStyleBackColor = true;
			// 
			// tbTenRap
			// 
			this.tbTenRap.Location = new System.Drawing.Point(50, 47);
			this.tbTenRap.Name = "tbTenRap";
			this.tbTenRap.Size = new System.Drawing.Size(100, 20);
			this.tbTenRap.TabIndex = 3;
			// 
			// tbMaRap
			// 
			this.tbMaRap.Location = new System.Drawing.Point(50, 20);
			this.tbMaRap.Name = "tbMaRap";
			this.tbMaRap.Size = new System.Drawing.Size(100, 20);
			this.tbMaRap.TabIndex = 2;
			// 
			// lblTenRap
			// 
			this.lblTenRap.AutoSize = true;
			this.lblTenRap.Location = new System.Drawing.Point(7, 50);
			this.lblTenRap.Name = "lblTenRap";
			this.lblTenRap.Size = new System.Drawing.Size(26, 13);
			this.lblTenRap.TabIndex = 1;
			this.lblTenRap.Text = "Tên";
			// 
			// lblMaRap
			// 
			this.lblMaRap.AutoSize = true;
			this.lblMaRap.Location = new System.Drawing.Point(6, 23);
			this.lblMaRap.Name = "lblMaRap";
			this.lblMaRap.Size = new System.Drawing.Size(36, 13);
			this.lblMaRap.TabIndex = 0;
			this.lblMaRap.Text = "Mã số";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.richTextBox1);
			this.groupBox2.Location = new System.Drawing.Point(198, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(431, 338);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Danh sách";
			this.groupBox2.Enter += new System.EventHandler(this.GroupBox2Enter);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(113, 116);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(156, 159);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "- Mã rạp\n- Tên đầy đủ\n- Địa chỉ\n- Điện thoại\n- Số phòng\n- Tổng số ghế";
			// 
			// HTRap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(641, 362);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "HTRap";
			this.Text = "Danh sách Phim";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label lblMaRap;
		private System.Windows.Forms.Label lblTenRap;
		private System.Windows.Forms.TextBox tbMaRap;
		private System.Windows.Forms.TextBox tbTenRap;
		private System.Windows.Forms.Button btnTimKiem;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
