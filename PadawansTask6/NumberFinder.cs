using System;

namespace PadawansTask6
{
    public static class NumberFinder
    {
        public static int NextBiggerThan(int number)
        {

            //throw new NotImplementedException();

            string str = "" + number;
            int[] mass = new int[str.Length];
            char[] chA = str.ToCharArray();
            for(int i = 0; i<chA.Length; i++)
              mass[i] = chA[i] - '0';

            int index = -1;
            int n = -1;
            for (int i = 0; i < mass.Length; i++)
                if (mass[mass.Length - 1 - i] >= mass[mass.Length - 2 - i])
                {
                    index = mass.Length - 2 - i;
                    n = i;
                    break;
                }

            if (index != -1)
            {
                for (int i = 0; i < n + 2; i++)
                {
                    if (mass[mass.Length - 1 - i] >  mass[index])
                    {
                        int tmp = mass[index];
                        mass[index] = mass[mass.Length - 1 - i];
                        mass[mass.Length - 1 - i] = tmp;
                    }
                }
                for (int j = 0; j < n; j++) 
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (mass[mass.Length - 1 - i] > mass.Length - 2 - i)
                        {
                            int tmp = mass[mass.Length - 2 - i];
                            mass[mass.Length - 2 - i] = mass[mass.Length - 1 - i];
                            mass[mass.Length - 1 - i] = tmp;
                        }
                    }
                }
                str = "";
                for (int i = 0; i < mass.Length; i++)
                    str += mass[i];

                return Int32.Parse(str);
            }
            else
                return 0;
        }
    }
}
