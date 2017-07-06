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
    static class Program
    {
        private static MainForm mainForm;
        private static readonly ApplicationSettings appSettings = ApplicationSettings.Instance;

        public static MainForm MainForm { get { return Program.mainForm; } }
        public static ApplicationSettings AppSettings { get { return appSettings; } }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            appSettings.Read();

            var settings2 = new MongoClientSettings
            {
                Server = new MongoServerAddress("localhost", 27017),
                UseSsl = false
            };
            var client2 = new MongoClient(settings2);

            IMongoDatabase db = client2.GetDatabase("myTest");

            var collection1 = db.GetCollection<User>("test");
            var collection2 = db.GetCollection<BsonDocument>("test2");

            collection1.DeleteMany(FilterDefinition<User>.Empty);
            collection2.DeleteMany(FilterDefinition<BsonDocument>.Empty);


            collection2.InsertOne(new BsonDocument() { { "test", "zxcvzxcvzvczcxv" } });
            collection1.InsertOne(new User() { Username = "rousojohn", Password = "123123123", Name = "Spyros" });

            //var aaa = collection1.FindSync<BsonDocument>(FilterDefinition<User>.Empty).ToList();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Program.mainForm = new MainForm();
            Application.Run(Program.mainForm);
        }
    }
}
