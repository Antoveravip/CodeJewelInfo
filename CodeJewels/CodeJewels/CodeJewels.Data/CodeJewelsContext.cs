namespace CodeJewels.Data
{
    using CodeJewels.Models;
    using System.Data.Entity;

    public class CodeJewelsContext : DbContext
    {
        public CodeJewelsContext()
            : base("CodeJewels")
        {
        }

        public DbSet<CodeJewel> CodeJewels { get; set; }
        public DbSet<CodeJewelCategory> CodeJewelCategory { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}