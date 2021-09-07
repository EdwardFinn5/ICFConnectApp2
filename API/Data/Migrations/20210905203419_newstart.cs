using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class newstart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmpNames",
                columns: table => new
                {
                    EmpNameId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpNames", x => x.EmpNameId);
                });

            migrationBuilder.CreateTable(
                name: "EmpTypes",
                columns: table => new
                {
                    EmpTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpTypeName = table.Column<string>(type: "nvarchar(40)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpTypes", x => x.EmpTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Majors",
                columns: table => new
                {
                    MajorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MajorName = table.Column<string>(type: "nvarchar(60)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Majors", x => x.MajorId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    AppUserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    UserType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    EmpType = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    Major = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.AppUserId);
                });

            migrationBuilder.CreateTable(
                name: "UserTypes",
                columns: table => new
                {
                    UserTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTypes", x => x.UserTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Colleges",
                columns: table => new
                {
                    CollegeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CollegeName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    CollegeNickname = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    CollegeLocation = table.Column<string>(type: "nvarchar(60)", nullable: true),
                    AppUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colleges", x => x.CollegeId);
                    table.ForeignKey(
                        name: "FK_Colleges_Users_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "Users",
                        principalColumn: "AppUserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HomeCities",
                columns: table => new
                {
                    HomeCityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HomeCityName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    AppUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeCities", x => x.HomeCityId);
                    table.ForeignKey(
                        name: "FK_HomeCities_Users_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "Users",
                        principalColumn: "AppUserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    PhotoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HrUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsMainStudent = table.Column<bool>(type: "bit", nullable: false),
                    IsMainLogo = table.Column<bool>(type: "bit", nullable: false),
                    IsMainHr = table.Column<bool>(type: "bit", nullable: false),
                    PublicId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.PhotoId);
                    table.ForeignKey(
                        name: "FK_Photos_Users_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "Users",
                        principalColumn: "AppUserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    PositionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PositionName = table.Column<string>(type: "nvarchar(60)", nullable: true),
                    PositionType = table.Column<string>(type: "nvarchar(12)", nullable: true),
                    PositionLocation = table.Column<string>(type: "nvarchar(60)", nullable: true),
                    Positioninfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LookingFor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HowToApply = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    ApplyUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplyDeadline = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HrContact = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    HrContactTitle = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    HrEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.PositionId);
                    table.ForeignKey(
                        name: "FK_Positions_Users_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "Users",
                        principalColumn: "AppUserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Colleges_AppUserId",
                table: "Colleges",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_HomeCities_AppUserId",
                table: "HomeCities",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_AppUserId",
                table: "Photos",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Positions_AppUserId",
                table: "Positions",
                column: "AppUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Colleges");

            migrationBuilder.DropTable(
                name: "EmpNames");

            migrationBuilder.DropTable(
                name: "EmpTypes");

            migrationBuilder.DropTable(
                name: "HomeCities");

            migrationBuilder.DropTable(
                name: "Majors");

            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "UserTypes");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
