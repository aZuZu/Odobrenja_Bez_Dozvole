/*
 * Created by SharpDevelop.
 * User: azuzu
 * Date: 15.10.2015.
 * Time: 21:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace Odobrenja_Bez_Dozvole
{
	/// <summary>
	/// Description of LogIn.
	/// </summary>
	public partial class LogIn : Form
	{
		
		public LogIn()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Login_OK()
		{
			File.WriteAllText(MainForm.Power_User_File,"EP");
			this.DialogResult = DialogResult.OK;
			this.Close();			
		}
		void Login_Failed(bool Show_Message, DialogResult D_Result)
		{
			if ( Show_Message )
			{
				MessageBox.Show("Kriva lozinka!", "Info!", MessageBoxButtons.OK);
			}
			this.DialogResult = D_Result;
			this.Close();
		}
		
		
		void Button_LogIn_OkClick(object sender, EventArgs e)
		{
			if ( textBox_LogIn_Item.Text == "Elitna prva" )
			{
				Login_OK();
			} else {
				Login_Failed(true, DialogResult.None);
			}
		}
		void Button_LogIn_CancelClick(object sender, EventArgs e)
		{
			Login_Failed(false, DialogResult.Cancel);
		}
		void TextBox_LogIn_ItemKeyDown(object sender, KeyEventArgs e)
		{
			if ( e.KeyCode == Keys.Enter )
			{
				if ( textBox_LogIn_Item.Text == "Elitna prva" )
				{
					Login_OK();
				} else {
					Login_Failed(true, DialogResult.None);
				}
			}
		}
	}
}
