using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask
{
   class CPublishingHouse
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Adress { get; set; }
        public CPublishingHouse (int id, string name, string adress)
        {
            Id = id;
            Name = name;
            Adress = adress;
        }
    }
}
