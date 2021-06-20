using Microsoft.EntityFrameworkCore.Migrations;

namespace Contacts.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<long>(type: "bigint", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "Address", "Name", "Note", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "454, Laurel St, California", "Angeline", "School Friend", 9910456545L },
                    { 2, "589, Kings St, Texas", "Rajakumar", "Neighbour", 8945786231L },
                    { 3, "111, Sagewood St, Iowa", "Jeshlin", "School Teacher", 8521463335L },
                    { 4, "785, Samsung St, Iowa", "Ferryn", "Mercy Doctor", 5152202323L },
                    { 5, "412, Hickman St, California", "Braydon", "Colleague", 9005157723L },
                    { 6, "155, Milton Ave, California", "Jacklin", "Relative", 5152124544L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");
        }
    }
}
