using System;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Model;
using System.ComponentModel.DataAnnotations.Schema;

public class SatHistoryLog
{
    [Key]
    public int ID { get; set; }


    [ForeignKey("Satelite")]
    public int SatID { get; set; }
    public string? Longitude { get; set; }
    public string? Latitude { get; set; }
    public string? TimeStamp { get; set; }

}
public class Satelite
{
    [Key] 
    public int SatID { get; set; }
    public string? NORADId { get; set; }
    public string? SatName { get; set; }
    public string? LaunchDate { get; set; }
    public string? Country { get; set; }    
    public string? Picture { get; set; }

}

public class SateliteDBContext : DbContext
{
    
    public SateliteDBContext()
    {
        string FnameCSV = @".\satelites.csv";
        
        string ttt = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string tempDBPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SateliteTempDB.db";
        if (!File.Exists(tempDBPath))
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
          
            foreach (string line in System.IO.File.ReadLines(FnameCSV))
            {
                //temp[0] [2]
                var temp = line.Split(",");
                var dataContext = new SateliteDBContext();

                dataContext.Satelites.Add(new Satelite() { NORADId = temp[2], SatName = temp[0] });

                dataContext.SaveChanges();

            }


        }
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder)
    {
        string tempDBPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SateliteTempDB.db";
        
        optionbuilder.UseSqlite("Data Source=" + tempDBPath);

    }



    public DbSet<Satelite> Satelites { get; set; } //add get to filter for a string?

    public DbSet<SatHistoryLog> SatHistory { get; set; }

}
