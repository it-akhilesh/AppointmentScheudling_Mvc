using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppointmentScheudling.Migrations
{
    /// <inheritdoc />
    public partial class ChangeDurationSpelling : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Duriation",
                table: "Appointments",
                newName: "Duration");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Duration",
                table: "Appointments",
                newName: "Duriation");
        }
    }
}
