using DinkToPdf;
using DinkToPdf.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeFlick.Core.Interfaces;
using TimeFlick.Infrastructure.Data;
using TimeFlick.Infrastructure.Repositories;
using TimeFlick.Infrastructure.Services;

namespace TimeFlick.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureDI(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            services.AddSingleton<IConverter>(new SynchronizedConverter(new PdfTools()));
            services.AddScoped<IPdfGenerator, DinkPdfGenerator>();
            //services.AddScoped<IPdfGenerator, SelectPdfGenerator>();

            // Add other services here
            services.AddScoped<IPersonRepository, PersonRepository>();
            //services.AddScoped<IUnitOfWork, UnitOfWork>();
            // আরও প্রয়োজনীয় সার্ভিস

            return services;
        }
    }
}
