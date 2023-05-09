using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mobile.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddCascadeDelete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_SettingsId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Settings_ColorSchemeId",
                table: "Settings");

            migrationBuilder.CreateIndex(
                name: "IX_Users_SettingsId",
                table: "Users",
                column: "SettingsId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Settings_ColorSchemeId",
                table: "Settings",
                column: "ColorSchemeId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_SettingsId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Settings_ColorSchemeId",
                table: "Settings");

            migrationBuilder.CreateIndex(
                name: "IX_Users_SettingsId",
                table: "Users",
                column: "SettingsId");

            migrationBuilder.CreateIndex(
                name: "IX_Settings_ColorSchemeId",
                table: "Settings",
                column: "ColorSchemeId");
        }
    }
}
