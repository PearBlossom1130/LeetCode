namespace _6.LongestPalindromicSubstring
{
	using System.Text;

	class Program
	{
		static void Main(string[] args)
		{
			var s = Convert("LZAGHKTIOIJO", 3);
		}

		public static string Convert(string s, int row)
		{
			int len = s.Length;

			var sb = new StringBuilder[row];

			for (int j = 0; j < sb.Length; j++)
			{
				sb[j] = new StringBuilder();
			}

			int i = 0;
			while (i < len)
			{
				for (int idx = 0; idx < row && i < len; idx++)
				{
					sb[idx].Append(s[i++]);
				}

				for (int idx = row-2; idx >= 1 && i < len; idx--)
				{
					sb[idx].Append(s[i++]);
				}


			}


			for (int idx = 1; idx < sb.Length; idx++)
			{
				sb[0].Append(sb[idx]);
			}

			return sb[0].ToString();
		}
	}

}
