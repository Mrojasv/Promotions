using System;
using Microsoft.EntityFrameworkCore;

namespace ApplicationData.Models
{
    public class PromotionContext : DbContext
    {
        public PromotionContext(DbContextOptions<PromotionContext> options) : base(options)
        {
        }
    }
}
