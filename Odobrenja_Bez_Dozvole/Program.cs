/*
 * Created by SharpDevelop.
 * User: aZuZu
 * Date: 4.11.2015.
 * Time: 21:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using System.Threading;

namespace Odobrenja_Bez_Dozvole
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{

        bool ok;
        Mutex m = new Mutex(true, "Odobrenja_Bez_Dozvole", out ok);

        if (!ok)
        {
            MessageBox.Show("Program je več pokrenut.");
            return;
        }			
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
