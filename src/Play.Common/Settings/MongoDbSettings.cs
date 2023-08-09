namespace Play.Common.Settings
{
    //docker run -d --rm --name mongo -p 27017:27017 -v mongodbdata:/data/db mongo
    public class MongoDbSettings
    {
        public string Host { get; init; }
        public int Port { get; init; }
        public string ConnectionString => $"mongodb://{Host}:{Port}";
    }
}