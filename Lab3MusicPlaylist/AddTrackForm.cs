using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3MusicPlaylist
{
    public partial class AddTrackForm : Form
    {
        private Playlist Playlist;
        private everyloopContext _db;
        public AddTrackForm(Playlist playlist, everyloopContext db)
        {
            InitializeComponent();
            Playlist = playlist;
            dataGridViewAddTrack.Rows.Clear();
            listBoxAddedSongs.Items.Clear();
            _db = db;

            var tracks = db.Tracks;

            foreach (var track in tracks)
            {
                int rowIndex = dataGridViewAddTrack.Rows.Add();
                dataGridViewAddTrack.Rows[rowIndex].Tag = track;

                dataGridViewAddTrack.Rows[rowIndex].Cells["IdHeader"].Value = rowIndex + 1;
                dataGridViewAddTrack.Rows[rowIndex].Cells["TitleHeader"].Value = track.Name;
                dataGridViewAddTrack.Rows[rowIndex].Cells["ArtistHeader"].Value = track.Album.Artist.Name;
                dataGridViewAddTrack.Rows[rowIndex].Cells["AlbumHeader"].Value = track.Album.Title;
                dataGridViewAddTrack.Rows[rowIndex].Cells["GenreHeader"].Value = track.Genre.Name;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            
            if (dataGridViewAddTrack.SelectedRows[0].Tag is Track track)
            {
                if (Playlist.PlaylistTracks.Any(t => t.TrackId == track.TrackId)) return;
                var newTrack = new PlaylistTrack { PlaylistId = Playlist.PlaylistId, TrackId = track.TrackId, Playlist = Playlist, Track = track};
                Playlist?.PlaylistTracks.Add(newTrack);
                listBoxAddedSongs.Items.Add(track.Name);
                _db.SaveChanges();
            }
        }
    }
}
