
namespace Lab3MusicPlaylist
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRemoveSong = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAddTrack = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArtistHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlbumHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenreHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.buttonRemoveSong);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.buttonDelete);
            this.splitContainer1.Panel1.Controls.Add(this.buttonAddTrack);
            this.splitContainer1.Panel1.Controls.Add(this.buttonCreate);
            this.splitContainer1.Panel1.Controls.Add(this.listBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1034, 593);
            this.splitContainer1.SplitterDistance = 343;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter playlist name";
            // 
            // buttonRemoveSong
            // 
            this.buttonRemoveSong.Location = new System.Drawing.Point(211, 544);
            this.buttonRemoveSong.Name = "buttonRemoveSong";
            this.buttonRemoveSong.Size = new System.Drawing.Size(115, 37);
            this.buttonRemoveSong.TabIndex = 5;
            this.buttonRemoveSong.Text = "Remove song";
            this.buttonRemoveSong.UseVisualStyleBackColor = true;
            this.buttonRemoveSong.Click += new System.EventHandler(this.buttonRemoveSong_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 405);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 23);
            this.textBox1.TabIndex = 4;
            // 
            // buttonDelete
            // 
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonDelete.Location = new System.Drawing.Point(12, 544);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(115, 37);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete playlist";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAddTrack
            // 
            this.buttonAddTrack.Location = new System.Drawing.Point(12, 485);
            this.buttonAddTrack.Name = "buttonAddTrack";
            this.buttonAddTrack.Size = new System.Drawing.Size(115, 39);
            this.buttonAddTrack.TabIndex = 2;
            this.buttonAddTrack.Text = "Add song to playlist";
            this.buttonAddTrack.UseVisualStyleBackColor = true;
            this.buttonAddTrack.Click += new System.EventHandler(this.buttonAddTrack_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(12, 389);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(115, 39);
            this.buttonCreate.TabIndex = 1;
            this.buttonCreate.Text = "Create playlist";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(337, 349);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdHeader,
            this.TitleHeader,
            this.ArtistHeader,
            this.AlbumHeader,
            this.GenreHeader});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(687, 593);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 593);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(1050, 632);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Playlist Creator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAddTrack;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtistHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlbumHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenreHeader;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonRemoveSong;
        private System.Windows.Forms.Label label1;
    }
}

