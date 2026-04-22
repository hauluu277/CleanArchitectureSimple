using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Spending
    {
        public long Id { get; private set; }
        public string Name { get; private set; }
        public decimal? Amount { get; private set; }
        public DateTime? Date { get; private set; }
        public string? Description { get; private set; } = string.Empty;

        public Spending(string name, decimal? amount = null, DateTime? date = null, string? description = null)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name cannot be null or empty.", nameof(name));
            }
            Name = name;
            Amount = amount;
            Date = date;
            Description = description ?? string.Empty;
        }

        public Spending(string title)
        {
            if(string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentException("Title cannot be null or empty.", nameof(title));
            }
        }
    }
}
