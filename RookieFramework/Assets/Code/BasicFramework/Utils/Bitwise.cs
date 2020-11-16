// personal license onlyps

/*=============================================================================
	 Bitwise.cs
	 2020-11-16 01:46 created by zipzap <zipzap92@163.com>
	 DESC: bitwise operations
=============================================================================*/

namespace Code.BasicFramework.Utils
{
    public static class Bitwise
    {
        public static bool IsEven(int num)
        {
            return (num & 1) == 0;
        }

        public static bool IsPowOf2(int num)
        {
            return (num & (num - 1)) == 0;
        }
        
        public static uint Part1By2(uint n)
        {
            n = (n ^ (n << 16)) & 0xff0000ff; //1
            n = (n ^ (n << 8)) & 0x0300f00f;  //2
            n = (n ^ (n << 4)) & 0x030c30c3;  //3
            n = (n ^ (n << 2)) & 0x09249249;  //4
            return n;
        }

    }
}