using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxErrorModal.Controllers
{
    public class ErrorController : Controller
    {
        public string NotFound()
        {
            var result = "Could not find the resource";
            
            return result;
        }
	}
}