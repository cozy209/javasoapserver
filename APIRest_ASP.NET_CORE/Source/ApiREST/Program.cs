using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace ApiREST
{
    public static class Program
    {
        #region MAIN
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).UseUrls("http://localhost:5000/").Build().Run();
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
