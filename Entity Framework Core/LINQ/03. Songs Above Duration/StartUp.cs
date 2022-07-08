namespace _03._Songs_Above_Duration
{
    using _03._Songs_Above_Duration.Data;
    using _03._Songs_Above_Duration.Initializer;
    using System.Text;

    internal class StartUp
    {
        static void Main(string[] args)
        {
            MusicHubDbContext context =
                new MusicHubDbContext();

            DbInitializer.ResetDatabase(context);

            string result = ExportSongsAboveDuration(context, 4);
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
                builder.AppendLine($"-ReleaseDate: {album.ReleaseDate:MM/dd/yyyy}");
                builder.AppendLine($"-ProducerName: {album.ProducerName}");
                builder.AppendLine("-Songs:");
                int counterSong = 1;
                foreach (var song in album.Songs)
                {
                    builder.AppendLine($"---#{counterSong}");
                    builder.AppendLine($"---SongName: {song.Name}");
                    builder.AppendLine($"---Price: {song.Price:f2}");
                    builder.AppendLine($"---Writer: {song.WriterName}");
                    counterSong++;
                }
                builder.AppendLine($"-AlbumPrice: {album.TotalPrice:f2}");
            }

            return builder.ToString().TrimEnd();
        }

        public static string ExportSongsAboveDuration(MusicHubDbContext context, int duration)
        {
            var songs = context.Songs
                .ToList()
                .Where(x => x.Duration.TotalSeconds > duration)
                .Select(s => new
                {
                    Name = s.Name,
                    PerformerFullName = s.SongPerformers
                                        .Select(x => x.Performer.FirstName + " " + x.Performer.LastName)
                                        .FirstOrDefault(),
                    WriterName = s.Writer.Name,
                    AlbumProducer = s.Album.Producer.Name,
                    Duration = s.Duration
                })
                .OrderBy(x => x.Name)
                .ThenBy(x => x.WriterName)
                .ThenBy(x => x.PerformerFullName);


            StringBuilder builder = new StringBuilder();
            int counterSong = 1;
            foreach (var song in songs)
            {
                builder.AppendLine($"-Song #{counterSong}");
                builder.AppendLine($"---SongName: {song.Name}");
                builder.AppendLine($"---Writer: {song.WriterName}");
                builder.AppendLine($"---Performer: {song.PerformerFullName}");
                builder.AppendLine($"---AlbumProducer: {song.AlbumProducer}");
                builder.AppendLine($"---Duration: {song.Duration:c}");
                counterSong++;
            }

            return builder.ToString().TrimEnd();
        }
    }
}