using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_practice
{
    internal class coadfunction
    {

        //Find the duplicate number in an array of integers.

        public List<int> dublicatearray(List<int> inputarray)
        {
            List<int> result = new List<int>();
            Dictionary<int, int> numberdict = new Dictionary<int, int>();
            foreach(int i in inputarray)
            {
                if (numberdict.ContainsKey(i))
                {
                    numberdict[i] += 1;

                    if(numberdict[i] == 2)
                    {
                        result.Add(i);
                    } 
                }
                else
                {
                    numberdict[i] = 1;
                }
            }
            return result;
        }


        public int[] addsorerarra(int[] a1 , int[] a2)
        {
            
            return a1.Concat(a2).OrderBy(x=>x).ToArray();
        }
    }
}
