using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DynamicDropdown.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        public string CityId { get; set; }
        public string CityName { get; set; }

        public virtual ICollection<Region> Regions { get; set; }
    }
}
