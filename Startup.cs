using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MiPrimerApi.DataProvider;

namespace MiPrimerApi
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
            services.AddControllers();
            
            //services.AddDbContext<MusicStoreContext>(x =>)
            services.AddScoped<IAlbumDataProvider,AlbumDataProviderFake>(); // le digo que cuando necesite un IAlbumDataProvider le mande un AlbumDataProviderFake // vive lo que dure el request
            //services.AddTransient<IAlbumDataProvider,AlbumDataProviderFake>(); // 
            //services.AddSingleton<IAlbumDataProvider,AlbumDataProviderFake>();// crea AlbumDataProviderFake y lo deja vivo todo el tiempo para enviarlo cuando lo necesite, singleton

            //Quitamos las validaciones de los objetos de los atributos (en Album)
            services.Configure<ApiBehaviorOptions>(ppt => ppt.SuppressModelStateInvalidFilter = true);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

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
