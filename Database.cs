using System;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Category
{
    public int CategoryID { get; set; }
    public string? CategoryName { get; set; }
    public string? url { get; set; }

}

public class Satelite
{
    public int SatID { get; set; }
    public string? SatName { get; set; }
    public string? LaunchDate { get; set; }
    public string? Picture { get; set; }

}


//public class SampleDBContext : DbContext
//{
//    private static bool _created = false;
//    public SampleDBContext()
//    {
//        if (!_created)
//        {
//            _created = true;
//            Database.EnsureDeleted();
//            Database.EnsureCreated();
//        }
//    }
//    protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder)
//    {
//        optionbuilder.UseSqlite(@"Data Source=.\SatDB.db");
//    }

//    public DbSet<Category> Categories { get; set; }
//    public DbSet<Satelite> Satelites { get; set; }
//}
