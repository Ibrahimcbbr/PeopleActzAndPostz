﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PeopleActzAndPostz.Domain.Models.DbEntities.IdentityEntities;

namespace PeopleActzAndPostz.Infrastructure.EntityFramework.MappingConfigurations.IdentityMappings
{
    public class UserClaimMap : IEntityTypeConfiguration<AppUserClaim>
    {
        public void Configure(EntityTypeBuilder<AppUserClaim> builder)
        {
            // Primary key
            builder.HasKey(uc => uc.Id);

            // Maps to the AspNetUserClaims table
            builder.ToTable("AspNetUserClaims");

        

        }
    }
 }

