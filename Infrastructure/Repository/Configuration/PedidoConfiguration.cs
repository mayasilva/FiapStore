﻿using Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace Infrastructure.Repository.Configuration
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            
            builder.ToTable("pedido");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnType("INT").ValueGeneratedNever().UseIdentityColumn();
            builder.Property(p => p.DataCriacao).HasColumnType("DATETIME").IsRequired();
            builder.Property(p => p.ClienteId).HasColumnType("INT").IsRequired();
            builder.Property(p => p.LivroId).HasColumnType("INT").IsRequired();
            
            builder.HasOne(p => p.Cliente)
            .WithMany(c => c.Pedidos)
            .HasPrincipalKey(c => c.Id);
            
            builder.HasOne(p => p.Livro)
            .WithMany(l => l.Pedidos)
            .HasPrincipalKey(l => l.Id);

            
        }
    }
}
