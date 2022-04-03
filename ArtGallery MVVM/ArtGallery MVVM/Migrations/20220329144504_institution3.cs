using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ArtGallery_MVVM.Migrations
{
    public partial class institution3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_art_instutution_InstitutionId",
                table: "art");

            migrationBuilder.DropPrimaryKey(
                name: "PK_art",
                table: "art");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "art");

            migrationBuilder.DropColumn(
                name: "Technique",
                table: "art");

            migrationBuilder.DropColumn(
                name: "Sculpture_Type",
                table: "art");

            migrationBuilder.RenameTable(
                name: "art",
                newName: "sculpture");

            migrationBuilder.RenameIndex(
                name: "IX_art_InstitutionId",
                table: "sculpture",
                newName: "IX_sculpture_InstitutionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_sculpture",
                table: "sculpture",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "painting",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(nullable: true),
                    ArtistName = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    Technique = table.Column<string>(nullable: true),
                    InstitutionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_painting", x => x.Id);
                    table.ForeignKey(
                        name: "FK_painting_instutution_InstitutionId",
                        column: x => x.InstitutionId,
                        principalTable: "instutution",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_painting_InstitutionId",
                table: "painting",
                column: "InstitutionId");

            migrationBuilder.AddForeignKey(
                name: "FK_sculpture_instutution_InstitutionId",
                table: "sculpture",
                column: "InstitutionId",
                principalTable: "instutution",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_sculpture_instutution_InstitutionId",
                table: "sculpture");

            migrationBuilder.DropTable(
                name: "painting");

            migrationBuilder.DropPrimaryKey(
                name: "PK_sculpture",
                table: "sculpture");

            migrationBuilder.RenameTable(
                name: "sculpture",
                newName: "art");

            migrationBuilder.RenameIndex(
                name: "IX_sculpture_InstitutionId",
                table: "art",
                newName: "IX_art_InstitutionId");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "art",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Technique",
                table: "art",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sculpture_Type",
                table: "art",
                type: "text",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_art",
                table: "art",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_art_instutution_InstitutionId",
                table: "art",
                column: "InstitutionId",
                principalTable: "instutution",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
