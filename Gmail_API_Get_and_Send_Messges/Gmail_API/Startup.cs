namespace Gmail_API
{
    using Google.Apis.Gmail.v1;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.AspNetCore.Authentication.Cookies;

    public class Startup
    {
        public Startup(IConfiguration configuration) => Configuration = configuration;

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddMvc();
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = "Google";
            }).AddCookie().AddGoogle("Google", options =>
            {
                options.ClientId = "702316497690-hdgraei5upb9jb8dpemvfmv773jj3fn6.apps.googleusercontent.com";
                options.ClientSecret = "hqe65rDTEBV9iamtFSSmGOL7";
                //options.ClientId = "914124357276-kdtkspulpdb972hi0vad63jq2smm5s46.apps.googleusercontent.com";
                //options.ClientSecret = "w52nW5x3OaRmO5y8cM825dgN";
                options.CallbackPath = new PathString("/signin-google");
                options.Scope.Add(GmailService.Scope.MailGoogleCom);
                options.Scope.Add(GmailService.Scope.GmailReadonly);
                options.Scope.Add(GmailService.Scope.GmailCompose);
                options.SaveTokens = true;
            });
            services.Configure<IISServerOptions>(options =>
            {
                options.AllowSynchronousIO = true;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) app.UseDeveloperExceptionPage();
            else { app.UseExceptionHandler("/Home/Error"); app.UseHsts(); }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            { endpoints.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}"); });
        }
    }
}
