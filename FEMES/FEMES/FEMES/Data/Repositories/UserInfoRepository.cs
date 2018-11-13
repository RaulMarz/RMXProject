using SQLite;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace FEMES.Data.Repositories
{
    public class UserInfoRepository
    {
        SQLite.SQLiteAsyncConnection Database;

        public UserInfoRepository()
        {
            string DbFilePath = Path.Combine(
                System.Environment.GetFolderPath(
                    System.Environment.SpecialFolder.LocalApplicationData), "NorthWind.db");

            Database = new SQLiteAsyncConnection(DbFilePath);
            Database.CreateTableAsync<Entities.UserInfo>().Wait();
        }

        public Task<int> CreateUserInfoAsync(Entities.UserInfo userInfo)
        {
            return Database.InsertAsync(userInfo);
        }

        public List<Entities.UserInfo> GetUserInfoAsync()
        {
            return Database.Table<Entities.UserInfo>().ToListAsync().Result;
        }

        public Task<int> UpdateUserInfoAsync(Entities.UserInfo userInfo)
        {
            return Database.UpdateAsync(userInfo);
        }
    }
}