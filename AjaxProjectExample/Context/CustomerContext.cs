using AjaxProjectExample.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace AjaxProjectExample.Context
{
    public class CustomerContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-FUO4J03; initial Catalog=CustomerAjaxDb; integrated Security=true; Trust Server Certificate=True;");
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
