using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppDemo.Enttities;

namespace WebAppDemo.DataContext
{
    public class DatabaseContext : DbContext
    {
        
        public DatabaseContext()
        {
            
        }

        public DbSet<User> Users { get; set; }

        public DbSet<AssetsDetails> assetsDetails { get; set; }

       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source =DESKTOP-HA42MEA\SQLEXPRESS; initial catalog =AssestDemo; persist security info =True; user id =sa; password =Sql@2019; MultipleActiveResultSets=True; ");
        }

    }
}
