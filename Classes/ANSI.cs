using System.Collections.Generic;

namespace LZWAlgorithms
{
    public class ANSI
    {
        public static Dictionary<string, uint> Table
        {
            get
            {
                var temp = new Dictionary<string, uint>();
                for (uint i = 0; i < 256; i++)
                    temp.Add(((char)i).ToString(), i);

                return temp;
            }
        }

        public static Dictionary<uint, string> TableReversed
        {
            get
            {
                var temp = new Dictionary<uint, string>();
                for (uint i = 0; i < 256; i++)
                    temp.Add(i, ((char)i).ToString());

                return temp;
            }
        }
    }
}