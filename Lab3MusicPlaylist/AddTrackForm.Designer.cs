
namespace Lab3MusicPlaylist
{
    partial class AddTrackForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxAddedSongs = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewAddTrack = new System.Windows.Forms.DataGridView();
            this.IdHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArtistHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlbumHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenreHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.listBoxAddedSongs);
            this.splitContainer1.Panel1.Controls.Add(this.buttonAdd);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewAddTrack);
            this.splitContainer1.Size = new System.Drawing.Size(648, 390);
            this.splitContainer1.SplitterDistance = 215;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Currently added songs";
            // 
            // listBoxAddedSongs
            // 
            this.listBoxAddedSongs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxAddedSongs.FormattingEnabled = true;
            this.listBoxAddedSongs.ItemHeight = 15;
            this.listBoxAddedSongs.Location = new System.Drawing.Point(12, 119);
            this.listBoxAddedSongs.Name = "listBoxAddedSongs";
            this.listBoxAddedSongs.Size = new System.Drawing.Size(189, 244);
            this.listBoxAddedSongs.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 26);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(189, 43);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add Selected Song";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewAddTrack
            // 
            this.dataGridViewAddTrack.AllowUserToAddRows = false;
            this.dataGridViewAddTrack.AllowUserToDeleteRows = false;
            this.dataGridViewAddTrack.AllowUserToResizeRows = false;
            this.dataGridViewAddTrack.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAddTrack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddTrack.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdHeader,
            this.TitleHeader,
            this.ArtistHeader,
            this.AlbumHeader,
            this.GenreHeader});
            this.dataGridViewAddTrack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAddTrack.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAddTrack.MultiSelect = false;
            this.dataGridViewAddTrack.Name = "dataGridViewAddTrack";
            this.dataGridViewAddTrack.ReadOnly = true;
            this.dataGridViewAddTrack.RowHeadersVisible = false;
            this.dataGridViewAddTrack.RowTemplate.Height = 25;
            this.dataGridViewAddTrack.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAddTrack.Size = new System.Drawing.Size(429, 390);
            this.dataGridViewAddTrack.TabIndex = 2;
            // 
            // IdHeader
            // 
            this.IdHeader.FillWeight = 50.65181F;
            this.IdHeader.HeaderText = "ID";
            this.IdHeader.Name = "IdHeader";
            this.IdHeader.ReadOnly = true;
            // 
            // TitleHeader
            // 
            this.TitleHeader.FillWeight = 70.49043F;
            this.TitleHeader.HeaderText = "Title";
            this.TitleHeader.Name = "TitleHeader";
            this.TitleHeader.ReadOnly = true;
            // 
            // ArtistHeader
            // 
            this.ArtistHeader.FillWeight = 70.49043F;
            this.ArtistHeader.HeaderText = "Artist";
            this.ArtistHeader.Name = "ArtistHeader";
            this.ArtistHeader.ReadOnly = true;
            // 
            // AlbumHeader
            // 
            this.AlbumHeader.FillWeight = 70.49043F;
            this.AlbumHeader.HeaderText = "Album";
            this.AlbumHeader.Name = "AlbumHeader";
            this.AlbumHeader.ReadOnly = true;
            // 
            // GenreHeader
            // 
            this.GenreHeader.FillWeight = 70.49043F;
            this.GenreHeader.HeaderText = "Genre";
            this.GenreHeader.Name = "GenreHeader";
            this.GenreHeader.ReadOnly = true;
            // 
            // AddTrackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 390);
            this.Controls.Add(this.splitContainer1);
            this.MaximumSize = new System.Drawing.Size(1050, 632);
            this.MinimumSize = new System.Drawing.Size(664, 429);
            this.Name = "AddTrackForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ModifyPlaylistForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddTrack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridViewAddTrack;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtistHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlbumHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenreHeader;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxAddedSongs;
    }
}