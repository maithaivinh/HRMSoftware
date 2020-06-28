using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HRMSoftware.Data.EF.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cat_JobTitles",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    DateUpdate = table.Column<DateTime>(nullable: false),
                    UserCreate = table.Column<string>(nullable: true),
                    UserUpdate = table.Column<string>(nullable: true),
                    Code = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    JobTitleName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    JobTitleNameEn = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cat_JobTitles", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Cat_Positions",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    DateUpdate = table.Column<DateTime>(nullable: false),
                    UserCreate = table.Column<string>(nullable: true),
                    UserUpdate = table.Column<string>(nullable: true),
                    Code = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    PositionName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PositionNameEn = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cat_Positions", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Hre_Profiles",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    DateUpdate = table.Column<DateTime>(nullable: false),
                    UserCreate = table.Column<string>(nullable: true),
                    UserUpdate = table.Column<string>(nullable: true),
                    CodeEmp = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    ProfileName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    OrgStructureID = table.Column<Guid>(nullable: false),
                    PositionID = table.Column<Guid>(nullable: true),
                    JobTitleID = table.Column<Guid>(nullable: true),
                    Gender = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: true),
                    PlaceOfBirth = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DateHire = table.Column<DateTime>(nullable: true),
                    DateQuit = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hre_Profiles", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Hre_Profiles_Cat_JobTitles_JobTitleID",
                        column: x => x.JobTitleID,
                        principalTable: "Cat_JobTitles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Hre_Profiles_Cat_Positions_PositionID",
                        column: x => x.PositionID,
                        principalTable: "Cat_Positions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hre_Profiles_JobTitleID",
                table: "Hre_Profiles",
                column: "JobTitleID");

            migrationBuilder.CreateIndex(
                name: "IX_Hre_Profiles_PositionID",
                table: "Hre_Profiles",
                column: "PositionID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hre_Profiles");

            migrationBuilder.DropTable(
                name: "Cat_JobTitles");

            migrationBuilder.DropTable(
                name: "Cat_Positions");
        }
    }
}
