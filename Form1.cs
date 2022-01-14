using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace APAD
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = string.Format("Initialize {0}ms", Puzzle.initializeMs);
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
		}

		private void button1_Click(object sender, EventArgs e)
		{
			UInt64 field = Puzzle.wallbit;
			int s = 64;
			s -= dateTimePicker1.Value.Month;
			if (dateTimePicker1.Value.Month > 6) s -= 2;
			field |= 1ul << s;
			s = 47;
			s -= dateTimePicker1.Value.Day - 1;
			s -= (dateTimePicker1.Value.Day - 1) / 7;
			field |= 1ul << s;
			//Console.WriteLine(Puzzle.bit2str(field));

			Stopwatch sw = new Stopwatch();
			sw.Start();
			var ret = Puzzle.Search(Puzzle.PARTS_STATUS, field, 0);
			toolStripStatusLabel1.Text = string.Format("Puzzle.Search() {0}ms", sw.ElapsedMilliseconds);
			if (ret != null)
			{
				UInt64 result = field;
				List<UInt64> list = new List<UInt64>();
				for (int i = 0; i < Puzzle.PARTS_STATUS.Count; i++)
				{
					list.Add(Puzzle.PARTS_STATUS[i][ret[i]]);
					result |= Puzzle.PARTS_STATUS[i][ret[i]];
					//Console.WriteLine(Puzzle.bit2str(result));
				}
				//list.Add(Puzzle.wallbit);
				puzzleDrawer1.Data = list;
				puzzleDrawer1.Invalidate();
			}
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			puzzleDrawer1.Data = null;
			puzzleDrawer1.Invalidate();
		}
	}
}
