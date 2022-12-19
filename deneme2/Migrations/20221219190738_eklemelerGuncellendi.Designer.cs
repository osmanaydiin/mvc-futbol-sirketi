﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using deneme2.Models;

#nullable disable

namespace deneme2.Migrations
{
    [DbContext(typeof(DbCoreKitap))]
    [Migration("20221219190738_eklemelerGuncellendi")]
    partial class eklemelerGuncellendi
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("deneme2.Models.Kategori", b =>
                {
                    b.Property<int>("KtgId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KtgId"));

                    b.Property<string>("KtgTuru")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KtgId");

                    b.ToTable("Kategoriler");
                });

            modelBuilder.Entity("deneme2.Models.Kitap", b =>
                {
                    b.Property<int>("KitapId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KitapId"));

                    b.Property<string>("KitapAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KitapHakkinda")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KitapResimUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KitapSayfa")
                        .HasColumnType("int");

                    b.Property<int>("KtgId")
                        .HasColumnType("int");

                    b.HasKey("KitapId");

                    b.HasIndex("KtgId");

                    b.ToTable("Kitaplar");
                });

            modelBuilder.Entity("deneme2.Models.Kitap_Tercuman", b =>
                {
                    b.Property<int>("KitapId")
                        .HasColumnType("int");

                    b.Property<int>("TercumanId")
                        .HasColumnType("int");

                    b.HasKey("KitapId", "TercumanId");

                    b.HasIndex("TercumanId");

                    b.ToTable("Kitap_Tercumanlar");
                });

            modelBuilder.Entity("deneme2.Models.Kitap_Yazar", b =>
                {
                    b.Property<int>("KitapId")
                        .HasColumnType("int");

                    b.Property<int>("YazarId")
                        .HasColumnType("int");

                    b.HasKey("KitapId", "YazarId");

                    b.HasIndex("YazarId");

                    b.ToTable("Kitap_Yazarlar");
                });

            modelBuilder.Entity("deneme2.Models.Kullanici", b =>
                {
                    b.Property<int>("KullaniciId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KullaniciId"));

                    b.Property<string>("KullaniciAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KullaniciMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KullaniciSifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KullaniciSoyadi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KullaniciId");

                    b.ToTable("Kullanicilar");
                });

            modelBuilder.Entity("deneme2.Models.Tercuman", b =>
                {
                    b.Property<int>("TrcId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TrcId"));

                    b.Property<string>("TrcAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrcSoyadi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TrcId");

                    b.ToTable("Tercumanlar");
                });

            modelBuilder.Entity("deneme2.Models.Yazar", b =>
                {
                    b.Property<int>("YazarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("YazarId"));

                    b.Property<string>("YazarAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YazarSoyadi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("YazarId");

                    b.ToTable("Yazarlar");
                });

            modelBuilder.Entity("deneme2.Models.Yorum", b =>
                {
                    b.Property<int>("YorumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("YorumId"));

                    b.Property<int>("KitapId")
                        .HasColumnType("int");

                    b.Property<int>("KullaniciId")
                        .HasColumnType("int");

                    b.Property<string>("YorumBaslik")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YorumIcerik")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("YorumId");

                    b.HasIndex("KitapId");

                    b.HasIndex("KullaniciId");

                    b.ToTable("Yorumlar");
                });

            modelBuilder.Entity("deneme2.Models.Kitap", b =>
                {
                    b.HasOne("deneme2.Models.Kategori", "Kategori")
                        .WithMany("Kitaplar")
                        .HasForeignKey("KtgId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("deneme2.Models.Kitap_Tercuman", b =>
                {
                    b.HasOne("deneme2.Models.Kitap", "Kitap")
                        .WithMany("Kitap_Tercumanlar")
                        .HasForeignKey("KitapId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("deneme2.Models.Tercuman", "Tercuman")
                        .WithMany("Kitap_Tercumanlar")
                        .HasForeignKey("TercumanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kitap");

                    b.Navigation("Tercuman");
                });

            modelBuilder.Entity("deneme2.Models.Kitap_Yazar", b =>
                {
                    b.HasOne("deneme2.Models.Kitap", "Kitap")
                        .WithMany("Kitap_Yazarlar")
                        .HasForeignKey("KitapId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("deneme2.Models.Yazar", "Yazar")
                        .WithMany("Kitap_Yazarlar")
                        .HasForeignKey("YazarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kitap");

                    b.Navigation("Yazar");
                });

            modelBuilder.Entity("deneme2.Models.Yorum", b =>
                {
                    b.HasOne("deneme2.Models.Kitap", "Kitap")
                        .WithMany("Yorumlar")
                        .HasForeignKey("KitapId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("deneme2.Models.Kullanici", "Kullanici")
                        .WithMany("Yorumlar")
                        .HasForeignKey("KullaniciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kitap");

                    b.Navigation("Kullanici");
                });

            modelBuilder.Entity("deneme2.Models.Kategori", b =>
                {
                    b.Navigation("Kitaplar");
                });

            modelBuilder.Entity("deneme2.Models.Kitap", b =>
                {
                    b.Navigation("Kitap_Tercumanlar");

                    b.Navigation("Kitap_Yazarlar");

                    b.Navigation("Yorumlar");
                });

            modelBuilder.Entity("deneme2.Models.Kullanici", b =>
                {
                    b.Navigation("Yorumlar");
                });

            modelBuilder.Entity("deneme2.Models.Tercuman", b =>
                {
                    b.Navigation("Kitap_Tercumanlar");
                });

            modelBuilder.Entity("deneme2.Models.Yazar", b =>
                {
                    b.Navigation("Kitap_Yazarlar");
                });
#pragma warning restore 612, 618
        }
    }
}
