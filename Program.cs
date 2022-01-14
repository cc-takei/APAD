using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace APAD
{
	static class Program
	{
		/// <summary>
		/// アプリケーションのメイン エントリ ポイントです。
		/// </summary>
		[STAThread]
		static void Main()
		{
			Test();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}

		static void PrintField(int [][] field)
		{
			foreach (int[] line in field)
			{
				foreach (int b in line)
				{
					Console.Write(b);
				}
				Console.WriteLine();
			}
		}

		static void Test()
		{
		}
	}
}
