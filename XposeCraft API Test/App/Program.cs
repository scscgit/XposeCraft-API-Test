﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XposeCraft_UI_API_Prototype_Test
{
	static class Program
	{
		public static Form1 MainForm
		{
			get; private set;
		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			MainForm = new Form1();
			Application.Run(MainForm);
		}
	}
}