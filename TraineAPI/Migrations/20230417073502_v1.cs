using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TraineAPI.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "admins",
                columns: table => new
                {
                    AdminId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdminDegree = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admins", x => x.AdminId);
                });

            migrationBuilder.CreateTable(
                name: "trains",
                columns: table => new
                {
                    TrainId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Degree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrainNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumOfSeat = table.Column<int>(type: "int", nullable: false),
                    NumOfTrainCars = table.Column<int>(type: "int", nullable: false),
                    Conductor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Driver = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentLocation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trains", x => x.TrainId);
                });

            migrationBuilder.CreateTable(
                name: "news",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ContentOfPost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdminId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_news", x => x.Id);
                    table.ForeignKey(
                        name: "FK_news_admins_AdminId",
                        column: x => x.AdminId,
                        principalTable: "admins",
                        principalColumn: "AdminId");
                });

            migrationBuilder.CreateTable(
                name: "stations",
                columns: table => new
                {
                    StationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NextStation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    TrainId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stations", x => x.StationId);
                    table.ForeignKey(
                        name: "FK_stations_trains_TrainId",
                        column: x => x.TrainId,
                        principalTable: "trains",
                        principalColumn: "TrainId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Jop = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrainId = table.Column<int>(type: "int", nullable: true),
                    StationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_users_stations_StationId",
                        column: x => x.StationId,
                        principalTable: "stations",
                        principalColumn: "StationId");
                    table.ForeignKey(
                        name: "FK_users_trains_TrainId",
                        column: x => x.TrainId,
                        principalTable: "trains",
                        principalColumn: "TrainId");
                });

            migrationBuilder.CreateTable(
                name: "liveLocations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    DateOfShareLoaction = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrainId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_liveLocations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_liveLocations_trains_TrainId",
                        column: x => x.TrainId,
                        principalTable: "trains",
                        principalColumn: "TrainId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_liveLocations_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "payments",
                columns: table => new
                {
                    PaymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardNumber = table.Column<int>(type: "int", nullable: false),
                    Cost = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payments", x => x.PaymentId);
                    table.ForeignKey(
                        name: "FK_payments_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "posts",
                columns: table => new
                {
                    PostId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrainNumber = table.Column<int>(type: "int", nullable: false),
                    Critical = table.Column<bool>(type: "bit", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdminId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_posts", x => x.PostId);
                    table.ForeignKey(
                        name: "FK_posts_admins_AdminId",
                        column: x => x.AdminId,
                        principalTable: "admins",
                        principalColumn: "AdminId");
                    table.ForeignKey(
                        name: "FK_posts_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumOfSeat = table.Column<int>(type: "int", nullable: false),
                    TakeOffDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TakeOffStation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArrivalStation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ScanedOrNot = table.Column<bool>(type: "bit", nullable: false),
                    TrainDegree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    PaymentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tickets_payments_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "payments",
                        principalColumn: "PaymentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tickets_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "comments",
                columns: table => new
                {
                    CommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    AdminId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_comments_admins_AdminId",
                        column: x => x.AdminId,
                        principalTable: "admins",
                        principalColumn: "AdminId");
                    table.ForeignKey(
                        name: "FK_comments_posts_PostId",
                        column: x => x.PostId,
                        principalTable: "posts",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_comments_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "reports",
                columns: table => new
                {
                    ReportId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descreption = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    PostId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reports", x => x.ReportId);
                    table.ForeignKey(
                        name: "FK_reports_posts_PostId",
                        column: x => x.PostId,
                        principalTable: "posts",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reports_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.NoAction);
                });

            
            migrationBuilder.InsertData(
                table: "trains",
                columns: new[] { "TrainId", "Conductor", "CurrentLocation", "Degree", "Driver", "NumOfSeat", "NumOfTrainCars", "TrainNumber" },
                values: new object[,]
                {
                    { 18, "", "", "3rd Air Conditioned", "", 880, 11, "18" },
                    { 24, "", "", "Russian", "", 880, 10, "24" },
                    { 164, "", "", "3rd Air Conditioned", "", 880, 11, "164" },
                    { 914, "", "", "1st & 2nd Air Conditioned", "", 572, 10, "914" },
                    { 916, "", "", "VIP", "", 10, 572, "916" }
                });

            migrationBuilder.InsertData(
                table: "stations",
                columns: new[] { "StationId", "Description", "Latitude", "Longitude", "Name", "NextStation", "TrainId" },
                values: new object[,]
                {
                    { 21200, "Qaha Preserved Food Company is an Egyptian government joint stock company, owned by the Holding Company for Food Industries, one of the companies of the Ministry of Supply and Internal Trade, working in the field of food industries.", 30.285198657390623, 31.208928538794947, "Qaha", "Qelyoub", 24 },
                    { 212022, "Among the Islamic monuments is Al-Zahir Baybars Mosque, which was built in the year 670-672 AH in the village of Qalyub.", 30.187796088125985, 31.22807432746081, "Qelyoub", "Shubra El Kheima", 24 },
                    { 1145100, "The College of the Holy Qur’an (Tanta) is the first of its kind at Al-Azhar University, and it has no equal in terms of its specialization in the Holy Qur’an except for the College of the Holy Qur’an in Medina. The origin of the reciter, Sheikh Mahmoud Khalil Al-Husri.", 30.781941029218899, 30.995483984834241, "Tanta", "Birket el Sab", 164 },
                    { 1331520, "Alexandria is the second capital of Egypt and was its capital in the past. It is the capital of Alexandria Governorate and its largest city, located on the Mediterranean coast.", 31.193105781485116, 29.905233139369273, "Alexandria", "Sidi Gaber", 18 },
                    { 1821021, "The College of the Holy Qur’an (Tanta) is the first of its kind at Al-Azhar University, and it has no equal in terms of its specialization in the Holy Qur’an except for the College of the Holy Qur’an in Medina. The origin of the reciter, Sheikh Mahmoud Khalil Al-Husri.", 30.781941029218899, 30.995483984834241, "Tanta", "Birket el Sab", 18 },
                    { 2018020, "Shubra El Kheima, a suburb of Cairo. Originally, I was known by the names of Shubra al-Shaheed and Shubra al-Balad, and I was also known as Shubra Damanhour, after the city next to it called Damanhour.", 30.122241959951801, 31.244513237455582, "Shubra El Kheima", "nextStation", 24 },
                    { 2102120, "The center and city of Toukh, in the center of Qalyubia Governorate. It is one of the ancient villages.", 30.351615440389189, 31.198362936947632, "Toukh", "Qaha", 18 },
                    { 3302120, "Sidi Gaber district; It is one of the high-end neighborhoods and areas in Alexandria, Egypt.", 31.218776152059611, 29.942300551565349, "Sidi Gaber", "Ramsis(Cairo)", 916 },
                    { 10100120, "The Al-Tawbah Mosque is located in it, and it is the second mosque in Africa that was built by Amr bin Al-Aas in the year 21 AH.", 31.034533770853649, 30.468689104431753, "Damanhour", "Tanta", 164 },
                    { 10405120, "The opening of the Welcome Ramadan exhibition in Kafr El-Zayyat to provide food commodities to citizens 2023.", 30.81945162969096, 30.814538865795129, "Kafr El-Zayat", "Tanta", 914 },
                    { 11145600, "Alexandria is the second capital of Egypt and was its capital in the past. It is the capital of Alexandria Governorate and its largest city, located on the Mediterranean coast.", 31.193105781485116, 29.905233139369273, "Alexandria", "Sidi Gaber", 164 },
                    { 11225600, "Sidi Gaber district; It is one of the high-end neighborhoods and areas in Alexandria, Egypt.", 31.218776152059611, 29.942300551565349, "Sidi Gaber", "Damanhour", 164 },
                    { 11723120, "One of the facilities of the General Authority for Culture Palaces is the House of Culture in Birket El Sab.", 30.637454507182532, 31.079936683751335, "Birket El Sab", "Qewaisna", 18 },
                    { 14510534, "Sidi Gaber district; It is one of the high-end neighborhoods and areas in Alexandria, Egypt.", 31.218776152059611, 29.942300551565349, "Sidi Gaber", "Damanhour", 914 },
                    { 14512002, "There is a war road in Quesna, and this road was used during the war to transport equipment and ammunition. The Delta University of Technology was established in 2019 in Quesna and includes four majors in the field of technology.", 30.547991778887262, 31.139919904419259, "Qewaisna", "Banha", 164 },
                    { 14512345, "It is called Banha Al - Assal as it produces the finest types of bee honey.", 30.455953488998389, 31.181093848594685, "Banha", "Ramsis(Cairo)", 164 },
                    { 14512400, "Cairo is ranked 35th as the longest metro line among 114 cities in the world.", 30.063231628191652, 31.246724130095895, "Ramsis(Cairo)", "nextStation", 164 },
                    { 14514520, "One of the facilities of the General Authority for Culture Palaces is the House of Culture in Birket El Sab.", 30.637454507182532, 31.079936683751335, "Birket El Sab", "Qewaisna", 164 },
                    { 15132120, "The origin of Sheikh Muhammad Al-Ghazali.", 30.887954013325928, 30.67008637907707, "Itay El Barud", "Tawfiqia", 18 },
                    { 18821230, "Al Tawfiqia Hospital is located on the agricultural road and serves all road accidents from Tanta to Kafr El Dawwar.", 30.816339320978063, 30.748217873741716, "Tawfiqia", "Kafr El-Zayat", 18 },
                    { 18872121, "The opening of the Welcome Ramadan exhibition in Kafr El-Zayyat to provide food commodities to citizens 2023.", 30.81945162969096, 30.814538865795129, "Kafr El-Zayat", "Tanta", 18 },
                    { 24052120, "Shubra El Kheima, a suburb of Cairo. Originally, I was known by the names of Shubra al-Shaheed and Shubra al-Balad, and I was also known as Shubra Damanhour, after the city next to it called Damanhour.", 30.122241959951801, 31.244513237455582, "Shubra El Kheima", "nextStation", 18 },
                    { 33021020, "Alexandria is the second capital of Egypt and was its capital in the past. It is the capital of Alexandria Governorate and its largest city, located on the Mediterranean coast.", 31.193105781485116, 29.905233139369273, "Alexandria", "Sidi Gaber", 916 },
                    { 33021101, "Cairo is ranked 35th as the longest metro line among 114 cities in the world.", 30.063231628191652, 31.246724130095895, "Ramsis(Cairo)", "nextStation", 916 },
                    { 45002129, "The College of the Holy Qur’an (Tanta) is the first of its kind at Al-Azhar University, and it has no equal in terms of its specialization in the Holy Qur’an except for the College of the Holy Qur’an in Medina. The origin of the reciter, Sheikh Mahmoud Khalil Al-Husri.", 30.781941029218899, 30.995483984834241, "Tanta", "Birket el Sab", 24 },
                    { 45002450, "It is called Banha Al - Assal as it produces the finest types of bee honey.", 30.455953488998389, 31.181093848594685, "Banha", "Toukh", 24 },
                    { 45021020, "The origin of Sheikh Muhammad Al-Ghazali.", 30.887954013325928, 30.67008637907707, "Itay El Barud", "Tawfiqia", 24 },
                    { 90902120, "There is a war road in Quesna, and this road was used during the war to transport equipment and ammunition. The Delta University of Technology was established in 2019 in Quesna and includes four majors in the field of technology.", 30.547991778887262, 31.139919904419259, "Qewaisna", "Banha", 24 },
                    { 99021020, "One of the facilities of the General Authority for Culture Palaces is the House of Culture in Birket El Sab.", 30.637454507182532, 31.079936683751335, "Birket El Sab", "Qewaisna", 24 },
                    { 105433120, "Misr Spinning and Weaving Company in Kafr El-Dawar is the largest company in the city, and it comes in second place in Egypt after Misr Spinning and Weaving Company in El-Mahalla El-Kubra.", 31.132741286101705, 30.130901427172223, " Kafr El Dawwar", "Abu Humus", 18 },
                    { 125021020, "Al Tawfiqia Hospital is located on the agricultural road and serves all road accidents from Tanta to Kafr El Dawwar.", 30.816339320978063, 30.748217873741716, "Tawfiqia", "Kafr El-Zayat", 24 },
                    { 130313120, "Sidi Gaber district; It is one of the high-end neighborhoods and areas in Alexandria, Egypt.", 31.218776152059611, 29.942300551565349, "Sidi Gaber", "Kafr El Dawwar", 18 },
                    { 145114580, "The College of the Holy Qur’an (Tanta) is the first of its kind at Al-Azhar University, and it has no equal in terms of its specialization in the Holy Qur’an except for the College of the Holy Qur’an in Medina. The origin of the reciter, Sheikh Mahmoud Khalil Al-Husri.", 30.781941029218899, 30.995483984834241, "Tanta", "Birket el Sab", 914 },
                    { 145123487, "The Al-Tawbah Mosque is located in it, and it is the second mosque in Africa that was built by Amr bin Al-Aas in the year 21 AH.", 31.034533770853649, 30.468689104431753, "Damanhour", "Itay El Barud", 914 },
                    { 145124505, "Alexandria is the second capital of Egypt and was its capital in the past. It is the capital of Alexandria Governorate and its largest city, located on the Mediterranean coast.", 31.193105781485116, 29.905233139369273, "Alexandria", "Sidi Gaber", 914 },
                    { 145127400, "One of the facilities of the General Authority for Culture Palaces is the House of Culture in Birket El Sab.", 30.637454507182532, 31.079936683751335, "Birket El Sab", "Qewaisna", 914 },
                    { 145127445, "There is a war road in Quesna, and this road was used during the war to transport equipment and ammunition. The Delta University of Technology was established in 2019 in Quesna and includes four majors in the field of technology.", 30.547991778887262, 31.139919904419259, "Qewaisna", "Banha", 914 },
                    { 182154220, "There is a war road in Quesna, and this road was used during the war to transport equipment and ammunition. The Delta University of Technology was established in 2019 in Quesna and includes four majors in the field of technology.", 30.547991778887262, 31.139919904419259, "Qewaisna", "Banha", 18 },
                    { 201021020, "Qaha Preserved Food Company is an Egyptian government joint stock company, owned by the Holding Company for Food Industries, one of the companies of the Ministry of Supply and Internal Trade, working in the field of food industries.", 30.285198657390623, 31.208928538794947, "Qaha", "Shubra El Kheima", 18 },
                    { 210212210, "It is called Banha Al - Assal as it produces the finest types of bee honey.", 30.455953488998389, 31.181093848594685, "Banha", "Toukh", 18 },
                    { 302002120, "Misr Spinning and Weaving Company in Kafr El-Dawar is the largest company in the city, and it comes in second place in Egypt after Misr Spinning and Weaving Company in El-Mahalla El-Kubra.", 31.132741286101705, 30.130901427172223, " Kafr El Dawwar", "Abu Humus", 24 },
                    { 303021200, "Sidi Gaber district; It is one of the high-end neighborhoods and areas in Alexandria, Egypt.", 31.218776152059611, 29.942300551565349, "Sidi Gaber", "Kafr El Dawwar", 24 },
                    { 330211203, "Alexandria is the second capital of Egypt and was its capital in the past. It is the capital of Alexandria Governorate and its largest city, located on the Mediterranean coast.", 31.193105781485116, 29.905233139369273, "Alexandria", "Sidi Gaber", 24 },
                    { 330302120, "Among the archaeological monuments in the Abu Hummus center is Tel Koum Archaeological Center, which is an area where there are likely to be antiquities, and it is located south of Ezbet El Sawy.", 31.085098233708155, 30.310392025322059, "Abu Humus", "Damanhour", 24 },
                    { 404002120, "The Al-Tawbah Mosque is located in it, and it is the second mosque in Africa that was built by Amr bin Al-Aas in the year 21 AH.", 31.034533770853649, 30.468689104431753, "Damanhour", "Itay El Barud", 24 },
                    { 413020120, "The center and city of Toukh, in the center of Qalyubia Governorate. It is one of the ancient villages.", 30.351615440389189, 31.198362936947632, "Toukh", "Qaha", 24 },
                    { 451021020, "The opening of the Welcome Ramadan exhibition in Kafr El-Zayyat to provide food commodities to citizens 2023.", 30.81945162969096, 30.814538865795129, "Kafr El-Zayat", "Tanta", 24 },
                    { 1004875120, "Cairo is ranked 35th as the longest metro line among 114 cities in the world.", 30.063231628191652, 31.246724130095895, "Ramsis(Cairo)", "nextStation", 914 },
                    { 1045452120, "The origin of Sheikh Muhammad Al-Ghazali.", 30.887954013325928, 30.67008637907707, "Itay El Barud", "Kafr El-Zayat", 914 },
                    { 1303202120, "The Al-Tawbah Mosque is located in it, and it is the second mosque in Africa that was built by Amr bin Al-Aas in the year 21 AH.", 31.034533770853649, 30.468689104431753, "Damanhour", "Itay El Barud", 18 },
                    { 1331201210, "Among the archaeological monuments in the Abu Hummus center is Tel Koum Archaeological Center, which is an area where there are likely to be antiquities, and it is located south of Ezbet El Sawy.", 31.085098233708155, 30.310392025322059, "Abu Humus", "Damanhour", 18 },
                    { 1478913620, "It is called Banha Al - Assal as it produces the finest types of bee honey.", 30.455953488998389, 31.181093848594685, "Banha", "Ramsis(Cairo)", 914 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_comments_AdminId",
                table: "comments",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_comments_PostId",
                table: "comments",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_comments_UserId",
                table: "comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_liveLocations_TrainId",
                table: "liveLocations",
                column: "TrainId");

            migrationBuilder.CreateIndex(
                name: "IX_liveLocations_UserId",
                table: "liveLocations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_news_AdminId",
                table: "news",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_payments_UserId",
                table: "payments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_posts_AdminId",
                table: "posts",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_posts_UserId",
                table: "posts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_reports_PostId",
                table: "reports",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_reports_UserId",
                table: "reports",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_stations_TrainId",
                table: "stations",
                column: "TrainId");

            migrationBuilder.CreateIndex(
                name: "IX_tickets_PaymentId",
                table: "tickets",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_tickets_UserId",
                table: "tickets",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_users_StationId",
                table: "users",
                column: "StationId");

            migrationBuilder.CreateIndex(
                name: "IX_users_TrainId",
                table: "users",
                column: "TrainId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "comments");

            migrationBuilder.DropTable(
                name: "liveLocations");

            migrationBuilder.DropTable(
                name: "news");

            migrationBuilder.DropTable(
                name: "reports");

            migrationBuilder.DropTable(
                name: "tickets");

            migrationBuilder.DropTable(
                name: "posts");

            migrationBuilder.DropTable(
                name: "payments");

            migrationBuilder.DropTable(
                name: "admins");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "stations");

            migrationBuilder.DropTable(
                name: "trains");
        }
    }
}
