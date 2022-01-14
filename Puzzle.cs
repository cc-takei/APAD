using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace APAD
{
	class Puzzle
	{
		#region PARTS_DATA
		static readonly int[][][][] PARTS = new int[][][][]
		{
			/*
			 * ■■■
			 * ■■■
			 */
			new int[][][]
			{
				new int[][]
				{
					new int[]{ 1, 1, 1 },
					new int[]{ 1, 1, 1 },
				},
				new int[][]
				{
					new int[]{ 1, 1 },
					new int[]{ 1, 1 },
					new int[]{ 1, 1 },
				},
			},
			/*
			 * ■■■
			 * ■　■
			 */
			new int[][][]
			{
				new int[][]
				{
					new int[]{ 1, 1, 1 },
					new int[]{ 1, 0, 1 },
				},
				new int[][]
				{
					new int[]{ 1, 1 },
					new int[]{ 0, 1 },
					new int[]{ 1, 1 },
				},
				new int[][]
				{
					new int[]{ 1, 0, 1 },
					new int[]{ 1, 1, 1 },
				},
				new int[][]
				{
					new int[]{ 1, 1 },
					new int[]{ 1, 0 },
					new int[]{ 1, 1 },
				},
			},
			/*
			 * ■■■
			 * ■　　
			 * ■　　
			 */
			new int[][][]
			{
				new int[][]
				{
					new int[]{ 1, 1, 1 },
					new int[]{ 1 },
					new int[]{ 1 },
				},
				new int[][]
				{
					new int[]{ 1, 1, 1 },
					new int[]{ 0, 0, 1 },
					new int[]{ 0, 0, 1 },
				},
				new int[][]
				{
					new int[]{ 0, 0, 1 },
					new int[]{ 0, 0, 1 },
					new int[]{ 1, 1, 1 },
				},
				new int[][]
				{
					new int[]{ 1 },
					new int[]{ 1 },
					new int[]{ 1, 1, 1 },
				},
			},
			/*
			 * ■■
			 * 　■■■　
			 */
			new int[][][]
			{
				new int[][]
				{
					new int[]{ 1, 1 },
					new int[]{ 0, 1, 1, 1 },
				},
				new int[][]
				{
					new int[]{ 0, 1 },
					new int[]{ 1, 1 },
					new int[]{ 1 },
					new int[]{ 1 },
				},
				new int[][]
				{
					new int[]{ 1, 1, 1 },
					new int[]{ 0, 0, 1, 1 },
				},
				new int[][]
				{
					new int[]{ 0, 1 },
					new int[]{ 0, 1 },
					new int[]{ 1, 1 },
					new int[]{ 1 },
				},

				new int[][]
				{
					new int[]{ 0, 0, 1, 1 },
					new int[]{ 1, 1, 1 },
				},
				new int[][]
				{
					new int[]{ 1 },
					new int[]{ 1, 1 },
					new int[]{ 0, 1 },
					new int[]{ 0, 1 },
				},
				new int[][]
				{
					new int[]{ 0, 1, 1, 1 },
					new int[]{ 1, 1 },
				},
				new int[][]
				{
					new int[]{ 1 },
					new int[]{ 1 },
					new int[]{ 1, 1 },
					new int[]{ 0, 1 },
				},
			},
			/*
			 * 　■■
			 * ■■■
			 */
			new int[][][]
			{
				new int[][]
				{
					new int[]{ 0, 1, 1 },
					new int[]{ 1, 1, 1 },
				},
				new int[][]
				{
					new int[]{ 1, 1 },
					new int[]{ 1, 1, 1 },
				},
				new int[][]
				{
					new int[]{ 1, 1, 1 },
					new int[]{ 1, 1 },
				},
				new int[][]
				{
					new int[]{ 1, 1, 1 },
					new int[]{ 0, 1, 1 },
				},
				new int[][]
				{
					new int[]{ 0, 1 },
					new int[]{ 1, 1 },
					new int[]{ 1, 1 },
				},
				new int[][]
				{
					new int[]{ 1 },
					new int[]{ 1, 1 },
					new int[]{ 1, 1 },
				},
				new int[][]
				{
					new int[]{ 1, 1 },
					new int[]{ 1, 1 },
					new int[]{ 1 },
				},
				new int[][]
				{
					new int[]{ 1, 1 },
					new int[]{ 1, 1 },
					new int[]{ 0, 1 },
				},
			},
			/*
			 * 　■
			 * ■■■■
			 */
			new int[][][]
			{
				new int[][]
				{
					new int[]{ 0, 1 },
					new int[]{ 1, 1, 1, 1 },
				},
				new int[][]
				{
					new int[]{ 1 },
					new int[]{ 1, 1 },
					new int[]{ 1 },
					new int[]{ 1 },
				},
				new int[][]
				{
					new int[]{ 1, 1, 1, 1 },
					new int[]{ 0, 0, 1 },
				},
				new int[][]
				{
					new int[]{ 0, 1 },
					new int[]{ 0, 1 },
					new int[]{ 1, 1 },
					new int[]{ 0, 1 },
				},
				new int[][]
				{
					new int[]{ 0, 0, 1 },
					new int[]{ 1, 1, 1, 1 },
				},
				new int[][]
				{
					new int[]{ 1 },
					new int[]{ 1 },
					new int[]{ 1, 1 },
					new int[]{ 1 },
				},
				new int[][]
				{
					new int[]{ 1, 1, 1, 1 },
					new int[]{ 0, 1 },
				},
				new int[][]
				{
					new int[]{ 0, 1 },
					new int[]{ 1, 1 },
					new int[]{ 0, 1 },
					new int[]{ 0, 1 },
				},
			},
			/*
			 * ■
			 * ■■■
			 * 　　■
			 */
			new int[][][]
			{
				new int[][]
				{
					new int[]{ 1 },
					new int[]{ 1, 1, 1 },
					new int[]{ 0, 0, 1 },
				},
				new int[][]
				{
					new int[]{ 0, 1, 1 },
					new int[]{ 0, 1, 0 },
					new int[]{ 1, 1 },
				},
				new int[][]
				{
					new int[]{ 0, 0, 1 },
					new int[]{ 1, 1, 1 },
					new int[]{ 1 },
				},
				new int[][]
				{
					new int[]{ 1, 1 },
					new int[]{ 0, 1, 0 },
					new int[]{ 0, 1, 1 },
				},
			},
			/*
			 * ■■■■
			 * ■　　
			 */
			new int[][][]
			{
				new int[][]
				{
					new int[]{ 1, 1, 1, 1 },
					new int[]{ 1 },
				},
				new int[][]
				{
					new int[]{ 1, 1 },
					new int[]{ 0, 1 },
					new int[]{ 0, 1 },
					new int[]{ 0, 1 },
				},
				new int[][]
				{
					new int[]{ 0, 0, 0, 1 },
					new int[]{ 1, 1, 1, 1 },
				},
				new int[][]
				{
					new int[]{ 1 },
					new int[]{ 1 },
					new int[]{ 1 },
					new int[]{ 1, 1 },
				},
				new int[][]
				{
					new int[]{ 1 },
					new int[]{ 1, 1, 1, 1 },
				},
				new int[][]
				{
					new int[]{ 0, 1 },
					new int[]{ 0, 1 },
					new int[]{ 0, 1 },
					new int[]{ 1, 1 },
				},
				new int[][]
				{
					new int[]{ 1, 1, 1, 1 },
					new int[]{ 0, 0, 0, 1 },
				},
				new int[][]
				{
					new int[]{ 1, 1 },
					new int[]{ 1 },
					new int[]{ 1 },
					new int[]{ 1 },
				},
			},
		};
		#endregion

		public static readonly int[][] WALL = new int[][]
		{
				new int[] { 0,0,0,0,0,0,1,1 },
				new int[] { 0,0,0,0,0,0,1,1 },
				new int[] { 0,0,0,0,0,0,0,1 },
				new int[] { 0,0,0,0,0,0,0,1 },
				new int[] { 0,0,0,0,0,0,0,1 },
				new int[] { 0,0,0,0,0,0,0,1 },
				new int[] { 0,0,0,1,1,1,1,1 },
				new int[] { 1,1,1,1,1,1,1,1 },
		};
		public static readonly UInt64 wallbit = Field2Bit(WALL);

		public static string bit2str(UInt64 v)
		{
			StringBuilder sb = new StringBuilder();
			UInt64 m = 1ul << 63;
			int i = 0;
			while (m != 0)
			{
				sb.Append(((v & m) == 0) ? '0' : '1');
				m >>= 1;
				if (++i == 8)
				{
					sb.AppendLine();
					i = 0;
				}
			}
			return sb.ToString();
		}

		static bool Place(int[][] field, int[][] parts, int x, int y)
		{
			for (int j = 0; j < parts.Length; j++)
			{
				for (int i = 0; i < parts[j].Length; i++)
				{
					field[y + j][x + i] += parts[j][i];
					if (field[y + j][x + i] > 1) return false;
				}
			}
			return true;
		}
		public static readonly List<List<UInt64>> PARTS_STATUS;

		public static readonly long initializeMs = 0;
		static Puzzle()
		{
			Stopwatch sw = new Stopwatch();
			sw.Start();
			PARTS_STATUS = new List<List<UInt64>>();
			for (int i = 0; i < PARTS.Length; i++)
			{
				List<UInt64> list = new List<UInt64>();
				for (int j = 0; j < PARTS[i].Length; j++)
				{
					int[][] field = new int[][]
					{
							new int[8],
							new int[8],
							new int[8],
							new int[8],
							new int[8],
							new int[8],
							new int[8],
							new int[8],
					};
					Place(field, PARTS[i][j], 0, 0);
					UInt64 bit = Field2Bit(field);
					for (int k = 0; k < 52; k++)
					{
						if ((bit & wallbit) == 0)
						{
							//Console.WriteLine(bit2str(bit));
							list.Add(bit);
						}
						bit >>= 1;
					}
				}
				//Console.WriteLine(list.Count);
				PARTS_STATUS.Add(list);
			}
			initializeMs = sw.ElapsedMilliseconds;
		}

		public static UInt64 Field2Bit(int[][] field)
		{
			UInt64 ret = 0;
			foreach (int[] line in field)
			{
				foreach (int b in line)
				{
					ret <<= 1;
					if (b != 0) ret |= 1;
				}
			}
			return ret;
		}

		public static int[] Search(List<List<UInt64>> PARTS_STATUS, UInt64 field, int depth)
		{
			if (depth == PARTS_STATUS.Count)
			{
				return new int[PARTS_STATUS.Count];
			}
			for (int i = 0; i < PARTS_STATUS[depth].Count; i++)
			{
				if ((field & PARTS_STATUS[depth][i]) == 0)
				{
					//Console.WriteLine(bit2str(field | PARTS_STATUS[depth][i]));
					var ret = Search(PARTS_STATUS, field | PARTS_STATUS[depth][i], depth + 1);
					if (ret != null)
					{
						ret[depth] = i;
						return ret;
					}
				}
			}
			return null;
		}
	}
}
