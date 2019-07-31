using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Sale.ApplicationService.Customers;
using Sale.ApplicationService.Invoices;
using Sale.ApplicationService.Products;
using Sale.Contract.Common;
using Sale.Contract.Customers;
using Sale.Contract.Invoices;
using Sale.Contract.Products;
using Sale.DomainService.Customers;
using Sale.DomainService.Invoices;

using Sale.Infrastructure.EntityFramework;
using Sale.Infrastructure.Validations;

namespace Sale.ApplicationService
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1).AddJsonOptions(options => {
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            });
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"), optionsBuilder =>
                 optionsBuilder.MigrationsAssembly("Sale.ApplicationService")));

            services.AddScoped(typeof(IGenericValidation<>), typeof(GenericValidation<>));
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            
            services.AddTransient<IProductDomainService, ProductDomainService>();
            services.AddTransient<ICustomerApplicationService, CustomerApplicationService>();
            services.AddTransient<IInvoiceApplicationService, InvoiceApplicationService>();
            services.AddTransient<IProductApplicationService, ProductApplicationService>();
            services.AddTransient<IInvoiceDomainService, InvoiceDomainService>();
            services.AddTransient<ICustomerDomainService, CustomerDomainService>();
            services.AddTransient<IProductDomainService, ProductDomainService>();
           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
