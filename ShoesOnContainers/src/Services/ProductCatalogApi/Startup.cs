using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProductCatalogApi.Data;
using System;

namespace ProductCatalogApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            //Configuration objesi sayesinde settings(appsettings) json filelardan istediğimiz key value pair değerini çekebiliriz.
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            //appsettings'deki ExternalCatalogBaseUrl değerini CatalogSettingsdeki propertye set etmiş olduk.
            services.Configure<CatalogSettings>(Configuration);
            //docker-compose up ile servisi çalıştırdığımız zaman docker-compose'daki ConnectionStringi alır. VS'den çalıştırdığımızda appsettings.json alır.
            services.AddDbContext<CatalogContext>(options => options.UseSqlServer(Configuration["ConnectionString"]));

            services.AddMvc();

            services.AddSwaggerGen(options =>
            {
                options.DescribeAllEnumsAsStrings();
                options.SwaggerDoc("v1", new Swashbuckle.AspNetCore.Swagger.Info
                {
                    Title = "ShoesOnContainers - Product Catalog HTTP API",
                    Version = "v1",
                    Description = "The Product Catalog Microservice HTTP API. This is a Data-Driven/CRUD microservice sample",
                    TermsOfService = "Terms Of Service"
                });
            });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger()
                .UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint($"/swagger/v1/swagger.json", "ProductCatalogAPI V1");
                });

            //app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
