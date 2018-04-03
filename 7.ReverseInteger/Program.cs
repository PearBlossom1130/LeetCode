namespace _7.ReverseInteger
{
	using System;
	using System.Collections.Generic;

	class Program
	{
		static void Main(string[] args)
		{
			//var d = Reverse(1534236469);
			//var d = Reverse(102);
			var d1 = Reverse(-44007);
			var d2 = Reverse2(-44007);
		}

		static int Reverse(int x)
		{
			if (x <= Int32.MinValue)
				return 0;
			if (x >= Int32.MaxValue)
				return 0;

			bool signFlag = x < 0;

			var absX = Math.Abs(x);

			Int64 loop = 10;
			var reverse = new List<int>();

			var temp = absX;

			int i = 0;
			var prevModule = 0;

			if (temp < 10)
			{
				reverse.Add(temp);
			}
			else
			{
				while (true)
				{
					var module = (int)(temp % loop);

					if (loop != 10 && module < 10) module = 0;
					reverse.Add((module - prevModule) / (int)Math.Pow(10, i));
					if (module == temp) break;

					loop *= 10;
					i++;
					prevModule = module;
				}
			}

			Int64 result = 0;
			for (int j = 0; j < reverse.Count; j++)
			{
				result += reverse[j] * (Int64)Math.Pow(10, reverse.Count - j - 1);
			}

			result = signFlag ? result * -1 : result;

			if (result <= Int32.MinValue)
				return 0;
			if (result >= Int32.MaxValue)
				return 0;

			return (int)result;
		}

		static int Reverse2(int x)
		{
			int result = 0;

			while (x != 0)
			{
				int tail = x % 10;
				int newResult = result * 10 + tail;
				if ((newResult - tail) / 10 != result)
				{ return 0; }
				result = newResult;
				x = x / 10;
			}

			return result;
		}
	}
}
