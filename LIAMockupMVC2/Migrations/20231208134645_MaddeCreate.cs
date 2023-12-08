using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LIAMockupMVC2.Migrations
{
    /// <inheritdoc />
    public partial class MaddeCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    OrgId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrgName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Field = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.OrgId);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionText = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    QuestionNum = table.Column<int>(type: "int", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.QuestionId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    GroupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FK_OrgId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.GroupId);
                    table.ForeignKey(
                        name: "FK_Groups_Organizations_FK_OrgId",
                        column: x => x.FK_OrgId,
                        principalTable: "Organizations",
                        principalColumn: "OrgId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserGroups",
                columns: table => new
                {
                    UserGroupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FK_UserId = table.Column<int>(type: "int", nullable: false),
                    FK_GroupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGroups", x => x.UserGroupId);
                    table.ForeignKey(
                        name: "FK_UserGroups_Groups_FK_GroupId",
                        column: x => x.FK_GroupId,
                        principalTable: "Groups",
                        principalColumn: "GroupId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserGroups_Users_FK_UserId",
                        column: x => x.FK_UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    AnswerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnswerText = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    AnswerNum = table.Column<int>(type: "int", maxLength: 10, nullable: true),
                    FK_QuestionId = table.Column<int>(type: "int", nullable: false),
                    FK_UserGroupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.AnswerId);
                    table.ForeignKey(
                        name: "FK_Answers_Questions_FK_QuestionId",
                        column: x => x.FK_QuestionId,
                        principalTable: "Questions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Answers_UserGroups_FK_UserGroupId",
                        column: x => x.FK_UserGroupId,
                        principalTable: "UserGroups",
                        principalColumn: "UserGroupId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "OrgId", "Field", "OrgName" },
                values: new object[,]
                {
                    { 1, "School", "Edugrade" },
                    { 2, "Store", "Interflora" },
                    { 3, "Industrial", "Hexatronic" }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionId", "QuestionNum", "QuestionText" },
                values: new object[,]
                {
                    { 1, null, "Hur mår du idag?" },
                    { 2, null, "Hur kändes lektionen idag?" },
                    { 3, null, "Vad önskar du ska tas upp på nästa APT-möte?" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "Password", "UserName" },
                values: new object[,]
                {
                    { 1, "user33@gmail.com", "heyhopp33", "user0033" },
                    { 2, "user44@gmail.com", "heyhopp44", "user0044" },
                    { 3, "user55@gmail.com", "heyhopp55", "user0055" }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "GroupId", "FK_OrgId", "GroupName" },
                values: new object[,]
                {
                    { 1, 1, "NET22" },
                    { 2, 2, "Kassa" },
                    { 3, 3, "Fiberavdelningen" }
                });

            migrationBuilder.InsertData(
                table: "UserGroups",
                columns: new[] { "UserGroupId", "FK_GroupId", "FK_UserId" },
                values: new object[,]
                {
                    { 1, 2, 1 },
                    { 2, 3, 2 },
                    { 3, 1, 3 }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "AnswerId", "AnswerNum", "AnswerText", "FK_QuestionId", "FK_UserGroupId" },
                values: new object[,]
                {
                    { 1, null, "Inte så jättebra, jag är trött", 1, 1 },
                    { 2, null, "Svår men rolig", 2, 3 },
                    { 3, null, "Hur hanterar man jobbiga kunder bäst?", 3, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_FK_QuestionId",
                table: "Answers",
                column: "FK_QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Answers_FK_UserGroupId",
                table: "Answers",
                column: "FK_UserGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_FK_OrgId",
                table: "Groups",
                column: "FK_OrgId");

            migrationBuilder.CreateIndex(
                name: "IX_UserGroups_FK_GroupId",
                table: "UserGroups",
                column: "FK_GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_UserGroups_FK_UserId",
                table: "UserGroups",
                column: "FK_UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "UserGroups");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Organizations");
        }
    }
}
