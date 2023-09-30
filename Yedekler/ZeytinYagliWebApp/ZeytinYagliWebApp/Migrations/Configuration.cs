namespace ZeytinYagliWebApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ZeytinYagliWebApp.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<OliveOilDBModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;   
        }

        protected override void Seed(ZeytinYagliWebApp.Models.OliveOilDBModel context)
        {
            context.Managers.AddOrUpdate(x => x.ID, new Manager() { ID = 1, Name = "Ozan", Surname = "Ögel", Password = "1234", Mail = "ozanogel2005@gmail.com", IsAdmin = true });

        }
    }
}
