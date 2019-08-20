using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

[assembly: OwinStartupAttribute(typeof(SignalRDemo.RouteConfig))]
namespace SignalRDemo
{
    public class RouteConfig
    {
        /// <summary>
        /// 配置你的信息 可以连带 [assembly: OwinStartupAttribute(typeof(SignalDemo.RouteConfig))]
        /// 如果有Startup.cs可以写到 Startup 中
        /// 或者 创建个 Startup.cs (我这里懒得创建 所以直接写到了路由配置上面 效果一样)
        /// </summary>
        /// <param name="app"></param>
        #region MyRegion
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
        #endregion
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
