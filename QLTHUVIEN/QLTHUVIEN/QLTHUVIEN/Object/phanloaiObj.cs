using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTHUVIEN.Object
{
    class phanloaiObj
    {
        string maloai, tenloai;

        public phanloaiObj() { }
        public phanloaiObj(string maloai, string tenloai)
        {
            this.Maloai = maloai;
            this.Tenloai = tenloai;
        }

        public string Maloai
        {
            get
            {
                return maloai;
            }

            set
            {
                maloai = value;
            }
        }

        public string Tenloai
        {
            get
            {
                return tenloai;
            }

            set
            {
                tenloai = value;
            }
        }
    }
}
