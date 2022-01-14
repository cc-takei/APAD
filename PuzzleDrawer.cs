using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace APAD
{
	public partial class PuzzleDrawer : UserControl
	{
		public PuzzleDrawer()
		{
			InitializeComponent();
		}

		Brush[] m_brushes = new Brush[]
		{
			Brushes.Blue,
			Brushes.Green,
			Brushes.Red,
			Brushes.LightBlue,
			Brushes.LightGreen,
			Brushes.Pink,
			Brushes.Cyan,
			Brushes.Magenta,
			Brushes.Black,
		};

		private void PuzzleDrawer_Paint(object sender, PaintEventArgs e)
		{
			var g = e.Graphics;
			if (Data == null) return;
			for (int i = 0; i < Data.Count; i++)
			{
				for (int y = 0; y < 7; y++)
				{
					for (int x = 0; x < 7; x++)
					{
						if (((1ul << (63 - (y * 8 + x))) & Data[i]) != 0)
						{
							g.FillRectangle(m_brushes[i], new Rectangle(x * 33, y * 33, 32, 32));
						}
					}
				}
			}
		}

		public List<UInt64> Data = null;
	}
}
