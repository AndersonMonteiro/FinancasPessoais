using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinancasPessoais.Infrastructure.DI
{
    public static class MainModule
    {
        public static IServiceCollection RegisterServices(
            this IServiceCollection services)
        {
            // Main Services
            //services.AddTransient<ITestCoreServ, TestCoreServ>();

            // Main Repositories
            //services.AddTransient<ITestCoreRepo, TestCoreRepo>();

            // DatabaseHelper
            
            return services;
        }
    }
}
