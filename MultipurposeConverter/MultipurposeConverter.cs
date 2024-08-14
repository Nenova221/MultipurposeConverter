using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    public class MultipurposeConverter
    {
        public static float Convert(float fromvalue, string fromunit, string tounit)
        {
            string lbs = "lbs";
            string st = "st";
            string k = "k";
            if (fromunit == lbs && tounit == st )
            {
                return (float)(fromvalue / 14);
            }
            if (fromunit == st && tounit == lbs)
            {
                return (float)(fromvalue * 14);
            }
            if (fromunit == st && tounit == k)
            {
                return (float)(fromvalue * 6.35);
            }
            if (fromunit == k && tounit == st)
            {
                return (float)(fromvalue / 6.35);
            }
            if (fromunit == lbs && tounit == k)
            {
                return (float)(fromvalue / 2.205);
            }
            if (fromunit == k && tounit == lbs)
            {
                return (float)(fromvalue * 2.205);
            }
            throw new ArgumentOutOfRangeException($"Argument {nameof(fromunit)} is out of range");
        }
    }
}
