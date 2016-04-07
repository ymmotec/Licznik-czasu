using System.Data.Entity;

namespace OEE.Data.DataModel
{
    public partial class LicznikDataModel : DbContext
    {
        // testowa Lokalna baza danych "name=LocalLicznikDataModel"
        // produkcyjna baza danych "name=LicznikDataModel"
        public LicznikDataModel() : base("name=LicznikDataModel")
        {

        }


        public virtual DbSet<Stan> Stan { get; set; }
        public virtual DbSet<Maszyny> Maszyna { get; set; }
        public virtual DbSet<Awaria> Awaria { get; set; }
        public virtual DbSet<Przezbrojenie> Przezbrojenia { get; set; }
        public virtual DbSet<TypZdarzenia> TypZdarzenia { get; set; }
        public virtual DbSet<Linia> Linia { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
