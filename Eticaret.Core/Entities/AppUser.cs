using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Core.Entities
{
    public class AppUser : IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? Phone {  get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool isActive { get; set; }
        public bool isAdmin { get; set; }
        public DateTime CreateDate { get; set; }
        public Guid UserGuid { get; set; } = Guid.Empty;
    }
}
