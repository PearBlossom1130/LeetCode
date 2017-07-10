using System.Collections.Generic;

namespace _4.FindMedian
{
	class Program
	{
		static void Main(string[] args)
		{
		}

		// The array has 5 elements with indexes in the range of 0 to 4, and the median element is at index(5-1)/2 = 2. 
		// In general, the median is at index(n-1)/2 if the number of elements in an array(n) is odd. 
		// For a sorted array with an even number of elements, two elements in the middle are medians.
		static double FindMedianSortedArrays(int[] n1, int[] n2)
		{
			if (n1.Length == 0 && n2.Length == 0)
				return 0.0;

			if (n1.Length == 0 && n2.Length != 0)
			{
				if (n2.Length % 2 == 0)
					return (n2[n2.Length / 2] + n2[n2.Length / 2 - 1]) / 2.0;
				else
					return n2[n2.Length / 2];
			}

			if (n1.Length != 0 && n2.Length == 0)
			{
				if (n1.Length % 2 == 0)
					return (n1[n1.Length / 2] + n1[n1.Length / 2 - 1]) / 2.0;
				else
					return n1[n1.Length / 2];
			}


			var combined = new List<int>();
			int i = 0, j = 0;
			var b1 = false;
			var b2 = false;

			while (true)
			{
				var t1 = 0;
				var t2 = 0;
				if (n1.Length > i)
				{
					t1 = n1[i];
				}
				else
				{
					b1 = true;
				}

				if (n2.Length > j)
				{
					t2 = n2[j];
				}
				else
				{
					b2 = true;
				}

				if (b1 && b2) break;

				if (b1)
				{
					combined.Add(t2);
					j++;
					continue;
				}

				if (b2)
				{
					combined.Add(t1);
					i++;
					continue;
				}


				if (t1 < t2)
				{
					combined.Add(t1);
					i++;
				}
				else
				{
					combined.Add(t2);
					j++;
				}

			}

			if (combined.Count % 2 == 0)
			{
				return ((combined[combined.Count / 2] + combined[combined.Count / 2 - 1]) / 2.0d);
			}
			else
			{
				return combined[combined.Count / 2];
			}
		}

	}
}
