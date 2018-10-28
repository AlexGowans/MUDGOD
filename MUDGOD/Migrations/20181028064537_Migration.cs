using Microsoft.EntityFrameworkCore.Migrations;

namespace MUDGOD.Migrations
{
    public partial class Migration : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlayerClass",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    level = table.Column<int>(nullable: false),
                    hpMulti = table.Column<float>(nullable: false),
                    mpMulti = table.Column<float>(nullable: false),
                    strMulti = table.Column<float>(nullable: false),
                    dexMulti = table.Column<float>(nullable: false),
                    intMulti = table.Column<float>(nullable: false),
                    wisMulti = table.Column<float>(nullable: false),
                    lckMulti = table.Column<float>(nullable: false),
                    defMulti = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerClass", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "PlayerRace",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    hpMulti = table.Column<float>(nullable: false),
                    mpMulti = table.Column<float>(nullable: false),
                    strMulti = table.Column<float>(nullable: false),
                    dexMulti = table.Column<float>(nullable: false),
                    intMulti = table.Column<float>(nullable: false),
                    wisMulti = table.Column<float>(nullable: false),
                    lckMulti = table.Column<float>(nullable: false),
                    defMulti = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerRace", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "playerList",
                columns: table => new
                {
                    name = table.Column<string>(nullable: true),
                    bodySize = table.Column<int>(nullable: false),
                    level = table.Column<int>(nullable: false),
                    healthPointsMax = table.Column<int>(nullable: false),
                    healthPoints = table.Column<int>(nullable: false),
                    manaPointsMax = table.Column<int>(nullable: false),
                    manaPoints = table.Column<int>(nullable: false),
                    strPoints = table.Column<int>(nullable: false),
                    dexPoints = table.Column<int>(nullable: false),
                    intPoints = table.Column<int>(nullable: false),
                    wisPoints = table.Column<int>(nullable: false),
                    lckPoints = table.Column<int>(nullable: false),
                    defPoints = table.Column<int>(nullable: false),
                    accuracyPoints = table.Column<int>(nullable: false),
                    passiveDodgePoints = table.Column<int>(nullable: false),
                    currency = table.Column<int>(nullable: false),
                    locationX = table.Column<int>(nullable: false),
                    locationY = table.Column<int>(nullable: false),
                    playerId = table.Column<ulong>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    playerName = table.Column<string>(nullable: true),
                    myClassid = table.Column<int>(nullable: true),
                    myRaceid = table.Column<int>(nullable: true),
                    peasantLevel = table.Column<int>(nullable: false),
                    fighterLevel = table.Column<int>(nullable: false),
                    magicianLevel = table.Column<int>(nullable: false),
                    rangerLevel = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_playerList", x => x.playerId);
                    table.ForeignKey(
                        name: "FK_playerList_PlayerClass_myClassid",
                        column: x => x.myClassid,
                        principalTable: "PlayerClass",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_playerList_PlayerRace_myRaceid",
                        column: x => x.myRaceid,
                        principalTable: "PlayerRace",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_playerList_myClassid",
                table: "playerList",
                column: "myClassid");

            migrationBuilder.CreateIndex(
                name: "IX_playerList_myRaceid",
                table: "playerList",
                column: "myRaceid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "playerList");

            migrationBuilder.DropTable(
                name: "PlayerClass");

            migrationBuilder.DropTable(
                name: "PlayerRace");
        }
    }
}
