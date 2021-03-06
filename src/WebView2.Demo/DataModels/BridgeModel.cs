﻿using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core;

namespace WebView2.Demo.DataModels
{
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [Route("Bridge")]
    public class BridgeModel : ViewModelBase
    {
        [Get("DataLoad")]
        public CoreWebView2WebResourceResponse DataLoad(CoreWebView2WebResourceRequest request)
        {
            var context = GetQueryParameters(request.Uri);
            var response = Text(context["Name"]);
            return response;
        }
    }
}