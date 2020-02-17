using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System;

namespace WebApplicationJS
{
    public class Program
    {
        #region MAIN
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).UseUrls("http://localhost:5003/").Build().Run();
        }
        #endregion

        #region Function
        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args).UseStartup<Startup>();
        }
        #endregion
    }
}
