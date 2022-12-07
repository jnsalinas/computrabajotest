using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ComputrabajoTest.Api.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Portal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Portal", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(65)", maxLength: 65, nullable: false),
                    Fax = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastLogin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PortalaId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User_Portal_PortalaId",
                        column: x => x.PortalaId,
                        principalTable: "Portal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Company",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Senger Group" },
                    { 2, "Waelchi, Bauch and Wuckert" },
                    { 3, "Hegmann Inc and Sons" },
                    { 4, "Feest LLC" },
                    { 5, "Konopelski Inc and Sons" },
                    { 6, "Weber LLC" },
                    { 7, "Russel Inc and Sons" },
                    { 8, "Bernier LLC" },
                    { 9, "Goldner-Kerluke" },
                    { 10, "Jakubowski-Franecki" },
                    { 11, "Romaguera Group" },
                    { 12, "Kunze-Schmidt" },
                    { 13, "Harvey Group" },
                    { 14, "Mertz, Kiehn and Braun" },
                    { 15, "Kessler Group" },
                    { 16, "Watsica-Rowe" },
                    { 17, "Wiza, Haag and Adams" },
                    { 18, "Swaniawski Inc and Sons" },
                    { 19, "Hessel, Gutkowski and Denesik" },
                    { 20, "Barton, Swift and Murazik" },
                    { 21, "Green-Pouros" },
                    { 22, "Connelly LLC" },
                    { 23, "Dietrich LLC" },
                    { 24, "Barton, Bauch and Spencer" },
                    { 25, "Nolan-Thiel" },
                    { 26, "Watsica-Legros" },
                    { 27, "Leannon LLC" },
                    { 28, "Boyle Group" },
                    { 29, "Murray-Botsford" },
                    { 30, "Rau-Grimes" },
                    { 31, "Daugherty, Dibbert and Steuber" },
                    { 32, "Strosin-Bednar" },
                    { 33, "Terry Inc and Sons" },
                    { 34, "Pouros Group" },
                    { 35, "Glover-McGlynn" },
                    { 36, "Welch, Rogahn and Keebler" },
                    { 37, "Ebert, Miller and Hermiston" },
                    { 38, "Swift LLC" },
                    { 39, "Jacobs-McCullough" },
                    { 40, "Nienow, Moore and Schowalter" },
                    { 41, "Runolfsson-Shields" },
                    { 42, "Berge Group" },
                    { 43, "Effertz, Waelchi and Hartmann" },
                    { 44, "West Group" },
                    { 45, "Dach-Hansen" },
                    { 46, "Bechtelar, Cartwright and Franecki" },
                    { 47, "Senger LLC" },
                    { 48, "Daugherty Group" },
                    { 49, "Bernier Inc and Sons" },
                    { 50, "Boehm Group" },
                    { 51, "Mann Inc and Sons" },
                    { 52, "Spinka, Ebert and Dicki" },
                    { 53, "Kemmer-Bernier" },
                    { 54, "Schaefer LLC" },
                    { 55, "Gutkowski, Strosin and Barrows" },
                    { 56, "Stamm, Senger and Windler" },
                    { 57, "Ortiz Group" },
                    { 58, "Kuvalis-Nikolaus" },
                    { 59, "DuBuque Group" },
                    { 60, "Pacocha-Boehm" },
                    { 61, "Carroll-Koelpin" },
                    { 62, "Predovic LLC" },
                    { 63, "Welch-Breitenberg" },
                    { 64, "Barton-Zemlak" },
                    { 65, "Reynolds-Mitchell" },
                    { 66, "Waelchi, Monahan and Hoppe" },
                    { 67, "Mertz Inc and Sons" },
                    { 68, "Paucek-Von" },
                    { 69, "Balistreri Inc and Sons" },
                    { 70, "Prohaska Group" },
                    { 71, "Ziemann LLC" },
                    { 72, "Corkery Inc and Sons" },
                    { 73, "Stark Inc and Sons" },
                    { 74, "Huel-Hettinger" },
                    { 75, "Tremblay-Sawayn" },
                    { 76, "Schaefer, Williamson and Dickens" },
                    { 77, "Brakus-Gerhold" },
                    { 78, "Glover Group" },
                    { 79, "Kling, Dibbert and Paucek" },
                    { 80, "Stanton-Wisoky" },
                    { 81, "Schiller-Nienow" },
                    { 82, "Jones Group" },
                    { 83, "Lemke LLC" },
                    { 84, "Purdy LLC" },
                    { 85, "Jerde, Bernhard and Altenwerth" },
                    { 86, "Orn-Jones" },
                    { 87, "Labadie, Breitenberg and Beahan" },
                    { 88, "Kohler-Breitenberg" },
                    { 89, "Torp LLC" },
                    { 90, "Franecki, Mills and Hauck" },
                    { 91, "Sipes, Lemke and Wisozk" },
                    { 92, "Deckow-Eichmann" },
                    { 93, "Olson LLC" },
                    { 94, "Gerlach LLC" },
                    { 95, "Gulgowski, Davis and O'Kon" },
                    { 96, "Armstrong, Strosin and Reynolds" },
                    { 97, "Walter, Crooks and Hoeger" },
                    { 98, "Orn, Bradtke and Kautzer" },
                    { 99, "Hilll, Cassin and Hills" }
                });

            migrationBuilder.InsertData(
                table: "Portal",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "halvorsonpagac.name" },
                    { 2, "friesen.co.uk" },
                    { 3, "blanda.com" },
                    { 4, "smitham.com" },
                    { 5, "swaniawski.uk" },
                    { 6, "wunschrussel.name" },
                    { 7, "mante.co.uk" },
                    { 8, "rempel.ca" },
                    { 9, "hahn.us" },
                    { 10, "kovacekprice.co.uk" },
                    { 11, "halvorson.uk" },
                    { 12, "tremblayhammes.co.uk" },
                    { 13, "fritsch.com" },
                    { 14, "parisian.info" },
                    { 15, "herman.co.uk" },
                    { 16, "jakubowskigoldner.biz" },
                    { 17, "carroll.com" },
                    { 18, "kihn.uk" },
                    { 19, "rempeltrantow.us" },
                    { 20, "dickiconn.com" },
                    { 21, "pacocha.co.uk" },
                    { 22, "cronin.co.uk" },
                    { 23, "hesselsenger.name" },
                    { 24, "whitebradtke.info" },
                    { 25, "murphyblick.ca" },
                    { 26, "hamill.info" },
                    { 27, "damoreemmerich.us" },
                    { 28, "ward.name" },
                    { 29, "ward.co.uk" },
                    { 30, "sawayngerhold.co.uk" },
                    { 31, "howezulauf.name" },
                    { 32, "goodwin.biz" },
                    { 33, "zemlak.biz" },
                    { 34, "kuphalschoen.co.uk" },
                    { 35, "mraz.biz" },
                    { 36, "oreillynolan.ca" },
                    { 37, "kiehn.name" },
                    { 38, "borer.name" },
                    { 39, "champlin.co.uk" },
                    { 40, "zieme.uk" },
                    { 41, "bednar.com" },
                    { 42, "bruen.info" },
                    { 43, "streich.info" },
                    { 44, "grimes.biz" },
                    { 45, "pfannerstill.us" },
                    { 46, "labadie.co.uk" },
                    { 47, "ondrickasimonis.uk" },
                    { 48, "harberokon.name" },
                    { 49, "gusikowski.uk" },
                    { 50, "luettgen.us" },
                    { 51, "dicki.info" },
                    { 52, "cummerata.com" },
                    { 53, "breitenberg.us" },
                    { 54, "rogahn.biz" },
                    { 55, "medhurstondricka.name" },
                    { 56, "glover.name" },
                    { 57, "champlinwyman.co.uk" },
                    { 58, "blickhand.us" },
                    { 59, "dietrichfritsch.ca" },
                    { 60, "walterwehner.name" },
                    { 61, "bodehansen.com" },
                    { 62, "bartell.name" },
                    { 63, "colebotsford.co.uk" },
                    { 64, "fadelkerluke.ca" },
                    { 65, "hillscasper.biz" },
                    { 66, "rodriguez.com" },
                    { 67, "dicki.ca" },
                    { 68, "treutelmorissette.uk" },
                    { 69, "roob.uk" },
                    { 70, "mcclure.biz" },
                    { 71, "kling.us" },
                    { 72, "brekke.com" },
                    { 73, "smitham.co.uk" },
                    { 74, "upton.ca" },
                    { 75, "treutelrempel.uk" },
                    { 76, "dach.info" },
                    { 77, "treutel.name" },
                    { 78, "kuhic.ca" },
                    { 79, "romaguera.uk" },
                    { 80, "bednar.co.uk" },
                    { 81, "osinski.com" },
                    { 82, "jacobi.co.uk" },
                    { 83, "hillsorn.ca" },
                    { 84, "harris.us" },
                    { 85, "mohrvon.us" },
                    { 86, "casper.uk" },
                    { 87, "robertsdamore.name" },
                    { 88, "boyle.co.uk" },
                    { 89, "abshire.name" },
                    { 90, "hane.biz" },
                    { 91, "waelchi.biz" },
                    { 92, "hillsfeest.name" },
                    { 93, "ullrich.name" },
                    { 94, "hoppe.co.uk" },
                    { 95, "stark.co.uk" },
                    { 96, "simonis.ca" },
                    { 97, "rau.com" },
                    { 98, "goyette.ca" },
                    { 99, "yost.uk" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Administrador" },
                    { 2, "Asistente" }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Activo" },
                    { 2, "Inactivo" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CompanyId", "CreatedOn", "DeletedOn", "Email", "Fax", "LastLogin", "Name", "Password", "PortalaId", "RoleId", "StatusId", "Telephone", "UpdatedOn", "Username" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 8, 28, 6, 13, 26, 813, DateTimeKind.Utc).AddTicks(5950), new DateTime(2022, 12, 6, 6, 13, 26, 813, DateTimeKind.Utc).AddTicks(6470), "elfrieda_hegmann@lefflerharvey.biz", "1-098-438-9660", new DateTime(2022, 11, 26, 6, 13, 26, 813, DateTimeKind.Utc).AddTicks(6470), "Elfrieda Hegmann", "pendiente encriptar", 1, 1, 2, "(986)427-1497", new DateTime(2022, 12, 6, 6, 13, 26, 813, DateTimeKind.Utc).AddTicks(6470), "elfrieda.hegmann" },
                    { 2, 2, new DateTime(2022, 8, 28, 6, 13, 26, 813, DateTimeKind.Utc).AddTicks(8050), new DateTime(2022, 12, 6, 6, 13, 26, 813, DateTimeKind.Utc).AddTicks(8480), "yasmeen_hermann@nolangreen.biz", "1-832-000-6305", new DateTime(2022, 11, 26, 6, 13, 26, 813, DateTimeKind.Utc).AddTicks(8480), "Yasmeen Hermann", "pendiente encriptar", 2, 1, 2, "(994)987-0567", new DateTime(2022, 12, 6, 6, 13, 26, 813, DateTimeKind.Utc).AddTicks(8480), "yasmeen.hermann" },
                    { 3, 3, new DateTime(2022, 8, 28, 6, 13, 26, 813, DateTimeKind.Utc).AddTicks(9990), new DateTime(2022, 12, 6, 6, 13, 26, 814, DateTimeKind.Utc).AddTicks(270), "grover_kassulke@koepp.ca", "1-482-499-6897", new DateTime(2022, 11, 26, 6, 13, 26, 814, DateTimeKind.Utc).AddTicks(270), "Grover Kassulke", "pendiente encriptar", 3, 1, 2, "1-850-120-9102 x159", new DateTime(2022, 12, 6, 6, 13, 26, 814, DateTimeKind.Utc).AddTicks(270), "grover.kassulke" },
                    { 4, 4, new DateTime(2022, 8, 28, 6, 13, 26, 814, DateTimeKind.Utc).AddTicks(1800), new DateTime(2022, 12, 6, 6, 13, 26, 814, DateTimeKind.Utc).AddTicks(2200), "timothy.padberg@yostfeil.biz", "492-246-7895", new DateTime(2022, 11, 26, 6, 13, 26, 814, DateTimeKind.Utc).AddTicks(2200), "Timothy Padberg", "pendiente encriptar", 4, 2, 1, "848-664-1527 x615", new DateTime(2022, 12, 6, 6, 13, 26, 814, DateTimeKind.Utc).AddTicks(2200), "timothy_padberg" },
                    { 5, 5, new DateTime(2022, 8, 28, 6, 13, 26, 814, DateTimeKind.Utc).AddTicks(3700), new DateTime(2022, 12, 6, 6, 13, 26, 814, DateTimeKind.Utc).AddTicks(3970), "justina.weber@mccullough.us", "133-922-7031 x75527", new DateTime(2022, 11, 26, 6, 13, 26, 814, DateTimeKind.Utc).AddTicks(3970), "Justina Weber", "pendiente encriptar", 5, 2, 1, "(275)252-7954", new DateTime(2022, 12, 6, 6, 13, 26, 814, DateTimeKind.Utc).AddTicks(3970), "justina.weber" },
                    { 6, 6, new DateTime(2022, 8, 28, 6, 13, 26, 814, DateTimeKind.Utc).AddTicks(5360), new DateTime(2022, 12, 6, 6, 13, 26, 814, DateTimeKind.Utc).AddTicks(5650), "zaria.kuvalis@auer.info", "(436)757-0505 x3632", new DateTime(2022, 11, 26, 6, 13, 26, 814, DateTimeKind.Utc).AddTicks(5650), "Zaria Kuvalis", "pendiente encriptar", 6, 2, 2, "738-216-1684 x9818", new DateTime(2022, 12, 6, 6, 13, 26, 814, DateTimeKind.Utc).AddTicks(5650), "zaria_kuvalis" },
                    { 7, 7, new DateTime(2022, 8, 28, 6, 13, 26, 814, DateTimeKind.Utc).AddTicks(6880), new DateTime(2022, 12, 6, 6, 13, 26, 814, DateTimeKind.Utc).AddTicks(7400), "vito_ferry@baumbach.biz", "(642)009-6980", new DateTime(2022, 11, 26, 6, 13, 26, 814, DateTimeKind.Utc).AddTicks(7400), "Vito Ferry", "pendiente encriptar", 7, 1, 1, "540-347-6875 x8352", new DateTime(2022, 12, 6, 6, 13, 26, 814, DateTimeKind.Utc).AddTicks(7400), "vito_ferry" },
                    { 8, 8, new DateTime(2022, 8, 28, 6, 13, 26, 814, DateTimeKind.Utc).AddTicks(8650), new DateTime(2022, 12, 6, 6, 13, 26, 814, DateTimeKind.Utc).AddTicks(8910), "anita_schamberger@eichmann.uk", "054.036.6341", new DateTime(2022, 11, 26, 6, 13, 26, 814, DateTimeKind.Utc).AddTicks(8910), "Anita Schamberger", "pendiente encriptar", 8, 2, 1, "1-172-471-2614", new DateTime(2022, 12, 6, 6, 13, 26, 814, DateTimeKind.Utc).AddTicks(8920), "anita.schamberger" },
                    { 9, 9, new DateTime(2022, 8, 28, 6, 13, 26, 815, DateTimeKind.Utc).AddTicks(570), new DateTime(2022, 12, 6, 6, 13, 26, 815, DateTimeKind.Utc).AddTicks(1020), "althea.o.conner@beckerhartmann.com", "(619)800-6185 x6671", new DateTime(2022, 11, 26, 6, 13, 26, 815, DateTimeKind.Utc).AddTicks(1020), "Althea O'Conner", "pendiente encriptar", 9, 1, 1, "1-515-912-4876", new DateTime(2022, 12, 6, 6, 13, 26, 815, DateTimeKind.Utc).AddTicks(1020), "althea.o_conner" },
                    { 10, 10, new DateTime(2022, 8, 28, 6, 13, 26, 815, DateTimeKind.Utc).AddTicks(2480), new DateTime(2022, 12, 6, 6, 13, 26, 815, DateTimeKind.Utc).AddTicks(3020), "lorine.keebler@howe.name", "892-083-3179 x7711", new DateTime(2022, 11, 26, 6, 13, 26, 815, DateTimeKind.Utc).AddTicks(3020), "Lorine Keebler", "pendiente encriptar", 10, 1, 2, "(162)156-0944 x87572", new DateTime(2022, 12, 6, 6, 13, 26, 815, DateTimeKind.Utc).AddTicks(3020), "lorine.keebler" },
                    { 11, 11, new DateTime(2022, 8, 28, 6, 13, 26, 815, DateTimeKind.Utc).AddTicks(4300), new DateTime(2022, 12, 6, 6, 13, 26, 815, DateTimeKind.Utc).AddTicks(4590), "phyllis_marquardt@walter.uk", "1-386-169-4651 x1122", new DateTime(2022, 11, 26, 6, 13, 26, 815, DateTimeKind.Utc).AddTicks(4590), "Phyllis Marquardt", "pendiente encriptar", 11, 2, 1, "254-231-5581 x9325", new DateTime(2022, 12, 6, 6, 13, 26, 815, DateTimeKind.Utc).AddTicks(4590), "phyllis.marquardt" },
                    { 12, 12, new DateTime(2022, 8, 28, 6, 13, 26, 815, DateTimeKind.Utc).AddTicks(6080), new DateTime(2022, 12, 6, 6, 13, 26, 815, DateTimeKind.Utc).AddTicks(6590), "terence_hamill@corkery.name", "1-564-032-4564", new DateTime(2022, 11, 26, 6, 13, 26, 815, DateTimeKind.Utc).AddTicks(6590), "Terence Hamill", "pendiente encriptar", 12, 1, 2, "111.019.0186", new DateTime(2022, 12, 6, 6, 13, 26, 815, DateTimeKind.Utc).AddTicks(6590), "terence_hamill" },
                    { 13, 13, new DateTime(2022, 8, 28, 6, 13, 26, 815, DateTimeKind.Utc).AddTicks(8080), new DateTime(2022, 12, 6, 6, 13, 26, 815, DateTimeKind.Utc).AddTicks(8540), "hulda.bahringer@langparker.info", "682-596-5284 x215", new DateTime(2022, 11, 26, 6, 13, 26, 815, DateTimeKind.Utc).AddTicks(8540), "Hulda Bahringer", "pendiente encriptar", 13, 2, 2, "1-225-055-7280 x12393", new DateTime(2022, 12, 6, 6, 13, 26, 815, DateTimeKind.Utc).AddTicks(8540), "hulda_bahringer" },
                    { 14, 14, new DateTime(2022, 8, 28, 6, 13, 26, 816, DateTimeKind.Utc).AddTicks(20), new DateTime(2022, 12, 6, 6, 13, 26, 816, DateTimeKind.Utc).AddTicks(560), "noble_kertzmann@cole.com", "1-886-624-4456 x7390", new DateTime(2022, 11, 26, 6, 13, 26, 816, DateTimeKind.Utc).AddTicks(560), "Noble Kertzmann", "pendiente encriptar", 14, 1, 2, "822.537.1434 x17385", new DateTime(2022, 12, 6, 6, 13, 26, 816, DateTimeKind.Utc).AddTicks(560), "noble.kertzmann" },
                    { 15, 15, new DateTime(2022, 8, 28, 6, 13, 26, 816, DateTimeKind.Utc).AddTicks(2070), new DateTime(2022, 12, 6, 6, 13, 26, 816, DateTimeKind.Utc).AddTicks(2580), "sammie_mcdermott@bogan.biz", "070.699.1947 x163", new DateTime(2022, 11, 26, 6, 13, 26, 816, DateTimeKind.Utc).AddTicks(2580), "Sammie McDermott", "pendiente encriptar", 15, 2, 2, "150.435.7453", new DateTime(2022, 12, 6, 6, 13, 26, 816, DateTimeKind.Utc).AddTicks(2580), "sammie_mcdermott" },
                    { 16, 16, new DateTime(2022, 8, 28, 6, 13, 26, 816, DateTimeKind.Utc).AddTicks(4050), new DateTime(2022, 12, 6, 6, 13, 26, 816, DateTimeKind.Utc).AddTicks(4610), "kurt.rau@mcclure.biz", "599.683.6989 x7290", new DateTime(2022, 11, 26, 6, 13, 26, 816, DateTimeKind.Utc).AddTicks(4610), "Kurt Rau", "pendiente encriptar", 16, 1, 2, "721-103-0814 x773", new DateTime(2022, 12, 6, 6, 13, 26, 816, DateTimeKind.Utc).AddTicks(4610), "kurt_rau" },
                    { 17, 17, new DateTime(2022, 8, 28, 6, 13, 26, 816, DateTimeKind.Utc).AddTicks(6110), new DateTime(2022, 12, 6, 6, 13, 26, 816, DateTimeKind.Utc).AddTicks(6380), "oral.stanton@crist.us", "822.741.9268 x0090", new DateTime(2022, 11, 26, 6, 13, 26, 816, DateTimeKind.Utc).AddTicks(6380), "Oral Stanton", "pendiente encriptar", 17, 1, 2, "680.712.5251", new DateTime(2022, 12, 6, 6, 13, 26, 816, DateTimeKind.Utc).AddTicks(6380), "oral.stanton" },
                    { 18, 18, new DateTime(2022, 8, 28, 6, 13, 26, 816, DateTimeKind.Utc).AddTicks(7960), new DateTime(2022, 12, 6, 6, 13, 26, 816, DateTimeKind.Utc).AddTicks(8490), "tamia_erdman@wilkinson.uk", "530-034-9019", new DateTime(2022, 11, 26, 6, 13, 26, 816, DateTimeKind.Utc).AddTicks(8490), "Tamia Erdman", "pendiente encriptar", 18, 2, 2, "845.991.9801 x3793", new DateTime(2022, 12, 6, 6, 13, 26, 816, DateTimeKind.Utc).AddTicks(8490), "tamia.erdman" },
                    { 19, 19, new DateTime(2022, 8, 28, 6, 13, 26, 817, DateTimeKind.Utc).AddTicks(80), new DateTime(2022, 12, 6, 6, 13, 26, 817, DateTimeKind.Utc).AddTicks(370), "hayden.kuphal@gerhold.com", "718.743.0178 x22509", new DateTime(2022, 11, 26, 6, 13, 26, 817, DateTimeKind.Utc).AddTicks(370), "Hayden Kuphal", "pendiente encriptar", 19, 1, 2, "(044)942-9212 x9764", new DateTime(2022, 12, 6, 6, 13, 26, 817, DateTimeKind.Utc).AddTicks(370), "hayden_kuphal" },
                    { 20, 20, new DateTime(2022, 8, 28, 6, 13, 26, 817, DateTimeKind.Utc).AddTicks(1990), new DateTime(2022, 12, 6, 6, 13, 26, 817, DateTimeKind.Utc).AddTicks(2550), "joey.watsica@halvorson.co.uk", "1-411-069-0450", new DateTime(2022, 11, 26, 6, 13, 26, 817, DateTimeKind.Utc).AddTicks(2550), "Joey Watsica", "pendiente encriptar", 20, 2, 2, "952-455-7038 x33598", new DateTime(2022, 12, 6, 6, 13, 26, 817, DateTimeKind.Utc).AddTicks(2550), "joey_watsica" },
                    { 21, 21, new DateTime(2022, 8, 28, 6, 13, 26, 817, DateTimeKind.Utc).AddTicks(3930), new DateTime(2022, 12, 6, 6, 13, 26, 817, DateTimeKind.Utc).AddTicks(4220), "lucy_kohler@jenkins.ca", "279.666.2449 x228", new DateTime(2022, 11, 26, 6, 13, 26, 817, DateTimeKind.Utc).AddTicks(4220), "Lucy Kohler", "pendiente encriptar", 21, 2, 2, "1-115-019-1331 x00411", new DateTime(2022, 12, 6, 6, 13, 26, 817, DateTimeKind.Utc).AddTicks(4220), "lucy.kohler" },
                    { 22, 22, new DateTime(2022, 8, 28, 6, 13, 26, 817, DateTimeKind.Utc).AddTicks(5710), new DateTime(2022, 12, 6, 6, 13, 26, 817, DateTimeKind.Utc).AddTicks(6240), "tamara_powlowski@wilderman.info", "867.605.9201 x465", new DateTime(2022, 11, 26, 6, 13, 26, 817, DateTimeKind.Utc).AddTicks(6240), "Tamara Powlowski", "pendiente encriptar", 22, 2, 1, "098-344-3045 x0535", new DateTime(2022, 12, 6, 6, 13, 26, 817, DateTimeKind.Utc).AddTicks(6240), "tamara_powlowski" },
                    { 23, 23, new DateTime(2022, 8, 28, 6, 13, 26, 817, DateTimeKind.Utc).AddTicks(7600), new DateTime(2022, 12, 6, 6, 13, 26, 817, DateTimeKind.Utc).AddTicks(7990), "jared_runte@fayfritsch.uk", "1-164-721-1244", new DateTime(2022, 11, 26, 6, 13, 26, 817, DateTimeKind.Utc).AddTicks(7990), "Jared Runte", "pendiente encriptar", 23, 1, 2, "820.340.2448 x308", new DateTime(2022, 12, 6, 6, 13, 26, 817, DateTimeKind.Utc).AddTicks(7990), "jared_runte" },
                    { 24, 24, new DateTime(2022, 8, 28, 6, 13, 26, 817, DateTimeKind.Utc).AddTicks(9590), new DateTime(2022, 12, 6, 6, 13, 26, 818, DateTimeKind.Utc).AddTicks(70), "tyree_schmeler@deckowschmeler.name", "1-323-182-9013", new DateTime(2022, 11, 26, 6, 13, 26, 818, DateTimeKind.Utc).AddTicks(70), "Tyree Schmeler", "pendiente encriptar", 24, 1, 1, "407.776.1222", new DateTime(2022, 12, 6, 6, 13, 26, 818, DateTimeKind.Utc).AddTicks(70), "tyree_schmeler" },
                    { 25, 25, new DateTime(2022, 8, 28, 6, 13, 26, 818, DateTimeKind.Utc).AddTicks(1540), new DateTime(2022, 12, 6, 6, 13, 26, 818, DateTimeKind.Utc).AddTicks(2050), "angelita.kshlerin@smith.co.uk", "032.498.7694", new DateTime(2022, 11, 26, 6, 13, 26, 818, DateTimeKind.Utc).AddTicks(2040), "Angelita Kshlerin", "pendiente encriptar", 25, 2, 2, "1-197-622-2563", new DateTime(2022, 12, 6, 6, 13, 26, 818, DateTimeKind.Utc).AddTicks(2050), "angelita_kshlerin" },
                    { 26, 26, new DateTime(2022, 8, 28, 6, 13, 26, 818, DateTimeKind.Utc).AddTicks(3650), new DateTime(2022, 12, 6, 6, 13, 26, 818, DateTimeKind.Utc).AddTicks(3920), "patricia_lakin@stark.ca", "1-117-160-1530 x824", new DateTime(2022, 11, 26, 6, 13, 26, 818, DateTimeKind.Utc).AddTicks(3920), "Patricia Lakin", "pendiente encriptar", 26, 2, 2, "(451)953-7850", new DateTime(2022, 12, 6, 6, 13, 26, 818, DateTimeKind.Utc).AddTicks(3920), "patricia.lakin" },
                    { 27, 27, new DateTime(2022, 8, 28, 6, 13, 26, 818, DateTimeKind.Utc).AddTicks(5290), new DateTime(2022, 12, 6, 6, 13, 26, 818, DateTimeKind.Utc).AddTicks(5700), "brooke.shanahan@parisianfarrell.ca", "1-493-459-6822 x597", new DateTime(2022, 11, 26, 6, 13, 26, 818, DateTimeKind.Utc).AddTicks(5700), "Brooke Shanahan", "pendiente encriptar", 27, 2, 1, "(519)543-1994 x5098", new DateTime(2022, 12, 6, 6, 13, 26, 818, DateTimeKind.Utc).AddTicks(5700), "brooke.shanahan" },
                    { 28, 28, new DateTime(2022, 8, 28, 6, 13, 26, 818, DateTimeKind.Utc).AddTicks(6930), new DateTime(2022, 12, 6, 6, 13, 26, 818, DateTimeKind.Utc).AddTicks(7490), "vanessa_legros@kuphal.name", "619.330.0791 x201", new DateTime(2022, 11, 26, 6, 13, 26, 818, DateTimeKind.Utc).AddTicks(7490), "Vanessa Legros", "pendiente encriptar", 28, 1, 2, "668.576.3522", new DateTime(2022, 12, 6, 6, 13, 26, 818, DateTimeKind.Utc).AddTicks(7490), "vanessa.legros" },
                    { 29, 29, new DateTime(2022, 8, 28, 6, 13, 26, 818, DateTimeKind.Utc).AddTicks(8860), new DateTime(2022, 12, 6, 6, 13, 26, 818, DateTimeKind.Utc).AddTicks(9250), "tia.kovacek@rippindickinson.com", "(832)635-7638 x15341", new DateTime(2022, 11, 26, 6, 13, 26, 818, DateTimeKind.Utc).AddTicks(9250), "Tia Kovacek", "pendiente encriptar", 29, 1, 2, "402-416-5731", new DateTime(2022, 12, 6, 6, 13, 26, 818, DateTimeKind.Utc).AddTicks(9250), "tia_kovacek" },
                    { 30, 30, new DateTime(2022, 8, 28, 6, 13, 26, 819, DateTimeKind.Utc).AddTicks(740), new DateTime(2022, 12, 6, 6, 13, 26, 819, DateTimeKind.Utc).AddTicks(1140), "elena.breitenberg@rohansenger.ca", "1-609-427-1597", new DateTime(2022, 11, 26, 6, 13, 26, 819, DateTimeKind.Utc).AddTicks(1140), "Elena Breitenberg", "pendiente encriptar", 30, 2, 2, "1-646-151-2983 x74637", new DateTime(2022, 12, 6, 6, 13, 26, 819, DateTimeKind.Utc).AddTicks(1140), "elena_breitenberg" },
                    { 31, 31, new DateTime(2022, 8, 28, 6, 13, 26, 819, DateTimeKind.Utc).AddTicks(2880), new DateTime(2022, 12, 6, 6, 13, 26, 819, DateTimeKind.Utc).AddTicks(3180), "mathew.collier@goldner.ca", "1-898-915-4481 x2677", new DateTime(2022, 11, 26, 6, 13, 26, 819, DateTimeKind.Utc).AddTicks(3180), "Mathew Collier", "pendiente encriptar", 31, 2, 2, "(387)576-5899", new DateTime(2022, 12, 6, 6, 13, 26, 819, DateTimeKind.Utc).AddTicks(3180), "mathew.collier" },
                    { 32, 32, new DateTime(2022, 8, 28, 6, 13, 26, 819, DateTimeKind.Utc).AddTicks(4780), new DateTime(2022, 12, 6, 6, 13, 26, 819, DateTimeKind.Utc).AddTicks(5170), "magnolia_cole@keelingruecker.us", "(430)464-2575 x2270", new DateTime(2022, 11, 26, 6, 13, 26, 819, DateTimeKind.Utc).AddTicks(5170), "Magnolia Cole", "pendiente encriptar", 32, 2, 1, "300.817.2802 x534", new DateTime(2022, 12, 6, 6, 13, 26, 819, DateTimeKind.Utc).AddTicks(5170), "magnolia_cole" },
                    { 33, 33, new DateTime(2022, 8, 28, 6, 13, 26, 823, DateTimeKind.Utc).AddTicks(3610), new DateTime(2022, 12, 6, 6, 13, 26, 823, DateTimeKind.Utc).AddTicks(4380), "dovie_ankunding@lubowitz.info", "009-654-7535 x98803", new DateTime(2022, 11, 26, 6, 13, 26, 823, DateTimeKind.Utc).AddTicks(4380), "Dovie Ankunding", "pendiente encriptar", 33, 2, 1, "068.514.3389", new DateTime(2022, 12, 6, 6, 13, 26, 823, DateTimeKind.Utc).AddTicks(4380), "dovie_ankunding" },
                    { 34, 34, new DateTime(2022, 8, 28, 6, 13, 26, 823, DateTimeKind.Utc).AddTicks(5830), new DateTime(2022, 12, 6, 6, 13, 26, 823, DateTimeKind.Utc).AddTicks(6370), "herminia.bartoletti@runolfsdottirdibbert.name", "(256)147-8403 x375", new DateTime(2022, 11, 26, 6, 13, 26, 823, DateTimeKind.Utc).AddTicks(6370), "Herminia Bartoletti", "pendiente encriptar", 34, 1, 1, "507.509.9202", new DateTime(2022, 12, 6, 6, 13, 26, 823, DateTimeKind.Utc).AddTicks(6370), "herminia.bartoletti" },
                    { 35, 35, new DateTime(2022, 8, 28, 6, 13, 26, 823, DateTimeKind.Utc).AddTicks(7610), new DateTime(2022, 12, 6, 6, 13, 26, 823, DateTimeKind.Utc).AddTicks(8130), "mylene.hagenes@larkin.uk", "(777)580-2540 x489", new DateTime(2022, 11, 26, 6, 13, 26, 823, DateTimeKind.Utc).AddTicks(8130), "Mylene Hagenes", "pendiente encriptar", 35, 1, 2, "1-467-505-9089 x9375", new DateTime(2022, 12, 6, 6, 13, 26, 823, DateTimeKind.Utc).AddTicks(8130), "mylene.hagenes" },
                    { 36, 36, new DateTime(2022, 8, 28, 6, 13, 26, 823, DateTimeKind.Utc).AddTicks(9630), new DateTime(2022, 12, 6, 6, 13, 26, 824, DateTimeKind.Utc).AddTicks(40), "hal_douglas@dietrichmarquardt.uk", "(414)967-4720 x85066", new DateTime(2022, 11, 26, 6, 13, 26, 824, DateTimeKind.Utc).AddTicks(40), "Hal Douglas", "pendiente encriptar", 36, 2, 1, "(313)712-7487 x6036", new DateTime(2022, 12, 6, 6, 13, 26, 824, DateTimeKind.Utc).AddTicks(40), "hal.douglas" },
                    { 37, 37, new DateTime(2022, 8, 28, 6, 13, 26, 824, DateTimeKind.Utc).AddTicks(1560), new DateTime(2022, 12, 6, 6, 13, 26, 824, DateTimeKind.Utc).AddTicks(1870), "lula.boehm@murphy.com", "054.621.2578", new DateTime(2022, 11, 26, 6, 13, 26, 824, DateTimeKind.Utc).AddTicks(1870), "Lula Boehm", "pendiente encriptar", 37, 2, 2, "(296)865-8273 x55213", new DateTime(2022, 12, 6, 6, 13, 26, 824, DateTimeKind.Utc).AddTicks(1870), "lula_boehm" },
                    { 38, 38, new DateTime(2022, 8, 28, 6, 13, 26, 824, DateTimeKind.Utc).AddTicks(3200), new DateTime(2022, 12, 6, 6, 13, 26, 824, DateTimeKind.Utc).AddTicks(3770), "effie.stanton@rice.co.uk", "156.192.6160 x0019", new DateTime(2022, 11, 26, 6, 13, 26, 824, DateTimeKind.Utc).AddTicks(3770), "Effie Stanton", "pendiente encriptar", 38, 2, 1, "132.450.5719 x11248", new DateTime(2022, 12, 6, 6, 13, 26, 824, DateTimeKind.Utc).AddTicks(3770), "effie_stanton" },
                    { 39, 39, new DateTime(2022, 8, 28, 6, 13, 26, 824, DateTimeKind.Utc).AddTicks(5450), new DateTime(2022, 12, 6, 6, 13, 26, 824, DateTimeKind.Utc).AddTicks(6000), "buster.johnston@purdy.name", "1-068-392-4400 x9315", new DateTime(2022, 11, 26, 6, 13, 26, 824, DateTimeKind.Utc).AddTicks(6000), "Buster Johnston", "pendiente encriptar", 39, 1, 2, "1-939-731-3853", new DateTime(2022, 12, 6, 6, 13, 26, 824, DateTimeKind.Utc).AddTicks(6000), "buster.johnston" },
                    { 40, 40, new DateTime(2022, 8, 28, 6, 13, 26, 824, DateTimeKind.Utc).AddTicks(7540), new DateTime(2022, 12, 6, 6, 13, 26, 824, DateTimeKind.Utc).AddTicks(8010), "adrian_daniel@hyatt.us", "351-840-1714 x241", new DateTime(2022, 11, 26, 6, 13, 26, 824, DateTimeKind.Utc).AddTicks(8010), "Adrian Daniel", "pendiente encriptar", 40, 2, 1, "(338)301-4952", new DateTime(2022, 12, 6, 6, 13, 26, 824, DateTimeKind.Utc).AddTicks(8010), "adrian.daniel" },
                    { 41, 41, new DateTime(2022, 8, 28, 6, 13, 26, 824, DateTimeKind.Utc).AddTicks(9430), new DateTime(2022, 12, 6, 6, 13, 26, 824, DateTimeKind.Utc).AddTicks(9940), "ramiro_rohan@carter.ca", "(374)569-9990 x06156", new DateTime(2022, 11, 26, 6, 13, 26, 824, DateTimeKind.Utc).AddTicks(9940), "Ramiro Rohan", "pendiente encriptar", 41, 1, 2, "392.492.6150 x2657", new DateTime(2022, 12, 6, 6, 13, 26, 824, DateTimeKind.Utc).AddTicks(9940), "ramiro.rohan" },
                    { 42, 42, new DateTime(2022, 8, 28, 6, 13, 26, 825, DateTimeKind.Utc).AddTicks(1030), new DateTime(2022, 12, 6, 6, 13, 26, 825, DateTimeKind.Utc).AddTicks(1510), "daron.spencer@larson.co.uk", "1-070-170-2821 x7447", new DateTime(2022, 11, 26, 6, 13, 26, 825, DateTimeKind.Utc).AddTicks(1510), "Daron Spencer", "pendiente encriptar", 42, 1, 1, "1-579-481-5749", new DateTime(2022, 12, 6, 6, 13, 26, 825, DateTimeKind.Utc).AddTicks(1510), "daron_spencer" },
                    { 43, 43, new DateTime(2022, 8, 28, 6, 13, 26, 825, DateTimeKind.Utc).AddTicks(2850), new DateTime(2022, 12, 6, 6, 13, 26, 825, DateTimeKind.Utc).AddTicks(3090), "jaycee.zboncak@satterfield.us", "1-336-698-4267", new DateTime(2022, 11, 26, 6, 13, 26, 825, DateTimeKind.Utc).AddTicks(3090), "Jaycee Zboncak", "pendiente encriptar", 43, 2, 2, "1-316-004-2379 x200", new DateTime(2022, 12, 6, 6, 13, 26, 825, DateTimeKind.Utc).AddTicks(3090), "jaycee_zboncak" },
                    { 44, 44, new DateTime(2022, 8, 28, 6, 13, 26, 825, DateTimeKind.Utc).AddTicks(4410), new DateTime(2022, 12, 6, 6, 13, 26, 825, DateTimeKind.Utc).AddTicks(4660), "schuyler_wolff@berge.uk", "381-793-1763 x94197", new DateTime(2022, 11, 26, 6, 13, 26, 825, DateTimeKind.Utc).AddTicks(4660), "Schuyler Wolff", "pendiente encriptar", 44, 1, 2, "1-682-050-5581", new DateTime(2022, 12, 6, 6, 13, 26, 825, DateTimeKind.Utc).AddTicks(4660), "schuyler_wolff" },
                    { 45, 45, new DateTime(2022, 8, 28, 6, 13, 26, 825, DateTimeKind.Utc).AddTicks(5860), new DateTime(2022, 12, 6, 6, 13, 26, 825, DateTimeKind.Utc).AddTicks(6100), "sienna_schimmel@paucek.info", "1-112-573-7175", new DateTime(2022, 11, 26, 6, 13, 26, 825, DateTimeKind.Utc).AddTicks(6100), "Sienna Schimmel", "pendiente encriptar", 45, 2, 1, "238.057.8552", new DateTime(2022, 12, 6, 6, 13, 26, 825, DateTimeKind.Utc).AddTicks(6110), "sienna_schimmel" },
                    { 46, 46, new DateTime(2022, 8, 28, 6, 13, 26, 825, DateTimeKind.Utc).AddTicks(7650), new DateTime(2022, 12, 6, 6, 13, 26, 825, DateTimeKind.Utc).AddTicks(7900), "isidro_schulist@streich.co.uk", "1-833-024-0635 x00870", new DateTime(2022, 11, 26, 6, 13, 26, 825, DateTimeKind.Utc).AddTicks(7900), "Isidro Schulist", "pendiente encriptar", 46, 1, 2, "1-618-265-7639", new DateTime(2022, 12, 6, 6, 13, 26, 825, DateTimeKind.Utc).AddTicks(7900), "isidro.schulist" },
                    { 47, 47, new DateTime(2022, 8, 28, 6, 13, 26, 825, DateTimeKind.Utc).AddTicks(9100), new DateTime(2022, 12, 6, 6, 13, 26, 825, DateTimeKind.Utc).AddTicks(9600), "enos_haag@tillman.biz", "924.423.3767 x93509", new DateTime(2022, 11, 26, 6, 13, 26, 825, DateTimeKind.Utc).AddTicks(9600), "Enos Haag", "pendiente encriptar", 47, 1, 1, "(486)818-8071 x47129", new DateTime(2022, 12, 6, 6, 13, 26, 825, DateTimeKind.Utc).AddTicks(9600), "enos.haag" },
                    { 48, 48, new DateTime(2022, 8, 28, 6, 13, 26, 826, DateTimeKind.Utc).AddTicks(820), new DateTime(2022, 12, 6, 6, 13, 26, 826, DateTimeKind.Utc).AddTicks(1190), "kimberly_emmerich@daughertyprice.uk", "1-074-566-0104 x1305", new DateTime(2022, 11, 26, 6, 13, 26, 826, DateTimeKind.Utc).AddTicks(1190), "Kimberly Emmerich", "pendiente encriptar", 48, 2, 2, "987-958-5751 x0492", new DateTime(2022, 12, 6, 6, 13, 26, 826, DateTimeKind.Utc).AddTicks(1200), "kimberly_emmerich" },
                    { 49, 49, new DateTime(2022, 8, 28, 6, 13, 26, 826, DateTimeKind.Utc).AddTicks(2280), new DateTime(2022, 12, 6, 6, 13, 26, 826, DateTimeKind.Utc).AddTicks(2770), "cristal_gerlach@stark.biz", "567-630-7114 x0911", new DateTime(2022, 11, 26, 6, 13, 26, 826, DateTimeKind.Utc).AddTicks(2770), "Cristal Gerlach", "pendiente encriptar", 49, 1, 1, "427-803-4612 x1662", new DateTime(2022, 12, 6, 6, 13, 26, 826, DateTimeKind.Utc).AddTicks(2770), "cristal.gerlach" },
                    { 50, 50, new DateTime(2022, 8, 28, 6, 13, 26, 826, DateTimeKind.Utc).AddTicks(3860), new DateTime(2022, 12, 6, 6, 13, 26, 826, DateTimeKind.Utc).AddTicks(4220), "laurie_morar@naderhilpert.ca", "1-383-068-7061 x79263", new DateTime(2022, 11, 26, 6, 13, 26, 826, DateTimeKind.Utc).AddTicks(4220), "Laurie Morar", "pendiente encriptar", 50, 1, 1, "(432)379-3148", new DateTime(2022, 12, 6, 6, 13, 26, 826, DateTimeKind.Utc).AddTicks(4220), "laurie_morar" },
                    { 51, 51, new DateTime(2022, 8, 28, 6, 13, 26, 826, DateTimeKind.Utc).AddTicks(5300), new DateTime(2022, 12, 6, 6, 13, 26, 826, DateTimeKind.Utc).AddTicks(5780), "madalyn_russel@bins.ca", "(014)367-0598", new DateTime(2022, 11, 26, 6, 13, 26, 826, DateTimeKind.Utc).AddTicks(5780), "Madalyn Russel", "pendiente encriptar", 51, 1, 2, "(885)085-8924 x52820", new DateTime(2022, 12, 6, 6, 13, 26, 826, DateTimeKind.Utc).AddTicks(5780), "madalyn.russel" },
                    { 52, 52, new DateTime(2022, 8, 28, 6, 13, 26, 826, DateTimeKind.Utc).AddTicks(7160), new DateTime(2022, 12, 6, 6, 13, 26, 826, DateTimeKind.Utc).AddTicks(7580), "nellie_reichert@emmerichschaefer.biz", "1-781-381-1628", new DateTime(2022, 11, 26, 6, 13, 26, 826, DateTimeKind.Utc).AddTicks(7580), "Nellie Reichert", "pendiente encriptar", 52, 2, 1, "418.707.4225 x30501", new DateTime(2022, 12, 6, 6, 13, 26, 826, DateTimeKind.Utc).AddTicks(7580), "nellie.reichert" },
                    { 53, 53, new DateTime(2022, 8, 28, 6, 13, 26, 826, DateTimeKind.Utc).AddTicks(9100), new DateTime(2022, 12, 6, 6, 13, 26, 826, DateTimeKind.Utc).AddTicks(9360), "madisyn_ryan@mraz.us", "278.464.1051 x05951", new DateTime(2022, 11, 26, 6, 13, 26, 826, DateTimeKind.Utc).AddTicks(9360), "Madisyn Ryan", "pendiente encriptar", 53, 2, 2, "862-332-4901 x216", new DateTime(2022, 12, 6, 6, 13, 26, 826, DateTimeKind.Utc).AddTicks(9360), "madisyn.ryan" },
                    { 54, 54, new DateTime(2022, 8, 28, 6, 13, 26, 827, DateTimeKind.Utc).AddTicks(750), new DateTime(2022, 12, 6, 6, 13, 26, 827, DateTimeKind.Utc).AddTicks(1120), "grayce.mclaughlin@gloverlangosh.us", "113.649.1823 x912", new DateTime(2022, 11, 26, 6, 13, 26, 827, DateTimeKind.Utc).AddTicks(1120), "Grayce McLaughlin", "pendiente encriptar", 54, 1, 1, "(764)237-6061 x93991", new DateTime(2022, 12, 6, 6, 13, 26, 827, DateTimeKind.Utc).AddTicks(1120), "grayce_mclaughlin" },
                    { 55, 55, new DateTime(2022, 8, 28, 6, 13, 26, 827, DateTimeKind.Utc).AddTicks(2550), new DateTime(2022, 12, 6, 6, 13, 26, 827, DateTimeKind.Utc).AddTicks(3030), "theron_collier@koepp.info", "(669)140-1842 x173", new DateTime(2022, 11, 26, 6, 13, 26, 827, DateTimeKind.Utc).AddTicks(3030), "Theron Collier", "pendiente encriptar", 55, 2, 2, "1-285-430-7252 x537", new DateTime(2022, 12, 6, 6, 13, 26, 827, DateTimeKind.Utc).AddTicks(3030), "theron_collier" },
                    { 56, 56, new DateTime(2022, 8, 28, 6, 13, 26, 827, DateTimeKind.Utc).AddTicks(4470), new DateTime(2022, 12, 6, 6, 13, 26, 827, DateTimeKind.Utc).AddTicks(4720), "aliza.nikolaus@kemmer.com", "(405)636-9213 x333", new DateTime(2022, 11, 26, 6, 13, 26, 827, DateTimeKind.Utc).AddTicks(4720), "Aliza Nikolaus", "pendiente encriptar", 56, 2, 1, "192.418.1646", new DateTime(2022, 12, 6, 6, 13, 26, 827, DateTimeKind.Utc).AddTicks(4720), "aliza_nikolaus" },
                    { 57, 57, new DateTime(2022, 8, 28, 6, 13, 26, 827, DateTimeKind.Utc).AddTicks(5910), new DateTime(2022, 12, 6, 6, 13, 26, 827, DateTimeKind.Utc).AddTicks(6170), "marie_mcdermott@rice.uk", "752.817.4983 x3154", new DateTime(2022, 11, 26, 6, 13, 26, 827, DateTimeKind.Utc).AddTicks(6170), "Marie McDermott", "pendiente encriptar", 57, 1, 2, "1-941-926-6663 x240", new DateTime(2022, 12, 6, 6, 13, 26, 827, DateTimeKind.Utc).AddTicks(6170), "marie_mcdermott" },
                    { 58, 58, new DateTime(2022, 8, 28, 6, 13, 26, 827, DateTimeKind.Utc).AddTicks(7500), new DateTime(2022, 12, 6, 6, 13, 26, 827, DateTimeKind.Utc).AddTicks(8020), "stacey_friesen@hoeger.name", "769.974.7112", new DateTime(2022, 11, 26, 6, 13, 26, 827, DateTimeKind.Utc).AddTicks(8020), "Stacey Friesen", "pendiente encriptar", 58, 2, 2, "701.534.8509 x0464", new DateTime(2022, 12, 6, 6, 13, 26, 827, DateTimeKind.Utc).AddTicks(8020), "stacey_friesen" },
                    { 59, 59, new DateTime(2022, 8, 28, 6, 13, 26, 827, DateTimeKind.Utc).AddTicks(9210), new DateTime(2022, 12, 6, 6, 13, 26, 827, DateTimeKind.Utc).AddTicks(9490), "eveline_schiller@champlin.ca", "410.259.5837 x49986", new DateTime(2022, 11, 26, 6, 13, 26, 827, DateTimeKind.Utc).AddTicks(9490), "Eveline Schiller", "pendiente encriptar", 59, 2, 1, "120.918.2649 x99959", new DateTime(2022, 12, 6, 6, 13, 26, 827, DateTimeKind.Utc).AddTicks(9490), "eveline.schiller" },
                    { 60, 60, new DateTime(2022, 8, 28, 6, 13, 26, 828, DateTimeKind.Utc).AddTicks(780), new DateTime(2022, 12, 6, 6, 13, 26, 828, DateTimeKind.Utc).AddTicks(1280), "else.heller@bernhard.us", "338.097.3304 x9045", new DateTime(2022, 11, 26, 6, 13, 26, 828, DateTimeKind.Utc).AddTicks(1270), "Else Heller", "pendiente encriptar", 60, 1, 2, "1-724-760-6172 x47083", new DateTime(2022, 12, 6, 6, 13, 26, 828, DateTimeKind.Utc).AddTicks(1280), "else_heller" },
                    { 61, 61, new DateTime(2022, 8, 28, 6, 13, 26, 828, DateTimeKind.Utc).AddTicks(2590), new DateTime(2022, 12, 6, 6, 13, 26, 828, DateTimeKind.Utc).AddTicks(2950), "agnes_turner@cruickshankturner.ca", "(135)178-9577 x5872", new DateTime(2022, 11, 26, 6, 13, 26, 828, DateTimeKind.Utc).AddTicks(2950), "Agnes Turner", "pendiente encriptar", 61, 1, 2, "870.530.3721", new DateTime(2022, 12, 6, 6, 13, 26, 828, DateTimeKind.Utc).AddTicks(2950), "agnes_turner" },
                    { 62, 62, new DateTime(2022, 8, 28, 6, 13, 26, 828, DateTimeKind.Utc).AddTicks(4030), new DateTime(2022, 12, 6, 6, 13, 26, 828, DateTimeKind.Utc).AddTicks(4520), "ryleigh.von@medhurst.ca", "494.289.0051", new DateTime(2022, 11, 26, 6, 13, 26, 828, DateTimeKind.Utc).AddTicks(4520), "Ryleigh Von", "pendiente encriptar", 62, 2, 1, "(700)179-6373 x70888", new DateTime(2022, 12, 6, 6, 13, 26, 828, DateTimeKind.Utc).AddTicks(4520), "ryleigh_von" },
                    { 63, 63, new DateTime(2022, 8, 28, 6, 13, 26, 828, DateTimeKind.Utc).AddTicks(5810), new DateTime(2022, 12, 6, 6, 13, 26, 828, DateTimeKind.Utc).AddTicks(6300), "raymundo_greenholt@strosin.us", "750.102.4666 x120", new DateTime(2022, 11, 26, 6, 13, 26, 828, DateTimeKind.Utc).AddTicks(6300), "Raymundo Greenholt", "pendiente encriptar", 63, 2, 1, "1-017-670-5333 x8908", new DateTime(2022, 12, 6, 6, 13, 26, 828, DateTimeKind.Utc).AddTicks(6300), "raymundo_greenholt" },
                    { 64, 64, new DateTime(2022, 8, 28, 6, 13, 26, 828, DateTimeKind.Utc).AddTicks(7610), new DateTime(2022, 12, 6, 6, 13, 26, 828, DateTimeKind.Utc).AddTicks(8070), "lindsay_torphy@goyette.info", "1-121-485-1568", new DateTime(2022, 11, 26, 6, 13, 26, 828, DateTimeKind.Utc).AddTicks(8070), "Lindsay Torphy", "pendiente encriptar", 64, 1, 1, "943.604.9462", new DateTime(2022, 12, 6, 6, 13, 26, 828, DateTimeKind.Utc).AddTicks(8070), "lindsay_torphy" },
                    { 65, 65, new DateTime(2022, 8, 28, 6, 13, 26, 828, DateTimeKind.Utc).AddTicks(9390), new DateTime(2022, 12, 6, 6, 13, 26, 828, DateTimeKind.Utc).AddTicks(9870), "cathrine.heaney@daniel.com", "151-254-1433", new DateTime(2022, 11, 26, 6, 13, 26, 828, DateTimeKind.Utc).AddTicks(9870), "Cathrine Heaney", "pendiente encriptar", 65, 2, 1, "204-941-9704 x359", new DateTime(2022, 12, 6, 6, 13, 26, 828, DateTimeKind.Utc).AddTicks(9870), "cathrine_heaney" },
                    { 66, 66, new DateTime(2022, 8, 28, 6, 13, 26, 829, DateTimeKind.Utc).AddTicks(1180), new DateTime(2022, 12, 6, 6, 13, 26, 829, DateTimeKind.Utc).AddTicks(1450), "craig.dibbert@russel.uk", "226-925-0660 x2695", new DateTime(2022, 11, 26, 6, 13, 26, 829, DateTimeKind.Utc).AddTicks(1450), "Craig Dibbert", "pendiente encriptar", 66, 1, 2, "188.370.6317 x73441", new DateTime(2022, 12, 6, 6, 13, 26, 829, DateTimeKind.Utc).AddTicks(1450), "craig.dibbert" },
                    { 67, 67, new DateTime(2022, 8, 28, 6, 13, 26, 829, DateTimeKind.Utc).AddTicks(2760), new DateTime(2022, 12, 6, 6, 13, 26, 829, DateTimeKind.Utc).AddTicks(3250), "grover_goyette@flatley.com", "457-932-2150 x867", new DateTime(2022, 11, 26, 6, 13, 26, 829, DateTimeKind.Utc).AddTicks(3250), "Grover Goyette", "pendiente encriptar", 67, 2, 2, "(749)653-9991 x8701", new DateTime(2022, 12, 6, 6, 13, 26, 829, DateTimeKind.Utc).AddTicks(3250), "grover.goyette" },
                    { 68, 68, new DateTime(2022, 8, 28, 6, 13, 26, 829, DateTimeKind.Utc).AddTicks(4560), new DateTime(2022, 12, 6, 6, 13, 26, 829, DateTimeKind.Utc).AddTicks(4940), "billy.franecki@ernserhills.com", "1-585-313-5008 x6928", new DateTime(2022, 11, 26, 6, 13, 26, 829, DateTimeKind.Utc).AddTicks(4940), "Billy Franecki", "pendiente encriptar", 68, 2, 2, "925-923-2758 x77738", new DateTime(2022, 12, 6, 6, 13, 26, 829, DateTimeKind.Utc).AddTicks(4940), "billy_franecki" },
                    { 69, 69, new DateTime(2022, 8, 28, 6, 13, 26, 829, DateTimeKind.Utc).AddTicks(6250), new DateTime(2022, 12, 6, 6, 13, 26, 829, DateTimeKind.Utc).AddTicks(6500), "maria_keebler@welch.biz", "(028)499-4476", new DateTime(2022, 11, 26, 6, 13, 26, 829, DateTimeKind.Utc).AddTicks(6500), "Maria Keebler", "pendiente encriptar", 69, 2, 1, "985.549.9202 x882", new DateTime(2022, 12, 6, 6, 13, 26, 829, DateTimeKind.Utc).AddTicks(6500), "maria_keebler" },
                    { 70, 70, new DateTime(2022, 8, 28, 6, 13, 26, 829, DateTimeKind.Utc).AddTicks(7810), new DateTime(2022, 12, 6, 6, 13, 26, 829, DateTimeKind.Utc).AddTicks(8050), "alisha_douglas@crona.com", "258-815-6120", new DateTime(2022, 11, 26, 6, 13, 26, 829, DateTimeKind.Utc).AddTicks(8050), "Alisha Douglas", "pendiente encriptar", 70, 1, 2, "516.563.2222", new DateTime(2022, 12, 6, 6, 13, 26, 829, DateTimeKind.Utc).AddTicks(8050), "alisha_douglas" },
                    { 71, 71, new DateTime(2022, 8, 28, 6, 13, 26, 829, DateTimeKind.Utc).AddTicks(9370), new DateTime(2022, 12, 6, 6, 13, 26, 829, DateTimeKind.Utc).AddTicks(9740), "evert.rowe@rathryan.ca", "1-162-363-3982 x249", new DateTime(2022, 11, 26, 6, 13, 26, 829, DateTimeKind.Utc).AddTicks(9740), "Evert Rowe", "pendiente encriptar", 71, 1, 1, "433.549.4933 x611", new DateTime(2022, 12, 6, 6, 13, 26, 829, DateTimeKind.Utc).AddTicks(9740), "evert_rowe" },
                    { 72, 72, new DateTime(2022, 8, 28, 6, 13, 26, 830, DateTimeKind.Utc).AddTicks(810), new DateTime(2022, 12, 6, 6, 13, 26, 830, DateTimeKind.Utc).AddTicks(1280), "lula.hartmann@okeefe.name", "1-009-551-8886", new DateTime(2022, 11, 26, 6, 13, 26, 830, DateTimeKind.Utc).AddTicks(1280), "Lula Hartmann", "pendiente encriptar", 72, 2, 1, "495-441-2776", new DateTime(2022, 12, 6, 6, 13, 26, 830, DateTimeKind.Utc).AddTicks(1280), "lula.hartmann" },
                    { 73, 73, new DateTime(2022, 8, 28, 6, 13, 26, 830, DateTimeKind.Utc).AddTicks(2370), new DateTime(2022, 12, 6, 6, 13, 26, 830, DateTimeKind.Utc).AddTicks(2850), "myra.vonrueden@lueilwitz.us", "686.771.9025", new DateTime(2022, 11, 26, 6, 13, 26, 830, DateTimeKind.Utc).AddTicks(2850), "Myra VonRueden", "pendiente encriptar", 73, 1, 2, "(715)906-8556 x88252", new DateTime(2022, 12, 6, 6, 13, 26, 830, DateTimeKind.Utc).AddTicks(2850), "myra_vonrueden" },
                    { 74, 74, new DateTime(2022, 8, 28, 6, 13, 26, 830, DateTimeKind.Utc).AddTicks(4040), new DateTime(2022, 12, 6, 6, 13, 26, 830, DateTimeKind.Utc).AddTicks(4280), "kacie_spinka@hackett.uk", "364-282-2489", new DateTime(2022, 11, 26, 6, 13, 26, 830, DateTimeKind.Utc).AddTicks(4280), "Kacie Spinka", "pendiente encriptar", 74, 2, 1, "440.132.9448", new DateTime(2022, 12, 6, 6, 13, 26, 830, DateTimeKind.Utc).AddTicks(4280), "kacie.spinka" },
                    { 75, 75, new DateTime(2022, 8, 28, 6, 13, 26, 830, DateTimeKind.Utc).AddTicks(5570), new DateTime(2022, 12, 6, 6, 13, 26, 830, DateTimeKind.Utc).AddTicks(5940), "flavie_lakin@langworthcorwin.uk", "1-156-915-9704 x8739", new DateTime(2022, 11, 26, 6, 13, 26, 830, DateTimeKind.Utc).AddTicks(5940), "Flavie Lakin", "pendiente encriptar", 75, 1, 2, "(728)340-5293 x7394", new DateTime(2022, 12, 6, 6, 13, 26, 830, DateTimeKind.Utc).AddTicks(5940), "flavie.lakin" },
                    { 76, 76, new DateTime(2022, 8, 28, 6, 13, 26, 830, DateTimeKind.Utc).AddTicks(7480), new DateTime(2022, 12, 6, 6, 13, 26, 830, DateTimeKind.Utc).AddTicks(7740), "arvid_feest@howe.us", "563.418.5290 x52459", new DateTime(2022, 11, 26, 6, 13, 26, 830, DateTimeKind.Utc).AddTicks(7740), "Arvid Feest", "pendiente encriptar", 76, 2, 1, "(661)535-1171 x949", new DateTime(2022, 12, 6, 6, 13, 26, 830, DateTimeKind.Utc).AddTicks(7740), "arvid.feest" },
                    { 77, 77, new DateTime(2022, 8, 28, 6, 13, 26, 830, DateTimeKind.Utc).AddTicks(9160), new DateTime(2022, 12, 6, 6, 13, 26, 830, DateTimeKind.Utc).AddTicks(9400), "stuart.wunsch@auer.uk", "812.785.3076", new DateTime(2022, 11, 26, 6, 13, 26, 830, DateTimeKind.Utc).AddTicks(9400), "Stuart Wunsch", "pendiente encriptar", 77, 1, 2, "730-813-1640", new DateTime(2022, 12, 6, 6, 13, 26, 830, DateTimeKind.Utc).AddTicks(9400), "stuart_wunsch" },
                    { 78, 78, new DateTime(2022, 8, 28, 6, 13, 26, 831, DateTimeKind.Utc).AddTicks(730), new DateTime(2022, 12, 6, 6, 13, 26, 831, DateTimeKind.Utc).AddTicks(1210), "vergie.borer@langosh.name", "1-654-743-5676", new DateTime(2022, 11, 26, 6, 13, 26, 831, DateTimeKind.Utc).AddTicks(1210), "Vergie Borer", "pendiente encriptar", 78, 2, 2, "129-176-3756", new DateTime(2022, 12, 6, 6, 13, 26, 831, DateTimeKind.Utc).AddTicks(1210), "vergie_borer" },
                    { 79, 79, new DateTime(2022, 8, 28, 6, 13, 26, 831, DateTimeKind.Utc).AddTicks(2530), new DateTime(2022, 12, 6, 6, 13, 26, 831, DateTimeKind.Utc).AddTicks(3020), "gunnar_gleason@hahn.co.uk", "(254)610-8708 x351", new DateTime(2022, 11, 26, 6, 13, 26, 831, DateTimeKind.Utc).AddTicks(3020), "Gunnar Gleason", "pendiente encriptar", 79, 1, 2, "(610)995-8576 x7226", new DateTime(2022, 12, 6, 6, 13, 26, 831, DateTimeKind.Utc).AddTicks(3020), "gunnar.gleason" },
                    { 80, 80, new DateTime(2022, 8, 28, 6, 13, 26, 831, DateTimeKind.Utc).AddTicks(4240), new DateTime(2022, 12, 6, 6, 13, 26, 831, DateTimeKind.Utc).AddTicks(4610), "monserrate_marquardt@lubowitzosinski.name", "(875)390-4432", new DateTime(2022, 11, 26, 6, 13, 26, 831, DateTimeKind.Utc).AddTicks(4610), "Monserrate Marquardt", "pendiente encriptar", 80, 1, 2, "(851)039-2314 x14339", new DateTime(2022, 12, 6, 6, 13, 26, 831, DateTimeKind.Utc).AddTicks(4610), "monserrate.marquardt" },
                    { 81, 81, new DateTime(2022, 8, 28, 6, 13, 26, 831, DateTimeKind.Utc).AddTicks(6060), new DateTime(2022, 12, 6, 6, 13, 26, 831, DateTimeKind.Utc).AddTicks(6420), "aniyah_rolfson@hahnjewess.info", "024.308.3264 x391", new DateTime(2022, 11, 26, 6, 13, 26, 831, DateTimeKind.Utc).AddTicks(6420), "Aniyah Rolfson", "pendiente encriptar", 81, 1, 1, "514-933-0236 x9195", new DateTime(2022, 12, 6, 6, 13, 26, 831, DateTimeKind.Utc).AddTicks(6420), "aniyah_rolfson" },
                    { 82, 82, new DateTime(2022, 8, 28, 6, 13, 26, 831, DateTimeKind.Utc).AddTicks(7510), new DateTime(2022, 12, 6, 6, 13, 26, 831, DateTimeKind.Utc).AddTicks(7970), "janice_bayer@ernser.ca", "620-760-4051", new DateTime(2022, 11, 26, 6, 13, 26, 831, DateTimeKind.Utc).AddTicks(7970), "Janice Bayer", "pendiente encriptar", 82, 2, 2, "(111)847-3298", new DateTime(2022, 12, 6, 6, 13, 26, 831, DateTimeKind.Utc).AddTicks(7980), "janice_bayer" },
                    { 83, 83, new DateTime(2022, 8, 28, 6, 13, 26, 831, DateTimeKind.Utc).AddTicks(9170), new DateTime(2022, 12, 6, 6, 13, 26, 831, DateTimeKind.Utc).AddTicks(9440), "jaquan_durgan@wuckert.ca", "(774)659-4644 x438", new DateTime(2022, 11, 26, 6, 13, 26, 831, DateTimeKind.Utc).AddTicks(9440), "Jaquan Durgan", "pendiente encriptar", 83, 2, 2, "606-563-8748 x84135", new DateTime(2022, 12, 6, 6, 13, 26, 831, DateTimeKind.Utc).AddTicks(9440), "jaquan.durgan" },
                    { 84, 84, new DateTime(2022, 8, 28, 6, 13, 26, 832, DateTimeKind.Utc).AddTicks(550), new DateTime(2022, 12, 6, 6, 13, 26, 832, DateTimeKind.Utc).AddTicks(1030), "evert_kassulke@lehner.co.uk", "(989)091-2132 x18649", new DateTime(2022, 11, 26, 6, 13, 26, 832, DateTimeKind.Utc).AddTicks(1030), "Evert Kassulke", "pendiente encriptar", 84, 1, 2, "1-847-181-9482", new DateTime(2022, 12, 6, 6, 13, 26, 832, DateTimeKind.Utc).AddTicks(1030), "evert_kassulke" },
                    { 85, 85, new DateTime(2022, 8, 28, 6, 13, 26, 832, DateTimeKind.Utc).AddTicks(2480), new DateTime(2022, 12, 6, 6, 13, 26, 832, DateTimeKind.Utc).AddTicks(2720), "jeramy.padberg@shanahan.com", "295-340-6297", new DateTime(2022, 11, 26, 6, 13, 26, 832, DateTimeKind.Utc).AddTicks(2720), "Jeramy Padberg", "pendiente encriptar", 85, 2, 2, "(122)852-4724", new DateTime(2022, 12, 6, 6, 13, 26, 832, DateTimeKind.Utc).AddTicks(2720), "jeramy.padberg" },
                    { 86, 86, new DateTime(2022, 8, 28, 6, 13, 26, 832, DateTimeKind.Utc).AddTicks(3930), new DateTime(2022, 12, 6, 6, 13, 26, 832, DateTimeKind.Utc).AddTicks(4190), "virginia_eichmann@flatley.co.uk", "1-414-150-2374 x8823", new DateTime(2022, 11, 26, 6, 13, 26, 832, DateTimeKind.Utc).AddTicks(4190), "Virginia Eichmann", "pendiente encriptar", 86, 2, 1, "1-182-764-6272 x691", new DateTime(2022, 12, 6, 6, 13, 26, 832, DateTimeKind.Utc).AddTicks(4190), "virginia.eichmann" },
                    { 87, 87, new DateTime(2022, 8, 28, 6, 13, 26, 832, DateTimeKind.Utc).AddTicks(5620), new DateTime(2022, 12, 6, 6, 13, 26, 832, DateTimeKind.Utc).AddTicks(5980), "luciano.schumm@jerdewillms.biz", "634-340-2213", new DateTime(2022, 11, 26, 6, 13, 26, 832, DateTimeKind.Utc).AddTicks(5980), "Luciano Schumm", "pendiente encriptar", 87, 1, 1, "040-990-9428 x582", new DateTime(2022, 12, 6, 6, 13, 26, 832, DateTimeKind.Utc).AddTicks(5980), "luciano.schumm" },
                    { 88, 88, new DateTime(2022, 8, 28, 6, 13, 26, 832, DateTimeKind.Utc).AddTicks(7180), new DateTime(2022, 12, 6, 6, 13, 26, 832, DateTimeKind.Utc).AddTicks(7540), "manuela_feest@hayesswaniawski.uk", "(276)224-9371", new DateTime(2022, 11, 26, 6, 13, 26, 832, DateTimeKind.Utc).AddTicks(7540), "Manuela Feest", "pendiente encriptar", 88, 2, 1, "1-951-385-2243", new DateTime(2022, 12, 6, 6, 13, 26, 832, DateTimeKind.Utc).AddTicks(7540), "manuela.feest" },
                    { 89, 89, new DateTime(2022, 8, 28, 6, 13, 26, 832, DateTimeKind.Utc).AddTicks(8620), new DateTime(2022, 12, 6, 6, 13, 26, 832, DateTimeKind.Utc).AddTicks(9100), "ezequiel_nader@schmeler.us", "(965)386-3243 x6401", new DateTime(2022, 11, 26, 6, 13, 26, 832, DateTimeKind.Utc).AddTicks(9100), "Ezequiel Nader", "pendiente encriptar", 89, 2, 2, "600-756-5426", new DateTime(2022, 12, 6, 6, 13, 26, 832, DateTimeKind.Utc).AddTicks(9100), "ezequiel_nader" },
                    { 90, 90, new DateTime(2022, 8, 28, 6, 13, 26, 833, DateTimeKind.Utc).AddTicks(420), new DateTime(2022, 12, 6, 6, 13, 26, 833, DateTimeKind.Utc).AddTicks(830), "thalia_o.hara@christiansenreinger.us", "936.954.9607 x541", new DateTime(2022, 11, 26, 6, 13, 26, 833, DateTimeKind.Utc).AddTicks(830), "Thalia O'Hara", "pendiente encriptar", 90, 2, 1, "(004)314-2020", new DateTime(2022, 12, 6, 6, 13, 26, 833, DateTimeKind.Utc).AddTicks(830), "thalia_o_hara" },
                    { 91, 91, new DateTime(2022, 8, 28, 6, 13, 26, 833, DateTimeKind.Utc).AddTicks(2170), new DateTime(2022, 12, 6, 6, 13, 26, 833, DateTimeKind.Utc).AddTicks(2660), "icie.lueilwitz@morissette.biz", "520.407.7991 x3627", new DateTime(2022, 11, 26, 6, 13, 26, 833, DateTimeKind.Utc).AddTicks(2660), "Icie Lueilwitz", "pendiente encriptar", 91, 1, 1, "623.665.2098 x5017", new DateTime(2022, 12, 6, 6, 13, 26, 833, DateTimeKind.Utc).AddTicks(2660), "icie.lueilwitz" },
                    { 92, 92, new DateTime(2022, 8, 28, 6, 13, 26, 833, DateTimeKind.Utc).AddTicks(4060), new DateTime(2022, 12, 6, 6, 13, 26, 833, DateTimeKind.Utc).AddTicks(4560), "elian.herman@bogisich.com", "(615)388-1904 x20741", new DateTime(2022, 11, 26, 6, 13, 26, 833, DateTimeKind.Utc).AddTicks(4560), "Elian Herman", "pendiente encriptar", 92, 2, 1, "(406)995-3475 x919", new DateTime(2022, 12, 6, 6, 13, 26, 833, DateTimeKind.Utc).AddTicks(4560), "elian_herman" },
                    { 93, 93, new DateTime(2022, 8, 28, 6, 13, 26, 833, DateTimeKind.Utc).AddTicks(5650), new DateTime(2022, 12, 6, 6, 13, 26, 833, DateTimeKind.Utc).AddTicks(5900), "charley_tromp@murazik.ca", "650-249-4698 x1516", new DateTime(2022, 11, 26, 6, 13, 26, 833, DateTimeKind.Utc).AddTicks(5900), "Charley Tromp", "pendiente encriptar", 93, 1, 1, "543-351-7194", new DateTime(2022, 12, 6, 6, 13, 26, 833, DateTimeKind.Utc).AddTicks(5900), "charley.tromp" },
                    { 94, 94, new DateTime(2022, 8, 28, 6, 13, 26, 833, DateTimeKind.Utc).AddTicks(7230), new DateTime(2022, 12, 6, 6, 13, 26, 833, DateTimeKind.Utc).AddTicks(7620), "savannah_kirlin@kossmcclure.uk", "323-396-5197 x14595", new DateTime(2022, 11, 26, 6, 13, 26, 833, DateTimeKind.Utc).AddTicks(7620), "Savannah Kirlin", "pendiente encriptar", 94, 1, 2, "932-789-7302 x86852", new DateTime(2022, 12, 6, 6, 13, 26, 833, DateTimeKind.Utc).AddTicks(7620), "savannah.kirlin" },
                    { 95, 95, new DateTime(2022, 8, 28, 6, 13, 26, 833, DateTimeKind.Utc).AddTicks(8920), new DateTime(2022, 12, 6, 6, 13, 26, 833, DateTimeKind.Utc).AddTicks(9280), "sandrine.bernhard@ziemannauer.ca", "(211)983-5535", new DateTime(2022, 11, 26, 6, 13, 26, 833, DateTimeKind.Utc).AddTicks(9280), "Sandrine Bernhard", "pendiente encriptar", 95, 1, 2, "312.805.4764 x23548", new DateTime(2022, 12, 6, 6, 13, 26, 833, DateTimeKind.Utc).AddTicks(9280), "sandrine.bernhard" },
                    { 96, 96, new DateTime(2022, 8, 28, 6, 13, 26, 834, DateTimeKind.Utc).AddTicks(820), new DateTime(2022, 12, 6, 6, 13, 26, 834, DateTimeKind.Utc).AddTicks(1080), "jessica_kohler@mann.info", "(593)988-8141 x284", new DateTime(2022, 11, 26, 6, 13, 26, 834, DateTimeKind.Utc).AddTicks(1080), "Jessica Kohler", "pendiente encriptar", 96, 1, 1, "312.130.2677 x90522", new DateTime(2022, 12, 6, 6, 13, 26, 834, DateTimeKind.Utc).AddTicks(1090), "jessica.kohler" },
                    { 97, 97, new DateTime(2022, 8, 28, 6, 13, 26, 834, DateTimeKind.Utc).AddTicks(2630), new DateTime(2022, 12, 6, 6, 13, 26, 834, DateTimeKind.Utc).AddTicks(3010), "laney_swaniawski@millerswaniawski.name", "(305)924-5072 x12616", new DateTime(2022, 11, 26, 6, 13, 26, 834, DateTimeKind.Utc).AddTicks(3010), "Laney Swaniawski", "pendiente encriptar", 97, 1, 2, "(440)311-7374 x839", new DateTime(2022, 12, 6, 6, 13, 26, 834, DateTimeKind.Utc).AddTicks(3010), "laney_swaniawski" },
                    { 98, 98, new DateTime(2022, 8, 28, 6, 13, 26, 834, DateTimeKind.Utc).AddTicks(4330), new DateTime(2022, 12, 6, 6, 13, 26, 834, DateTimeKind.Utc).AddTicks(4700), "kara.steuber@haneconroy.info", "238-657-3374 x75915", new DateTime(2022, 11, 26, 6, 13, 26, 834, DateTimeKind.Utc).AddTicks(4700), "Kara Steuber", "pendiente encriptar", 98, 2, 2, "1-308-710-6447 x0580", new DateTime(2022, 12, 6, 6, 13, 26, 834, DateTimeKind.Utc).AddTicks(4700), "kara.steuber" },
                    { 99, 99, new DateTime(2022, 8, 28, 6, 13, 26, 834, DateTimeKind.Utc).AddTicks(6250), new DateTime(2022, 12, 6, 6, 13, 26, 834, DateTimeKind.Utc).AddTicks(6510), "barry.lakin@king.ca", "(997)136-8749 x55220", new DateTime(2022, 11, 26, 6, 13, 26, 834, DateTimeKind.Utc).AddTicks(6510), "Barry Lakin", "pendiente encriptar", 99, 1, 2, "588.475.6786", new DateTime(2022, 12, 6, 6, 13, 26, 834, DateTimeKind.Utc).AddTicks(6510), "barry_lakin" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_CompanyId",
                table: "User",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_User_PortalaId",
                table: "User",
                column: "PortalaId");

            migrationBuilder.CreateIndex(
                name: "IX_User_RoleId",
                table: "User",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_User_StatusId",
                table: "User",
                column: "StatusId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Portal");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Status");
        }
    }
}
