using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFixedView.Entities
{
    public class Personal
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String FirstName { get; set; }

        public Personal(int id, String FirstName, String Name) {
            this.Id = id;
            this.FirstName = FirstName;
            this.Name = Name;
        }
    }
}
