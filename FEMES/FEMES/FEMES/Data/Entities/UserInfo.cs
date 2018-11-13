

namespace FEMES.Data.Entities
{
    public class UserInfo
    {
        [SQLite.PrimaryKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string RH { get; set; }
     
        //public int CategoryID { get; set; }
    }
}