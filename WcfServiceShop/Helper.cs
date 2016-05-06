using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfServiceShop
{
    public static class Helper
    {
        public static int TryParseToInt(string id)
        {
            int idCustomer;
            if (!Int32.TryParse(id, out idCustomer))
            {
                throw new ArgumentException("TryParseToInt Failed");
            }
            return idCustomer;
        }
    }
}