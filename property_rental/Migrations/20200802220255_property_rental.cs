using Microsoft.EntityFrameworkCore.Migrations;

namespace property_rental.Migrations
{
    public partial class property_rental : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "propery_details",
                columns: table => new
                {
                    property_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    property_name = table.Column<string>(nullable: true),
                    property_type = table.Column<string>(nullable: true),
                    property_address = table.Column<string>(nullable: true),
                    property_value = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_propery_details", x => x.property_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "propery_details");
        }
    }
}
