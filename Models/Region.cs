using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DynamicDropdown.Models
{
    public class Region
    {
        [Key]
        public int Id { get; set; }
        public string RegionId { get; set; }
        public string RegionName { get; set; }

        public string CityId { get; set; }

        public virtual City City { get; set; }
    }
}
