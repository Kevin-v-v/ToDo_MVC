Imports System.Web.Optimization
'DOCUMENTATION USED FOR THIS PROYECT
'https://learn.microsoft.com/en-us/aspnet/mvc/overview/older-versions/getting-started-with-aspnet-mvc3/vb/
Public Class MvcApplication
    Inherits System.Web.HttpApplication

    Sub Application_Start()
        System.Data.Entity.Database.SetInitializer(Of TaskDBContext)(New ToDo_MVC.Models.TaskInitializer())
        AreaRegistration.RegisterAllAreas()
        FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters)
        RouteConfig.RegisterRoutes(RouteTable.Routes)
        BundleConfig.RegisterBundles(BundleTable.Bundles)
    End Sub
End Class
