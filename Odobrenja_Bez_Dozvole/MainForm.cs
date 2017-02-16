/*
 * Created by SharpDevelop.
 * User: aZuZu
 * Date: 4.11.2015.
 * Time: 21:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Odobrenja_Bez_Dozvole
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public static string OBD_Executable = Application.ExecutablePath;
		public static string StartUp_Folder = Path.GetDirectoryName(Application.ExecutablePath);
		public static string PC_FSC_List_File = StartUp_Folder + "\\OBD_List.dat";
		public static string Mobile_FSC_List_File = StartUp_Folder + "\\OBD_Mobile_List.obd";
	
		public static string Power_User_File = StartUp_Folder + "\\Right_User.dat";
		public static string OBD_BackUp_Folder = "C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\OBD_Data";
		public static string OBD_BackUp_File = OBD_BackUp_Folder + "\\Right_User.obd";
	
		public static string Current_OBD_Mode = "View";
		
		public string OBD_List_Header = "OBDxL, Created on " + String.Format("{0:g}", DateTime.Now);

		public List<string> OBD_List = new List<string>();
		public List<string> Search_Result_List = new List<string>();

		public TreeNode Root = null;
		public TreeNode SubContractor = null;
		public static int start_mode = 1;

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

		string DD_Array(string Start_Folder)
		{
			List<string> outx = new List<string>();
			string[] File_Data = new string[4];
			string Formated_Line = string.Empty;
			outx.Clear();			
			foreach (string Folder in Directory.GetDirectories(Start_Folder) )
			{	
				foreach ( string SFile in Directory.GetFiles(Folder) )
				{
					File_Data = File.ReadAllLines(SFile);
					Formated_Line = Path.GetFileName(Folder) + "=" + File_Data[2].Replace(Environment.NewLine, string.Empty).Replace("|", ",").Replace("Nema osoba vezanih uz registraciju.", "Lista osoba je prazna!") + ":" + Add_Status(File_Data[3].Replace(Environment.NewLine, string.Empty).Replace("|", ","));
					if ( !outx.Contains(Formated_Line) )
				    {
						outx.Add(Formated_Line);
					}
				}
			}
			return string.Join("/", outx.ToArray());
		}
		string DD_Nodes( TreeNode Start_Node)
		{
			List<string> outx = new List<string>();
			string Formated_Line = string.Empty;
			outx.Clear();
			
			foreach( TreeNode Main_Node in Start_Node.Nodes )
			{
				Formated_Line = Main_Node.Text + "=" + string.Join(",", Main_Node.Tag.ToString().Split(':')[0].Split(',').Distinct().ToArray()) + ":" + string.Join(",", Main_Node.Tag.ToString().Split(':')[1].Split(',').Distinct().ToArray()).ToUpper();
				if ( !outx.Contains(Formated_Line) && Main_Node.Tag.ToString() != string.Empty)
				{
					outx.Add(Formated_Line);
				}
			}
			return string.Join("/", outx.ToArray());
		}		
		List<string> Folder_To_Data(string Start_Folder )
		{
			List<string> outx = new List<string>();
			outx.Clear();
			foreach (string Folder in Directory.GetDirectories(Start_Folder) )
			{	
				if ( !outx.Contains(Path.GetFileName(Folder) + "|" + DD_Array(Folder)) )
				{
					outx.Add(Path.GetFileName(Folder) + "|" + DD_Array(Folder));
				}
			}
			return outx;
		}
		List<string> Tree_To_Data()
		{
			List<string> outx = new List<string>();
			outx.Clear();
			foreach (TreeNode Start_Node in tV_OBD_Main.Nodes )
			{
				if ( !outx.Contains( Start_Node.Text + "|" + DD_Nodes(Start_Node)) && DD_Nodes(Start_Node).Length != 0)
				{
					outx.Add(Start_Node.Text + "|" + DD_Nodes(Start_Node));
				}
			}
			return outx;
		}		
		
		bool Is_Car_Registration(string In_String)
		{
			foreach( char Is_Digit in In_String.ToCharArray() )
			{
				if ( Char.IsNumber(Is_Digit) )
				{
					return true;
				}
			}
			return false;
		}
		string Add_Status(string In_Data)
		{
			string[] inx = In_Data.Split(',');
			string[] outx = new string[inx.Length];
			for ( int idx = 0; idx < inx.Length; idx++ )
			{
				if ( inx[idx].Contains("+0") || inx[idx].Contains("+1") || inx[idx].Contains("+2") )
				{
					outx[idx] = inx[idx];
				} else {
					outx[idx] = inx[idx] + "+1";
				}
			}
			return string.Join(",", outx).Replace(",+1", string.Empty);
		}
		string Remove_Status(string In_Data)
		{
			string[] inx = In_Data.Split(',');
			string[] outx = new string[inx.Length];
			for ( int idx = 0; idx < inx.Length; idx++ )
			{
				if ( inx[idx].Contains("+") )
				{
					outx[idx] = inx[idx].Substring(0, inx[idx].Length - 2);
				} else {
					outx[idx] = inx[idx];
				}
			}
			return string.Join(",", outx);
		}		
		void Get_Status(int Where)
		{
			string Item = tV_OBD_Main.SelectedNode.Tag.ToString().Split(':')[1].Split(',')[lBox_Vehicles.SelectedIndex];
			if ( Item.EndsWith("+0") ) {
				lbl_Vehicle_Status.BackColor = Color.Red;
				lbl_Vehicle_Status.ForeColor = Color.Black;
				lbl_Vehicle_Status.Text = "Zabranjen ulaz!";
			} else if ( Item.EndsWith("+1") ) {
				lbl_Vehicle_Status.BackColor = Color.White;
				lbl_Vehicle_Status.ForeColor = Color.Black;
				lbl_Vehicle_Status.Text = "Dozvoljen ulaz u dnevnu!";
			} else if ( Item.EndsWith("+2") ) {
				lbl_Vehicle_Status.BackColor = Color.DarkGray;
				lbl_Vehicle_Status.ForeColor = Color.Black;
				lbl_Vehicle_Status.Text = "Dozvoljen ulaz u nočnu!";
			} else if ( Item.EndsWith("+3") ) {
				lbl_Vehicle_Status.BackColor = SystemColors.Control;
				lbl_Vehicle_Status.ForeColor = Color.Black;
				lbl_Vehicle_Status.Text = "Stalno dozvoljen ulaz!";
			}
		}

		void Make_OBD_List()
		{
			OBD_List.Clear();
			OBD_List.Add(OBD_List_Header);
			OBD_List.AddRange(Folder_To_Data("Firme"));
			TextWriter tw = new StreamWriter(File.OpenWrite(PC_FSC_List_File));
			for ( int file_idx = 0; file_idx < OBD_List.ToArray().Length; file_idx++ )
			{
				tw.WriteLine(OBD_List[file_idx]);
			}
			tw.Close();
			
		}		
		void Load_OBD_List()
		{
			List<string> OBD_File = new List<string>();
			OBD_File.AddRange(File.ReadAllLines(PC_FSC_List_File));
			if ( OBD_File[0].StartsWith("OBDxL") )
			{
				tV_OBD_Main.Nodes.Clear();
				OBD_List.AddRange(OBD_File.GetRange(1, 6));
				string Firm_Item = string.Empty, Data_Item = string.Empty;
				string[] SubContractor_Item;
				foreach (string OBD_Data in OBD_List.ToArray())
				{
					Firm_Item = OBD_Data.Split('|')[0];
					SubContractor_Item = OBD_Data.Split('|')[1].Split('/');
					Root = new TreeNode(Firm_Item);
					tV_OBD_Main.Nodes.Add(Root);
					foreach ( string SC in SubContractor_Item)
					{
						SubContractor = new TreeNode(SC.Split('=')[0]);
						SubContractor.Tag = SC.Split('=')[1].Split(':')[0] + ":" + Add_Status(SC.Split('=')[1].Split(':')[1]);
						Root.Nodes.Add(SubContractor);
					}
				}
				OBD_File.Clear();
				OBD_List.Clear();
				
			} else {
				MessageBox.Show("Ovo nije valjana lista!", "Upozorenje!", MessageBoxButtons.OK);
				Environment.Exit(-1);
			}
		}

		void GZ_Compress(string infile, string outputFile)
		{
			FileStream in_fs = File.OpenRead(infile);
			FileStream out_fs = File.Create(outputFile);
			 
			GZipStream gz_fs = new GZipStream(out_fs, CompressionMode.Compress);
			 
			byte[] bytes = new byte[2048];
			int bytesRead;
			
			while ((bytesRead = in_fs.Read(bytes, 0, bytes.Length)) != 0 )
			{
		    	gz_fs.Write(bytes, 0, bytesRead);
			}

			in_fs.Close();
			gz_fs.Close();
			out_fs.Close();
		}
		void GZ_DeCompress(string infile, string outputFile)
		{
			FileStream in_fs = File.OpenRead(infile);
			FileStream out_fs= File.Create(outputFile);
			 
			GZipStream gz_fs = new GZipStream(in_fs, CompressionMode.Decompress);
			byte[] bytes = new byte[2048];
			int bytesRead;
			
			while ((bytesRead = gz_fs.Read(bytes, 0, bytes.Length)) != 0 )
			{
		    	out_fs.Write(bytes,0, bytesRead);
			}
		    
			gz_fs.Close();
			in_fs.Close();
			out_fs.Close();
		}	
		
		void Set_OBD_Mode(string View_Edit)
		{
			Current_OBD_Mode = View_Edit;
			switch ( Current_OBD_Mode )
			{
				case "View":
				{
					tabControl_MO.SelectTab(0);
					break;						
				}
				case "Edit":
				{
					tV_OBD_Main.LabelEdit = true;
					/*
					//tV_OBD_Main.ContextMenuStrip = contextMenuStrip_Root;
					foreach ( TreeNode FN in tV_OBD_Main.Nodes )
					{
						FN.ContextMenuStrip = contextMenuStrip_Root;
						foreach ( TreeNode SN in FN.Nodes )
						{
							SN.ContextMenuStrip = contextMenuStrip_Child;
						}
					}
					*/						
					break;
				}
			}
		}		

		string Smart_Mark(string Search_For, string[] Where)
		{
			List<string> outx = new List<string>();
			for ( int Test = 0; Test < Where.Length; Test++ )
			{
				if ( Where[Test].ToLower().Contains(Search_For.ToLower()) )
				{
					outx.Add(Test.ToString());
				}
			}
			return string.Join(",", outx.ToArray());
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			new DirectoryInfo(OBD_BackUp_Folder).Create();
			if ( !File.Exists(PC_FSC_List_File) )
			{
				GZ_DeCompress(OBD_BackUp_File, PC_FSC_List_File);
			}
			if ( start_mode == 0 )
		    	Make_OBD_List();
			else
				Load_OBD_List();
		}
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			File.Delete(Power_User_File);
			if ( File.Exists(PC_FSC_List_File + ".1") )
			{
				File.Delete(PC_FSC_List_File);
				File.Move(PC_FSC_List_File + ".1", PC_FSC_List_File);
			}
			GZ_Compress(PC_FSC_List_File, OBD_BackUp_File);
			GZ_Compress(PC_FSC_List_File, Mobile_FSC_List_File);
		}

		void LBox_VehiclesSelectedValueChanged(object sender, EventArgs e)
		{
			if ( lBox_Vehicles.SelectedIndex != -1 )
			{
				Get_Status(lBox_Vehicles.SelectedIndex);
			}
		}
		void TabControl_MOSelected(object sender, TabControlEventArgs e)
		{
			switch ( e.TabPageIndex)
			{
				case 0:
				{
					Set_OBD_Mode("View");
					break;
				}
				case 1:
				{
					if ( !File.Exists(Power_User_File) )
					{
						LogIn LogMeIn = new LogIn();			
						DialogResult = LogMeIn.ShowDialog();
						if ( DialogResult == DialogResult.OK)
						{
							Set_OBD_Mode("Edit");
						} else if ( DialogResult == DialogResult.Cancel ) {
							Set_OBD_Mode("View");
						}
					} else {
						Set_OBD_Mode("Edit");
					}						
					break;
				}
			}			
		}

		void Smart_Search(string Search_For)
		{
			Search_Result_List.Clear();
			comboBox_Search_Results.Items.Clear();
			
			foreach ( TreeNode Main_Node in tV_OBD_Main.Nodes )
			{
				foreach ( TreeNode Sub_Node in Main_Node.Nodes )
				{
					if ( Is_Car_Registration(Search_For) )
					{
						if ( Sub_Node.Tag.ToString().Split(':')[1].ToLower().Contains(Search_For.ToLower()) )
						{
							Search_Result_List.Add( "V" + "|" + 
							                        Main_Node.Text.ToString() + "," + Sub_Node.Text.ToString() + "|" + 
							                        Main_Node.Index.ToString() + "," + Sub_Node.Index.ToString() + "|" + 
							                        Smart_Mark ( Search_For, Sub_Node.Tag.ToString().Split(':')[1].Split(',')));
						}
					} else {
						if ( Sub_Node.Tag.ToString().Split(':')[0].ToLower().Contains(Search_For.ToLower()) )
						{
							Search_Result_List.Add( "P" + "|" + 
							                        Main_Node.Text.ToString() + "," + Sub_Node.Text.ToString() + "|" + 
							                        Main_Node.Index.ToString() + "," + Sub_Node.Index.ToString() + "|" + 
							                        Smart_Mark ( Search_For, Sub_Node.Tag.ToString().Split(':')[0].Split(',')));
						}
						
					}
				}
			}
			foreach ( string Found_Items in Search_Result_List.ToArray() )
			{
				comboBox_Search_Results.Items.Add( Found_Items.Split('|')[1] );
			}
			
			if ( comboBox_Search_Results.Items.Count > 0 )
			{
				comboBox_Search_Results.Visible = true;
			} else {
				comboBox_Search_Results.Visible = false;
			}
		}		
		void Button_SearchClick(object sender, EventArgs e)
		{
			if ( txtBox_Search_Item.Text.Length >= 3 )
			{
				Smart_Search(txtBox_Search_Item.Text);
			} else if ( txtBox_Search_Item.Text.Length < 3 )
			{
				txtBox_Search_Item.Text = "Upiši bar 3 slova ...";
			}
		}
		void ComboBox_Search_ResultsSelectedValueChanged(object sender, EventArgs e)
		{
			string What_Is_Found = string.Empty;
			int Main_Node = -1, Sub_Node = -1, Found_Items_Count = -1;
			string[] Found_Items = null;
			Main_Node = int.Parse(Search_Result_List[comboBox_Search_Results.SelectedIndex].Split('|')[2].Split(',')[0]);
			Sub_Node = int.Parse(Search_Result_List[comboBox_Search_Results.SelectedIndex].Split('|')[2].Split(',')[1]);
			Found_Items = Search_Result_List[comboBox_Search_Results.SelectedIndex].Split('|')[3].Split(',');
			Found_Items_Count = Found_Items.Length;
			What_Is_Found = Search_Result_List[comboBox_Search_Results.SelectedIndex].Split('|')[0];

			if ( Main_Node != -1 || Sub_Node != -1 )
			{
				tV_OBD_Main.Nodes[Main_Node].Expand();
				tV_OBD_Main.SelectedNode = tV_OBD_Main.Nodes[Main_Node].Nodes[Sub_Node];
				tV_OBD_Main.Select();
			}

			switch ( What_Is_Found )
			{
				case "P":
					foreach ( string Items in Found_Items)
					{
							lBox_Personnel.SetSelected(Convert.ToUInt16(Items), true);
					}
					break;
				case "V":
					foreach ( string Items in Found_Items)
					{
							lBox_Vehicles.SetSelected(Convert.ToUInt16(Items), true);
					}
					break;
			}

		}
		
		void TxtBox_Search_ItemClick(object sender, EventArgs e)
		{
			tabControl_MO.SelectTab(0);
			lBox_Personnel.ClearSelected();
			lBox_Vehicles.ClearSelected();
			txtBox_Search_Item.Clear();
			tV_OBD_Main.CollapseAll();
			comboBox_Search_Results.Visible = false;
		}
		void TxtBox_Search_ItemKeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if ( e.KeyCode == Keys.Enter )
			{
				if ( txtBox_Search_Item.Text.Length >= 3 )
				{
					comboBox_Search_Results.Items.Clear();
					comboBox_Search_Results.Visible = false;
					Smart_Search(txtBox_Search_Item.Text);
				} else if ( txtBox_Search_Item.Text.Length < 3 )
				{
					txtBox_Search_Item.Text = "Upiši bar 3 slova ...";
				}				
			}
		}

		void TV_OBD_MainAfterSelect(object sender, TreeViewEventArgs e)
		{
			toolStripStatusLabel.Text = "Odabrano: " + tV_OBD_Main.SelectedNode.FullPath;
			if ( e.Node.IsSelected && tV_OBD_Main.SelectedNode.Level == 1 )
			{
				switch (Current_OBD_Mode)
				{
					case "View":
					{
						lBox_Personnel.Items.Clear();
						lBox_Personnel.Items.AddRange(tV_OBD_Main.SelectedNode.Tag.ToString().Split(':')[0].Split(','));
						lBox_Vehicles.Items.Clear();
						lBox_Vehicles.Items.AddRange(Remove_Status(tV_OBD_Main.SelectedNode.Tag.ToString().Split(':')[1]).Split(','));
						break;
					}
					case "Edit":
					{
						Button_Save.Enabled = true;
						txtBox_Personnel.ReadOnly = false;
						txtBox_Vehicles.ReadOnly = false;						
						txtBox_Personnel.Text = tV_OBD_Main.SelectedNode.Tag.ToString().Split(':')[0].Replace(",", Environment.NewLine);
						txtBox_Vehicles.Text = tV_OBD_Main.SelectedNode.Tag.ToString().Split(':')[1].Replace(",", Environment.NewLine);
						break;
					}
				}
			} else if ( e.Node.IsSelected && tV_OBD_Main.SelectedNode.Level == 0) {
				Button_Save.Enabled = false;
				txtBox_Personnel.ReadOnly = true;
				txtBox_Vehicles.ReadOnly = true;
				lBox_Personnel.Items.Clear();
				lBox_Vehicles.Items.Clear();
				txtBox_Personnel.Clear();
				txtBox_Vehicles.Clear();
			}
		}
		void TV_OBD_MainNodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			if ( Current_OBD_Mode == "Edit" )
			{
				if ( e.Node.IsSelected && e.Button == MouseButtons.Right )
				{
					switch ( tV_OBD_Main.SelectedNode.Level )
					{
						case 0:
						{
							contextMenuStrip_Root.Show(tV_OBD_Main, e.Location);
							break;
						}
						case 1:
						{
							contextMenuStrip_Child.Show(tV_OBD_Main, e.Location);
							break;
						}
					}
				}
			}
		}
		void ContextMenuStrip_RootItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
		   if ( Current_OBD_Mode == "Edit" )
		   {
			   switch (e.ClickedItem.Text)
			   {
			      case "Dodaj firmu ...":
			   		 tV_OBD_Main.Nodes.Add("Nova firma ...");
			         break;
			      case "Izbriši firmu ...":
			         contextMenuStrip_Root.Hide();
			         DialogResult = MessageBox.Show("Izbrisati firmu " + tV_OBD_Main.SelectedNode.Text + "?", "Upozorenje!", MessageBoxButtons.YesNo);
			         switch ( DialogResult )
			         {
			         	case DialogResult.Yes:
			         	{
    				        tV_OBD_Main.SelectedNode.Remove();
			         		break;
			         	}
			         	case DialogResult.No:
		         		{
			         		break;
			         	}
	         		}
			        break;
			      case "Preimenuj firmu ...":
			   		 tV_OBD_Main.SelectedNode.BeginEdit();
			         break;
			      case "Dodaj podizvođača ...":
			         tV_OBD_Main.Nodes[tV_OBD_Main.SelectedNode.Index].Expand();
			   		 tV_OBD_Main.Nodes[tV_OBD_Main.SelectedNode.Index].Nodes.Add("Novi podizvođač ...");
			   		 tV_OBD_Main.Nodes[tV_OBD_Main.SelectedNode.Index].LastNode.Tag = ":";
			   		 tV_OBD_Main.Nodes[tV_OBD_Main.SelectedNode.Index].LastNode.BeginEdit();
			   		 if ( !tV_OBD_Main.Nodes[tV_OBD_Main.SelectedNode.Index].LastNode.IsEditing )
			   		 {
			   		 	tV_OBD_Main.Nodes[tV_OBD_Main.SelectedNode.Index].LastNode.TreeView.Select();
			   		 }
			         break;		         
			    }
			}
		}
		void ContextMenuStrip_ChildItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
		   if ( Current_OBD_Mode == "Edit" )
		   {
		   		switch (e.ClickedItem.Text)
		   		{
		   			case "Izbriši podizvođača ...":
		   			{
	   					contextMenuStrip_Child.Hide();
			         	DialogResult = MessageBox.Show("Izbrisati " + tV_OBD_Main.SelectedNode.Text + "?", "Upozorenje!", MessageBoxButtons.YesNo);
			         	switch ( DialogResult )
			         	{
			         		case DialogResult.Yes:
			         		{
			   					tV_OBD_Main.SelectedNode.Remove();
			         			break;
			         		}
			         		case DialogResult.No:
		         			{
			         			break;
			         		}
	         			}
		   				break;
		   			}
		   			case "Preimenuj podizvođača ...":
			   		{
			   		 tV_OBD_Main.SelectedNode.BeginEdit();
			   		 break;
			     	}
		   		}
		   		
		   	}
		}

		void Smart_Save()
		{
			string Personnel_New = string.Join(",", txtBox_Personnel.Lines.Distinct().ToArray());
			string Vehicles_New = Add_Status(string.Join(",", txtBox_Vehicles.Lines.Distinct().ToArray()));
			
			tV_OBD_Main.SelectedNode.Tag = Personnel_New + ":" + Vehicles_New;
		}
		void Button_SaveClick(object sender, EventArgs e)
		{	
			Smart_Save();
			OBD_List.Clear();
			OBD_List.Add(OBD_List_Header);
			OBD_List.AddRange(Tree_To_Data());
			File.WriteAllLines(PC_FSC_List_File + ".1", OBD_List.ToArray());
			MessageBox.Show("Spremljeno!", "Informacija!", MessageBoxButtons.OK);
		}

		void IzveziToolStripMenuItemClick(object sender, EventArgs e)
		{
			DialogResult = saveFileDialog_List_Export.ShowDialog();
			if ( DialogResult == DialogResult.OK )
			{
				GZ_Compress(PC_FSC_List_File, saveFileDialog_List_Export.FileName.ToString());
			}
		}
		void UveziToolStripMenuItemClick(object sender, EventArgs e)
		{
			DialogResult = openFileDialog_List_Import.ShowDialog();
			if ( DialogResult == DialogResult.OK)
			{
				GZ_DeCompress(openFileDialog_List_Import.FileName.ToString(), PC_FSC_List_File);
				Load_OBD_List();
			}

		}
		void IzlazToolStripMenuItemClick(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}
		void OProgramuToolStripMenuItemClick(object sender, System.EventArgs e)
		{
			MessageBox.Show( "Program izradio Ivan Slaninka. 2015.", "Informacija!", MessageBoxButtons.OK);
		}
	}
}
