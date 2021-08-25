using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BD;
using WBL;


namespace WebApiRest
{
    public static class ContainerExtensions
    {

        public static IServiceCollection AddDIContainer(this IServiceCollection services)
        {

            services.AddSingleton<IDataAccess, DataAccess>();
            services.AddTransient<ICategoriaService, CategoriaService>();
            services.AddTransient<IProductosService, ProductosService>();
            services.AddTransient<IPedidoService, PedidoService>();
            services.AddTransient<IClienteService, ClienteService>();
            services.AddTransient<IEntregaService, EntregaService>();
            services.AddTransient<ICamionService, CamionService>();
            services.AddTransient<IConductorService, ConductorService>();


            return services;
        }
    }
}
