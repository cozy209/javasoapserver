using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;

namespace WebApplicationJS
{
    public class Startup
    {
        #region STARTUP
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        #endregion

        #region VARIABLE
        public IConfiguration Configuration { get; }
        #endregion

        #region Configuration des services
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = Microsoft.AspNetCore.Http.SameSiteMode.None;
            });
            //services.AddAuthentication(options =>
            //{
            //    // Store the session to cookies
            //    options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            //    // OpenId authentication
            //    options.DefaultChallengeScheme = OpenIdConnectDefaults.AuthenticationScheme;
            //}).AddCookie("Cookies").AddOpenIdConnect(options =>
            //{
            //    options.Authority = "http://localhost:8080/auth";
            //    // Client configured in the Keycloak
            //    options.ClientId = "APIRest";
            //   
            //
            //    // For testing we disable https (should be true for production)
            //    options.RequireHttpsMetadata = false;
            //    options.SaveTokens = true;
            //
            //    // Client secret shared with Keycloak
            //    options.ClientSecret = "bb2fb726-bcd6-4b51-ab47-a5d33b98fc75";
            //
            //    options.GetClaimsFromUserInfoEndpoint = true;
            //
            //    // OpenID flow to use
            //    options.ResponseType = OpenIdConnectResponseType.CodeIdToken;
            //});
             services.AddAuthentication(options =>
               {
                   options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                   options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                   options.DefaultChallengeScheme = "GitHub";
               })
            .AddCookie()
            .AddOAuth("GitHub", options =>
            {
                options.ClientId = Configuration["GitHub:ClientId"];
                options.ClientSecret = Configuration["GitHub:ClientSecret"];
                options.CallbackPath = new PathString("/signin-github");
            
                options.AuthorizationEndpoint = "https://github.com/login/oauth/authorize";
                options.TokenEndpoint = "https://github.com/login/oauth/access_token";
                options.UserInformationEndpoint = "https://api.github.com/user";
            
                options.ClaimActions.MapJsonKey(ClaimTypes.NameIdentifier, "id");
                options.ClaimActions.MapJsonKey(ClaimTypes.Name, "name");
                options.ClaimActions.MapJsonKey("urn:github:login", "login");
                options.ClaimActions.MapJsonKey("urn:github:url", "html_url");
                options.ClaimActions.MapJsonKey("urn:github:avatar", "avatar_url");
            
                options.Events = new OAuthEvents
                {
                    OnCreatingTicket = async context =>
                    {
                        var request = new HttpRequestMessage(HttpMethod.Get, context.Options.UserInformationEndpoint);
                        request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", context.AccessToken);
            
                        var response = await context.Backchannel.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, context.HttpContext.RequestAborted);
                        response.EnsureSuccessStatusCode();
            
                        var user = JObject.Parse(await response.Content.ReadAsStringAsync());
            
                        context.RunClaimActions(user);
                    }
                };
            });
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }
        #endregion

        #region Configuration application
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }


            app.UseAuthentication();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
        #endregion
    }
}
