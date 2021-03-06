// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Software_2.Data;

namespace Software_2.Migrations
{
    [DbContext(typeof(InventarioContext))]
    [Migration("20210615184935_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Software_2.Models.Cliente", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Cantidad")
                        .HasColumnName("cantidad")
                        .HasColumnType("integer");

                    b.Property<string>("Celular")
                        .HasColumnName("celular")
                        .HasColumnType("text");

                    b.Property<string>("Direccion")
                        .HasColumnName("direccion")
                        .HasColumnType("text");

                    b.Property<string>("Nombre")
                        .HasColumnName("nombre")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("t_cliente");
                });

            modelBuilder.Entity("Software_2.Models.EntradaProducto", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("ProductoId")
                        .HasColumnType("integer");

                    b.Property<int>("cantidadEntrada")
                        .HasColumnName("cantidadEntrada")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.HasIndex("ProductoId");

                    b.ToTable("t_EntradaProducto");
                });

            modelBuilder.Entity("Software_2.Models.Producto", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("cantidad")
                        .HasColumnName("cantidad")
                        .HasColumnType("integer");

                    b.Property<string>("color")
                        .IsRequired()
                        .HasColumnName("color")
                        .HasColumnType("text");

                    b.Property<string>("modelo")
                        .IsRequired()
                        .HasColumnName("modelo")
                        .HasColumnType("text");

                    b.Property<string>("product")
                        .IsRequired()
                        .HasColumnName("product")
                        .HasColumnType("text");

                    b.Property<string>("sexo")
                        .IsRequired()
                        .HasColumnName("sexo")
                        .HasColumnType("text");

                    b.Property<string>("tallas")
                        .IsRequired()
                        .HasColumnName("tallas")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("t_producto");
                });

            modelBuilder.Entity("Software_2.Models.ProductoH", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Codigo")
                        .HasColumnName("codigo")
                        .HasColumnType("text");

                    b.Property<string>("Color")
                        .HasColumnName("color")
                        .HasColumnType("text");

                    b.Property<string>("Descripcion")
                        .HasColumnName("descri")
                        .HasColumnType("text");

                    b.Property<string>("Nombre")
                        .HasColumnName("nombre")
                        .HasColumnType("text");

                    b.Property<int>("Talla40")
                        .HasColumnName("talla40")
                        .HasColumnType("integer");

                    b.Property<int>("Talla41")
                        .HasColumnName("talla41")
                        .HasColumnType("integer");

                    b.Property<int>("Talla42")
                        .HasColumnName("talla42")
                        .HasColumnType("integer");

                    b.Property<int>("Talla43")
                        .HasColumnName("talla43")
                        .HasColumnType("integer");

                    b.Property<string>("Tipo")
                        .HasColumnName("tipo")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("t_hombre");
                });

            modelBuilder.Entity("Software_2.Models.ProductoM", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Codigo")
                        .HasColumnName("codigo")
                        .HasColumnType("text");

                    b.Property<string>("Color")
                        .HasColumnName("color")
                        .HasColumnType("text");

                    b.Property<string>("Descripcion")
                        .HasColumnName("descri")
                        .HasColumnType("text");

                    b.Property<string>("Nombre")
                        .HasColumnName("nombre")
                        .HasColumnType("text");

                    b.Property<int>("Talla35")
                        .HasColumnName("talla35")
                        .HasColumnType("integer");

                    b.Property<int>("Talla36")
                        .HasColumnName("talla36")
                        .HasColumnType("integer");

                    b.Property<int>("Talla37")
                        .HasColumnName("talla37")
                        .HasColumnType("integer");

                    b.Property<int>("Talla38")
                        .HasColumnName("talla38")
                        .HasColumnType("integer");

                    b.Property<int>("Talla39")
                        .HasColumnName("talla39")
                        .HasColumnType("integer");

                    b.Property<string>("Tipo")
                        .HasColumnName("tipo")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("t_mujer");
                });

            modelBuilder.Entity("Software_2.Models.ProductoN", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Codigo")
                        .HasColumnName("codigo")
                        .HasColumnType("text");

                    b.Property<string>("Color")
                        .HasColumnName("color")
                        .HasColumnType("text");

                    b.Property<string>("Descripcion")
                        .HasColumnName("descri")
                        .HasColumnType("text");

                    b.Property<string>("Nombre")
                        .HasColumnName("nombre")
                        .HasColumnType("text");

                    b.Property<string>("Sexo")
                        .HasColumnName("sexo")
                        .HasColumnType("text");

                    b.Property<int>("Talla25")
                        .HasColumnName("talla25")
                        .HasColumnType("integer");

                    b.Property<int>("Talla26")
                        .HasColumnName("talla26")
                        .HasColumnType("integer");

                    b.Property<int>("Talla27")
                        .HasColumnName("talla27")
                        .HasColumnType("integer");

                    b.Property<int>("Talla28")
                        .HasColumnName("talla28")
                        .HasColumnType("integer");

                    b.Property<int>("Talla29")
                        .HasColumnName("talla29")
                        .HasColumnType("integer");

                    b.Property<int>("Talla30")
                        .HasColumnName("talla30")
                        .HasColumnType("integer");

                    b.Property<string>("Tipo")
                        .HasColumnName("tipo")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("t_nino");
                });

            modelBuilder.Entity("Software_2.Models.Registrar", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Apellido")
                        .HasColumnName("apellido")
                        .HasColumnType("text");

                    b.Property<string>("Cargo")
                        .HasColumnName("cargo")
                        .HasColumnType("text");

                    b.Property<string>("Contraseña")
                        .HasColumnName("contraseña")
                        .HasColumnType("text");

                    b.Property<string>("Correo")
                        .HasColumnName("correo")
                        .HasColumnType("text");

                    b.Property<string>("DNI")
                        .HasColumnName("dni")
                        .HasColumnType("text");

                    b.Property<string>("Nombre")
                        .HasColumnName("nombre")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("t_usuario");
                });

            modelBuilder.Entity("Software_2.Models.RegistroS", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Cantidad")
                        .HasColumnName("cantidad")
                        .HasColumnType("integer");

                    b.Property<string>("Codigo")
                        .HasColumnName("codigo")
                        .HasColumnType("text");

                    b.Property<string>("Color")
                        .HasColumnName("color")
                        .HasColumnType("text");

                    b.Property<string>("Nombre")
                        .HasColumnName("nombre")
                        .HasColumnType("text");

                    b.Property<string>("Sexo")
                        .HasColumnName("sexo")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("t_ventas");
                });

            modelBuilder.Entity("Software_2.Models.EntradaProducto", b =>
                {
                    b.HasOne("Software_2.Models.Producto", "producto")
                        .WithMany("EntradaProductos")
                        .HasForeignKey("ProductoId");
                });
#pragma warning restore 612, 618
        }
    }
}
