namespace MyArchiv.Models
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public class Album
    {
        [Key]
        [DisplayName("Identifikation")]
        public ulong Id { get; set; }
        [DisplayName("Name")]
        public string Name { get; set; }
        [DisplayName("Erscheinungsdatum")]
        public string Release { get; set; }
        [DisplayName("Künstler")]
        public string Interpret { get; set; }
        [DisplayName("Cover")]
        public string Image { get; set; }
        [DisplayName("Inhalt")]
        public HashSet<AlbumItem> Items { get; set; } = new HashSet<AlbumItem>();
    }
}