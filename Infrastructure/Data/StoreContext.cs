using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Infrastructure.Data
{
    public class StoreContext : DbContext //DbContext is a class in EF.
                                          //It is a bridge between your domain
                                          //or entity classes and the database.
                                          //The primary class that is responsible
                                          //for interacting with data as objects
                                          //DbContext.
                                          //One of the classes is Find method
                                          //Used to find entities inside our database
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }


        public DbSet<Product> Products { get; set; } //Products is the name of the table we want to grab information from.


    }
}
