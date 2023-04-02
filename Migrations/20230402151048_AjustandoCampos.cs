using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Logistica.Migrations
{
    /// <inheritdoc />
    public partial class AjustandoCampos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_servicos_ServicoId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_status_StatusId",
                table: "Tickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_status",
                table: "status");

            migrationBuilder.DropPrimaryKey(
                name: "PK_servicos",
                table: "servicos");

            migrationBuilder.RenameTable(
                name: "status",
                newName: "Status");

            migrationBuilder.RenameTable(
                name: "servicos",
                newName: "Servicos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Status",
                table: "Status",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Servicos",
                table: "Servicos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Servicos_ServicoId",
                table: "Tickets",
                column: "ServicoId",
                principalTable: "Servicos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Status_StatusId",
                table: "Tickets",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Servicos_ServicoId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Status_StatusId",
                table: "Tickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Status",
                table: "Status");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Servicos",
                table: "Servicos");

            migrationBuilder.RenameTable(
                name: "Status",
                newName: "status");

            migrationBuilder.RenameTable(
                name: "Servicos",
                newName: "servicos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_status",
                table: "status",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_servicos",
                table: "servicos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_servicos_ServicoId",
                table: "Tickets",
                column: "ServicoId",
                principalTable: "servicos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_status_StatusId",
                table: "Tickets",
                column: "StatusId",
                principalTable: "status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
