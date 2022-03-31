﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NFLStatsAPI_roughDraft.DataAccess;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace NFLStatsAPI_roughDraft.Migrations
{
    [DbContext(typeof(PostgreSqlContext))]
    [Migration("20220331183337_AddCNF")]
    partial class AddCNF
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("NFLStatsAPI_roughDraft.Models.Standings", b =>
                {
                    b.Property<int>("standingsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("cnf")
                        .HasColumnType("text");

                    b.Property<string>("div_leader")
                        .HasColumnType("text");

                    b.Property<decimal>("dsrs")
                        .HasColumnType("numeric");

                    b.Property<int>("g")
                        .HasColumnType("integer");

                    b.Property<int>("l")
                        .HasColumnType("integer");

                    b.Property<decimal>("mov")
                        .HasColumnType("numeric");

                    b.Property<decimal>("osrs")
                        .HasColumnType("numeric");

                    b.Property<int>("pa")
                        .HasColumnType("integer");

                    b.Property<int>("pd")
                        .HasColumnType("integer");

                    b.Property<int>("pf")
                        .HasColumnType("integer");

                    b.Property<string>("season")
                        .HasColumnType("text");

                    b.Property<decimal>("sos")
                        .HasColumnType("numeric");

                    b.Property<decimal>("srs")
                        .HasColumnType("numeric");

                    b.Property<int>("team_id")
                        .HasColumnType("integer");

                    b.Property<int>("w")
                        .HasColumnType("integer");

                    b.Property<decimal>("w_to_l_percent")
                        .HasColumnType("numeric");

                    b.Property<string>("wild_card")
                        .HasColumnType("text");

                    b.HasKey("standingsId");

                    b.ToTable("standings");
                });

            modelBuilder.Entity("NFLStatsAPI_roughDraft.Models.Team", b =>
                {
                    b.Property<int>("teamid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.HasKey("teamid");

                    b.ToTable("teams");
                });
#pragma warning restore 612, 618
        }
    }
}
