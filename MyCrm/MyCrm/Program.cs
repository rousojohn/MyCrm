using MyCrm.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;

namespace MyCrm
{
    public enum ApplicationState
    {
        AppStart,
        UserLoggedIn,
        UserLoggesOut
    }


    static class Program
    {
        private static MainForm mainForm;
        private static readonly ApplicationSettings appSettings = ApplicationSettings.Instance;
        private static IMongoDatabase crmDb;
        private static User currentUser;
        private static ApplicationState appState;

        public static MainForm MainForm { get { return Program.mainForm; } }
        public static ApplicationSettings AppSettings { get { return appSettings; } }
        public static IMongoDatabase CrmDb { get { return crmDb; } }
        public static User CurrentUser { get { return currentUser;  } }
        public static ApplicationState AppState {  get { return appState; } }


        public static bool IsUserLoggedIn ()
        {
            return ApplicationState.UserLoggedIn == appState;
        }


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            appState = ApplicationState.AppStart;

            appSettings.Read();

            crmDb = new MongoClient(new MongoClientSettings
            {
                Server = new MongoServerAddress(appSettings.Host, appSettings.Port),
                UseSsl = false
            }).GetDatabase(appSettings.Database);

            //var collection1 = crmDb.GetCollection<User>("users");

            //var collection1 = crmDb.GetCollection<Member>("members");
            //collection1.DeleteMany(FilterDefinition<Member>.Empty);




            //collection2.DeleteMany(FilterDefinition<BsonDocument>.Empty);


            //collection2.InsertOne(new BsonDocument() { { "test", "zxcvzxcvzvczcxv" } });
            //var _addresses = new Address[] {new Address()}
            //collection1.InsertOne(new Member()
            //{
            //    Age = 19,
            //    Birthdate = DateTime.Now,
            //    Name = "spyros_membefffr",
            //    Surname = "Surname",
            //    Addresses = new Address[] {
            //        new Address() {
            //            PostalCode =16561,
            //            Region = "Glyfada",
            //            Street="Msfdfessinis",
            //            StreetNo="23"
            //        },
            //        new Address() {
            //            PostalCode =44444,
            //            Region = "Glyasdfasdfadfsdfsdfsdfada",
            //            Street="Messasdfadsfinis",
            //            StreetNo="23"
            //        }
            //    }
            //});


            //collection1.InsertMany(new Member[]
            //{
            //    new Member()
            //    {
            //        Age = 19,
            //        Birthdate = DateTime.Now,
            //        Name = "spyros_membefffr",
            //        Surname = "Surname",
            //        Addresses = new Address[] {
            //            new Address() {
            //                PostalCode =16561,
            //                Region = "Glyfada",
            //                Street="Msfdfessinis",
            //                StreetNo="23"
            //            },
            //            new Address() {
            //                PostalCode =44444,
            //                Region = "Glyasdfasdfadfsdfsdfsdfada",
            //                Street="Messasdfadsfinis",
            //                StreetNo="23"
            //            }
            //        }
            //    }, 
            //    new Member()
            //    {
                     
            //        Age = 191,
            //        Birthdate = DateTime.Now,
            //        Name = "spyros_member",
            //        Surname = "Surname",
            //        Addresses = new Address[] {
            //            new Address() {
            //                PostalCode =16561,
            //                Region = "Glyfada",
            //                Street="Msfdfessinis",
            //                StreetNo="23"
            //            },
            //            new Address() {
            //                PostalCode =44444,
            //                Region = "Glyasdfasdfadfsdfsdfsdfada",
            //                Street="Messasdfadsfinis",
            //                StreetNo="23"
            //            }
            //        }
            //    }
            //});

            //var aaa = collection1.FindSync<BsonDocument>(FilterDefinition<Member>.Empty).ToList();
            ////FilterDefinition<User> filter = new FilterDefinition<Member<>>
            //Member aMember = collection1.FindSync<Member>(Builders<Member>.Filter.Where(u => u.Name.Equals("spyros_member"))).First();

            appState = ApplicationState.UserLoggedIn;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Program.mainForm = new MainForm();

            Application.Run(Program.mainForm);
        }
    }
}
