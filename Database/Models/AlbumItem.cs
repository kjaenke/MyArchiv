namespace MyArchiv.Models
{
    public class AlbumItem
    {
        public ulong AlbumId { get; set; }
        public ulong TrackId { get; set; }
        public Track Track { get; set; }
    }
}