using Gas_Laws.Pages;
using Gas_Laws.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using System.Windows.Controls;

namespace Gas_Laws
{
    public class ViewModelLocator
    {
        public static ServiceProvider _provider;

        public static void Init()
        {
            var services = new ServiceCollection();

            //VM
            services.AddTransient<MainViewModel>();
            services.AddScoped<BoylesVM>();
            services.AddScoped<LussacsVM>();
            services.AddScoped<CharlesVM>();

            //Pages
            services.AddScoped<Boyles_Law>();
            services.AddScoped<Gay_Lussacs_Law>();
            services.AddScoped<Charles_Law>();

            services.AddScoped<Porshen>();

            _provider = services.BuildServiceProvider();

            foreach (var item in services)
            {
                _provider.GetRequiredService(item.ServiceType);
            }
        }

        public static MainViewModel MainViewModel => _provider.GetRequiredService<MainViewModel>();
        public static BoylesVM BoylesVM => _provider.GetRequiredService<BoylesVM>();
        public static LussacsVM LussacsVM => _provider.GetRequiredService<LussacsVM>();
        public static CharlesVM CharlesVM => _provider.GetRequiredService<CharlesVM>();

        public static Page Boyles_Law => _provider.GetRequiredService<Boyles_Law>();
        public static Page Gay_Lussacs_Law => _provider.GetRequiredService<Gay_Lussacs_Law>();
        public static Page Charles_Law => _provider.GetRequiredService<Charles_Law>();

        public static Porshen Porshen => _provider.GetRequiredService<Porshen>();


    }
}
