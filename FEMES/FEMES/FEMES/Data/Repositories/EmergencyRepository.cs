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
                Date = "2018/11/10",
                Hour = "22:05",
                Lat = "1",
                Lng = "1"
            };

            var emergency2 = new Data.Entities.Emergency
            {
                ID = 2,
                Type = "Incendio",
                Description = "Incendio forestal",
                LogoSource = "fire.png",
                Date = "2018/08/10",
                Hour = "22:05",
                Lat = "2",
                Lng = "2"
            };
            var emergency3 = new Data.Entities.Emergency
            {
                ID = 3,
                Type = "Rescate",
                Description = "Persona atrapada",
                LogoSource = "ax.png",
                Date = "2018/11/10",
                Hour = "22:05",
                Lat = "3",
                Lng = "3"
            };
            var emergency4 = new Data.Entities.Emergency
            {
                ID = 4,
                Type = "Administrativo",
                Description = "Presencia en concierto",
                LogoSource = "form.png",
                Date = "2018/05/03",
                Hour = "22:05",
                Lat = "4",
                Lng = "4"
            };

            var emergency5 = new Data.Entities.Emergency
            {
                ID = 5,
                Type = "Sustancias",
                Description = "Fuga de gas",
                LogoSource = "Chemical.png",
                Date = "2018/02/28",
                Hour = "22:05",
                Lat = "5",
                Lng = "5"
            };

            var emergency6 = new Data.Entities.Emergency
            {
                ID = 6,
                Type = "Incendio",
                Description = "Incendio en Habitación",
                LogoSource = "fire.png",
                Date = "2018/11/10",
                Hour = "22:05",
                Lat = "2",
                Lng = "2"
            };

            CreateEmergencyAsync(emergency1);
            CreateEmergencyAsync(emergency2);
            CreateEmergencyAsync(emergency3);
            CreateEmergencyAsync(emergency4);
            CreateEmergencyAsync(emergency5);
            CreateEmergencyAsync(emergency6);

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

        public Task<Entities.Emergency> GetEntityByIDAsync(int id)
        {
            return Database.Table<Entities.Emergency>().Where(e => e.ID == id).FirstOrDefaultAsync();
        }
    }
}