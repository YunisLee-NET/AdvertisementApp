using Parviz.AdvertisementApp.DataAccess.Context;
using Parviz.AdvertisementApp.DataAccess.Interface;
using Parviz.AdvertisementApp.DataAccess.Repositories;
using Parviz.AdvertisementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parviz.AdvertisementApp.DataAccess.UnitOfWork
{
    public class UOW:IUOW
    {
        private readonly AdvertisementContext _context;

        public UOW(AdvertisementContext context)
        {
            _context = context;
        }

        public IRepository<T> GetRepository<T>() where T : BaseEntity
        {
            return new Repository<T>(_context);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
