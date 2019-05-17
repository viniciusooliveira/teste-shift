using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Cors.Internal;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Teste.Infra.Data.Context;

namespace API
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddJsonOptions(o => {
                    o.SerializerSettings.DateFormatString = "dd/MM/yyyy";
                    o.SerializerSettings.Culture = CultureInfo.InvariantCulture;
                });

            services.AddCors(o =>
            {
#if DEBUG
                // Configurações de DEBUG
                o.AddPolicy("DefaultCORS",
                    b =>
                    {
                        b.AllowAnyOrigin();
                        b.AllowAnyHeader();
                        b.AllowAnyMethod();
                    }
                );
#endif
            });

            services.Configure<MvcOptions>(o =>
            {
                o.Filters.Add(new CorsAuthorizationFilterFactory("DefaultCORS"));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
            public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
