using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDR.Service
{
    class SuperGlobal
    {
        //global Name
        private static string v_GlobalName = "";
        public static string GlobalName
        {
            get { return v_GlobalName; }
            set { v_GlobalName = value; }
        }

        private static string v_GlobalName2 = "";
        public static string GlobalName2
        {
            get { return v_GlobalName2; }
            set { v_GlobalName2 = value; }
        }
    }
}
