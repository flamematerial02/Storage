/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 10/11/2017
 * Time: 10:48 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace cinemaManagement
{
	partial class filmList
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cbDir = new System.Windows.Forms.ComboBox();
			this.lblDir = new System.Windows.Forms.Label();
			this.lblType = new System.Windows.Forms.Label();
			this.cbType = new System.Windows.Forms.ComboBox();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Location = new System.Drawing.Point(12, 161);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(488, 154);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "List";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.comboBox1);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.cbDir);
			this.groupBox2.Controls.Add(this.lblDir);
			this.groupBox2.Controls.Add(this.lblType);
			this.groupBox2.Controls.Add(this.cbType);
			this.groupBox2.Location = new System.Drawing.Point(12, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(670, 58);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Tìm kiếm";
			this.groupBox2.Enter += new System.EventHandler(this.GroupBox2Enter);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
									"2017"});
			this.comboBox1.Location = new System.Drawing.Point(543, 19);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 5;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(460, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "Năm sản xuất";
			// 
			// cbDir
			// 
			this.cbDir.FormattingEnabled = true;
			this.cbDir.Location = new System.Drawing.Point(305, 19);
			this.cbDir.Name = "cbDir";
			this.cbDir.Size = new System.Drawing.Size(121, 21);
			this.cbDir.TabIndex = 3;
			// 
			// lblDir
			// 
			this.lblDir.Location = new System.Drawing.Point(241, 22);
			this.lblDir.Name = "lblDir";
			this.lblDir.Size = new System.Drawing.Size(58, 23);
			this.lblDir.TabIndex = 2;
			this.lblDir.Text = "Đạo diễn";
			this.lblDir.Click += new System.EventHandler(this.LblDirClick);
			// 
			// lblType
			// 
			this.lblType.Location = new System.Drawing.Point(7, 22);
			this.lblType.Name = "lblType";
			this.lblType.Size = new System.Drawing.Size(61, 23);
			this.lblType.TabIndex = 1;
			this.lblType.Text = "Thể loại";
			this.lblType.Click += new System.EventHandler(this.Label1Click);
			// 
			// cbType
			// 
			this.cbType.FormattingEnabled = true;
			this.cbType.Location = new System.Drawing.Point(74, 19);
			this.cbType.Name = "cbType";
			this.cbType.Size = new System.Drawing.Size(94, 21);
			this.cbType.TabIndex = 0;
			// 
			// filmList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(694, 327);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "filmList";
			this.Text = "Film List";
			this.Load += new System.EventHandler(this.FilmListLoad);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ComboBox cbDir;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label lblDir;
		private System.Windows.Forms.ComboBox cbType;
		private System.Windows.Forms.Label lblType;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
