using System.ComponentModel.DataAnnotations;

namespace spotifychartsAPI.Requests
{
    public class ItemDatetimeRequest
    {
        [Required]
        public string Playlist { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public string? Item { get; set; }
    }
}
