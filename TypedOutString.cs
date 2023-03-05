using System;
using System.Text;
namespace Interview
{
	public class TypedOutString
	{
		public bool isTypedOutString(string s, string t)
		{
			//Stack<char> test1 = new Stack<char>();
			//         Stack<char> test2 = new Stack<char>();
			//         for (int i = 0; i < s.Length; i++)
			//{
			//	if (s[i] != '#')
			//	{
			//		test1.Push(s[i]);

			//	}
			//	else
			//	{
			//                 if (test1.Count != 0)
			//                 {
			//                     test1.Pop();
			//                 }
			//             }
			//}
			//         for (int i = 0; i < t.Length; i++)
			//         {
			//             if (t[i] != '#')
			//             {
			//                 test2.Push(t[i]);

			//             }
			//             else
			//             {
			//		if (test2.Count != 0)
			//		{
			//			test2.Pop();
			//		}
			//             }

			//         }

			//if(test1.Count != test2.Count)
			//{
			//	return false;
			//}
			//else
			//{
			//	for(int i = test1.Count; i > 0; i--)
			//	{
			//		if(test1.Pop() != test2.Pop())
			//		{
			//			return false;
			//		}
			//	}
			//	return true;
			//}
			int counter = 0;
			for(int i = s.Length - 1; i > 0; i--)
			{
				if (s[i] == '#')
				{
					counter++;
				}
				else
				{
					if(counter > 0)
					{
						if( i - counter > 0)
						{
							s = s.Remove(i, counter);
						}
						else
						{
							s = "";
							break;
						}
					}
				}
			}
			counter = 0;
            for (int i = t.Length - 1; i > 0; i--)
            {
                if (t[i] == '#')
                {
                    counter++;
                }
                else
                {
                    if (counter > 0)
                    {
                        if (i - counter > 0)
                        {
                            t = s.Remove(i, counter);
                        }
                        else
                        {
                            t = "";
                            break;
                        }
                    }
                }
            }
			return s.Equals(t);



































        }
	}
}

