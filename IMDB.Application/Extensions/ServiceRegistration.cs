using IMDB.Domain.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IMDB.Application.Extensions
{
    public static class ServiceRegistration
    {
        public static void AppApplicationLayer(this IServiceCollection services, IConfiguration confi)
        {
            services.AddOptions<SessionKey>();
            services.Configure<SessionKey>(confi.GetSection("SessionKeys"));
        
        
        }
    }
}
