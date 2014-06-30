using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxErrorModal.Controllers
{
    public class BaseController : Controller
    {
        protected override void OnException(ExceptionContext filterContext)
        {
            // It's important to be aware that no exception that originates outside the controller will be caught by OnException
            if (Request.IsAjaxRequest())
            {
                 
            }

            base.OnException(filterContext);
        }
	}
}