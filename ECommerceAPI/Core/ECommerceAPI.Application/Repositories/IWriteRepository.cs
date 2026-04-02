using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerceAPI.Domain.Entities.Common;

namespace ECommerceAPI.Application.Repositories
{
    //Burada Query İşlemlerini Yapacak ORM Araçlarını Kullanan Kendi Metodlarımızı Yazacağız..
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task<bool> AddAsync(T model);
        Task<bool> AddAsync(List<T> model);
        Task<bool> Remove(T model);
        Task<bool> Remove(string id);
        Task<bool> UpdateAsync(T model);
    }
}
