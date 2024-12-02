using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Core.Entities
{
    public class Category : IEntity
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public bool isActive { get; set; }
        public DateTime CreateDate { get; set; }
        public bool isTopMenu { get; set; }
        public int parentId { get; set; }
        public int OrderNo { get; set; }
        public IList<Product>? Products { get; set;}

    }
}
