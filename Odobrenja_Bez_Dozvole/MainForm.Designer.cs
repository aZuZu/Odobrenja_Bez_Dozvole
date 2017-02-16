/*
 * Created by SharpDevelop.
 * User: aZuZu
 * Date: 4.11.2015.
 * Time: 21:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Odobrenja_Bez_Dozvole
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
			this.components = new System.ComponentModel.Container();
			this.tV_OBD_Main = new System.Windows.Forms.TreeView();
			this.contextMenuStrip_Root = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItem_Add_Firm = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_Remove_Firm = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_Rename_Firm = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_Add_SubContractor = new System.Windows.Forms.ToolStripMenuItem();
			this.txtBox_Search_Item = new System.Windows.Forms.TextBox();
			this.Button_Search = new System.Windows.Forms.Button();
			this.tabControl_MO = new System.Windows.Forms.TabControl();
			this.tabPage_View = new System.Windows.Forms.TabPage();
			this.lbl_Vehicle_Status = new System.Windows.Forms.Label();
			this.lBox_Vehicles = new System.Windows.Forms.ListBox();
			this.lBox_Personnel = new System.Windows.Forms.ListBox();
			this.tabPage_Edit = new System.Windows.Forms.TabPage();
			this.txtBox_Vehicles = new System.Windows.Forms.TextBox();
			this.Button_Save = new System.Windows.Forms.Button();
			this.txtBox_Personnel = new System.Windows.Forms.TextBox();
			this.menuStrip_Menu = new System.Windows.Forms.MenuStrip();
			this.glavniMeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.podatkeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.izveziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.uveziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.oProgramuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip_Status = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.contextMenuStrip_Child = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItem_Remove_SubContractor = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_Rename_SubContractor = new System.Windows.Forms.ToolStripMenuItem();
			this.comboBox_Search_Results = new System.Windows.Forms.ComboBox();
			this.openFileDialog_List_Import = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog_List_Export = new System.Windows.Forms.SaveFileDialog();
			this.contextMenuStrip_Root.SuspendLayout();
			this.tabControl_MO.SuspendLayout();
			this.tabPage_View.SuspendLayout();
			this.tabPage_Edit.SuspendLayout();
			this.menuStrip_Menu.SuspendLayout();
			this.statusStrip_Status.SuspendLayout();
			this.contextMenuStrip_Child.SuspendLayout();
			this.SuspendLayout();
			// 
			// tV_OBD_Main
			// 
			this.tV_OBD_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tV_OBD_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.tV_OBD_Main.HideSelection = false;
			this.tV_OBD_Main.Location = new System.Drawing.Point(12, 116);
			this.tV_OBD_Main.Name = "tV_OBD_Main";
			this.tV_OBD_Main.Size = new System.Drawing.Size(240, 230);
			this.tV_OBD_Main.TabIndex = 0;
			this.tV_OBD_Main.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TV_OBD_MainAfterSelect);
			this.tV_OBD_Main.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TV_OBD_MainNodeMouseClick);
			// 
			// contextMenuStrip_Root
			// 
			this.contextMenuStrip_Root.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripMenuItem_Add_Firm,
									this.toolStripMenuItem_Remove_Firm,
									this.toolStripMenuItem_Rename_Firm,
									this.toolStripMenuItem_Add_SubContractor});
			this.contextMenuStrip_Root.Name = "contextMenuStrip_Mouse";
			this.contextMenuStrip_Root.Size = new System.Drawing.Size(188, 92);
			this.contextMenuStrip_Root.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ContextMenuStrip_RootItemClicked);
			// 
			// toolStripMenuItem_Add_Firm
			// 
			this.toolStripMenuItem_Add_Firm.Name = "toolStripMenuItem_Add_Firm";
			this.toolStripMenuItem_Add_Firm.Size = new System.Drawing.Size(187, 22);
			this.toolStripMenuItem_Add_Firm.Text = "Dodaj firmu ...";
			// 
			// toolStripMenuItem_Remove_Firm
			// 
			this.toolStripMenuItem_Remove_Firm.Name = "toolStripMenuItem_Remove_Firm";
			this.toolStripMenuItem_Remove_Firm.Size = new System.Drawing.Size(187, 22);
			this.toolStripMenuItem_Remove_Firm.Text = "Izbriši firmu ...";
			// 
			// toolStripMenuItem_Rename_Firm
			// 
			this.toolStripMenuItem_Rename_Firm.Name = "toolStripMenuItem_Rename_Firm";
			this.toolStripMenuItem_Rename_Firm.Size = new System.Drawing.Size(187, 22);
			this.toolStripMenuItem_Rename_Firm.Text = "Preimenuj firmu ...";
			// 
			// toolStripMenuItem_Add_SubContractor
			// 
			this.toolStripMenuItem_Add_SubContractor.Name = "toolStripMenuItem_Add_SubContractor";
			this.toolStripMenuItem_Add_SubContractor.Size = new System.Drawing.Size(187, 22);
			this.toolStripMenuItem_Add_SubContractor.Text = "Dodaj podizvođača ...";
			// 
			// txtBox_Search_Item
			// 
			this.txtBox_Search_Item.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtBox_Search_Item.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txtBox_Search_Item.Location = new System.Drawing.Point(12, 57);
			this.txtBox_Search_Item.Name = "txtBox_Search_Item";
			this.txtBox_Search_Item.Size = new System.Drawing.Size(176, 22);
			this.txtBox_Search_Item.TabIndex = 2;
			this.txtBox_Search_Item.Click += new System.EventHandler(this.TxtBox_Search_ItemClick);
			this.txtBox_Search_Item.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBox_Search_ItemKeyDown);
			// 
			// Button_Search
			// 
			this.Button_Search.Location = new System.Drawing.Point(194, 56);
			this.Button_Search.Name = "Button_Search";
			this.Button_Search.Size = new System.Drawing.Size(58, 22);
			this.Button_Search.TabIndex = 3;
			this.Button_Search.Text = "Traži";
			this.Button_Search.UseVisualStyleBackColor = true;
			this.Button_Search.Click += new System.EventHandler(this.Button_SearchClick);
			// 
			// tabControl_MO
			// 
			this.tabControl_MO.Appearance = System.Windows.Forms.TabAppearance.Buttons;
			this.tabControl_MO.Controls.Add(this.tabPage_View);
			this.tabControl_MO.Controls.Add(this.tabPage_Edit);
			this.tabControl_MO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.tabControl_MO.Location = new System.Drawing.Point(272, 58);
			this.tabControl_MO.Multiline = true;
			this.tabControl_MO.Name = "tabControl_MO";
			this.tabControl_MO.SelectedIndex = 0;
			this.tabControl_MO.Size = new System.Drawing.Size(328, 288);
			this.tabControl_MO.TabIndex = 4;
			this.tabControl_MO.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControl_MOSelected);
			// 
			// tabPage_View
			// 
			this.tabPage_View.Controls.Add(this.lbl_Vehicle_Status);
			this.tabPage_View.Controls.Add(this.lBox_Vehicles);
			this.tabPage_View.Controls.Add(this.lBox_Personnel);
			this.tabPage_View.Location = new System.Drawing.Point(4, 27);
			this.tabPage_View.Name = "tabPage_View";
			this.tabPage_View.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_View.Size = new System.Drawing.Size(320, 257);
			this.tabPage_View.TabIndex = 0;
			this.tabPage_View.Text = "Pregledavanje";
			this.tabPage_View.UseVisualStyleBackColor = true;
			// 
			// lbl_Vehicle_Status
			// 
			this.lbl_Vehicle_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lbl_Vehicle_Status.Location = new System.Drawing.Point(6, 225);
			this.lbl_Vehicle_Status.Name = "lbl_Vehicle_Status";
			this.lbl_Vehicle_Status.Size = new System.Drawing.Size(308, 23);
			this.lbl_Vehicle_Status.TabIndex = 2;
			this.lbl_Vehicle_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lBox_Vehicles
			// 
			this.lBox_Vehicles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lBox_Vehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lBox_Vehicles.FormattingEnabled = true;
			this.lBox_Vehicles.ItemHeight = 16;
			this.lBox_Vehicles.Location = new System.Drawing.Point(206, 6);
			this.lBox_Vehicles.Name = "lBox_Vehicles";
			this.lBox_Vehicles.ScrollAlwaysVisible = true;
			this.lBox_Vehicles.Size = new System.Drawing.Size(108, 210);
			this.lBox_Vehicles.TabIndex = 1;
			this.lBox_Vehicles.SelectedValueChanged += new System.EventHandler(this.LBox_VehiclesSelectedValueChanged);
			// 
			// lBox_Personnel
			// 
			this.lBox_Personnel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lBox_Personnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lBox_Personnel.FormattingEnabled = true;
			this.lBox_Personnel.ItemHeight = 16;
			this.lBox_Personnel.Location = new System.Drawing.Point(6, 6);
			this.lBox_Personnel.Name = "lBox_Personnel";
			this.lBox_Personnel.ScrollAlwaysVisible = true;
			this.lBox_Personnel.Size = new System.Drawing.Size(194, 210);
			this.lBox_Personnel.TabIndex = 0;
			// 
			// tabPage_Edit
			// 
			this.tabPage_Edit.Controls.Add(this.txtBox_Vehicles);
			this.tabPage_Edit.Controls.Add(this.Button_Save);
			this.tabPage_Edit.Controls.Add(this.txtBox_Personnel);
			this.tabPage_Edit.Location = new System.Drawing.Point(4, 27);
			this.tabPage_Edit.Name = "tabPage_Edit";
			this.tabPage_Edit.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_Edit.Size = new System.Drawing.Size(320, 257);
			this.tabPage_Edit.TabIndex = 1;
			this.tabPage_Edit.Text = "Uređivanje";
			this.tabPage_Edit.UseVisualStyleBackColor = true;
			// 
			// txtBox_Vehicles
			// 
			this.txtBox_Vehicles.HideSelection = false;
			this.txtBox_Vehicles.Location = new System.Drawing.Point(206, 7);
			this.txtBox_Vehicles.Multiline = true;
			this.txtBox_Vehicles.Name = "txtBox_Vehicles";
			this.txtBox_Vehicles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtBox_Vehicles.Size = new System.Drawing.Size(108, 211);
			this.txtBox_Vehicles.TabIndex = 11;
			// 
			// Button_Save
			// 
			this.Button_Save.Location = new System.Drawing.Point(6, 224);
			this.Button_Save.Name = "Button_Save";
			this.Button_Save.Size = new System.Drawing.Size(126, 23);
			this.Button_Save.TabIndex = 4;
			this.Button_Save.Text = "Spremi promjene ...";
			this.Button_Save.UseVisualStyleBackColor = true;
			this.Button_Save.Click += new System.EventHandler(this.Button_SaveClick);
			// 
			// txtBox_Personnel
			// 
			this.txtBox_Personnel.HideSelection = false;
			this.txtBox_Personnel.Location = new System.Drawing.Point(6, 7);
			this.txtBox_Personnel.Multiline = true;
			this.txtBox_Personnel.Name = "txtBox_Personnel";
			this.txtBox_Personnel.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtBox_Personnel.Size = new System.Drawing.Size(194, 211);
			this.txtBox_Personnel.TabIndex = 10;
			// 
			// menuStrip_Menu
			// 
			this.menuStrip_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.glavniMeniToolStripMenuItem,
									this.oProgramuToolStripMenuItem});
			this.menuStrip_Menu.Location = new System.Drawing.Point(0, 0);
			this.menuStrip_Menu.Name = "menuStrip_Menu";
			this.menuStrip_Menu.Size = new System.Drawing.Size(612, 24);
			this.menuStrip_Menu.TabIndex = 5;
			// 
			// glavniMeniToolStripMenuItem
			// 
			this.glavniMeniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.podatkeToolStripMenuItem,
									this.izlazToolStripMenuItem});
			this.glavniMeniToolStripMenuItem.Name = "glavniMeniToolStripMenuItem";
			this.glavniMeniToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
			this.glavniMeniToolStripMenuItem.Text = "Glavni meni";
			// 
			// podatkeToolStripMenuItem
			// 
			this.podatkeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.izveziToolStripMenuItem,
									this.uveziToolStripMenuItem});
			this.podatkeToolStripMenuItem.Name = "podatkeToolStripMenuItem";
			this.podatkeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
			this.podatkeToolStripMenuItem.Text = "Podatke";
			// 
			// izveziToolStripMenuItem
			// 
			this.izveziToolStripMenuItem.Name = "izveziToolStripMenuItem";
			this.izveziToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
			this.izveziToolStripMenuItem.Text = "Izvezi";
			this.izveziToolStripMenuItem.Click += new System.EventHandler(this.IzveziToolStripMenuItemClick);
			// 
			// uveziToolStripMenuItem
			// 
			this.uveziToolStripMenuItem.Name = "uveziToolStripMenuItem";
			this.uveziToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
			this.uveziToolStripMenuItem.Text = "Uvezi";
			this.uveziToolStripMenuItem.Click += new System.EventHandler(this.UveziToolStripMenuItemClick);
			// 
			// izlazToolStripMenuItem
			// 
			this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
			this.izlazToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
			this.izlazToolStripMenuItem.Text = "Izlaz";
			this.izlazToolStripMenuItem.Click += new System.EventHandler(this.IzlazToolStripMenuItemClick);
			// 
			// oProgramuToolStripMenuItem
			// 
			this.oProgramuToolStripMenuItem.Name = "oProgramuToolStripMenuItem";
			this.oProgramuToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
			this.oProgramuToolStripMenuItem.Text = "O programu";
			this.oProgramuToolStripMenuItem.Click += new System.EventHandler(this.OProgramuToolStripMenuItemClick);
			// 
			// statusStrip_Status
			// 
			this.statusStrip_Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripStatusLabel});
			this.statusStrip_Status.Location = new System.Drawing.Point(0, 358);
			this.statusStrip_Status.Name = "statusStrip_Status";
			this.statusStrip_Status.Size = new System.Drawing.Size(612, 22);
			this.statusStrip_Status.TabIndex = 6;
			// 
			// toolStripStatusLabel
			// 
			this.toolStripStatusLabel.Name = "toolStripStatusLabel";
			this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
			// 
			// contextMenuStrip_Child
			// 
			this.contextMenuStrip_Child.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripMenuItem_Remove_SubContractor,
									this.toolStripMenuItem_Rename_SubContractor});
			this.contextMenuStrip_Child.Name = "contextMenuStrip_Mouse";
			this.contextMenuStrip_Child.Size = new System.Drawing.Size(211, 48);
			this.contextMenuStrip_Child.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ContextMenuStrip_ChildItemClicked);
			// 
			// toolStripMenuItem_Remove_SubContractor
			// 
			this.toolStripMenuItem_Remove_SubContractor.Name = "toolStripMenuItem_Remove_SubContractor";
			this.toolStripMenuItem_Remove_SubContractor.Size = new System.Drawing.Size(210, 22);
			this.toolStripMenuItem_Remove_SubContractor.Text = "Izbriši podizvođača ...";
			// 
			// toolStripMenuItem_Rename_SubContractor
			// 
			this.toolStripMenuItem_Rename_SubContractor.Name = "toolStripMenuItem_Rename_SubContractor";
			this.toolStripMenuItem_Rename_SubContractor.Size = new System.Drawing.Size(210, 22);
			this.toolStripMenuItem_Rename_SubContractor.Text = "Preimenuj podizvođača ...";
			// 
			// comboBox_Search_Results
			// 
			this.comboBox_Search_Results.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_Search_Results.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.comboBox_Search_Results.FormattingEnabled = true;
			this.comboBox_Search_Results.Location = new System.Drawing.Point(12, 85);
			this.comboBox_Search_Results.Name = "comboBox_Search_Results";
			this.comboBox_Search_Results.Size = new System.Drawing.Size(240, 23);
			this.comboBox_Search_Results.TabIndex = 7;
			this.comboBox_Search_Results.Visible = false;
			this.comboBox_Search_Results.SelectedValueChanged += new System.EventHandler(this.ComboBox_Search_ResultsSelectedValueChanged);
			// 
			// openFileDialog_List_Import
			// 
			this.openFileDialog_List_Import.DefaultExt = "*.obd";
			this.openFileDialog_List_Import.Filter = "Sve OBD datoteke ...(*.obd)|*.obd";
			this.openFileDialog_List_Import.Title = "Uvoz OBD Liste ...";
			// 
			// saveFileDialog_List_Export
			// 
			this.saveFileDialog_List_Export.DefaultExt = "*.obd";
			this.saveFileDialog_List_Export.Filter = "Sve OBD datoteke ...(*.obd)|*.obd";
			this.saveFileDialog_List_Export.Title = "Izvoz OBD liste ...";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(612, 380);
			this.Controls.Add(this.comboBox_Search_Results);
			this.Controls.Add(this.statusStrip_Status);
			this.Controls.Add(this.tabControl_MO);
			this.Controls.Add(this.Button_Search);
			this.Controls.Add(this.txtBox_Search_Item);
			this.Controls.Add(this.tV_OBD_Main);
			this.Controls.Add(this.menuStrip_Menu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip_Menu;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Odobrenja Bez Dozvole";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.contextMenuStrip_Root.ResumeLayout(false);
			this.tabControl_MO.ResumeLayout(false);
			this.tabPage_View.ResumeLayout(false);
			this.tabPage_Edit.ResumeLayout(false);
			this.tabPage_Edit.PerformLayout();
			this.menuStrip_Menu.ResumeLayout(false);
			this.menuStrip_Menu.PerformLayout();
			this.statusStrip_Status.ResumeLayout(false);
			this.statusStrip_Status.PerformLayout();
			this.contextMenuStrip_Child.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Remove_Firm;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Remove_SubContractor;
		private System.Windows.Forms.ToolStripMenuItem oProgramuToolStripMenuItem;
		private System.Windows.Forms.TextBox txtBox_Personnel;
		private System.Windows.Forms.TextBox txtBox_Vehicles;
		private System.Windows.Forms.SaveFileDialog saveFileDialog_List_Export;
		private System.Windows.Forms.OpenFileDialog openFileDialog_List_Import;
		private System.Windows.Forms.Button Button_Save;
		private System.Windows.Forms.ComboBox comboBox_Search_Results;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Rename_SubContractor;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Add_SubContractor;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Child;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Rename_Firm;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Add_Firm;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Root;
		private System.Windows.Forms.StatusStrip statusStrip_Status;
		private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem uveziToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem izveziToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem podatkeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem glavniMeniToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip_Menu;
		private System.Windows.Forms.TabPage tabPage_Edit;
		private System.Windows.Forms.ListBox lBox_Personnel;
		private System.Windows.Forms.ListBox lBox_Vehicles;
		private System.Windows.Forms.Label lbl_Vehicle_Status;
		private System.Windows.Forms.TabPage tabPage_View;
		private System.Windows.Forms.TabControl tabControl_MO;
		private System.Windows.Forms.Button Button_Search;
		private System.Windows.Forms.TextBox txtBox_Search_Item;
		private System.Windows.Forms.TreeView tV_OBD_Main;
	}
}
