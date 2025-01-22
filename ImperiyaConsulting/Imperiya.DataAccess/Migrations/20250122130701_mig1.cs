using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Imperiya.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animateds",
                columns: table => new
                {
                    AnimatedId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnimatedText = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animateds", x => x.AnimatedId);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<int>(type: "int", nullable: false),
                    Fullname = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                });

            migrationBuilder.CreateTable(
                name: "Headers",
                columns: table => new
                {
                    HeaderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Headers", x => x.HeaderId);
                });

            migrationBuilder.CreateTable(
                name: "Partners",
                columns: table => new
                {
                    PartnerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partners", x => x.PartnerId);
                });

            migrationBuilder.CreateTable(
                name: "Picses",
                columns: table => new
                {
                    PicsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl6 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Picses", x => x.PicsId);
                });

            migrationBuilder.CreateTable(
                name: "Publicities",
                columns: table => new
                {
                    PublicityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fullname = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publicities", x => x.PublicityId);
                });

            migrationBuilder.CreateTable(
                name: "ServiceCards",
                columns: table => new
                {
                    ServiceCardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceCards", x => x.ServiceCardId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animateds");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Headers");

            migrationBuilder.DropTable(
                name: "Partners");

            migrationBuilder.DropTable(
                name: "Picses");

            migrationBuilder.DropTable(
                name: "Publicities");

            migrationBuilder.DropTable(
                name: "ServiceCards");
        }
    }
}
