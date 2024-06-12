using Microsoft.EntityFrameworkCore;
using Migrations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrations.Data
{
    internal class JobContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS01;Database=master;Trusted_Connection=True;");
        }
        public DbSet<Job> Jobs {  get; set; }
    }
}
