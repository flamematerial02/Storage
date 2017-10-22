using System.Text;
/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 10/11/2017
 * Time: 9:52 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace cinemaManagement
{
	partial class MainForm
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
			this.btnExit = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuUsers = new System.Windows.Forms.ToolStripMenuItem();
			this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.updateApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnDanhSach = new System.Windows.Forms.Button();
			this.btnHeThongRap = new System.Windows.Forms.Button();
			this.btnBuoiChieu = new System.Windows.Forms.Button();
			this.btnPhongChieu = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(258, 184);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 0;
			this.btnExit.Text = "Thoát";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.BtnExitClick);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.mnuFile,
									this.mnuUsers,
									this.mnuHelp});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(345, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// mnuFile
			// 
			this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.loginToolStripMenuItem,
									this.saveToolStripMenuItem,
									this.exitToolStripMenuItem});
			this.mnuFile.Name = "mnuFile";
			this.mnuFile.Size = new System.Drawing.Size(37, 20);
			this.mnuFile.Text = "File";
			// 
			// loginToolStripMenuItem
			// 
			this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
			this.loginToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.loginToolStripMenuItem.Text = "Đăng nhập";
			this.loginToolStripMenuItem.Click += new System.EventHandler(this.ĐăngNhậpToolStripMenuItemClick);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.saveToolStripMenuItem.Text = "Lưu";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.exitToolStripMenuItem.Text = "Thoát";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ThoátToolStripMenuItemClick);
			// 
			// mnuUsers
			// 
			this.mnuUsers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.employeeToolStripMenuItem});
			this.mnuUsers.Name = "mnuUsers";
			this.mnuUsers.Size = new System.Drawing.Size(115, 20);
			this.mnuUsers.Text = "Quản lý nhân viên";
			// 
			// employeeToolStripMenuItem
			// 
			this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
			this.employeeToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
			this.employeeToolStripMenuItem.Text = "Danh sách nhân viên";
			// 
			// mnuHelp
			// 
			this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.helpToolStripMenuItem1,
									this.aboutToolStripMenuItem,
									this.updateApplicationToolStripMenuItem});
			this.mnuHelp.Name = "mnuHelp";
			this.mnuHelp.Size = new System.Drawing.Size(44, 20);
			this.mnuHelp.Text = "Help";
			// 
			// helpToolStripMenuItem1
			// 
			this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
			this.helpToolStripMenuItem1.Size = new System.Drawing.Size(176, 22);
			this.helpToolStripMenuItem1.Text = "Help Topic";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.aboutToolStripMenuItem.Text = "About...";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
			// 
			// updateApplicationToolStripMenuItem
			// 
			this.updateApplicationToolStripMenuItem.Name = "updateApplicationToolStripMenuItem";
			this.updateApplicationToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.updateApplicationToolStripMenuItem.Text = "Update Application";
			this.updateApplicationToolStripMenuItem.Click += new System.EventHandler(this.UpdateApplicationToolStripMenuItemClick);
			// 
			// btnDanhSach
			// 
			this.btnDanhSach.Location = new System.Drawing.Point(12, 58);
			this.btnDanhSach.Name = "btnDanhSach";
			this.btnDanhSach.Size = new System.Drawing.Size(141, 40);
			this.btnDanhSach.TabIndex = 2;
			this.btnDanhSach.Text = "Danh Sách Phim";
			this.btnDanhSach.UseVisualStyleBackColor = true;
			this.btnDanhSach.Click += new System.EventHandler(this.Button1Click);
			// 
			// btnHeThongRap
			// 
			this.btnHeThongRap.Location = new System.Drawing.Point(191, 58);
			this.btnHeThongRap.Name = "btnHeThongRap";
			this.btnHeThongRap.Size = new System.Drawing.Size(142, 40);
			this.btnHeThongRap.TabIndex = 3;
			this.btnHeThongRap.Text = "Hệ Thống Rạp";
			this.btnHeThongRap.UseVisualStyleBackColor = true;
			this.btnHeThongRap.Click += new System.EventHandler(this.Button2Click);
			// 
			// btnBuoiChieu
			// 
			this.btnBuoiChieu.Location = new System.Drawing.Point(12, 104);
			this.btnBuoiChieu.Name = "btnBuoiChieu";
			this.btnBuoiChieu.Size = new System.Drawing.Size(141, 40);
			this.btnBuoiChieu.TabIndex = 4;
			this.btnBuoiChieu.Text = "Danh Sách Buổi Chiếu";
			this.btnBuoiChieu.UseVisualStyleBackColor = true;
			this.btnBuoiChieu.Click += new System.EventHandler(this.Button3Click);
			// 
			// btnPhongChieu
			// 
			this.btnPhongChieu.Location = new System.Drawing.Point(191, 105);
			this.btnPhongChieu.Name = "btnPhongChieu";
			this.btnPhongChieu.Size = new System.Drawing.Size(141, 39);
			this.btnPhongChieu.TabIndex = 5;
			this.btnPhongChieu.Text = "Danh Sách Phòng Chiếu";
			this.btnPhongChieu.UseVisualStyleBackColor = true;
			this.btnPhongChieu.Click += new System.EventHandler(this.Button4Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(345, 219);
			this.Controls.Add(this.btnPhongChieu);
			this.Controls.Add(this.btnBuoiChieu);
			this.Controls.Add(this.btnHeThongRap);
			this.Controls.Add(this.btnDanhSach);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cinema Manager";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
		private System.Windows.Forms.Button btnPhongChieu;
		private System.Windows.Forms.Button btnBuoiChieu;
		private System.Windows.Forms.ToolStripMenuItem updateApplicationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mnuUsers;
		private System.Windows.Forms.Button btnHeThongRap;
		private System.Windows.Forms.Button btnDanhSach;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mnuHelp;
		private System.Windows.Forms.ToolStripMenuItem mnuFile;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Button btnExit;
		
	}
}
