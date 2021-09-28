using Interview.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Infrastructure
{
    public static class StartupSetup
    {
        public static void AddDBContext(this IServiceCollection services, string connectionString) =>
            services.AddDbContext<AppDBContext>(options =>
           options.UseSqlServer(connectionString));
    }
}
