using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;


namespace WindowsFormsApplication1
{
    class date_shamsi
    {
        public string DateShamsi()
        {
            string S;
            PersianCalendar p = new PersianCalendar();
            string mmmm = "", dddd = "";
         
            if (p.GetMonth(System.DateTime.Now) < 10)
                mmmm = "0" + p.GetMonth(System.DateTime.Now).ToString();
            else
                mmmm = p.GetMonth(System.DateTime.Now).ToString();

            if (p.GetDayOfMonth(System.DateTime.Now) < 10)
                dddd = "0" + p.GetDayOfMonth(System.DateTime.Now).ToString();
            else
                dddd = p.GetDayOfMonth(System.DateTime.Now).ToString();
            S = p.GetYear(System.DateTime.Now) + "/" + mmmm + "/" + dddd ;
            return S;
        }

  
    }
}
