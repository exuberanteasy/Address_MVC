using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace DynamicDropdown.Models
{
    

    public class AddressModel
    {

    }

    //public class City
    //{
    //    [Key]
    //    public int Id { get; set; }
    //    public string CityId { get; set; }
    //    public string CityName { get; set; }

    //    public virtual ICollection<Region> Regions { get; set; }
    //}

    //public class Region
    //{
    //    [Key]
    //    public int Id { get; set; }
    //    public string RegionId { get; set; }
    //    public string RegionName { get; set; }

    //    public string CityId { get; set; }

    //    public virtual City City { get; set; }
    //}

    public class CRContext : DbContext
    {
        public CRContext() : base("CRConnection")
        {

        }


        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
    }




}
