using System;
using System.Collections.Generic;
using System.Diagnostics;

#nullable disable

namespace Lab3MusicPlaylist
{
    public partial class Track
    {
        public Track()
        {
            PlaylistTracks = new HashSet<PlaylistTrack>();
        }

        public int TrackId { get; set; }
        public string Name { get; set; }
        public int? AlbumId { get; set; }
        public int MediaTypeId { get; set; }
        public int? GenreId { get; set; }
        public string Composer { get; set; }
        public int Milliseconds { get; set; }
        public int? Bytes { get; set; }
        public double UnitPrice { get; set; }

        public virtual Album Album { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual MediaType MediaType { get; set; }
        public virtual ICollection<PlaylistTrack> PlaylistTracks { get; set; }
    }
}
