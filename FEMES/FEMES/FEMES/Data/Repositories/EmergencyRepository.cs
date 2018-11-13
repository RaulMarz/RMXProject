using SQLite;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace FEMES.Data.Repositories
{
    public class EmergencyRepository
    {
        SQLite.SQLiteAsyncConnection Database;

        public EmergencyRepository()
        {
            string DbFilePath = Path.Combine(
                System.Environment.GetFolderPath(
                    System.Environment.SpecialFolder.LocalApplicationData), "NorthWind.db");

            Database = new SQLiteAsyncConnection(DbFilePath);
            Database.CreateTableAsync<Entities.Emergency>().Wait();


            var emergency1 = new Data.Entities.Emergency
            {
                ID = 1,
                Type = "1",
                Description = "1",
                Lat = "1",
                Lng = "1"
            };

            var emergency2 = new Data.Entities.Emergency
            {
                ID = 2,
                Type = "2",
                Description = "2",
                Lat = "2",
                Lng = "2"
            };
            var emergency3 = new Data.Entities.Emergency
            {
                ID = 3,
                Type = "3",
                Description = "3",
                Lat = "3",
                Lng = "3"
            };
            var emergency4 = new Data.Entities.Emergency
            {
                ID = 4,
                Type = "4",
                Description = "4",
                Lat = "4",
                Lng = "4"
            };

            var emergency5 = new Data.Entities.Emergency
            {
                ID = 5,
                Type = "5",
                Description = "5",
                Lat = "5",
                Lng = "5"
            };

            CreateEmergencyAsync(emergency1);
            CreateEmergencyAsync(emergency2);
            CreateEmergencyAsync(emergency3);
            CreateEmergencyAsync(emergency4);
            CreateEmergencyAsync(emergency5);

        }

        public Task<int> CreateEmergencyAsync(Entities.Emergency Emergency)
        {
            return Database.InsertAsync(Emergency);
        }

        public Task <List<Entities.Emergency>> GetEmergencyAsync()
        {
            return Database.Table<Entities.Emergency>().ToListAsync();
        }

        public Task<int> UpdateEmergencyAsync(Entities.Emergency Emergency)
        {
            return Database.UpdateAsync(Emergency);
        }
    }
}