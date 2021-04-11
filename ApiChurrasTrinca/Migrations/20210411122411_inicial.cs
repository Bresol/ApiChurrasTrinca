using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiChurrasTrinca.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Churrascos",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Observacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Data = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        ValorSugeridoPorParticipante = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        ValorSugeridoPorParticipanteComBebida = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Churrascos", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Participantes",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        ValorDeContribuicao = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        IdChurrasco = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Participantes", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Participantes_Churrascos_ChurrascoId",
            //            column: x => x.IdChurrasco,
            //            principalTable: "Churrascos",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.InsertData(
            //    table: "Churrascos",
            //    columns: new[] { "Id", "Data", "Descricao", "Observacao", "ValorSugeridoPorParticipante", "ValorSugeridoPorParticipanteComBebida" },
            //    values: new object[,]
            //    {
            //        { 1, new DateTime(2021, 4, 7, 19, 41, 40, 664, DateTimeKind.Local).AddTicks(7449), "Primeiro Churras", "Obs1", 30m, 45m },
            //        { 2, new DateTime(2021, 4, 8, 19, 41, 40, 666, DateTimeKind.Local).AddTicks(6904), "Segundo Churras", "Obs2", 30m, 45m },
            //        { 3, new DateTime(2021, 4, 9, 19, 41, 40, 666, DateTimeKind.Local).AddTicks(7002), "Terceiro Churras", "Obs3", 30m, 45m }
            //    });

            //migrationBuilder.InsertData(
            //    table: "Participantes",
            //    columns: new[] { "Id", "IdChurrasco", "Nome", "ValorDeContribuicao" },
            //    values: new object[,]
            //    {
            //        { 1, 1, "A", 30m },
            //        { 2, 1, "B", 45m },
            //        { 3, 1, "C", 30m },
            //        { 4, 2, "A", 45m },
            //        { 5, 2, "B", 30m },
            //        { 6, 3, "C", 30m }
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Participantes_IdChurrasco",
            //    table: "Participantes",
            //    column: "IdChurrasco");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "Participantes");

            //migrationBuilder.DropTable(
            //    name: "Churrascos");
        }
    }
}
