﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PracticeTheVerb.Infrastructure.Data;

#nullable disable

namespace PracticeTheVerb.Infrastructure.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230925213601_CreateDB")]
    partial class CreateDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PracticeTheVerb.API.Models.Italian.ItalianVerb", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("congiuntivoimperfettoio")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("congiuntivoimperfettoio");

                    b.Property<string>("congiuntivoimperfettoloro")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("congiuntivoimperfettoloro");

                    b.Property<string>("congiuntivoimperfettolui")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("congiuntivoimperfettolui");

                    b.Property<string>("congiuntivoimperfettonoi")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("congiuntivoimperfettonoi");

                    b.Property<string>("congiuntivoimperfettotu")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("congiuntivoimperfettotu");

                    b.Property<string>("congiuntivoimperfettovoi")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("congiuntivoimperfettovoi");

                    b.Property<string>("congiuntivopassatoio")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("congiuntivopassatoio");

                    b.Property<string>("congiuntivopassatoloro")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("congiuntivopassatoloro");

                    b.Property<string>("congiuntivopassatolui")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("congiuntivopassatolui");

                    b.Property<string>("congiuntivopassatonoi")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("congiuntivopassatonoi");

                    b.Property<string>("congiuntivopassatotu")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("congiuntivopassatotu");

                    b.Property<string>("congiuntivopassatovoi")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("congiuntivopassatovoi");

                    b.Property<string>("congiuntivopresenteio")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("congiuntivopresenteio");

                    b.Property<string>("congiuntivopresenteloro")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("congiuntivopresenteloro");

                    b.Property<string>("congiuntivopresentelui")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("congiuntivopresentelui");

                    b.Property<string>("congiuntivopresentenoi")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("congiuntivopresentenoi");

                    b.Property<string>("congiuntivopresentetu")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("congiuntivopresentetu");

                    b.Property<string>("congiuntivopresentevoi")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("congiuntivopresentevoi");

                    b.Property<string>("congiuntivotrapassatoio")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("congiuntivotrapassatoio");

                    b.Property<string>("congiuntivotrapassatoloro")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("congiuntivotrapassatoloro");

                    b.Property<string>("congiuntivotrapassatolui")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("congiuntivotrapassatolui");

                    b.Property<string>("congiuntivotrapassatonoi")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("congiuntivotrapassatonoi");

                    b.Property<string>("congiuntivotrapassatotu")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("congiuntivotrapassatotu");

                    b.Property<string>("congiuntivotrapassatovoi")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("congiuntivotrapassatovoi");

                    b.Property<string>("gerundiopassato")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("gerundiopassato");

                    b.Property<string>("gerundiopresente")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("gerundiopresente");

                    b.Property<string>("imperativopresenteloro")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("imperativopresenteloro");

                    b.Property<string>("imperativopresentelui")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("imperativopresentelui");

                    b.Property<string>("imperativopresentenoi")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("imperativopresentenoi");

                    b.Property<string>("imperativopresentetu")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("imperativopresentetu");

                    b.Property<string>("imperativopresentevoi")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("imperativopresentevoi");

                    b.Property<string>("indicativofuturoanterioreio")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("indicativofuturoanterioreio");

                    b.Property<string>("indicativofuturoanterioreloro")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("indicativofuturoanterioreloro");

                    b.Property<string>("indicativofuturoanteriorelui")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("indicativofuturoanteriorelui");

                    b.Property<string>("indicativofuturoanteriorenoi")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("indicativofuturoanteriorenoi");

                    b.Property<string>("indicativofuturoanterioretu")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("indicativofuturoanterioretu");

                    b.Property<string>("indicativofuturoanteriorevoi")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("indicativofuturoanteriorevoi");

                    b.Property<string>("indicativofuturosempliceio")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("indicativofuturosempliceio");

                    b.Property<string>("indicativofuturosempliceloro")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("indicativofuturosempliceloro");

                    b.Property<string>("indicativofuturosemplicelui")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("indicativofuturosemplicelui");

                    b.Property<string>("indicativofuturosemplicenoi")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("indicativofuturosemplicenoi");

                    b.Property<string>("indicativofuturosemplicetu")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("indicativofuturosemplicetu");

                    b.Property<string>("indicativofuturosemplicevoi")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("indicativofuturosemplicevoi");

                    b.Property<string>("indicativoimperfettoio")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("indicativoimperfettoio");

                    b.Property<string>("indicativoimperfettoloro")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("indicativoimperfettoloro");

                    b.Property<string>("indicativoimperfettolui")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("indicativoimperfettolui");

                    b.Property<string>("indicativoimperfettonoi")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("indicativoimperfettonoi");

                    b.Property<string>("indicativoimperfettotu")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("indicativoimperfettotu");

                    b.Property<string>("indicativoimperfettovoi")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("indicativoimperfettovoi");

                    b.Property<string>("indicativopassatoprossimoio")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("indicativopassatoprossimoio");

                    b.Property<string>("indicativopassatoprossimoloro")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("indicativopassatoprossimoloro");

                    b.Property<string>("indicativopassatoprossimolui")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("indicativopassatoprossimolui");

                    b.Property<string>("indicativopassatoprossimonoi")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("indicativopassatoprossimonoi");

                    b.Property<string>("indicativopassatoprossimotu")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("indicativopassatoprossimotu");

                    b.Property<string>("indicativopassatoprossimovoi")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("indicativopassatoprossimovoi");

                    b.Property<string>("indicativopassatoremotoio")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("indicativopassatoremotoio");

                    b.Property<string>("indicativopassatoremotoloro")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("indicativopassatoremotoloro");

                    b.Property<string>("indicativopassatoremotolui")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("indicativopassatoremotolui");

                    b.Property<string>("indicativopassatoremotonoi")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("indicativopassatoremotonoi");

                    b.Property<string>("indicativopassatoremototu")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("indicativopassatoremototu");

                    b.Property<string>("indicativopassatoremotovoi")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("indicativopassatoremotovoi");

                    b.Property<string>("indicativopresenteio")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("indicativopresenteio");

                    b.Property<string>("indicativopresenteloro")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("indicativopresenteloro");

                    b.Property<string>("indicativopresentelui")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("indicativopresentelui");

                    b.Property<string>("indicativopresentenoi")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("indicativopresentenoi");

                    b.Property<string>("indicativopresentetu")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("indicativopresentetu");

                    b.Property<string>("indicativopresentevoi")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("indicativopresente");

                    b.Property<string>("indicativotrapassatoprossimoio")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("indicativotrapassatoprossimoio");

                    b.Property<string>("indicativotrapassatoprossimoloro")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("indicativotrapassatoprossimoloro");

                    b.Property<string>("indicativotrapassatoprossimolui")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("indicativotrapassatoprossimolui");

                    b.Property<string>("indicativotrapassatoprossimonoi")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("indicativotrapassatoprossimonoi");

                    b.Property<string>("indicativotrapassatoprossimotu")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("indicativotrapassatoprossimotu");

                    b.Property<string>("indicativotrapassatoprossimovoi")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("indicativotrapassatoprossimovoi");

                    b.Property<string>("indicativotrapassatoremotoio")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("indicativotrapassatoremotoio");

                    b.Property<string>("indicativotrapassatoremotoloro")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("indicativotrapassatoremotoloro");

                    b.Property<string>("indicativotrapassatoremotolui")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("lui");

                    b.Property<string>("indicativotrapassatoremotonoi")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("indicativotrapassatoremotonoi");

                    b.Property<string>("indicativotrapassatoremototu")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("indicativotrapassatoremototu");

                    b.Property<string>("indicativotrapassatoremotovoi")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("indicativotrapassatoremotovoi");

                    b.Property<string>("infinitivopassato")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("infinitivopassato");

                    b.Property<string>("infinitivopresente")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("infinitivopresente");

                    b.Property<string>("participiopassato")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("participiopassato");

                    b.Property<string>("participiopresente")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("participiopresente");

                    b.HasKey("Id");

                    b.ToTable("PracticeTheVerb_Italian_Verb", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
