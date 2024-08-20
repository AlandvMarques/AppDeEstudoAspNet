using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace AppMvc.Migrations
{

    internal sealed class Configuration : DbMigrationsConfiguration<AppMvc.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(AppMvc.Models.ApplicationDbContext context)
        {
        }
    }
}
