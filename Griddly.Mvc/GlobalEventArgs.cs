﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Web;
#if NETFRAMEWORK
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Routing;
using IHtmlHelper = System.Web.Mvc.HtmlHelper;
using ActionContext = System.Web.Mvc.ControllerContext;
#else
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Routing;
#endif

namespace Griddly.Mvc
{
    public class HandleCustomExportArgs
    {
        public HandleCustomExportArgs(GriddlyResult result, NameValueCollection formValues, ActionContext context)
        {
            Result = result;
            FormValues = formValues;
            ActionContext = context;
        }

        public GriddlyResult Result { get; set; }
        public NameValueCollection FormValues { get; set; }
        public ActionContext ActionContext { get; set; }
    }
    public class BeforeRenderArgs
    {
        public BeforeRenderArgs(GriddlySettings settings, GriddlyResultPage resultPage, IHtmlHelper html, bool isFirstRender)
        {
            Settings = settings;
            ResultPage = resultPage;
            Html = html;
            IsFirstRender = isFirstRender;
        }

        public GriddlySettings Settings { get; set; }
        public GriddlyResultPage ResultPage { get; set; }
        public IHtmlHelper Html { get; set; }
        public bool IsFirstRender { get; set; }
    }
    public class GriddlyResultExecutingArgs
    {
        public GriddlyResultExecutingArgs(GriddlyResult result, GriddlySettings settings, ActionContext context)
        {
            Result = result;
            Settings = settings;
            ActionContext = context;
        }

        public GriddlyResult Result { get; }
        public GriddlySettings Settings { get; set; }
        public ActionContext ActionContext { get; set; }
    }
    public class GriddlyPageExecutingArgs
    {
        public GriddlyPageExecutingArgs(GriddlyResult result, GriddlySettings settings, GriddlyContext griddlyContext, ActionContext actionContext)
        {
            Result = result;
            Settings = settings;
            GriddlyContext = griddlyContext;
            ActionContext = actionContext;
        }

        public GriddlyResult Result { get; }
        public GriddlySettings Settings { get; set; }
        public GriddlyContext GriddlyContext { get; set; }
        public ActionContext ActionContext { get; set; }
    }
}
