using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PrisImoveis.Infra.ApiClients;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrisImoveis.WebApp.Extensions
{
    public static class ApiClientExtensions
    {
        public static void AddApiClients(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddRefitClient<IViaCep>().ConfigureHttpClient(x => x.BaseAddress = new Uri(configuration["UrlViaCep"]));
        }
    }
}
