using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Core.Entities
{
    public class Contact : IEntity
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? SurName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Meesage { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}
