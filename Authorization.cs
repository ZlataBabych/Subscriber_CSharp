using System.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subscriber
{
    public class Authorization
    {
        public static int losUser
        {
            get;
            set;
        }

        public int LogCheck(string logText, string pswText)
        {
            losUser = 0;

            if((logText == "Editor") && (pswText == "222"))
            {
                losUser = 2;
            }

            return losUser;
        }
    }
}
