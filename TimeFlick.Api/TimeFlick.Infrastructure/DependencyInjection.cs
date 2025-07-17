using DinkToPdf;
using DinkToPdf.Contracts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeFlick.Core.Interfaces;
using TimeFlick.Infrastructure.Services;

namespace TimeFlick.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureDI(this IServiceCollection services)
        {
            services.AddSingleton<IConverter>(new SynchronizedConverter(new PdfTools()));
            services.AddScoped<IPdfGenerator, DinkPdfGenerator>();
            //services.AddScoped<IPdfGenerator, SelectPdfGenerator>();

            // Add other services here
            return services;
        }
    }
}
