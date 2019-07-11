using System;
namespace ApplicationData.Models
{
    public class ConfigPromotion
    {
        public ConfigPromotion()
        {
            Id = new Guid();
            CreateOn = DateTime.Now;
        }

        public Guid Id { get; private set; }
        public string CustomerName { get; set; }
        public int NumberPrizes { get; set; }
        public decimal TotalPrize { get; set; }
        public DateTime CreateOn { get; private set; }
    }
}
