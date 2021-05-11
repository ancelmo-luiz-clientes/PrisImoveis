using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrisImoveis.Donimio.Entidades;
using PrisImoveis.Donimio.Enums;
using System;

namespace PrisImoveis.Infra.Contexto.Maps
{
    public class ImovelMap : IEntityTypeConfiguration<Imovel>
    {
        public void Configure(EntityTypeBuilder<Imovel> builder)
        {
            builder.ToTable("Imoveis");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.TipoDeImovel).IsRequired().HasConversion(v => v.ToString(), v => (ETipoDeImovel)Enum.Parse(typeof(ETipoDeImovel), v)).HasMaxLength(15).IsUnicode(false);
            builder.Property(x => x.Cep).IsRequired().HasMaxLength(10).HasColumnType("varchar(10)");
            builder.Property(x => x.Logradouro).IsRequired().HasMaxLength(100).HasColumnType("varchar(100)");
            builder.Property(x => x.Numero).IsRequired().HasMaxLength(10).HasColumnType("varchar(10)");
            builder.Property(x => x.Descricao).IsRequired().HasColumnType("text");
            builder.Property(x => x.Valor).IsRequired().HasColumnType("decimal(5,2)");
        }
    }
}
