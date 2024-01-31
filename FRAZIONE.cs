using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frazione_con_mcd
{
    internal class FRAZIONE
    {
        public int num { get; set; }
        public int den { get; set; }
        public int mcd { get; set; }
        public int mcm { get; set; }
        public int numsempl { get; set; }
        public int densempl { get; set; }



        public FRAZIONE(int num, int den)
        {
            this.num = num;
            this.den = den;

        }

        public int mcd1()
        {
            while (num != den)
            {
                if (num > den)
                {
                    num = num - den;
                }
                else
                {
                    den = den - num;
                }
            }
            mcm = num;
            mcd = (num * den) / mcm;
            numsempl = num / mcd;
            densempl = den / mcd;
            return mcd;
        }

        public override string ToString()
        {
            return string.Format("mcd : {0}\n frazione: {1}/{2}", mcd, numsempl, densempl);
        }

        public int returnnum()
        {
            return numsempl;
        }

        public int returnden()
        {
            return densempl;
        }


    }
}
