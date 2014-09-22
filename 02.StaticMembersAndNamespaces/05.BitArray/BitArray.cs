using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _05.BitArray
{
    class BitArray
    {
        private int size;
        private uint[] bits;
        private int remainder;

        public BitArray(int size)
        {
            this.Size = size;
            bits = InitBits(this.size);
        }

        public int Size
        { 
            get { return this.size; }
            set 
            {
                if (value < 1 || value > 100000)
                {
                    throw new ArgumentOutOfRangeException("Size should be between [1...1000 000]");
                }
                this.size = value;
            }
        }

        private uint[] InitBits(int size)
        {
            int bytes = size / 32;
            this.remainder = size % 32;
            if (remainder != 0)
            {
                bytes++;
            }
            uint[] b = new uint[bytes];
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = 0;
            }
            return b;
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= this.size)
                {
                    throw new ArgumentOutOfRangeException(String.Format("Index {0} is not in range [0...{1})", index, this.size));
                }
                int bytes = index / 32;
                uint cByte = this.bits[bytes];
                if ((cByte & (1 << index)) == 0)
                    return 0;
                else
                    return 1;
            }

            set
            {
                if (index < 0 || index >= this.size)
                {
                    throw new ArgumentOutOfRangeException(String.Format("Index {0} is not in range [0...{1})", index, this.size));
                }
                if (value != 0 && value != 1)
                {
                    throw new ArgumentException("Bits can only be 1 or 0!");
                }

                int bytes = index / 32;
                uint cByte = this.bits[bytes];
                cByte &= ~((uint)(1 << index));
                cByte |= (uint)(value << index);
                this.bits[bytes] = cByte;
            }
        }
        public override string ToString()
        {
            BigInteger result = new BigInteger(0);
            for (int i = 0; i < this.size; i++)
            {
                BigInteger bit = new BigInteger(this[i]);
                result += BigInteger.Pow(2, i) * bit;
            }
            return result.ToString("R");
        }
    }
}
