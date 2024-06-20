using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Automarket.Domain.Entity;

namespace Automarket.DAL
{
    class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            //Database.EnsureCreated(); - создание БД
            //EnsureDeleted - удаление БД
        }

        public DbSet<Car> Car { get; set; }
    }
}
