using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class _001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreateAt = table.Column<DateTime>(nullable: false),
                    ModifyBy = table.Column<string>(nullable: true),
                    ModifyAt = table.Column<DateTime>(nullable: false),
                    SystemCreatedBy = table.Column<string>(nullable: true),
                    SystemCreateAt = table.Column<DateTime>(nullable: false),
                    SystemModifyBy = table.Column<string>(nullable: true),
                    SystemModifyAt = table.Column<DateTime>(nullable: false),
                    EmployeeCode = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    NickName = table.Column<string>(nullable: true),
                    EmployeeImage = table.Column<byte[]>(nullable: true),
                    IsValid = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "Organaization",
                columns: table => new
                {
                    OrganaizationId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreateAt = table.Column<DateTime>(nullable: false),
                    ModifyBy = table.Column<string>(nullable: true),
                    ModifyAt = table.Column<DateTime>(nullable: false),
                    SystemCreatedBy = table.Column<string>(nullable: true),
                    SystemCreateAt = table.Column<DateTime>(nullable: false),
                    SystemModifyBy = table.Column<string>(nullable: true),
                    SystemModifyAt = table.Column<DateTime>(nullable: false),
                    OrganaizationName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organaization", x => x.OrganaizationId);
                });

            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    OwnerId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreateAt = table.Column<DateTime>(nullable: false),
                    ModifyBy = table.Column<string>(nullable: true),
                    ModifyAt = table.Column<DateTime>(nullable: false),
                    SystemCreatedBy = table.Column<string>(nullable: true),
                    SystemCreateAt = table.Column<DateTime>(nullable: false),
                    SystemModifyBy = table.Column<string>(nullable: true),
                    SystemModifyAt = table.Column<DateTime>(nullable: false),
                    CompanyName = table.Column<string>(nullable: true),
                    CompanyGlobalName = table.Column<string>(nullable: true),
                    CompanyImage = table.Column<byte[]>(nullable: true),
                    NowFiscalYear = table.Column<int>(nullable: false),
                    ValidFromDate = table.Column<DateTime>(nullable: false),
                    ValidToDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.OwnerId);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DepartmentId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreateAt = table.Column<DateTime>(nullable: false),
                    ModifyBy = table.Column<string>(nullable: true),
                    ModifyAt = table.Column<DateTime>(nullable: false),
                    SystemCreatedBy = table.Column<string>(nullable: true),
                    SystemCreateAt = table.Column<DateTime>(nullable: false),
                    SystemModifyBy = table.Column<string>(nullable: true),
                    SystemModifyAt = table.Column<DateTime>(nullable: false),
                    DepartmentCode = table.Column<string>(nullable: true),
                    DepartmentName = table.Column<string>(nullable: true),
                    GlobalDepartmentName = table.Column<string>(nullable: true),
                    DepartmentLevel = table.Column<int>(nullable: false),
                    ParentDepartmentCode = table.Column<string>(nullable: true),
                    OrganaizationId = table.Column<int>(nullable: false),
                    OrganaizationId1 = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DepartmentId);
                    table.ForeignKey(
                        name: "FK_Department_Organaization_OrganaizationId1",
                        column: x => x.OrganaizationId1,
                        principalTable: "Organaization",
                        principalColumn: "OrganaizationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Department_OrganaizationId1",
                table: "Department",
                column: "OrganaizationId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Owners");

            migrationBuilder.DropTable(
                name: "Organaization");
        }
    }
}
