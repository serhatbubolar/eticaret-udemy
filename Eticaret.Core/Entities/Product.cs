using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Core.Entities
{
    public class Product : IEntity
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public int Price { get; set; }
        public string? ProductCode { get; set; }
        public string? Code { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsHome { get; set; }
        public int parentId { get; set; }
        public string? CategoryId { get; set; }
        public Category? Category{ get; set; }
        public int BrandId { get; set; }
        public Category? Brand { get; set; }
        public int OrderNo { get; set; }
    }
}
