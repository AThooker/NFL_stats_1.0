using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace NFLStatsAPI_roughDraft.Migrations
{
    public partial class AddedScheduleDbSete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AddColumn<int>(
            //    name: "t",
            //    table: "standings",
            //    nullable: false,
            //    defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "teamName",
                table: "standings",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "schedules",
                columns: table => new
                {
                    scheduleID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    teamid = table.Column<int>(nullable: false),
                    team = table.Column<string>(nullable: true),
                    season = table.Column<string>(nullable: true),
                    week_1 = table.Column<string>(nullable: true),
                    week_2 = table.Column<string>(nullable: true),
                    week_3 = table.Column<string>(nullable: true),
                    week_4 = table.Column<string>(nullable: true),
                    week_5 = table.Column<string>(nullable: true),
                    week_6 = table.Column<string>(nullable: true),
                    week_7 = table.Column<string>(nullable: true),
                    week_8 = table.Column<string>(nullable: true),
                    week_9 = table.Column<string>(nullable: true),
                    week_10 = table.Column<string>(nullable: true),
                    week_11 = table.Column<string>(nullable: true),
                    week_12 = table.Column<string>(nullable: true),
                    week_13 = table.Column<string>(nullable: true),
                    week_14 = table.Column<string>(nullable: true),
                    week_15 = table.Column<string>(nullable: true),
                    week_16 = table.Column<string>(nullable: true),
                    week_17 = table.Column<string>(nullable: true),
                    week_18 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_schedules", x => x.scheduleID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "schedules");

            migrationBuilder.DropColumn(
                name: "t",
                table: "standings");

            migrationBuilder.DropColumn(
                name: "teamName",
                table: "standings");
        }
    }
}
