

namespace FEMES.Data.Entities
{
    public class Station
    {
        [SQLite.PrimaryKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
     
    }
}