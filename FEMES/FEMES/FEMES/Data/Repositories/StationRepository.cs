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
                Description = "EB - Central",
                Address = "1",
                Phone = "2739293",
                Lat = "1",
                Lng = "1"
            };

            var Station2 = new Data.Entities.Station
            {
                ID = 2,
                Name = "2",
                Description = "EB - Chapinero",
                Address = "2",
                Phone = "2839475",
                Lat = "2",
                Lng = "2"
            };

            var Station3 = new Data.Entities.Station
            {
                ID = 3,
                Name = "3",
                Description = "EB - Restrepo",
                Address = "3",
                Phone = "8938495",
                Lat = "3",
                Lng = "3"
            };

            var Station4 = new Data.Entities.Station
            {
                ID = 4,
                Name = "4",
                Description = "EB - Las Ferias",
                Address = "4",
                Phone = "1267384",
                Lat = "4",
                Lng = "4"
            };

            CreateStationAsync(Station1);
            CreateStationAsync(Station2);
            CreateStationAsync(Station3);
            CreateStationAsync(Station4);


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
        public Task<Entities.Station> GetEntityByIDAsync(int id)
        {
            return Database.Table<Entities.Station>().Where(e => e.ID == id).FirstOrDefaultAsync();
        }
    }
}