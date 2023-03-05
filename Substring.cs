using System;
using System.Text;
namespace Interview
{
	public class Substring
	{
		public int sub(string s)
        {
            if(s.Length <= 1)
            {
                return s.Length;
            }
            Dictionary<char, int> passedChar = new Dictionary<char, int>();
            int maxLength = 0;
            int p = 0;
            int startingPoint = 0;
            while (p < s.Length)
            {
                if (!passedChar.ContainsKey(s[p]))
                {
                    passedChar.Add(s[p], p);
                    maxLength = p - startingPoint + 1 > maxLength ?
                        p - startingPoint + 1 : maxLength;
                    p++;


                }else if(passedChar.GetValueOrDefault(s[p]) < startingPoint)
                {
                    passedChar[s[p]] = p;
                    maxLength = p - startingPoint + 1 > maxLength ?
                        p - startingPoint + 1 : maxLength;
                    p++;
                }
                else
                {
                    startingPoint = passedChar.GetValueOrDefault(s[p]) + 1;
                    passedChar[s[p]] = p;
                    p++;

                }
            }
            return maxLength;
        }


	}
}

