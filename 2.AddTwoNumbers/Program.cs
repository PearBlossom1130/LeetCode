namespace _2.AddTwoNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			//var list1 = new List<int>();
			//var list2 = new List<int>();

			//list1.Add(3);
			//list1.Add(4);
			//list1.Add(2);

			//list2.Add(4);
			//list2.Add(6);
			//list2.Add(5);

			var l1 = new ListNode(2);
			var l2 = new ListNode(4);
			l1.next = l2;
			var l3 = new ListNode(3);
			l2.next = l3;

			var l4 = new ListNode(5);
			var l5 = new ListNode(6);
			l4.next = l5;
			var l6 = new ListNode(4);
			l5.next = l6;

			var sum = AddTwoNumbers(l1, l4);

		}

		class ListNode
		{
			public int val;
			public ListNode next;
			public ListNode(int x) { val = x; }
		}


		static ListNode AddTwoNumbers(ListNode list1, ListNode list2)
		{


			//링크드 리스트에서 헤드는 시작점으로 이해하면됨.

			ListNode prev = new ListNode(0);
			ListNode head = prev;
			int carry = 0;
			while (list1 != null || list2 != null || carry != 0)
			{
				ListNode curr = new ListNode(0);

				int sum = (list1 == null ? 0 : list1.val) + (list2 == null ? 0 : list2.val) + carry;
				curr.val = sum % 10;
				carry = sum / 10;
				prev.next = curr;
				prev = curr;

				list1 = list1 == null ? list1 : list1.next;
				list2 = list2 == null ? list2 : list2.next;
			}

			return head.next;
		}

		//static List<int> AddTwoNumbers(List<int> list1, List<int> list2)
		//{
		//    var listSum = new List<int>();
		//    var digitFlag = false;
		//    for(int i = list1.Count-1; i >= 0; i--)
		//    {
		//        var sum = (list1[i] + list2[i]);
		//        if (digitFlag)
		//        {
		//            sum += 1;
		//            digitFlag = false;
		//        }

		//        if (sum >= 10)
		//        {
		//            digitFlag = true;
		//            sum %= 10;
		//        }

		//        listSum.Add(sum);
		//    }

		//    return listSum;
		//}
	}
}
