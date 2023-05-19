using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Odev_aw2.Data.EntityLayer;

namespace Odev_aw2.Data.Context;

public class Aw2DbContext : DbContext
{
    public Aw2DbContext(DbContextOptions<Aw2DbContext> options) : base(options)
    {

    }
    public DbSet<Staff> Staffs { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new StaffConfiguration());
        

        base.OnModelCreating(modelBuilder);
    }

}
