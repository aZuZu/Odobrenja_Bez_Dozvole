/*
 * Created by SharpDevelop.
 * User: azuzu
 * Date: 15.10.2015.
 * Time: 21:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Odobrenja_Bez_Dozvole
{
	partial class LogIn
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
			this.label_Info1 = new System.Windows.Forms.Label();
			this.textBox_LogIn_Item = new System.Windows.Forms.TextBox();
			this.button_LogIn_Ok = new System.Windows.Forms.Button();
			this.button_LogIn_Cancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label_Info1
			// 
			this.label_Info1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label_Info1.Location = new System.Drawing.Point(24, 19);
			this.label_Info1.Name = "label_Info1";
			this.label_Info1.Size = new System.Drawing.Size(100, 19);
			this.label_Info1.TabIndex = 0;
			this.label_Info1.Text = "Prijava u editor:";
			// 
			// textBox_LogIn_Item
			// 
			this.textBox_LogIn_Item.Location = new System.Drawing.Point(24, 41);
			this.textBox_LogIn_Item.Name = "textBox_LogIn_Item";
			this.textBox_LogIn_Item.PasswordChar = '*';
			this.textBox_LogIn_Item.Size = new System.Drawing.Size(218, 20);
			this.textBox_LogIn_Item.TabIndex = 1;
			this.textBox_LogIn_Item.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_LogIn_ItemKeyDown);
			// 
			// button_LogIn_Ok
			// 
			this.button_LogIn_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button_LogIn_Ok.Location = new System.Drawing.Point(24, 67);
			this.button_LogIn_Ok.Name = "button_LogIn_Ok";
			this.button_LogIn_Ok.Size = new System.Drawing.Size(100, 23);
			this.button_LogIn_Ok.TabIndex = 2;
			this.button_LogIn_Ok.Text = "Prijava";
			this.button_LogIn_Ok.UseVisualStyleBackColor = true;
			this.button_LogIn_Ok.Click += new System.EventHandler(this.Button_LogIn_OkClick);
			// 
			// button_LogIn_Cancel
			// 
			this.button_LogIn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button_LogIn_Cancel.Location = new System.Drawing.Point(142, 67);
			this.button_LogIn_Cancel.Name = "button_LogIn_Cancel";
			this.button_LogIn_Cancel.Size = new System.Drawing.Size(100, 23);
			this.button_LogIn_Cancel.TabIndex = 3;
			this.button_LogIn_Cancel.Text = "Odustani";
			this.button_LogIn_Cancel.UseVisualStyleBackColor = true;
			this.button_LogIn_Cancel.Click += new System.EventHandler(this.Button_LogIn_CancelClick);
			// 
			// LogIn
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(267, 105);
			this.ControlBox = false;
			this.Controls.Add(this.button_LogIn_Cancel);
			this.Controls.Add(this.button_LogIn_Ok);
			this.Controls.Add(this.textBox_LogIn_Item);
			this.Controls.Add(this.label_Info1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LogIn";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LogIn";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button_LogIn_Cancel;
		private System.Windows.Forms.Button button_LogIn_Ok;
		private System.Windows.Forms.TextBox textBox_LogIn_Item;
		private System.Windows.Forms.Label label_Info1;
	}
}
