using DoctorCRUD.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorCRUD.Data
{
    public class DoctorDbContext : DbContext
    {
        public DoctorDbContext(DbContextOptions options):base (options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }

    
        public DbSet<Doctor> doctors  { get; set; }
        public DbSet<Patient> patients  { get; set; }


    }
}
