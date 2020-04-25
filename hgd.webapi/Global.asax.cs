using Autofac.Integration.WebApi;
using hgd.webapi.AutoFac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace hgd.webapi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // ��ȡwebapi������
            var config = GlobalConfiguration.Configuration;
            // ��ȡwebapi������ע������
            var container = ContainerBuilerCommon.GetWebApiContainer();
            // ����webapi������ע��
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
