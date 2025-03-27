using System;
using System.Text;

int[] s = new int[]
{
	7, 12, 17, 22,  7, 12, 17, 22,  7, 12, 17, 22,  7, 12, 17, 22,
	5,  9, 14, 20,  5,  9, 14, 20,  5,  9, 14, 20,  5,  9, 14, 20,
	4, 11, 16, 23,  4, 11, 16, 23,  4, 11, 16, 23,  4, 11, 16, 23,
	6, 10, 15, 21,  6, 10, 15, 21,  6, 10, 15, 21,  6, 10, 15, 21
};

uint[] k = new uint[64];
for (int i = 0; i < k.Length; i++)
{
	k[i] = (uint)Math.Floor(Math.Pow(2, 32) * Math.Abs(Math.Sin(i + 1)));
}

uint a0 = 0x67452301;
uint b0 = 0xefcdab89;
uint c0 = 0x98badcfe;
uint d0 = 0x10325476;

byte[] message = Encoding.UTF8.GetBytes(args[0]);

