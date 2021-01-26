using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Lab3MusicPlaylist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Playlist> Playlist { get; set; }
        public everyloopContext db = new everyloopContext();
        private Playlist activePlaylist;

        private void Form1_Load(object sender, EventArgs e)
        {
            if (db.Database.CanConnect())
            {
                LoadPlaylists();

                foreach (var playlist in Playlist)
                {
                    listBox1.Items.Add(playlist.Name);
                }

                listBox1.Height = (listBox1.Items.Count + 1) * 15;
                dataGridView1.Columns[0].Width = 30;
            }
            else
            {
                Debug.WriteLine("Cant connect");
            }
        }

        private void LoadPlaylists()
        {
            var playlists = db.Playlists
                .Include(playlist => playlist.PlaylistTracks)
                .ThenInclude(playlistTracks => playlistTracks.Track)
                .ThenInclude(track => track.Album)
                .ThenInclude(album => album.Artist)
                .Include(playlist => playlist.PlaylistTracks)
                .ThenInclude(playlistTrack => playlistTrack.Track)
                .ThenInclude(track => track.Genre)
                .ToList();

            Playlist = playlists;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                dataGridView1.Rows.Clear();
                return;
            }

            PrintDataGrid(Playlist[listBox1.SelectedIndex]);
            activePlaylist = Playlist[listBox1.SelectedIndex];
        }

        private void PrintDataGrid(Playlist playlist)
        {
            dataGridView1.Rows.Clear();

            foreach (var track in playlist.PlaylistTracks)
            {
                int rowIndex = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowIndex].Tag = track;

                dataGridView1.Rows[rowIndex].Cells["IdHeader"].Value = rowIndex;
                dataGridView1.Rows[rowIndex].Cells["TitleHeader"].Value = track.Track.Name;
                dataGridView1.Rows[rowIndex].Cells["ArtistHeader"].Value = track.Track.Album.Artist.Name;
                dataGridView1.Rows[rowIndex].Cells["AlbumHeader"].Value = track.Track.Album.Title;
                dataGridView1.Rows[rowIndex].Cells["GenreHeader"].Value = track.Track.Genre.Name;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            db.SaveChanges();
            db.Dispose();
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (dataGridView1.SelectedRows[0].Tag is PlaylistTrack track)
                {
                    var result = MessageBox.Show(
                        $"Do you want to delete the song {track.Track.Name} from playlist {track.Playlist.Name}?",
                        "Remove Song", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        db.Remove(track);
                        dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                        db.SaveChanges();
                        PrintDataGrid(Playlist[listBox1.SelectedIndex]);
                    }
                }
            }
        }

        private void buttonAddTrack_Click(object sender, EventArgs e)
        {
            if (activePlaylist == null) return;
            using (var addTrack = new AddTrackForm(activePlaylist, db))
            {
                addTrack.ShowDialog();
            }
            PrintDataGrid(Playlist[listBox1.SelectedIndex]);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (Playlist[listBox1.SelectedIndex] is Playlist playlist)
            {
                var result = MessageBox.Show(
                    $"Are you sure you want to delete the playlist '{playlist.Name}'?",
                    "Remove Playlist", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    listBox1.Items.Remove(listBox1.SelectedItem);
                    foreach (var tracks in playlist.PlaylistTracks)
                    {
                        db.Remove(tracks);
                    }
                    db.Remove(playlist);
                    db.SaveChanges();
                    activePlaylist = null;
                    ListboxHeight();
                }
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter playlist name here") return;
            if (textBox1.Text == "") return;

            var newPlaylist = new Playlist { Name = textBox1.Text, PlaylistId = db.Playlists.Max(p => p.PlaylistId) + 1 };
            db.Playlists.Add(newPlaylist);
            db.SaveChanges();
            LoadPlaylists();
            listBox1.Items.Add(newPlaylist.Name);
            ListboxHeight();
        }

        private void ListboxHeight()
        {
            listBox1.Height = (listBox1.Items.Count + 1) * 15;
        }

        private void buttonRemoveSong_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows[0].Tag is PlaylistTrack track)
            {
                var result = MessageBox.Show(
                    $"Do you want to delete the song {track.Track.Name} from playlist {track.Playlist.Name}?",
                    "Remove Song", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    db.Remove(track);
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                    db.SaveChanges();
                    PrintDataGrid(Playlist[listBox1.SelectedIndex]);
                }
            }
        }

    }

}
