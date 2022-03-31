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
    [Migration("20220331214037_AddedScheduleDbSete")]
    partial class AddedScheduleDbSete
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("NFLStatsAPI_roughDraft.Models.Schedule", b =>
                {
                    b.Property<int>("scheduleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("season")
                        .HasColumnType("text");

                    b.Property<string>("team")
                        .HasColumnType("text");

                    b.Property<int>("teamid")
                        .HasColumnType("integer");

                    b.Property<string>("week_1")
                        .HasColumnType("text");

                    b.Property<string>("week_10")
                        .HasColumnType("text");

                    b.Property<string>("week_11")
                        .HasColumnType("text");

                    b.Property<string>("week_12")
                        .HasColumnType("text");

                    b.Property<string>("week_13")
                        .HasColumnType("text");

                    b.Property<string>("week_14")
                        .HasColumnType("text");

                    b.Property<string>("week_15")
                        .HasColumnType("text");

                    b.Property<string>("week_16")
                        .HasColumnType("text");

                    b.Property<string>("week_17")
                        .HasColumnType("text");

                    b.Property<string>("week_18")
                        .HasColumnType("text");

                    b.Property<string>("week_2")
                        .HasColumnType("text");

                    b.Property<string>("week_3")
                        .HasColumnType("text");

                    b.Property<string>("week_4")
                        .HasColumnType("text");

                    b.Property<string>("week_5")
                        .HasColumnType("text");

                    b.Property<string>("week_6")
                        .HasColumnType("text");

                    b.Property<string>("week_7")
                        .HasColumnType("text");

                    b.Property<string>("week_8")
                        .HasColumnType("text");

                    b.Property<string>("week_9")
                        .HasColumnType("text");

                    b.HasKey("scheduleID");

                    b.ToTable("schedules");
                });

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

                    b.Property<int>("t")
                        .HasColumnType("integer");

                    b.Property<string>("teamName")
                        .HasColumnType("text");

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