using Microsoft.EntityFrameworkCore.Migrations;

namespace MUDGOD.Migrations
{
    public partial class MyMigration : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "playerListDB",
                columns: table => new
                {
                    playerId = table.Column<ulong>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", false),
                    playerName = table.Column<string>(nullable: true),
                    myClassIdHolder = table.Column<int>(nullable: false),
                    myRaceIdHolder = table.Column<int>(nullable: false),
                    peasantLevel = table.Column<int>(nullable: false),
                    fighterLevel = table.Column<int>(nullable: false),
                    magicianLevel = table.Column<int>(nullable: false),
                    rangerLevel = table.Column<int>(nullable: false),
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
                    locationY = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_playerListDB", x => x.playerId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "playerListDB");
        }
    }
}
