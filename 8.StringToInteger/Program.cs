namespace _8.StringToInteger
{
	using System;

	class Program
	{
		static void Main(string[] args)
		{
			var d1 = "22222*";
			var dd = d1.IndexOf("*");


			//int d = Atoi("2147483648");
            int d = Atoi("2047");
        }

		public static int Atoi(string s)
		{
			if (string.IsNullOrEmpty(s)) return 0;

			int len = s.Length;
			int j = 0;
			int num = 1;
			for (int i = 0; i < len; i++)
			{
				int v = s[i] - '0';
				if (v > 9) return 0;
				if (i != 0) num = num * 10 + v;
				else num = v;
				if (Int32.MaxValue < num || Int64.MinValue > num) return 0;
			}

			return num;
		}
	}
}
