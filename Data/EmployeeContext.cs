using Microsoft.EntityFrameworkCore;

namespace SQLiteEFCore.Data
{
    public class EmployeeDataContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public EmployeeDataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(Configuration.GetConnectionString("EmployeeDB"));
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .ToTable("Employee");

            modelBuilder.Entity<Employee>()
                .HasData(
                     new Employee { Id = 1, FirstName = "Billie", LastName = "Churms", Email = "bchurms0@usda.gov", Department = "Female", Avatar = "93.247.225.92" },
                     new Employee { Id = 2, FirstName = "Clem", LastName = "Bunney", Email = "cbunney1@craigslist.org", Department = "Female", Avatar = "186.163.30.9" },
                     new Employee { Id = 3, FirstName = "Tab", LastName = "Wilcinskis", Email = "twilcinskis2@clickbank.net", Department = "Male", Avatar = "86.236.123.19" },
                     new Employee { Id = 4, FirstName = "Freda", LastName = "Thrussell", Email = "fthrussell3@slate.com", Department = "Female", Avatar = "163.137.92.211" },
                     new Employee { Id = 5, FirstName = "Marlie", LastName = "Kendall", Email = "mkendall4@theguardian.com", Department = "Female", Avatar = "200.178.41.254" },
                     new Employee { Id = 6, FirstName = "Em", LastName = "Cotman", Email = "ecotman5@dropbox.com", Department = "Female", Avatar = "188.80.18.29" },
                     new Employee { Id = 7, FirstName = "Taddeo", LastName = "Sissland", Email = "tsissland6@adobe.com", Department = "Male", Avatar = "185.47.190.64" },
                     new Employee { Id = 8, FirstName = "Stirling", LastName = "Janczyk", Email = "sjanczyk7@twitpic.com", Department = "Male", Avatar = "181.50.83.142" },
                     new Employee { Id = 9, FirstName = "Dukey", LastName = "Bertin", Email = "dbertin8@nasa.gov", Department = "Male", Avatar = "212.106.228.161" },
                     new Employee { Id = 10, FirstName = "Ardelis", LastName = "Toll", Email = "atoll9@pcworld.com", Department = "Female", Avatar = "229.51.110.20" },
                     new Employee { Id = 11, FirstName = "Emlyn", LastName = "McCrone", Email = "emccronea@buzzfeed.com", Department = "Female", Avatar = "233.38.178.55" },
                     new Employee { Id = 12, FirstName = "Agneta", LastName = "De Rechter", Email = "aderechterb@networksolutions.com", Department = "Female", Avatar = "84.120.103.48" },
                     new Employee { Id = 13, FirstName = "Maegan", LastName = "Vreede", Email = "mvreedec@behance.net", Department = "Female", Avatar = "59.199.251.206" },
                     new Employee { Id = 14, FirstName = "Archer", LastName = "Parsonson", Email = "aparsonsond@loc.gov", Department = "Male", Avatar = "115.136.4.239" },
                     new Employee { Id = 15, FirstName = "Sheila", LastName = "Suttie", Email = "ssuttiee@mayoclinic.com", Department = "Female", Avatar = "74.41.63.69" },
                     new Employee { Id = 16, FirstName = "Jeremiah", LastName = "Fiddian", Email = "jfiddianf@list-manage.com", Department = "Male", Avatar = "162.11.43.7" },
                     new Employee { Id = 17, FirstName = "Juliann", LastName = "Lamey", Email = "jlameyg@princeton.edu", Department = "Female", Avatar = "182.84.110.5" },
                     new Employee { Id = 18, FirstName = "Kippie", LastName = "Carus", Email = "kcarush@washingtonpost.com", Department = "Male", Avatar = "5.96.235.206" },
                     new Employee { Id = 19, FirstName = "Gary", LastName = "Smalecombe", Email = "gsmalecombei@reference.com", Department = "Male", Avatar = "78.5.19.223" },
                     new Employee { Id = 20, FirstName = "Stillmann", LastName = "Yeell", Email = "syeellj@dailymail.co.uk", Department = "Male", Avatar = "63.63.154.175" },
                     new Employee { Id = 21, FirstName = "Dareen", LastName = "Maurice", Email = "dmauricek@unesco.org", Department = "Female", Avatar = "191.93.135.211" },
                     new Employee { Id = 22, FirstName = "Bevin", LastName = "Suarez", Email = "bsuarezl@cnn.com", Department = "Male", Avatar = "154.205.73.155" },
                     new Employee { Id = 23, FirstName = "Cynthea", LastName = "Larmet", Email = "clarmetm@rambler.ru", Department = "Female", Avatar = "237.192.48.140" },
                     new Employee { Id = 24, FirstName = "Ardra", LastName = "Norbury", Email = "anorburyn@twitpic.com", Department = "Female", Avatar = "39.176.104.252" },
                     new Employee { Id = 25, FirstName = "Agatha", LastName = "McDonell", Email = "amcdonello@yale.edu", Department = "Female", Avatar = "141.142.33.54" },
                     new Employee { Id = 26, FirstName = "Orella", LastName = "Manvelle", Email = "omanvellep@wikimedia.org", Department = "Female", Avatar = "39.115.64.68" },
                     new Employee { Id = 27, FirstName = "Gunar", LastName = "Hassin", Email = "ghassinq@abc.net.au", Department = "Male", Avatar = "47.129.75.150" },
                     new Employee { Id = 28, FirstName = "Silvain", LastName = "Sutter", Email = "ssutterr@goo.ne.jp", Department = "Male", Avatar = "60.54.104.17" },
                     new Employee { Id = 29, FirstName = "Odetta", LastName = "Cabrara", Email = "ocabraras@mozilla.org", Department = "Bigender", Avatar = "21.148.104.113" },
                     new Employee { Id = 30, FirstName = "Flora", LastName = "Dencs", Email = "fdencst@instagram.com", Department = "Female", Avatar = "239.248.93.89" },
                     new Employee { Id = 31, FirstName = "Petronille", LastName = "Millichip", Email = "pmillichipu@spotify.com", Department = "Female", Avatar = "172.153.148.42" },
                     new Employee { Id = 32, FirstName = "Georgi", LastName = "Jaffray", Email = "gjaffrayv@cloudflare.com", Department = "Male", Avatar = "66.23.131.133" },
                     new Employee { Id = 33, FirstName = "Berny", LastName = "Pollok", Email = "bpollokw@github.io", Department = "Male", Avatar = "206.252.80.75" },
                     new Employee { Id = 34, FirstName = "Hernando", LastName = "Humes", Email = "hhumesx@nifty.com", Department = "Non-binary", Avatar = "68.202.94.210" },
                     new Employee { Id = 35, FirstName = "Aurea", LastName = "Bowkett", Email = "abowketty@rakuten.co.jp", Department = "Female", Avatar = "56.230.85.149" },
                     new Employee { Id = 36, FirstName = "Lavina", LastName = "Dowsey", Email = "ldowseyz@1688.com", Department = "Female", Avatar = "253.53.63.121" },
                     new Employee { Id = 37, FirstName = "Elnar", LastName = "Ralph", Email = "eralph10@rakuten.co.jp", Department = "Male", Avatar = "157.171.72.126" },
                     new Employee { Id = 38, FirstName = "Dorena", LastName = "Hallyburton", Email = "dhallyburton11@imdb.com", Department = "Female", Avatar = "110.152.135.226" },
                     new Employee { Id = 39, FirstName = "Myrle", LastName = "Costigan", Email = "mcostigan12@about.com", Department = "Female", Avatar = "241.42.234.92" },
                     new Employee { Id = 40, FirstName = "Dorette", LastName = "Rasor", Email = "drasor13@ameblo.jp", Department = "Female", Avatar = "71.29.222.161" },
                     new Employee { Id = 41, FirstName = "Maximilien", LastName = "Odger", Email = "modger14@prlog.org", Department = "Male", Avatar = "157.185.84.29" },
                     new Employee { Id = 42, FirstName = "Ingram", LastName = "Tilne", Email = "itilne15@prlog.org", Department = "Male", Avatar = "224.54.20.162" },
                     new Employee { Id = 43, FirstName = "Cthrine", LastName = "Beadnell", Email = "cbeadnell16@about.com", Department = "Female", Avatar = "52.31.32.90" },
                     new Employee { Id = 44, FirstName = "Eadmund", LastName = "Pleass", Email = "epleass17@columbia.edu", Department = "Male", Avatar = "99.22.146.3" },
                     new Employee { Id = 45, FirstName = "Jacintha", LastName = "de la Valette Parisot", Email = "jdelavaletteparisot18@latimes.com", Department = "Female", Avatar = "181.6.157.35" },
                     new Employee { Id = 46, FirstName = "Kore", LastName = "Nowak", Email = "knowak19@phoca.cz", Department = "Female", Avatar = "228.205.3.31" },
                     new Employee { Id = 47, FirstName = "Doyle", LastName = "Noulton", Email = "dnoulton1a@ucla.edu", Department = "Male", Avatar = "88.111.54.173" },
                     new Employee { Id = 48, FirstName = "Madelene", LastName = "Atkirk", Email = "matkirk1b@wufoo.com", Department = "Female", Avatar = "38.248.72.153" },
                     new Employee { Id = 49, FirstName = "Carolyne", LastName = "Breeder", Email = "cbreeder1c@si.edu", Department = "Bigender", Avatar = "196.14.231.174" },
                     new Employee { Id = 50, FirstName = "Calv", LastName = "Livock", Email = "clivock1d@mapy.cz", Department = "Male", Avatar = "24.165.109.241" }
                       );
        }
    }
}
