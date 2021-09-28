using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text;
using Microsoft.EntityFrameworkCore;
using MasterProject.Core.Entities;

namespace Interview.Infrastructure.Data.Config
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            List<Client> clients = new List<Client> {
            new Client { Name = "ABC Client", Id = Guid.Parse("15789274-A08E-4CCB-A149-BDE633421026"), CreatedOn = DateTime.Now }
            };
            builder.HasData(clients);
            builder.Property(s => s.CreatedOn)
                    .HasDefaultValueSql("GETDATE()");

            builder.Property(s => s.Id)
                     .HasDefaultValueSql("NEWID()");
        }
    }
}
