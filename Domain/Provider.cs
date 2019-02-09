using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Provider
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public string Email { get; set; }
        public bool IsApproved { get; set; }
        public string Password { get; set; }
        public string ComfirmPwd { get; set; }
        public string UserName { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
