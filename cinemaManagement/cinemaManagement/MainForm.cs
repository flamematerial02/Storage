/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 10/11/2017
 * Time: 9:52 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace cinemaManagement
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void Button1Click(object sender, EventArgs e)
		{
			if (!CheckExistForm("frmDanhSachPhim"))
			{
			    	frmDanhSachPhim dsp = new frmDanhSachPhim();
			    	dsp.MdiParent = this;
			    	dsp.show();
			}
			else
			{
				ActiveChilForm("frmDanhSachPhim");
			}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			if (!CheckExistForm("frmDanhSachRap"))
			{
			    	frmDanhSachRap dsr = new frmDanhSachRap();
			    	dsr.MdiParent = this;
			    	dsr.show();
			}
			else
			{
				ActiveChilForm("frmDanhSachRap");
			}
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			if (!CheckExistForm("frmDanhSachPhim"))
			{
			    	frmDanhSachBuoiChieu dsbc = new frmDanhSachBuoiChieu();
			    	dsbc.MdiParent = this;
			    	dsbc.show();
			}
			else
			{
				ActiveChilForm("frmDanhSachBuoiChieu");
			}
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			if (!CheckExistForm("frmDanhSachPhongChieu"))
			{
			    	frmDanhSachPhongChieu dspc = new frmDanhSachPhongChieu();
			    	dspc.MdiParent = this;
			    	dspc.show();
			}
			else
			{
				ActiveChilForm("frmDanhSachPhongChieu");
			}
		}
		
		void UpdateApplicationToolStripMenuItemClick(object sender, EventArgs e)
		{
			MessageBox.Show("There is no update available!", "Error", MessageBoxButton.OK, MessageBoxIcon.Asterisk);
		}
		
		void AboutToolStripMenuItemClick(object sender, EventArgs e)
		{
			StringBuilder about = new StringBuilder();
            about.AppendLine("     CINEMA MANAGEMENT v1.1     \n");
            about.AppendLine("   - Giáo viên hướng dẫn: ");
            about.AppendLine("               ThS. Nguyễn Thu Hường");
            about.AppendLine("   - Sinh viên thực hiện: ");
            about.AppendLine("				Vương Sỹ Sơn");
            about.AppendLine("				Đặng Tiến Mạnh");
            about.AppendLine("				Trần Đức Huy");
            about.AppendLine("				Nguyễn Văn Thảo");
            about.AppendLine("    Liên hệ: ");
            about.AppendLine("          Lớp CNTT2 - K56, Đại Học GTVT");

            MessageBox.Show(about.ToString(), "About", MessageBoxButtons.OK, MessageBoxIcon.Information);			
		}
		
		void BtnExitClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void exitToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
