using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerceAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ECommerceAPI.Persistence
{
    //Dotnet CLI kullandığımız zamanlarda proje direkt olarak startup projeden yani Presentation katmanındaki ECommerceAPI.API uygulamasından derlenmeye başlayacak ve burada Design Time hatası alacak. Bu hatayı önlemek adına Persistence katmanı içerisinde bir Design Time sınıfı yazıyoruz ve burada ilgili veritabanımızı verip onun üzerinde yapılacak değişikliklerle veritabanı nesnesi geri döneceğini bildiriyoruz.
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ECommerceAPIDbContext>
    {
        public ECommerceAPIDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<ECommerceAPIDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseNpgsql(Configuration.ConnectionString);
            return new(dbContextOptionsBuilder.Options);
        }
    }
}
