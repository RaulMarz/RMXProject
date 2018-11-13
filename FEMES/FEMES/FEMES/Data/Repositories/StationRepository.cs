using SQLite;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace FEMES.Data.Repositories
{
    public class StationRepository
    {
        SQLite.SQLiteAsyncConnection Database;

        public StationRepository()
        {
            string DbFilePath = Path.Combine(
                System.Environment.GetFolderPath(
                    System.Environment.SpecialFolder.LocalApplicationData), "NorthWind.db");

            Database = new SQLiteAsyncConnection(DbFilePath);
            Database.CreateTableAsync<Entities.Station>().Wait();


            var Station1 = new Data.Entities.Station
            {
                ID = 1,
                Name = "1",
                Description = "1",
                Address = "1",
                Phone = "1",
                Lat = "1",
                Lng = "1"
            };

            var Station2 = new Data.Entities.Station
            {
                ID = 2,
                Name = "2",
                Description = "2",
                Address = "2",
                Phone = "2",
                Lat = "2",
                Lng = "2"
            };

            var Station3 = new Data.Entities.Station
            {
                ID = 3,
                Name = "3",
                Description = "3",
                Address = "3",
                Phone = "3",
                Lat = "3",
                Lng = "3"
            };

            CreateStationAsync(Station1);
            CreateStationAsync(Station2);
            CreateStationAsync(Station3);
            

        }

        public Task<int> CreateStationAsync(Entities.Station Station)
        {
            return Database.InsertAsync(Station);
        }

        public Task <List<Entities.Station>> GetStationAsync()
        {
            return Database.Table<Entities.Station>().ToListAsync();
        }

        public Task<int> UpdateStationAsync(Entities.Station Station)
        {
            return Database.UpdateAsync(Station);
        }
    }
}