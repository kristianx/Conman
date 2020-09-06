﻿// <auto-generated />
using ConManApp.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace ConManApp.Migrations
{
    [DbContext(typeof(MojDBCOntext))]
    [Migration("20200108192337_Migracija5")]
    partial class Migracija5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ConManApp.EnModels.Administracija", b =>
                {
                    b.Property<int>("UposlenikId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Ime")
                        .IsRequired();

                    b.Property<string>("KontaktBroj");

                    b.Property<string>("Prezime");

                    b.Property<string>("StrucnoZvanje");

                    b.Property<int>("UredId");

                    b.Property<string>("password");

                    b.Property<string>("username");

                    b.HasKey("UposlenikId");

                    b.HasIndex("UredId");

                    b.ToTable("Administracija");
                });

            modelBuilder.Entity("ConManApp.EnModels.Dobavljac", b =>
                {
                    b.Property<int>("DobavljacId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("GodinaOsnivanja");

                    b.Property<string>("Naziv");

                    b.HasKey("DobavljacId");

                    b.ToTable("Dobavljac");
                });

            modelBuilder.Entity("ConManApp.EnModels.Drzava", b =>
                {
                    b.Property<int>("DrzavaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Naziv");

                    b.HasKey("DrzavaId");

                    b.ToTable("Drzava");
                });

            modelBuilder.Entity("ConManApp.EnModels.Grad", b =>
                {
                    b.Property<int>("GradId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DrzavaId");

                    b.Property<string>("Naziv");

                    b.HasKey("GradId");

                    b.HasIndex("DrzavaId");

                    b.ToTable("Grad");
                });

            modelBuilder.Entity("ConManApp.EnModels.GrupaMaterijal", b =>
                {
                    b.Property<int>("GrupaMaterijalId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NazivGrupe");

                    b.HasKey("GrupaMaterijalId");

                    b.ToTable("GrupaMaterijal");
                });

            modelBuilder.Entity("ConManApp.EnModels.Materijal", b =>
                {
                    b.Property<int>("MaterijalId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Cijena");

                    b.Property<int>("DobavljacId");

                    b.Property<int>("GrupaMaterijalId");

                    b.Property<string>("Naziv");

                    b.Property<int>("SkladisteId");

                    b.HasKey("MaterijalId");

                    b.HasIndex("DobavljacId");

                    b.HasIndex("GrupaMaterijalId");

                    b.HasIndex("SkladisteId");

                    b.ToTable("Materijal");
                });

            modelBuilder.Entity("ConManApp.EnModels.Narudzba", b =>
                {
                    b.Property<int>("NarudzbaId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatumKreiranja");

                    b.Property<string>("SpisakPotrebnihMaterijala");

                    b.Property<int>("UposlenikId");

                    b.HasKey("NarudzbaId");

                    b.HasIndex("UposlenikId");

                    b.ToTable("Narudzba");
                });

            modelBuilder.Entity("ConManApp.EnModels.Oprema", b =>
                {
                    b.Property<int>("OpremaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Naziv");

                    b.Property<int>("SkladisteId");

                    b.Property<bool>("usable");

                    b.HasKey("OpremaId");

                    b.HasIndex("SkladisteId");

                    b.ToTable("Oprema");
                });

            modelBuilder.Entity("ConManApp.EnModels.PlatnaLista", b =>
                {
                    b.Property<int>("PlatnaListaId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatumKreiranja");

                    b.Property<int>("UposlenikId");

                    b.Property<string>("godina");

                    b.Property<string>("mjesec");

                    b.HasKey("PlatnaListaId");

                    b.HasIndex("UposlenikId");

                    b.ToTable("PlatnaLista");
                });

            modelBuilder.Entity("ConManApp.EnModels.PlatnaPoslovodja", b =>
                {
                    b.Property<int>("PlatnaPoslovodjaId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IznosPlate");

                    b.Property<int>("PlatnaListaId");

                    b.Property<int>("UposlenikId");

                    b.HasKey("PlatnaPoslovodjaId");

                    b.HasIndex("PlatnaListaId");

                    b.HasIndex("UposlenikId");

                    b.ToTable("PlatnaPoslovodja");
                });

            modelBuilder.Entity("ConManApp.EnModels.PlatnaRadnik", b =>
                {
                    b.Property<int>("PlatnaRadnikId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IznosPlate");

                    b.Property<int>("PlatnaListaId");

                    b.Property<int>("UposlenikId");

                    b.HasKey("PlatnaRadnikId");

                    b.HasIndex("PlatnaListaId");

                    b.HasIndex("UposlenikId");

                    b.ToTable("PlatnaRadnik");
                });

            modelBuilder.Entity("ConManApp.EnModels.PlatnaSkladistar", b =>
                {
                    b.Property<int>("PlatnaSkladistarID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IznosPlate");

                    b.Property<int>("PlatnaListaId");

                    b.Property<int>("UposlenikId");

                    b.HasKey("PlatnaSkladistarID");

                    b.HasIndex("PlatnaListaId");

                    b.HasIndex("UposlenikId");

                    b.ToTable("PlatnaSkladistar");
                });

            modelBuilder.Entity("ConManApp.EnModels.Poslovodja", b =>
                {
                    b.Property<int>("UposlenikId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Ime")
                        .IsRequired();

                    b.Property<string>("KontaktBroj");

                    b.Property<string>("OpisIskustva");

                    b.Property<string>("Prezime");

                    b.Property<string>("password");

                    b.Property<string>("username");

                    b.HasKey("UposlenikId");

                    b.ToTable("Poslovodja");
                });

            modelBuilder.Entity("ConManApp.EnModels.Predracun", b =>
                {
                    b.Property<int>("PredracunId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatumKreiranja");

                    b.Property<string>("SpisakPotrebnihMaterijala");

                    b.Property<int>("UposlenikId");

                    b.HasKey("PredracunId");

                    b.HasIndex("UposlenikId");

                    b.ToTable("Predracun");
                });

            modelBuilder.Entity("ConManApp.EnModels.PredracunMaterijal", b =>
                {
                    b.Property<int>("PredracunMaterijalId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("MaterijalId");

                    b.Property<int>("PredracunId");

                    b.HasKey("PredracunMaterijalId");

                    b.HasIndex("MaterijalId");

                    b.HasIndex("PredracunId");

                    b.ToTable("PredracunMaterijal");
                });

            modelBuilder.Entity("ConManApp.EnModels.Projekt", b =>
                {
                    b.Property<int>("ProjektId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adresa");

                    b.Property<int>("GradId");

                    b.Property<string>("Naziv");

                    b.Property<int>("UposlenikId");

                    b.HasKey("ProjektId");

                    b.HasIndex("GradId");

                    b.HasIndex("UposlenikId");

                    b.ToTable("Projekt");
                });

            modelBuilder.Entity("ConManApp.EnModels.ProjektInfo", b =>
                {
                    b.Property<int>("ProjektInfoId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatumKreiranja");

                    b.Property<int>("ProjektId");

                    b.Property<string>("textInfo");

                    b.HasKey("ProjektInfoId");

                    b.HasIndex("ProjektId");

                    b.ToTable("ProjektInfo");
                });

            modelBuilder.Entity("ConManApp.EnModels.Radnik", b =>
                {
                    b.Property<int>("UposlenikId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Ime")
                        .IsRequired();

                    b.Property<string>("KontaktBroj");

                    b.Property<string>("Prezime");

                    b.Property<string>("info");

                    b.Property<string>("password");

                    b.Property<string>("username");

                    b.HasKey("UposlenikId");

                    b.ToTable("Radnik");
                });

            modelBuilder.Entity("ConManApp.EnModels.RadnikProjekt", b =>
                {
                    b.Property<int>("RadnikProjektId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatumDodavanja");

                    b.Property<int>("ProjektId");

                    b.Property<int>("UposlenikId");

                    b.HasKey("RadnikProjektId");

                    b.HasIndex("ProjektId");

                    b.HasIndex("UposlenikId");

                    b.ToTable("RadnikProjekt");
                });

            modelBuilder.Entity("ConManApp.EnModels.RadnikVozilo", b =>
                {
                    b.Property<int>("RadnikVoziloId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("DatumVracanja");

                    b.Property<DateTime>("DatumZaduzivanja");

                    b.Property<int>("UposlenikId");

                    b.Property<int>("VoziloId");

                    b.HasKey("RadnikVoziloId");

                    b.HasIndex("UposlenikId");

                    b.HasIndex("VoziloId");

                    b.ToTable("RadnikVozilo");
                });

            modelBuilder.Entity("ConManApp.EnModels.Skladistar", b =>
                {
                    b.Property<int>("UposlenikId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Ime")
                        .IsRequired();

                    b.Property<string>("KontaktBroj");

                    b.Property<string>("Prezime");

                    b.Property<int>("SkladisteId");

                    b.Property<string>("password");

                    b.Property<string>("username");

                    b.HasKey("UposlenikId");

                    b.HasIndex("SkladisteId");

                    b.ToTable("Skladistar");
                });

            modelBuilder.Entity("ConManApp.EnModels.Skladiste", b =>
                {
                    b.Property<int>("SkladisteId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adresa");

                    b.Property<int>("GradId");

                    b.Property<string>("Naziv");

                    b.HasKey("SkladisteId");

                    b.HasIndex("GradId");

                    b.ToTable("Skladiste");
                });

            modelBuilder.Entity("ConManApp.EnModels.TipVozila", b =>
                {
                    b.Property<int>("TipVozilaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NazivTipa");

                    b.HasKey("TipVozilaId");

                    b.ToTable("TipVozila");
                });

            modelBuilder.Entity("ConManApp.EnModels.Ured", b =>
                {
                    b.Property<int>("UredId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adresa")
                        .IsRequired();

                    b.Property<int>("GradId");

                    b.HasKey("UredId");

                    b.HasIndex("GradId");

                    b.ToTable("Ured");
                });

            modelBuilder.Entity("ConManApp.EnModels.Vlasnik", b =>
                {
                    b.Property<int>("VlasnikId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Ime");

                    b.Property<string>("Prezime");

                    b.Property<string>("password");

                    b.Property<string>("username");

                    b.HasKey("VlasnikId");

                    b.ToTable("Vlasnik");
                });

            modelBuilder.Entity("ConManApp.EnModels.Vozilo", b =>
                {
                    b.Property<int>("VoziloId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("GodinaProizvodnje");

                    b.Property<bool>("Iznajmljeno");

                    b.Property<string>("Model");

                    b.Property<string>("NazivProizvodjaca");

                    b.Property<int>("SkladisteId");

                    b.Property<int>("TipVozilaId");

                    b.Property<bool>("UVoznomStanju");

                    b.HasKey("VoziloId");

                    b.HasIndex("SkladisteId");

                    b.HasIndex("TipVozilaId");

                    b.ToTable("Vozilo");
                });

            modelBuilder.Entity("ConManApp.EnModels.Administracija", b =>
                {
                    b.HasOne("ConManApp.EnModels.Ured", "Ured")
                        .WithMany()
                        .HasForeignKey("UredId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ConManApp.EnModels.Grad", b =>
                {
                    b.HasOne("ConManApp.EnModels.Drzava", "Drzava")
                        .WithMany()
                        .HasForeignKey("DrzavaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ConManApp.EnModels.Materijal", b =>
                {
                    b.HasOne("ConManApp.EnModels.Dobavljac", "Dobavljac")
                        .WithMany()
                        .HasForeignKey("DobavljacId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ConManApp.EnModels.GrupaMaterijal", "GrupaMaterijal")
                        .WithMany()
                        .HasForeignKey("GrupaMaterijalId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ConManApp.EnModels.Skladiste", "Skladiste")
                        .WithMany()
                        .HasForeignKey("SkladisteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ConManApp.EnModels.Narudzba", b =>
                {
                    b.HasOne("ConManApp.EnModels.Administracija", "Administracija")
                        .WithMany()
                        .HasForeignKey("UposlenikId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ConManApp.EnModels.Oprema", b =>
                {
                    b.HasOne("ConManApp.EnModels.Skladiste", "Skladiste")
                        .WithMany()
                        .HasForeignKey("SkladisteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ConManApp.EnModels.PlatnaLista", b =>
                {
                    b.HasOne("ConManApp.EnModels.Administracija", "Administracija")
                        .WithMany()
                        .HasForeignKey("UposlenikId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ConManApp.EnModels.PlatnaPoslovodja", b =>
                {
                    b.HasOne("ConManApp.EnModels.PlatnaLista", "PlatnaLista")
                        .WithMany()
                        .HasForeignKey("PlatnaListaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ConManApp.EnModels.Poslovodja", "Poslovodja")
                        .WithMany()
                        .HasForeignKey("UposlenikId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ConManApp.EnModels.PlatnaRadnik", b =>
                {
                    b.HasOne("ConManApp.EnModels.PlatnaLista", "PlatnaLista")
                        .WithMany()
                        .HasForeignKey("PlatnaListaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ConManApp.EnModels.Radnik", "Radnik")
                        .WithMany()
                        .HasForeignKey("UposlenikId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ConManApp.EnModels.PlatnaSkladistar", b =>
                {
                    b.HasOne("ConManApp.EnModels.PlatnaLista", "PlatnaLista")
                        .WithMany()
                        .HasForeignKey("PlatnaListaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ConManApp.EnModels.Skladistar", "Skladistar")
                        .WithMany()
                        .HasForeignKey("UposlenikId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ConManApp.EnModels.Predracun", b =>
                {
                    b.HasOne("ConManApp.EnModels.Poslovodja", "Poslovodja")
                        .WithMany()
                        .HasForeignKey("UposlenikId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ConManApp.EnModels.PredracunMaterijal", b =>
                {
                    b.HasOne("ConManApp.EnModels.Materijal", "Materijal")
                        .WithMany()
                        .HasForeignKey("MaterijalId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ConManApp.EnModels.Predracun", "Predracun")
                        .WithMany()
                        .HasForeignKey("PredracunId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ConManApp.EnModels.Projekt", b =>
                {
                    b.HasOne("ConManApp.EnModels.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ConManApp.EnModels.Poslovodja", "Poslovodja")
                        .WithMany()
                        .HasForeignKey("UposlenikId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ConManApp.EnModels.ProjektInfo", b =>
                {
                    b.HasOne("ConManApp.EnModels.Projekt", "Projekt")
                        .WithMany()
                        .HasForeignKey("ProjektId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ConManApp.EnModels.RadnikProjekt", b =>
                {
                    b.HasOne("ConManApp.EnModels.Projekt", "Projekt")
                        .WithMany()
                        .HasForeignKey("ProjektId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ConManApp.EnModels.Radnik", "Radnik")
                        .WithMany()
                        .HasForeignKey("UposlenikId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ConManApp.EnModels.RadnikVozilo", b =>
                {
                    b.HasOne("ConManApp.EnModels.Radnik", "Radnik")
                        .WithMany()
                        .HasForeignKey("UposlenikId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ConManApp.EnModels.Vozilo", "Vozilo")
                        .WithMany()
                        .HasForeignKey("VoziloId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ConManApp.EnModels.Skladistar", b =>
                {
                    b.HasOne("ConManApp.EnModels.Skladiste", "Skladiste")
                        .WithMany()
                        .HasForeignKey("SkladisteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ConManApp.EnModels.Skladiste", b =>
                {
                    b.HasOne("ConManApp.EnModels.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ConManApp.EnModels.Ured", b =>
                {
                    b.HasOne("ConManApp.EnModels.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ConManApp.EnModels.Vozilo", b =>
                {
                    b.HasOne("ConManApp.EnModels.Skladiste", "Skladiste")
                        .WithMany()
                        .HasForeignKey("SkladisteId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ConManApp.EnModels.TipVozila", "TipVozila")
                        .WithMany()
                        .HasForeignKey("TipVozilaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
