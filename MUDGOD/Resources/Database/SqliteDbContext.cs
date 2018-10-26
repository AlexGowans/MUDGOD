using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MUDGOD.Resources.Database {
    public class SqliteDbContext : DbContext {

        public DbSet<PlayerCharacter> playerList { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) {
            string dbLocation = Assembly.GetEntryAssembly().Location.Replace(@"bin\Debug\netcoreapp2.1", @"Data\");  //change the path to our database
            options.UseSqlite($"Data Source={dbLocation}Database.sqlite");
        }
    }
}
