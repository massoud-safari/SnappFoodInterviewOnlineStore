using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Domain.Entities
{
    public sealed class Product
    {
        [Key]
        public int Id { get; set; }

        [StringLength(maximumLength: 40)]
        public string Title { get; set; }
        public int InventoryCount { get; set; }
        public decimal Price { get; set; }
        public double Discount { get; set; }
    }
}