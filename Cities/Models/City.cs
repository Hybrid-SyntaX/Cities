using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cities.Models
{
    /// <summary>
    /// City
    /// </summary>
    public class City
    {


        /// <summary>
        /// PrimaryKey in DB
        /// </summary>
        [Key] public Guid Id { set; get; }
        /// <summary>
        /// City Name
        /// </summary>
        public string Name { set; get; }

    }
}
