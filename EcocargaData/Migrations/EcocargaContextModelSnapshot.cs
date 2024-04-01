﻿// <auto-generated />
using System;
using Cl.Gob.Energia.Ecocarga.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cl.Gob.Energia.Ecocarga.Data.Migrations
{
    [DbContext(typeof(EcocargaContext))]
    partial class EcocargaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Cl.Gob.Energia.Ecocarga.Data.Models.DataAuto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("CapacidadBateria")
                        .HasColumnName("capacidad_bateria");

                    b.Property<double>("CapacidadInversorInternoAc")
                        .HasColumnName("capacidad_inversor_interno_ac");

                    b.Property<string>("CodigoInformeTecnico")
                        .IsRequired()
                        .HasColumnName("codigo_informe_tecnico")
                        .HasMaxLength(50);

                    b.Property<Guid>("IdPublico")
                        .HasColumnName("id_publico");

                    b.Property<string>("Imagen")
                        .HasColumnName("imagen")
                        .HasMaxLength(100);

                    b.Property<int>("MarcaId")
                        .HasColumnName("marca_id");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnName("modelo")
                        .HasMaxLength(100);

                    b.Property<double>("RendimientoElectrico")
                        .HasColumnName("rendimiento_electrico");

                    b.Property<int?>("TipoConectorAcId")
                        .HasColumnName("tipo_conector_ac_id");

                    b.Property<int?>("TipoConectorDcId")
                        .HasColumnName("tipo_conector_dc_id");

                    b.Property<string>("Traccion")
                        .IsRequired()
                        .HasColumnName("traccion")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.HasIndex("MarcaId");

                    b.HasIndex("TipoConectorAcId");

                    b.HasIndex("TipoConectorDcId");

                    b.ToTable("data_auto");
                });

            modelBuilder.Entity("Cl.Gob.Energia.Ecocarga.Data.Models.DataCargador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Cable")
                        .HasColumnName("cable");

                    b.Property<int>("ElectrolineraId")
                        .HasColumnName("electrolinera_id");

                    b.Property<string>("EstadoCargador")
                        .HasColumnName("estado_cargador")
                        .HasMaxLength(50);

                    b.Property<string>("IdCargadorCliente")
                        .IsRequired()
                        .HasColumnName("id_cargador_cliente")
                        .HasMaxLength(100);

                    b.Property<string>("IdCargadorSec")
                        .IsRequired()
                        .HasColumnName("id_cargador_sec")
                        .HasMaxLength(100);

                    b.Property<int?>("IdEstadoCargador")
                        .HasColumnName("id_estado_cargador");

                    b.Property<double>("Potencia")
                        .HasColumnName("potencia");

                    b.Property<int>("TipoConectorId")
                        .HasColumnName("tipo_conector_id");

                    b.Property<string>("TipoCorriente")
                        .IsRequired()
                        .HasColumnName("tipo_corriente")
                        .HasMaxLength(2);

                    b.HasKey("Id");

                    b.HasIndex("ElectrolineraId");

                    b.HasIndex("TipoConectorId");

                    b.ToTable("data_cargador");
                });

            modelBuilder.Entity("Cl.Gob.Energia.Ecocarga.Data.Models.DataCompania", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("nombre")
                        .HasMaxLength(30);

                    b.Property<string>("RutPropietario")
                        .IsRequired()
                        .HasColumnName("rut_propietario")
                        .HasMaxLength(15);

                    b.Property<string>("UrlImage")
                        .HasColumnName("url_image")
                        .HasMaxLength(100);

                    b.Property<string>("UrlInImage")
                        .HasColumnName("url_in_image")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("data_compania");
                });

            modelBuilder.Entity("Cl.Gob.Energia.Ecocarga.Data.Models.DataDiccionarioTipoConector", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EntidadExterna")
                        .HasColumnName("entidad_externo")
                        .HasMaxLength(50);

                    b.Property<string>("TipoConectorExterno")
                        .HasColumnName("tipo_conector_externo")
                        .HasMaxLength(50);

                    b.Property<int>("TipoConectorId")
                        .HasColumnName("tipo_conector_id");

                    b.HasKey("Id");

                    b.HasIndex("TipoConectorId");

                    b.ToTable("data_diccionariotipoconector");
                });

            modelBuilder.Entity("Cl.Gob.Energia.Ecocarga.Data.Models.DataElectrolinera", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AceptaConexionAc")
                        .HasColumnName("acepta_conexion_ac");

                    b.Property<bool>("AceptaConexionDc")
                        .HasColumnName("acepta_conexion_dc");

                    b.Property<int>("CantidadPuntosCarga")
                        .HasColumnName("cantidad_puntos_carga");

                    b.Property<int>("CompaniaId")
                        .HasColumnName("compania_id");

                    b.Property<string>("Comuna")
                        .IsRequired()
                        .HasColumnName("comuna")
                        .HasMaxLength(50);

                    b.Property<bool>("CoordenadasActualizar")
                        .HasColumnName("coordenadas_actualizar");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnName("direccion")
                        .HasMaxLength(100);

                    b.Property<string>("EstadoElectrolinera")
                        .HasColumnName("estado_electrolinera")
                        .HasMaxLength(50);

                    b.Property<string>("Horario")
                        .IsRequired()
                        .HasColumnName("horario")
                        .HasMaxLength(100);

                    b.Property<string>("IdElectrolineraCliente")
                        .IsRequired()
                        .HasColumnName("id_electrolinera_cliente")
                        .HasMaxLength(100);

                    b.Property<string>("IdElectrolineraSec")
                        .IsRequired()
                        .HasColumnName("id_electrolinera_sec")
                        .HasMaxLength(100);

                    b.Property<int?>("IdEstadoElectrolinera")
                        .HasColumnName("id_estado_electrolinera");

                    b.Property<Guid>("IdPublico")
                        .HasColumnName("id_publico");

                    b.Property<double>("Latitud")
                        .HasColumnName("latitud");

                    b.Property<double>("Longitud")
                        .HasColumnName("longitud");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnName("marca")
                        .HasMaxLength(30);

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnName("modelo")
                        .HasMaxLength(100);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("nombre")
                        .HasMaxLength(60);

                    b.Property<double>("Potencia")
                        .HasColumnName("potencia");

                    b.Property<double>("Precio")
                        .HasColumnName("precio");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnName("region")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("CompaniaId");

                    b.ToTable("data_electrolinera");
                });

            modelBuilder.Entity("Cl.Gob.Energia.Ecocarga.Data.Models.DataMarcaauto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Imagen")
                        .HasColumnName("imagen")
                        .HasMaxLength(100);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("nombre")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("data_marcaauto");
                });

            modelBuilder.Entity("Cl.Gob.Energia.Ecocarga.Data.Models.DataObservacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ElectrolineraId")
                        .HasColumnName("electrolinera_id");

                    b.Property<string>("Mensaje")
                        .IsRequired()
                        .HasColumnName("mensaje")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.HasIndex("ElectrolineraId");

                    b.ToTable("data_observacion");
                });

            modelBuilder.Entity("Cl.Gob.Energia.Ecocarga.Data.Models.DataTipocobro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CargadorId")
                        .HasColumnName("cargador_id");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("nombre")
                        .HasMaxLength(50);

                    b.Property<int>("Precio")
                        .HasColumnName("precio");

                    b.Property<string>("UnidadCobro")
                        .IsRequired()
                        .HasColumnName("unidad_cobro")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("CargadorId");

                    b.ToTable("data_tipocobro");
                });

            modelBuilder.Entity("Cl.Gob.Energia.Ecocarga.Data.Models.DataTipoconector", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid>("IdPublico")
                        .HasColumnName("id_publico");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("nombre")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("data_tipoconector");
                });

            modelBuilder.Entity("Cl.Gob.Energia.Ecocarga.Data.Models.DataUsuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CompaniaId")
                        .HasColumnName("compania_id");

                    b.Property<int>("PerfilId")
                        .HasColumnName("perfil_id");

                    b.Property<string>("Usuario")
                        .HasColumnName("usuario")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("CompaniaId");

                    b.ToTable("data_usuario");
                });

            modelBuilder.Entity("Cl.Gob.Energia.Ecocarga.Data.Models.DataVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Timestamp")
                        .HasColumnName("timestamp");

                    b.Property<Guid>("Version")
                        .HasColumnName("version");

                    b.HasKey("Id");

                    b.ToTable("data_version");
                });

            modelBuilder.Entity("Cl.Gob.Energia.Ecocarga.Data.Models.DataAuto", b =>
                {
                    b.HasOne("Cl.Gob.Energia.Ecocarga.Data.Models.DataMarcaauto", "Marca")
                        .WithMany("DataAuto")
                        .HasForeignKey("MarcaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Cl.Gob.Energia.Ecocarga.Data.Models.DataTipoconector", "TipoConectorAc")
                        .WithMany("DataAutoTipoConectorAc")
                        .HasForeignKey("TipoConectorAcId");

                    b.HasOne("Cl.Gob.Energia.Ecocarga.Data.Models.DataTipoconector", "TipoConectorDc")
                        .WithMany("DataAutoTipoConectorDc")
                        .HasForeignKey("TipoConectorDcId");
                });

            modelBuilder.Entity("Cl.Gob.Energia.Ecocarga.Data.Models.DataCargador", b =>
                {
                    b.HasOne("Cl.Gob.Energia.Ecocarga.Data.Models.DataElectrolinera", "Electrolinera")
                        .WithMany("DataCargador")
                        .HasForeignKey("ElectrolineraId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Cl.Gob.Energia.Ecocarga.Data.Models.DataTipoconector", "TipoConector")
                        .WithMany("DataCargador")
                        .HasForeignKey("TipoConectorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Cl.Gob.Energia.Ecocarga.Data.Models.DataDiccionarioTipoConector", b =>
                {
                    b.HasOne("Cl.Gob.Energia.Ecocarga.Data.Models.DataTipoconector", "TipoConector")
                        .WithMany("DataDiccionarioTipoConector")
                        .HasForeignKey("TipoConectorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Cl.Gob.Energia.Ecocarga.Data.Models.DataElectrolinera", b =>
                {
                    b.HasOne("Cl.Gob.Energia.Ecocarga.Data.Models.DataCompania", "Compania")
                        .WithMany("DataElectrolinera")
                        .HasForeignKey("CompaniaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Cl.Gob.Energia.Ecocarga.Data.Models.DataObservacion", b =>
                {
                    b.HasOne("Cl.Gob.Energia.Ecocarga.Data.Models.DataElectrolinera", "Electrolinera")
                        .WithMany("DataObservacion")
                        .HasForeignKey("ElectrolineraId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Cl.Gob.Energia.Ecocarga.Data.Models.DataTipocobro", b =>
                {
                    b.HasOne("Cl.Gob.Energia.Ecocarga.Data.Models.DataCargador", "Cargador")
                        .WithMany("DataTipocobroCargador")
                        .HasForeignKey("CargadorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Cl.Gob.Energia.Ecocarga.Data.Models.DataUsuario", b =>
                {
                    b.HasOne("Cl.Gob.Energia.Ecocarga.Data.Models.DataCompania", "Compania")
                        .WithMany("DataUsuario")
                        .HasForeignKey("CompaniaId");
                });
#pragma warning restore 612, 618
        }
    }
}
