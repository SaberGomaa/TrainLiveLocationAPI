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
            migrationBuilder.DropForeignKey(
                name: "FK_stations_trains_TrainId",
                table: "stations");

            migrationBuilder.DropIndex(
                name: "IX_stations_TrainId",
                table: "stations");

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 21200);

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 188120);

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 212022);

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 1145100);

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 1331520);

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 1821021);

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 2018020);

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 2102120);

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 3302120);

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 10100120);

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 10405120);

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 11145600);

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 11225600);

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 11723120);

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 14510534);

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 14512002);

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 14512345);

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 14512400);

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 14514520);

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 15132120);

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 18821230);

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 18872121);

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 24052120);

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 33021020);

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 33021101);

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 45002129);

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 45002450);

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 45021020);

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 90902120);

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 99021020);

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 105433120);

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 125021020);

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 130313120);

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 145114580);

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 145123487);

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 145124505);

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 145127400);

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 145127445);

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 182154220);

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 201021020);

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 210212210);

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 302002120);

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 303021200);

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 330211203);

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 330302120);

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 404002120);

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 413020120);

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 451021020);

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 1004875120);

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 1045452120);

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 1303202120);

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 1331201210);

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 1478913620);

            migrationBuilder.DeleteData(
                table: "trains",
                keyColumn: "TrainId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "trains",
                keyColumn: "TrainId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "trains",
                keyColumn: "TrainId",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "trains",
                keyColumn: "TrainId",
                keyValue: 914);

            migrationBuilder.DeleteData(
                table: "trains",
                keyColumn: "TrainId",
                keyValue: 916);

            migrationBuilder.DropColumn(
                name: "TrainId",
                table: "stations");

            migrationBuilder.AddColumn<string>(
                name: "image",
                table: "admins",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "image",
                table: "admins");

            migrationBuilder.AddColumn<int>(
                name: "TrainId",
                table: "stations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "stations",
                columns: new[] { "StationId", "Description", "Latitude", "Longitude", "Name", "NextStation", "Position", "TrainId" },
                values: new object[] { 188120, "description", 0.0, 0.0, "name", "nextStation", 0, 0 });

            migrationBuilder.InsertData(
                table: "trains",
                columns: new[] { "TrainId", "Conductor", "CurrentLocation", "Degree", "Driver", "NumOfSeat", "NumOfTrainCars", "TrainNumber", "TrainTime" },
                values: new object[,]
                {
                    { 18, "", "", "3rd Air Conditioned", "", 880, 11, "18", 0.0 },
                    { 24, "", "", "Russian", "", 880, 10, "24", 0.0 },
                    { 164, "", "", "3rd Air Conditioned", "", 880, 11, "164", 0.0 },
                    { 914, "", "", "1st & 2nd Air Conditioned", "", 572, 10, "914", 0.0 },
                    { 916, "", "", "VIP", "", 10, 572, "916", 0.0 }
                });

            migrationBuilder.InsertData(
                table: "stations",
                columns: new[] { "StationId", "Description", "Latitude", "Longitude", "Name", "NextStation", "Position", "TrainId" },
                values: new object[,]
                {
                    { 21200, "Qaha Preserved Food Company is an Egyptian government joint stock company, owned by the Holding Company for Food Industries, one of the companies of the Ministry of Supply and Internal Trade, working in the field of food industries.", 30.285198657390623, 31.208928538794947, "Qaha", "Qelyoub", 0, 24 },
                    { 212022, "Among the Islamic monuments is Al-Zahir Baybars Mosque, which was built in the year 670-672 AH in the village of Qalyub.", 30.187796088125985, 31.22807432746081, "Qelyoub", "Shubra El Kheima", 0, 24 },
                    { 1145100, "The College of the Holy Qur’an (Tanta) is the first of its kind at Al-Azhar University, and it has no equal in terms of its specialization in the Holy Qur’an except for the College of the Holy Qur’an in Medina. The origin of the reciter, Sheikh Mahmoud Khalil Al-Husri.", 30.781941029218899, 30.995483984834241, "Tanta", "Birket el Sab", 0, 164 },
                    { 1331520, "Alexandria is the second capital of Egypt and was its capital in the past. It is the capital of Alexandria Governorate and its largest city, located on the Mediterranean coast.", 31.193105781485116, 29.905233139369273, "Alexandria", "Sidi Gaber", 0, 18 },
                    { 1821021, "The College of the Holy Qur’an (Tanta) is the first of its kind at Al-Azhar University, and it has no equal in terms of its specialization in the Holy Qur’an except for the College of the Holy Qur’an in Medina. The origin of the reciter, Sheikh Mahmoud Khalil Al-Husri.", 30.781941029218899, 30.995483984834241, "Tanta", "Birket el Sab", 0, 18 },
                    { 2018020, "Shubra El Kheima, a suburb of Cairo. Originally, I was known by the names of Shubra al-Shaheed and Shubra al-Balad, and I was also known as Shubra Damanhour, after the city next to it called Damanhour.", 30.122241959951801, 31.244513237455582, "Shubra El Kheima", "nextStation", 0, 24 },
                    { 2102120, "The center and city of Toukh, in the center of Qalyubia Governorate. It is one of the ancient villages.", 30.351615440389189, 31.198362936947632, "Toukh", "Qaha", 0, 18 },
                    { 3302120, "Sidi Gaber district; It is one of the high-end neighborhoods and areas in Alexandria, Egypt.", 31.218776152059611, 29.942300551565349, "Sidi Gaber", "Ramsis(Cairo)", 0, 916 },
                    { 10100120, "The Al-Tawbah Mosque is located in it, and it is the second mosque in Africa that was built by Amr bin Al-Aas in the year 21 AH.", 31.034533770853649, 30.468689104431753, "Damanhour", "Tanta", 0, 164 },
                    { 10405120, "The opening of the Welcome Ramadan exhibition in Kafr El-Zayyat to provide food commodities to citizens 2023.", 30.81945162969096, 30.814538865795129, "Kafr El-Zayat", "Tanta", 0, 914 },
                    { 11145600, "Alexandria is the second capital of Egypt and was its capital in the past. It is the capital of Alexandria Governorate and its largest city, located on the Mediterranean coast.", 31.193105781485116, 29.905233139369273, "Alexandria", "Sidi Gaber", 0, 164 },
                    { 11225600, "Sidi Gaber district; It is one of the high-end neighborhoods and areas in Alexandria, Egypt.", 31.218776152059611, 29.942300551565349, "Sidi Gaber", "Damanhour", 0, 164 },
                    { 11723120, "One of the facilities of the General Authority for Culture Palaces is the House of Culture in Birket El Sab.", 30.637454507182532, 31.079936683751335, "Birket El Sab", "Qewaisna", 0, 18 },
                    { 14510534, "Sidi Gaber district; It is one of the high-end neighborhoods and areas in Alexandria, Egypt.", 31.218776152059611, 29.942300551565349, "Sidi Gaber", "Damanhour", 0, 914 },
                    { 14512002, "There is a war road in Quesna, and this road was used during the war to transport equipment and ammunition. The Delta University of Technology was established in 2019 in Quesna and includes four majors in the field of technology.", 30.547991778887262, 31.139919904419259, "Qewaisna", "Banha", 0, 164 },
                    { 14512345, "It is called Banha Al - Assal as it produces the finest types of bee honey.", 30.455953488998389, 31.181093848594685, "Banha", "Ramsis(Cairo)", 0, 164 },
                    { 14512400, "Cairo is ranked 35th as the longest metro line among 114 cities in the world.", 30.063231628191652, 31.246724130095895, "Ramsis(Cairo)", "nextStation", 0, 164 },
                    { 14514520, "One of the facilities of the General Authority for Culture Palaces is the House of Culture in Birket El Sab.", 30.637454507182532, 31.079936683751335, "Birket El Sab", "Qewaisna", 0, 164 },
                    { 15132120, "The origin of Sheikh Muhammad Al-Ghazali.", 30.887954013325928, 30.67008637907707, "Itay El Barud", "Tawfiqia", 0, 18 },
                    { 18821230, "Al Tawfiqia Hospital is located on the agricultural road and serves all road accidents from Tanta to Kafr El Dawwar.", 30.816339320978063, 30.748217873741716, "Tawfiqia", "Kafr El-Zayat", 0, 18 },
                    { 18872121, "The opening of the Welcome Ramadan exhibition in Kafr El-Zayyat to provide food commodities to citizens 2023.", 30.81945162969096, 30.814538865795129, "Kafr El-Zayat", "Tanta", 0, 18 },
                    { 24052120, "Shubra El Kheima, a suburb of Cairo. Originally, I was known by the names of Shubra al-Shaheed and Shubra al-Balad, and I was also known as Shubra Damanhour, after the city next to it called Damanhour.", 30.122241959951801, 31.244513237455582, "Shubra El Kheima", "nextStation", 0, 18 },
                    { 33021020, "Alexandria is the second capital of Egypt and was its capital in the past. It is the capital of Alexandria Governorate and its largest city, located on the Mediterranean coast.", 31.193105781485116, 29.905233139369273, "Alexandria", "Sidi Gaber", 0, 916 },
                    { 33021101, "Cairo is ranked 35th as the longest metro line among 114 cities in the world.", 30.063231628191652, 31.246724130095895, "Ramsis(Cairo)", "nextStation", 0, 916 },
                    { 45002129, "The College of the Holy Qur’an (Tanta) is the first of its kind at Al-Azhar University, and it has no equal in terms of its specialization in the Holy Qur’an except for the College of the Holy Qur’an in Medina. The origin of the reciter, Sheikh Mahmoud Khalil Al-Husri.", 30.781941029218899, 30.995483984834241, "Tanta", "Birket el Sab", 0, 24 },
                    { 45002450, "It is called Banha Al - Assal as it produces the finest types of bee honey.", 30.455953488998389, 31.181093848594685, "Banha", "Toukh", 0, 24 },
                    { 45021020, "The origin of Sheikh Muhammad Al-Ghazali.", 30.887954013325928, 30.67008637907707, "Itay El Barud", "Tawfiqia", 0, 24 },
                    { 90902120, "There is a war road in Quesna, and this road was used during the war to transport equipment and ammunition. The Delta University of Technology was established in 2019 in Quesna and includes four majors in the field of technology.", 30.547991778887262, 31.139919904419259, "Qewaisna", "Banha", 0, 24 },
                    { 99021020, "One of the facilities of the General Authority for Culture Palaces is the House of Culture in Birket El Sab.", 30.637454507182532, 31.079936683751335, "Birket El Sab", "Qewaisna", 0, 24 },
                    { 105433120, "Misr Spinning and Weaving Company in Kafr El-Dawar is the largest company in the city, and it comes in second place in Egypt after Misr Spinning and Weaving Company in El-Mahalla El-Kubra.", 31.132741286101705, 30.130901427172223, " Kafr El Dawwar", "Abu Humus", 0, 18 },
                    { 125021020, "Al Tawfiqia Hospital is located on the agricultural road and serves all road accidents from Tanta to Kafr El Dawwar.", 30.816339320978063, 30.748217873741716, "Tawfiqia", "Kafr El-Zayat", 0, 24 },
                    { 130313120, "Sidi Gaber district; It is one of the high-end neighborhoods and areas in Alexandria, Egypt.", 31.218776152059611, 29.942300551565349, "Sidi Gaber", "Kafr El Dawwar", 0, 18 },
                    { 145114580, "The College of the Holy Qur’an (Tanta) is the first of its kind at Al-Azhar University, and it has no equal in terms of its specialization in the Holy Qur’an except for the College of the Holy Qur’an in Medina. The origin of the reciter, Sheikh Mahmoud Khalil Al-Husri.", 30.781941029218899, 30.995483984834241, "Tanta", "Birket el Sab", 0, 914 },
                    { 145123487, "The Al-Tawbah Mosque is located in it, and it is the second mosque in Africa that was built by Amr bin Al-Aas in the year 21 AH.", 31.034533770853649, 30.468689104431753, "Damanhour", "Itay El Barud", 0, 914 },
                    { 145124505, "Alexandria is the second capital of Egypt and was its capital in the past. It is the capital of Alexandria Governorate and its largest city, located on the Mediterranean coast.", 31.193105781485116, 29.905233139369273, "Alexandria", "Sidi Gaber", 0, 914 },
                    { 145127400, "One of the facilities of the General Authority for Culture Palaces is the House of Culture in Birket El Sab.", 30.637454507182532, 31.079936683751335, "Birket El Sab", "Qewaisna", 0, 914 },
                    { 145127445, "There is a war road in Quesna, and this road was used during the war to transport equipment and ammunition. The Delta University of Technology was established in 2019 in Quesna and includes four majors in the field of technology.", 30.547991778887262, 31.139919904419259, "Qewaisna", "Banha", 0, 914 },
                    { 182154220, "There is a war road in Quesna, and this road was used during the war to transport equipment and ammunition. The Delta University of Technology was established in 2019 in Quesna and includes four majors in the field of technology.", 30.547991778887262, 31.139919904419259, "Qewaisna", "Banha", 0, 18 },
                    { 201021020, "Qaha Preserved Food Company is an Egyptian government joint stock company, owned by the Holding Company for Food Industries, one of the companies of the Ministry of Supply and Internal Trade, working in the field of food industries.", 30.285198657390623, 31.208928538794947, "Qaha", "Shubra El Kheima", 0, 18 },
                    { 210212210, "It is called Banha Al - Assal as it produces the finest types of bee honey.", 30.455953488998389, 31.181093848594685, "Banha", "Toukh", 0, 18 },
                    { 302002120, "Misr Spinning and Weaving Company in Kafr El-Dawar is the largest company in the city, and it comes in second place in Egypt after Misr Spinning and Weaving Company in El-Mahalla El-Kubra.", 31.132741286101705, 30.130901427172223, " Kafr El Dawwar", "Abu Humus", 0, 24 },
                    { 303021200, "Sidi Gaber district; It is one of the high-end neighborhoods and areas in Alexandria, Egypt.", 31.218776152059611, 29.942300551565349, "Sidi Gaber", "Kafr El Dawwar", 0, 24 },
                    { 330211203, "Alexandria is the second capital of Egypt and was its capital in the past. It is the capital of Alexandria Governorate and its largest city, located on the Mediterranean coast.", 31.193105781485116, 29.905233139369273, "Alexandria", "Sidi Gaber", 0, 24 },
                    { 330302120, "Among the archaeological monuments in the Abu Hummus center is Tel Koum Archaeological Center, which is an area where there are likely to be antiquities, and it is located south of Ezbet El Sawy.", 31.085098233708155, 30.310392025322059, "Abu Humus", "Damanhour", 0, 24 },
                    { 404002120, "The Al-Tawbah Mosque is located in it, and it is the second mosque in Africa that was built by Amr bin Al-Aas in the year 21 AH.", 31.034533770853649, 30.468689104431753, "Damanhour", "Itay El Barud", 0, 24 },
                    { 413020120, "The center and city of Toukh, in the center of Qalyubia Governorate. It is one of the ancient villages.", 30.351615440389189, 31.198362936947632, "Toukh", "Qaha", 0, 24 },
                    { 451021020, "The opening of the Welcome Ramadan exhibition in Kafr El-Zayyat to provide food commodities to citizens 2023.", 30.81945162969096, 30.814538865795129, "Kafr El-Zayat", "Tanta", 0, 24 },
                    { 1004875120, "Cairo is ranked 35th as the longest metro line among 114 cities in the world.", 30.063231628191652, 31.246724130095895, "Ramsis(Cairo)", "nextStation", 0, 914 },
                    { 1045452120, "The origin of Sheikh Muhammad Al-Ghazali.", 30.887954013325928, 30.67008637907707, "Itay El Barud", "Kafr El-Zayat", 0, 914 },
                    { 1303202120, "The Al-Tawbah Mosque is located in it, and it is the second mosque in Africa that was built by Amr bin Al-Aas in the year 21 AH.", 31.034533770853649, 30.468689104431753, "Damanhour", "Itay El Barud", 0, 18 },
                    { 1331201210, "Among the archaeological monuments in the Abu Hummus center is Tel Koum Archaeological Center, which is an area where there are likely to be antiquities, and it is located south of Ezbet El Sawy.", 31.085098233708155, 30.310392025322059, "Abu Humus", "Damanhour", 0, 18 },
                    { 1478913620, "It is called Banha Al - Assal as it produces the finest types of bee honey.", 30.455953488998389, 31.181093848594685, "Banha", "Ramsis(Cairo)", 0, 914 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_stations_TrainId",
                table: "stations",
                column: "TrainId");

            migrationBuilder.AddForeignKey(
                name: "FK_stations_trains_TrainId",
                table: "stations",
                column: "TrainId",
                principalTable: "trains",
                principalColumn: "TrainId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
