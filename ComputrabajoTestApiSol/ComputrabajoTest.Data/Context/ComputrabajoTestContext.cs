using System;
using System.Drawing;
using ComputrabajoTest.Entities.BE;
using ComputrabajoTest.Utilities.Helper.String;
using Faker;
using Microsoft.EntityFrameworkCore;

namespace ComputrabajoTest.Data.Context
{
    public class ComputrabajoTestContext : DbContext
    {
        #region commands run migrations
        //cd ComputrabajoTest.Api
        //dotnet ef migrations add Initial
        //dotnet ef database update
        #endregion

        #region DbSet
        public DbSet<CompanyBE> Company { get; set; }
        public DbSet<PortalBE> Portal { get; set; }
        public DbSet<RoleBE> Rote { get; set; }
        public DbSet<StatusBE> Status { get; set; }
        public DbSet<UserBE> User { get; set; }
        #endregion

        public ComputrabajoTestContext(DbContextOptions<ComputrabajoTestContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Insert default random data with faker library
            #region insert random data for test
            modelBuilder.Entity<RoleBE>().HasData(new RoleBE { Id = 1, Name = "Administrador" });
            modelBuilder.Entity<RoleBE>().HasData(new RoleBE { Id = 2, Name = "Asistente" });

            modelBuilder.Entity<StatusBE>().HasData(new StatusBE { Id = 1, Name = "Activo" });
            modelBuilder.Entity<StatusBE>().HasData(new StatusBE { Id = 2, Name = "Inactivo" });

            int numberOfCompanies = 100;
            for (int i = 1; i < numberOfCompanies; i++)
            {
                modelBuilder.Entity<CompanyBE>().HasData(new CompanyBE { Id = i, Name = HelperString.TruncateString(Faker.Company.Name(), 50) });
                modelBuilder.Entity<PortalBE>().HasData(new PortalBE { Id = i, Name = HelperString.TruncateString(Faker.Internet.DomainName(), 50) });

                var nameUser = HelperString.TruncateString(Faker.Name.FullName(NameFormats.Standard), 50);
                modelBuilder.Entity<UserBE>().HasData(new UserBE
                {
                    Id = i,
                    Name = nameUser,
                    CreatedOn = DateTime.UtcNow.AddDays(-100),
                    Email = HelperString.TruncateString(Faker.Internet.Email(nameUser), 65),
                    Password = "pendiente encriptar",
                    PortalaId = i,
                    RoleId = Faker.RandomNumber.Next(1, 2),
                    CompanyId = i,
                    StatusId = Faker.RandomNumber.Next(1, 2),
                    Telephone = Faker.Phone.Number(),
                    Username = HelperString.TruncateString(Faker.Internet.UserName(nameUser), 30),
                    Fax = HelperString.TruncateString(Faker.Phone.Number(), 30),
                    LastLogin = DateTime.UtcNow.AddDays(-10),
                    DeletedOn = DateTime.UtcNow,
                    UpdatedOn = DateTime.UtcNow,
                });

            }
            #endregion
        }
    }
}

