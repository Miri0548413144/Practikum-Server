using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
  public class DataContext:DbContext
  {
    public DbSet<Worker> Workers { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<WorkerRole> WorkerRole { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer("Server=34.122.63.173;Database=Miri_workersDb;Uid=SqlServer;Pwd=123456;TrustServerCertificate=Yes");
    }

  }
}
