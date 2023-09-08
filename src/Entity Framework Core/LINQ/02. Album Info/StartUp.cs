namespace _02._Album_Info
{
    using _02._Album_Info.Data;
    using _02._Album_Info.Initializer;
    using System.Text;

    internal class StartUp
    {
        static void Main(string[] args)
        {
            MusicHubDbContext context = new MusicHubDbContext();

            DbInitializer.ResetDatabase(context);

            string result = ExportAlbumsInfo(context, 9);
            Console.WriteLine(result);
        }
        public static string ExportAlbumsInfo(MusicHubDbContext context, int producerId)
        {
            var albums = context.Producers
                 .FirstOrDefault(x => x.Id == producerId)
                 .Albums
                 .Select(x => new
                 {
                     Name = x.Name,
                     ReleaseDate = x.ReleaseDate,
                     ProducerName = x.Producer.Name,
                     Songs = x.Songs.Select(x => new
                     {
                         Name = x.Name,
                         Price = x.Price,
                         WriterName = x.Writer.Name
                     }).OrderByDescending(x => x.Name).ThenBy(x => x.WriterName).ToList(),
                     TotalPrice = x.Price
                 }).OrderByDescending(x => x.TotalPrice)
                 .ToList();

            StringBuilder builder = new StringBuilder();

            foreach (var album in albums)
            {
                builder.AppendLine($"-AlbumName: {album.Name}");
                builder.AppendLine($"-ReleaseDate: {album.ReleaseDate.ToString("MM/dd/yyyy")}");
                builder.AppendLine($"-ProducerName: {album.ProducerName}");
                builder.AppendLine("-Songs:");
                int counter = 1;
                foreach (var song in album.Songs)
                {
                    builder.AppendLine($"---#{counter}");
                    builder.AppendLine($"---SongName: {song.Name}");
                    builder.AppendLine($"---Price: {song.Price:f2}");
                    builder.AppendLine($"---Writer: {song.WriterName}");
                    counter++;
                }
                builder.AppendLine($"-AlbumPrice: {album.TotalPrice:f2}");
            }

            return builder.ToString().TrimEnd();

        }

        public static string ExportSongsAboveDuration(MusicHubDbContext context, int duration)
        {
            throw new NotImplementedException();
        }
    }
}