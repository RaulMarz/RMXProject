

namespace FEMES.Data.Entities
{
    public class Emergency
    {
        [SQLite.PrimaryKey]
        public int ID { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
     
        //public int CategoryID { get; set; }
    }
}