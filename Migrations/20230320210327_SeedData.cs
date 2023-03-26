using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SQLiteEFCore.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Employee");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                table: "Employee",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "Avatar", "Department", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "93.247.225.92", "Female", "bchurms0@usda.gov", "Billie", "Churms" },
                    { 2, "186.163.30.9", "Female", "cbunney1@craigslist.org", "Clem", "Bunney" },
                    { 3, "86.236.123.19", "Male", "twilcinskis2@clickbank.net", "Tab", "Wilcinskis" },
                    { 4, "163.137.92.211", "Female", "fthrussell3@slate.com", "Freda", "Thrussell" },
                    { 5, "200.178.41.254", "Female", "mkendall4@theguardian.com", "Marlie", "Kendall" },
                    { 6, "188.80.18.29", "Female", "ecotman5@dropbox.com", "Em", "Cotman" },
                    { 7, "185.47.190.64", "Male", "tsissland6@adobe.com", "Taddeo", "Sissland" },
                    { 8, "181.50.83.142", "Male", "sjanczyk7@twitpic.com", "Stirling", "Janczyk" },
                    { 9, "212.106.228.161", "Male", "dbertin8@nasa.gov", "Dukey", "Bertin" },
                    { 10, "229.51.110.20", "Female", "atoll9@pcworld.com", "Ardelis", "Toll" },
                    { 11, "233.38.178.55", "Female", "emccronea@buzzfeed.com", "Emlyn", "McCrone" },
                    { 12, "84.120.103.48", "Female", "aderechterb@networksolutions.com", "Agneta", "De Rechter" },
                    { 13, "59.199.251.206", "Female", "mvreedec@behance.net", "Maegan", "Vreede" },
                    { 14, "115.136.4.239", "Male", "aparsonsond@loc.gov", "Archer", "Parsonson" },
                    { 15, "74.41.63.69", "Female", "ssuttiee@mayoclinic.com", "Sheila", "Suttie" },
                    { 16, "162.11.43.7", "Male", "jfiddianf@list-manage.com", "Jeremiah", "Fiddian" },
                    { 17, "182.84.110.5", "Female", "jlameyg@princeton.edu", "Juliann", "Lamey" },
                    { 18, "5.96.235.206", "Male", "kcarush@washingtonpost.com", "Kippie", "Carus" },
                    { 19, "78.5.19.223", "Male", "gsmalecombei@reference.com", "Gary", "Smalecombe" },
                    { 20, "63.63.154.175", "Male", "syeellj@dailymail.co.uk", "Stillmann", "Yeell" },
                    { 21, "191.93.135.211", "Female", "dmauricek@unesco.org", "Dareen", "Maurice" },
                    { 22, "154.205.73.155", "Male", "bsuarezl@cnn.com", "Bevin", "Suarez" },
                    { 23, "237.192.48.140", "Female", "clarmetm@rambler.ru", "Cynthea", "Larmet" },
                    { 24, "39.176.104.252", "Female", "anorburyn@twitpic.com", "Ardra", "Norbury" },
                    { 25, "141.142.33.54", "Female", "amcdonello@yale.edu", "Agatha", "McDonell" },
                    { 26, "39.115.64.68", "Female", "omanvellep@wikimedia.org", "Orella", "Manvelle" },
                    { 27, "47.129.75.150", "Male", "ghassinq@abc.net.au", "Gunar", "Hassin" },
                    { 28, "60.54.104.17", "Male", "ssutterr@goo.ne.jp", "Silvain", "Sutter" },
                    { 29, "21.148.104.113", "Bigender", "ocabraras@mozilla.org", "Odetta", "Cabrara" },
                    { 30, "239.248.93.89", "Female", "fdencst@instagram.com", "Flora", "Dencs" },
                    { 31, "172.153.148.42", "Female", "pmillichipu@spotify.com", "Petronille", "Millichip" },
                    { 32, "66.23.131.133", "Male", "gjaffrayv@cloudflare.com", "Georgi", "Jaffray" },
                    { 33, "206.252.80.75", "Male", "bpollokw@github.io", "Berny", "Pollok" },
                    { 34, "68.202.94.210", "Non-binary", "hhumesx@nifty.com", "Hernando", "Humes" },
                    { 35, "56.230.85.149", "Female", "abowketty@rakuten.co.jp", "Aurea", "Bowkett" },
                    { 36, "253.53.63.121", "Female", "ldowseyz@1688.com", "Lavina", "Dowsey" },
                    { 37, "157.171.72.126", "Male", "eralph10@rakuten.co.jp", "Elnar", "Ralph" },
                    { 38, "110.152.135.226", "Female", "dhallyburton11@imdb.com", "Dorena", "Hallyburton" },
                    { 39, "241.42.234.92", "Female", "mcostigan12@about.com", "Myrle", "Costigan" },
                    { 40, "71.29.222.161", "Female", "drasor13@ameblo.jp", "Dorette", "Rasor" },
                    { 41, "157.185.84.29", "Male", "modger14@prlog.org", "Maximilien", "Odger" },
                    { 42, "224.54.20.162", "Male", "itilne15@prlog.org", "Ingram", "Tilne" },
                    { 43, "52.31.32.90", "Female", "cbeadnell16@about.com", "Cthrine", "Beadnell" },
                    { 44, "99.22.146.3", "Male", "epleass17@columbia.edu", "Eadmund", "Pleass" },
                    { 45, "181.6.157.35", "Female", "jdelavaletteparisot18@latimes.com", "Jacintha", "de la Valette Parisot" },
                    { 46, "228.205.3.31", "Female", "knowak19@phoca.cz", "Kore", "Nowak" },
                    { 47, "88.111.54.173", "Male", "dnoulton1a@ucla.edu", "Doyle", "Noulton" },
                    { 48, "38.248.72.153", "Female", "matkirk1b@wufoo.com", "Madelene", "Atkirk" },
                    { 49, "196.14.231.174", "Bigender", "cbreeder1c@si.edu", "Carolyne", "Breeder" },
                    { 50, "24.165.109.241", "Male", "clivock1d@mapy.cz", "Calv", "Livock" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                table: "Employee");

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.RenameTable(
                name: "Employee",
                newName: "Employees");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "Id");
        }
    }
}
