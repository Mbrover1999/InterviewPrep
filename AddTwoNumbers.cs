using System;
namespace Interview
{
	public class AddTwoNumbers
	{
        public ListNode AddTwoNumbersd(ListNode l1, ListNode l2)
        {
            int carry = 0;
            ListNode results = new ListNode(0);
            ListNode copy = results;
            while(l1 != null || l2 != null || carry > 0)
            {
                int sum = (l1 == null ? 0 : l1.val)
                    + (l2 == null ? 0 : l2.val)
                    +carry;
                int remainder = sum % 10;
                carry = sum / 10;
                copy.next = new ListNode(remainder);
                copy = copy.next;
                if(l1 != null)
                {
                    l1 = l1.next;
                }
                if(l2 != null) {
                    l2 = l2.next;
                }



            }
            return results.next;

        }
    }
}

