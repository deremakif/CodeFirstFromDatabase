namespace CFFromDatabase
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FootballContext : DbContext
    {
        public FootballContext()
            : base("name=FootballContext")
        {
        }

        public virtual DbSet<PlayerAddress> PlayerAddresses { get; set; }
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Sponsor> Sponsors { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Personnel> Personnels { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Personnel>()
                .HasOptional(e => e.Department)
                .WithMany(e => e.Personnels)
                .HasForeignKey(e => e.DepartmentId);

            modelBuilder.Entity<Personnel>()
                .HasKey(e => e.TcNo);

            modelBuilder.Entity<Personnel>()
                .Property(e => e.TcNo)
                .HasMaxLength(11);

            modelBuilder.Entity<Personnel>()
                .Property(e => e.AdSoyad)
                .IsRequired()
                .HasMaxLength(100);


            modelBuilder.Entity<Department>()
                .Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("varchar");

            modelBuilder.Entity<Player>()
                .HasOptional(e => e.PlayerAddress)
                .WithRequired(e => e.Player);

            modelBuilder.Entity<Sponsor>()
                .HasMany(e => e.Teams)
                .WithMany(e => e.Sponsors)
                .Map(m => m.ToTable("SponsorTeams"));

            modelBuilder.Entity<Team>()
                .HasMany(e => e.Players)
                .WithOptional(e => e.Team)
                .HasForeignKey(e => e.Team_Id);
        }
    }
}
