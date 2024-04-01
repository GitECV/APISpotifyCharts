using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace spotifychartsAPI.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GlobalDailyChart",
                columns: table => new
                {
                    iIdInsertion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dtDatetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    sPlaylist = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    sIdSong = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    iChartPosition = table.Column<int>(type: "int", nullable: false),
                    sSongName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    sArtistName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    iPeak = table.Column<int>(type: "int", nullable: true),
                    sPrevPosition = table.Column<string>(type: "nvarchar(125)", maxLength: 125, nullable: true),
                    iStreak = table.Column<int>(type: "int", nullable: true),
                    iStreams = table.Column<int>(type: "int", nullable: false),
                    dtReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    dtFirstEntryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    iFirstEntryPosition = table.Column<int>(type: "int", nullable: true),
                    iTotalDaysOnChart = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GlobalDailyChart", x => x.iIdInsertion);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GlobalDailyChart");
        }
    }
}
