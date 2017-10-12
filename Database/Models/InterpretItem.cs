namespace Database.Models
{
    using MyArchiv.Models;

    public class InterpretItem
    {
        public ulong InterpretId { get; set; }
        public ulong AlbumId { get; set; }
        public Album Album { get; set; }
    }
}