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

            //h ttps://www.flaticon.com/icon-packs/firefighter?style_id=15
            //h ttps://www.flaticon.com/packs/emergency-services-9

            var emergency1 = new Data.Entities.Emergency
            {
                ID = 1,
                Type = "Médico",
                LogoSource="ambulance.png",
                Description = "Trauma por accidente vehicular",
                Lat = "1",
                Lng = "1"
            };

            var emergency2 = new Data.Entities.Emergency
            {
                ID = 2,
                Type = "Incendio",
                Description = "Incendio forestal",
                LogoSource = "fire.png",
                Lat = "2",
                Lng = "2"
            };
            var emergency3 = new Data.Entities.Emergency
            {
                ID = 3,
                Type = "Rescate",
                Description = "Persona atrapada",
                LogoSource = "ax.png",
                Lat = "3",
                Lng = "3"
            };
            var emergency4 = new Data.Entities.Emergency
            {
                ID = 4,
                Type = "Administrativo",
                Description = "Presencia en concierto",
                LogoSource = "form.png",
                Lat = "4",
                Lng = "4"
            };

            var emergency5 = new Data.Entities.Emergency
            {
                ID = 5,
                Type = "Sustancias",
                Description = "Fuga de gas",
                LogoSource = "Chemical.png",
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