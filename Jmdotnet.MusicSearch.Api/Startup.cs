using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jmdotnet.MusicSearch.Service;
using Jmdotnet.MusicSearch.SpotifyWrapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Jmdotnet.MusicSearch.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddControllers();

            var auth = AuthenticationManager
                            .GetToken(new AuthenticationConfig("5eb90c111ca843f8ab790569f39c077d", "3abeddabe063405db9280068cf8dee76", " https://accounts.spotify.com/api/token")).Result;
            

           services.AddScoped<ISpotifyWebAPI>(x => new SpotifyWebAPI(auth.access_token));
           services.AddScoped<ISearchService, SearchService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(
       options => options.WithOrigins("*").AllowAnyMethod()
   );

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

       
    }
}
