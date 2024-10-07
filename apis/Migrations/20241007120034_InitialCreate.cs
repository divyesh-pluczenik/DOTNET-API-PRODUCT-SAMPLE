using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace apis.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Goods",
                columns: table => new
                {
                    TGD_PK = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TGD_DOCNR = table.Column<int>(type: "int", nullable: false),
                    TGD_PNR = table.Column<int>(type: "int", nullable: false),
                    TGD_STONES = table.Column<int>(type: "int", nullable: false),
                    TGD_WEIGHT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TGD_AQP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TGD_PRICEM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TGD_PRICEE = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TGD_PRICEL = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TGD_ORDER = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TGD_TYPE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TGD_SHAPE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TGD_MAKE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TGD_MEASUR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TGD_MEASU2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TGD_MEASU3 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TGD_TOTDEP = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TGD_TABLEW = table.Column<int>(type: "int", nullable: false),
                    TGD_CRHEIG = table.Column<int>(type: "int", nullable: false),
                    TGD_GIRDLE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TGD_GIRDL2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TGD_DRILLE = table.Column<bool>(type: "bit", nullable: false),
                    TGD_LAB = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TGD_CERTNR = table.Column<long>(type: "bigint", nullable: false),
                    TGD_COLOR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TGD_CLARIT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TGD_POLISH = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TGD_SYMMET = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TGD_FLUORE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TGD_LABELC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TGD_SHAPE1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TGD_SHAPE2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TGD_SHAPE3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TGD_SHAPE4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TGD_MAKEFR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TGD_MAKETO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TGD_COLORF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TGD_COLORT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TGD_CLARI2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TGD_CLARI3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TGD_COLORE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TGD_INFO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TGD_ATOMIC = table.Column<bool>(type: "bit", nullable: false),
                    TGD_CULET = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TGD_REF = table.Column<long>(type: "bigint", nullable: false),
                    TGD_CERTDA = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TGD_APPRAI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TGD_CERTPK = table.Column<long>(type: "bigint", nullable: false),
                    TGD_CUT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TGD_STATUS = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goods", x => x.TGD_PK);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Goods");
        }
    }
}
