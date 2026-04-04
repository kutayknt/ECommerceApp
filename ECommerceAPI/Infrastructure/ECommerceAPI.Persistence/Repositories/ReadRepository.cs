using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ECommerceAPI.Application.Repositories;
using ECommerceAPI.Domain.Entities.Common;
using ECommerceAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace ECommerceAPI.Persistence.Repositories
{
    
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly ECommerceAPIDbContext _context;

        public ReadRepository(ECommerceAPIDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll(bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return query;
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return await query.FirstOrDefaultAsync(method);
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true)
        {
            var query = Table.Where(method);
            if(!tracking)
                query = query.AsNoTracking();
            return query;
        }
        public async Task<T> GetByIdAsync(string id, bool tracking = true)
        //=> await Table.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id)); //Marker Pattern Kullanarak böyle bir çözüm de getirebilirdik burada. Marker Pattern'ı kullanmak için IRepository'imizi Generic Yapılanmada gelecek base T olarak BaseEntity ile işaretlemiştik bu sayede burada T'yi BaseEntity olarak kabul ederek bize BaseEntity içerisindeki propertyleri getiriyor.
        //=> await Table.FindAsync(Guid.Parse(id); 
        {
            //Marker Pattern'a geri döndük. Sebebi yapılanmada tracking mekanizması hasıl olduğundan dolayı burada IQueryable durumlarda FindAsync metodunu kullanamamamızdan dolayı burada geri FirstOrDefaultAsync kullanacağız. FirstOrDefaultAsync kullandığıımız durumlarda Marker Pattern'ı kullanıyoruz. Yukarda bununla alakalı detaylı bir açıklama yazdım.
            var query = Table.AsQueryable();
            if(!tracking)
                query = Table.AsNoTracking();
            return await query.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));
        }
    }
}
