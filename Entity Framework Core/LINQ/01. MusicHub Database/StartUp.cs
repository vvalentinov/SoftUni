namespace _01._MusicHub_Database
{
    using _01._MusicHub_Database.Data;
    using _01._MusicHub_Database.Initializer;

    internal class StartUp
    {
        static void Main(string[] args)
        {
            MusicHubDbContext context = new MusicHubDbContext();

            DbInitializer.ResetDatabase(context);
        }

        public static string ExportAlbumsInfo(MusicHubDbContext context, int producerId)
        {
            throw new NotImplementedException();
        }

        public static string ExportSongsAboveDuration(MusicHubDbContext context, int duration)
        {
            throw new NotImplementedException();
        }
    }
}