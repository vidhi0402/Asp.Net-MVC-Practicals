﻿using System.Web;
using System.Web.Mvc;

namespace test_2__using_Javascript_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
