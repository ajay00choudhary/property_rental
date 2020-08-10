using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using property_rental.model;

namespace property_rental.Data
{
    public class property_rentalContext : DbContext
    {
        public property_rentalContext (DbContextOptions<property_rentalContext> options)
            : base(options)
        {
        }

        public DbSet<property_rental.model.propery_details> propery_details { get; set; }
    }
}
