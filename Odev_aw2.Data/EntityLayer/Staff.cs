﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_aw2.Data.EntityLayer
{
    public class Staff
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string AddressLine1 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        [NotMapped]
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
    }
    public class StaffConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.Property(x => x.Id).IsRequired(true).UseIdentityColumn();
            builder.Property(x => x.FirstName).IsRequired(true).HasMaxLength(30);
            builder.Property(x => x.LastName).IsRequired(true).HasMaxLength(30);
            builder.Property(x => x.Email).IsRequired(true).HasMaxLength(30);
            builder.Property(x => x.Phone).IsRequired(true).HasMaxLength(11);
            builder.Property(x => x.DateOfBirth).IsRequired(true);
            builder.Property(x => x.AddressLine1).IsRequired(true).HasMaxLength(100);
            builder.Property(x => x.City).IsRequired(true).HasMaxLength(20);
            builder.Property(x => x.Country).IsRequired(true).HasMaxLength(20);
            builder.Property(x => x.Province).IsRequired(true).HasMaxLength(30);

           
            builder.HasIndex(x => x.Email).IsUnique(true);
        }
    }

}
