﻿using System.Web;
using System.Web.Mvc;

namespace Dependency_Injection_using_Unity
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
