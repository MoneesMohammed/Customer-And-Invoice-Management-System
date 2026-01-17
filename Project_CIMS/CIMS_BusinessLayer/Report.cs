using CIMS_DataAccessLayar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIMS_BusinessLayer
{
    public class clsReport
    {
        public static DataTable GetSalesReport()
        {
            return clsReportsData.GetSalesReport();
        }

        public static DataTable GetTopProducts()
        {
            return clsReportsData.GetTopProducts();
        }

        public static DataTable GetCustomersReport()
        {
            return clsReportsData.GetCustomersReport();
        }

    }
}
