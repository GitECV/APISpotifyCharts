using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace spotifychartsAPI.Models
{
    public class Charts
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int iIdInsertion { get; set; }

        public DateTime dtDatetime { get; set; }

        [MaxLength(255)]
        public string sPlaylist { get; set; }

        [MaxLength(500)]
        public string sIdSong { get; set; }

        public int iChartPosition { get; set; }

        [MaxLength(500)]
        public string sSongName { get; set; }

        [MaxLength(500)]
        public string sArtistName { get; set; }

        public int? iPeak { get; set; }

        [MaxLength(125)]
        public string? sPrevPosition { get; set; }

        public int? iStreak { get; set; }

        public int iStreams { get; set; }

        public DateTime? dtReleaseDate { get; set; }

        public DateTime? dtFirstEntryDate { get; set; }

        public int? iFirstEntryPosition { get; set; }

        public int? iTotalDaysOnChart { get; set; }
    }
}
