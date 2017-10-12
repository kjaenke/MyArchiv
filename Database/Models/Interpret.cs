namespace Database.Models
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public class Interpret
    {
        [Key]
        [DisplayName("Identifikation")]
        public ulong Id { get; set; }
        [DisplayName("Identifikation")]
        public string Name { get; set; }
        [DisplayName("Identifikation")]
        public string Country { get; set; }
        [DisplayName("Identifikation")]
        public string Genre { get; set; }
        [DisplayName("Bild")]
        public string Image { get; set; }
        [DisplayName("Inhalt")]
        public HashSet<InterpretItem> Items { get; set; } =new HashSet<InterpretItem>();
    }
}