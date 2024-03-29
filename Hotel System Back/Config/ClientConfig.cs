﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hotel_System_Back.Config
{
    /// <summary>
    /// Configuration on Common Proprieties/Attributes for Client Entity 
    /// </summary>
    public class ClientConfig : 
        IEntityTypeConfiguration<Client>
    {
        /// <summary>
        /// Configuration Statements
        /// </summary>
        /// <param name="builder"> <see cref="Client"/> EntityBuilder </param>
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            // Apply Shared Constraints
            ExtendClass.ApplyConstraints(builder);

            // Constraints on Columns
            builder.Property(c => c.Nationality)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);
        }
    }
}
