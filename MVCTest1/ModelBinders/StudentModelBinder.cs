using MVCTest1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTest1.ModelBinders
{
    public class StudentModelBinder : DefaultModelBinder
    {

        public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            if (bindingContext.ModelType == typeof(Student))
            {
                HttpRequestBase request = controllerContext.HttpContext.Request;

                string frmFName = request.Form.Get("FirstName");
                string frmLName = request.Form.Get("LastName");

                return new Student
                {
                    FirstName = frmFName,
                    LastName = frmLName
                };
            }
            else
            {
                return base.BindModel(controllerContext, bindingContext);
            }
        }

    }
}