﻿using System.Web;
using System.Web.Routing;
using System.Collections.Generic;

namespace Cassette.Web
{
    public class AssetRouteHandler : IRouteHandler
    {
        public AssetRouteHandler(CassetteApplication application)
        {
            this.application = application;
        }

        readonly CassetteApplication application;

        public IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            return new AssetRequestHandler(
                requestContext,
                application.FindModuleContainingPath
            );
        }
    }
}