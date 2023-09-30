namespace CodeFirseCalisma.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using CodeFirseCalisma.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirseCalisma.Models.CodeFirstDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(CodeFirseCalisma.Models.CodeFirstDB context)
        {
            context.Kategorilers.AddOrUpdate(k => k.ID, new Kategoriler() { ID = 1, isim = "Temizlik" });
            context.Tedarikcilers.AddOrUpdate(t => t.ID, new Tedarikciler() { ID = 1, isim = "Domestos",Telefon = "05312268691" });
            context.Urunsler.AddOrUpdate(u => u.ID,new Urunler() { ID=1,KategoriID = 1, TedarikciID = 1, name = "Domestos 5 L Çamaşır Suyu", stok = 20, Fiyat = 25});
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
