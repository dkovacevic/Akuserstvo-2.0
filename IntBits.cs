using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parovic.Akuserstvo
{
    public class IntBits
    {
        public IntBits(Int64 initialBitValue)
        {
            bits = initialBitValue;
        }

        public bool this[int index]
        {
            get
            {
                return (bits & (1 << index)) != 0;
            }
            set
            {
                Int64 shift = 1;
                if (value)
                    bits |= (shift << index);
                else
                    bits &= ~(shift << index);
            }
        }

        public Int64 Val
        {
            get
            {
                return bits;
            }
            set
            {
                bits = value;
            }
        }

        public decimal ValDec
        {
            get
            {
                return (decimal)bits;
            }
            set
            {
                bits = (Int64)value;
            }
        }

        // indexer declared here
        private Int64 bits;
    }
}
