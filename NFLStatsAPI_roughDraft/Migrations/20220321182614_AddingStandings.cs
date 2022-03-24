using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace NFLStatsAPI_roughDraft.Migrations
{
    public partial class AddingStandings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "standings",
                columns: table => new
                {
                    standingsId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    team_id = table.Column<int>(nullable: false),
                    season = table.Column<string>(nullable: true),
                    g = table.Column<int>(nullable: false),
                    w = table.Column<int>(nullable: false),
                    l = table.Column<int>(nullable: false),
                    w_to_l_percent = table.Column<decimal>(nullable: false),
                    pf = table.Column<int>(nullable: false),
                    pa = table.Column<int>(nullable: false),
                    pd = table.Column<int>(nullable: false),
                    mov = table.Column<decimal>(nullable: false),
                    sos = table.Column<decimal>(nullable: false),
                    srs = table.Column<decimal>(nullable: false),
                    osrs = table.Column<decimal>(nullable: false),
                    dsrs = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_standings", x => x.standingsId);
                });

            migrationBuilder.CreateTable(
                name: "teams",
                columns: table => new
                {
                    teamid = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_teams", x => x.teamid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "standings");

            migrationBuilder.DropTable(
                name: "teams");
        }
    }
}
