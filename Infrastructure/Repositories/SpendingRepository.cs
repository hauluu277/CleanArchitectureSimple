using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class SpendingRepository : ISpendingRepository
    {
        private readonly AppDBContext _context;

        public SpendingRepository(AppDBContext context)
        {
            _context = context;
        }

        public async Task AddSpendingAsync(Spending spending)
        {
            _context.Spending.Add(spending);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Spending>> GetAllSpendingAsync()
        {
            return await _context.Spending.ToListAsync();
        }

        public async Task<Spending> GetSpendingByIdAsync(long id)
        {
            return await _context.Spending.FindAsync(id);
        }
    }
}
