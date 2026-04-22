using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class AppDBContext : DbContext
    {
        public DbSet<Spending> Spending => Set<Spending>();
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }

    }
}
