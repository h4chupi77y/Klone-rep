using System;

namespace Laba1DLL
{
    public class Summ
    {
        private string a;
        private string b;

        

        public int RecogOperation (string enter)
        {
            int recog = 0;
            int helpint;
            String helpstring;
            String helpstring2;
            for(int i=0;i<enter.Length;i++)
            {
                if (enter[i] == '+')
                {
                    helpint = i;
                    break;
                }
            }
            

            return recog;
        }
    }
}
