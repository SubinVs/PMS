using PMS.Entity;
using System;
using System.Collections.Generic;

namespace PMS.Data.Helper.HMS
{
    public static class TableHelper
    {
        public static Dictionary<Type, string> tables = new Dictionary<Type, string>();

        static TableHelper()
        {
            initialize();
        }

        public static void initialize()
        {
            tables.Add(typeof(HMS_AdvanceControl), "HMS_Tbl_Advance_Control");
            tables.Add(typeof(HMS_Agent), "HMS_Tbl_Agent");
            tables.Add(typeof(HMS_CheckIn), "HMS_Tbl_CheckIn");
            tables.Add(typeof(HMS_City), "HMS_Tbl_City");
            tables.Add(typeof(HMS_Company), "HMS_Tbl_Company");
            tables.Add(typeof(HMS_Control), "HMS_Tbl_Control");
            tables.Add(typeof(HMS_Country), "HMS_Tbl_Country");
            tables.Add(typeof(HMS_Floor), "HMS_Tbl_Floor");
            tables.Add(typeof(HMS_Guest), "HMS_Tbl_Guest");
            tables.Add(typeof(HMS_Outlet), "HMS_Tbl_Outlet");
            tables.Add(typeof(HMS_Plan), "HMS_Tbl_Plan");
            tables.Add(typeof(HMS_Purpose), "HMS_Tbl_Purpose");
            tables.Add(typeof(HMS_Rate), "HMS_Tbl_Rate");
            tables.Add(typeof(HMS_Room), "HMS_Tbl_Room");
            tables.Add(typeof(HMS_RoomType), "HMS_Tbl_Room_Type");
            tables.Add(typeof(HMS_State), "HMS_Tbl_State");
            tables.Add(typeof(HMS_TaxControl), "HMS_Tbl_Tax");
        }
    }
}
