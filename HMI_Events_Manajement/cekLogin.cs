using System;
using System.Collections.Generic;
using System.Configuration.Provider;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HMI_Events_Manajement
{
    internal class cekLogin
    {
        public static bool cekUser(string login)
        {
            try
            {
                
                return true;
            }
            catch
            {

                return false;
            }
        }
    }
}
