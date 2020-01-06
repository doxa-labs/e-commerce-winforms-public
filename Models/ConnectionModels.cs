namespace N11Category.Models
{
    public class ConnectionModelN11
    {
        public string server { get; set; }
        public string port { get; set; }
        public string databaseName { get; set; }
        public string tableAttributes { get; set; }
        public string tableCategories { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }

    public class ConnectionModelGG
    {
        public string server { get; set; }
        public string port { get; set; }
        public string databaseName { get; set; }
        public string productTable { get; set; }
        public string ggProductTable { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}
