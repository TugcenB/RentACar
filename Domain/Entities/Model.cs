using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Model: Entity<Guid>
    {
        public int BrandId { get; set; }
        public decimal DailyPrice { get; set; }
        public string ImageUrl { get; set; }
    }
    
}
