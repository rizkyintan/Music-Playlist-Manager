namespace MusicPlaylists
{
    partial class MusicPlaylist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlaylist));
            this.cmbPlaylists = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddNewPlaylist = new System.Windows.Forms.TextBox();
            this.btnAddPlaylist = new System.Windows.Forms.Button();
            this.btnGabungPlaylist = new System.Windows.Forms.Button();
            this.btnTambahLagu = new System.Windows.Forms.Button();
            this.txtPremium = new System.Windows.Forms.TextBox();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.lstDaftarLagu = new System.Windows.Forms.ListBox();
            this.cmbPlaylist2 = new System.Windows.Forms.ComboBox();
            this.btnSemuaLagu = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPlaylists
            // 
            this.cmbPlaylists.FormattingEnabled = true;
            this.cmbPlaylists.Location = new System.Drawing.Point(214, 37);
            this.cmbPlaylists.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPlaylists.Name = "cmbPlaylists";
            this.cmbPlaylists.Size = new System.Drawing.Size(240, 24);
            this.cmbPlaylists.TabIndex = 1;
            this.cmbPlaylists.SelectedIndexChanged += new System.EventHandler(this.cmbPlaylists_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Daftar Playlist:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Daftar Lagu:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(494, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nama Playlist:";
            // 
            // txtAddNewPlaylist
            // 
            this.txtAddNewPlaylist.Location = new System.Drawing.Point(500, 78);
            this.txtAddNewPlaylist.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddNewPlaylist.Name = "txtAddNewPlaylist";
            this.txtAddNewPlaylist.Size = new System.Drawing.Size(384, 22);
            this.txtAddNewPlaylist.TabIndex = 6;
            this.txtAddNewPlaylist.TextChanged += new System.EventHandler(this.txtAddNewPlaylist_TextChanged);
            // 
            // btnAddPlaylist
            // 
            this.btnAddPlaylist.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAddPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPlaylist.Location = new System.Drawing.Point(500, 119);
            this.btnAddPlaylist.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddPlaylist.Name = "btnAddPlaylist";
            this.btnAddPlaylist.Size = new System.Drawing.Size(198, 34);
            this.btnAddPlaylist.TabIndex = 7;
            this.btnAddPlaylist.Text = "Buat Playlist";
            this.btnAddPlaylist.UseVisualStyleBackColor = false;
            this.btnAddPlaylist.Click += new System.EventHandler(this.btnAddPlaylist_Click);
            // 
            // btnGabungPlaylist
            // 
            this.btnGabungPlaylist.BackColor = System.Drawing.Color.Gainsboro;
            this.btnGabungPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGabungPlaylist.Location = new System.Drawing.Point(500, 281);
            this.btnGabungPlaylist.Margin = new System.Windows.Forms.Padding(4);
            this.btnGabungPlaylist.Name = "btnGabungPlaylist";
            this.btnGabungPlaylist.Size = new System.Drawing.Size(198, 31);
            this.btnGabungPlaylist.TabIndex = 9;
            this.btnGabungPlaylist.Text = "Gabung Dua Playlists";
            this.btnGabungPlaylist.UseVisualStyleBackColor = false;
            this.btnGabungPlaylist.Click += new System.EventHandler(this.btnGabungPlaylist_Click);
            // 
            // btnTambahLagu
            // 
            this.btnTambahLagu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTambahLagu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambahLagu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTambahLagu.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnTambahLagu.Location = new System.Drawing.Point(214, 413);
            this.btnTambahLagu.Margin = new System.Windows.Forms.Padding(4);
            this.btnTambahLagu.Name = "btnTambahLagu";
            this.btnTambahLagu.Size = new System.Drawing.Size(240, 39);
            this.btnTambahLagu.TabIndex = 20;
            this.btnTambahLagu.Text = "Tambah Lagu";
            this.btnTambahLagu.UseVisualStyleBackColor = false;
            this.btnTambahLagu.Click += new System.EventHandler(this.btnTambahLagu_Click);
            // 
            // txtPremium
            // 
            this.txtPremium.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtPremium.Location = new System.Drawing.Point(500, 430);
            this.txtPremium.Margin = new System.Windows.Forms.Padding(4);
            this.txtPremium.Name = "txtPremium";
            this.txtPremium.ReadOnly = true;
            this.txtPremium.Size = new System.Drawing.Size(154, 22);
            this.txtPremium.TabIndex = 22;
            this.txtPremium.TextChanged += new System.EventHandler(this.txtPremium_TextChanged);
            // 
            // txtLimit
            // 
            this.txtLimit.Location = new System.Drawing.Point(668, 430);
            this.txtLimit.Margin = new System.Windows.Forms.Padding(4);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.ReadOnly = true;
            this.txtLimit.Size = new System.Drawing.Size(136, 22);
            this.txtLimit.TabIndex = 23;
            this.txtLimit.TextChanged += new System.EventHandler(this.txtLimit_TextChanged);
            // 
            // lstDaftarLagu
            // 
            this.lstDaftarLagu.FormattingEnabled = true;
            this.lstDaftarLagu.ItemHeight = 16;
            this.lstDaftarLagu.Location = new System.Drawing.Point(214, 84);
            this.lstDaftarLagu.Margin = new System.Windows.Forms.Padding(4);
            this.lstDaftarLagu.Name = "lstDaftarLagu";
            this.lstDaftarLagu.Size = new System.Drawing.Size(240, 260);
            this.lstDaftarLagu.TabIndex = 27;
            this.lstDaftarLagu.SelectedIndexChanged += new System.EventHandler(this.lstDaftarLagu_SelectedIndexChanged);
            // 
            // cmbPlaylist2
            // 
            this.cmbPlaylist2.FormattingEnabled = true;
            this.cmbPlaylist2.Location = new System.Drawing.Point(500, 237);
            this.cmbPlaylist2.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPlaylist2.Name = "cmbPlaylist2";
            this.cmbPlaylist2.Size = new System.Drawing.Size(384, 24);
            this.cmbPlaylist2.TabIndex = 28;
            // 
            // btnSemuaLagu
            // 
            this.btnSemuaLagu.BackColor = System.Drawing.Color.LightGray;
            this.btnSemuaLagu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSemuaLagu.Location = new System.Drawing.Point(214, 358);
            this.btnSemuaLagu.Margin = new System.Windows.Forms.Padding(4);
            this.btnSemuaLagu.Name = "btnSemuaLagu";
            this.btnSemuaLagu.Size = new System.Drawing.Size(240, 39);
            this.btnSemuaLagu.TabIndex = 30;
            this.btnSemuaLagu.Text = "Semua Lagu";
            this.btnSemuaLagu.UseVisualStyleBackColor = false;
            this.btnSemuaLagu.Click += new System.EventHandler(this.btnSemuaLagu_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Malgun Gothic Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(494, 184);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(310, 32);
            this.label7.TabIndex = 31;
            this.label7.Text = "Playlist yang ingin digabung:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Malgun Gothic Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(54, 413);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 32);
            this.label8.TabIndex = 32;
            this.label8.Text = "Edit Playlist:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(495, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 56);
            this.label6.TabIndex = 33;
            this.label6.Text = "Klik Tombol Di Samping \r\nUntuk Memutar Lagu!";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(728, 330);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // MusicPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(921, 509);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSemuaLagu);
            this.Controls.Add(this.cmbPlaylist2);
            this.Controls.Add(this.lstDaftarLagu);
            this.Controls.Add(this.txtLimit);
            this.Controls.Add(this.txtPremium);
            this.Controls.Add(this.btnTambahLagu);
            this.Controls.Add(this.btnGabungPlaylist);
            this.Controls.Add(this.btnAddPlaylist);
            this.Controls.Add(this.txtAddNewPlaylist);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPlaylists);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MusicPlaylist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusicPlaylist";
            this.Load += new System.EventHandler(this.MusicPlaylist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbPlaylists;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddNewPlaylist;
        private System.Windows.Forms.Button btnAddPlaylist;
        private System.Windows.Forms.Button btnGabungPlaylist;
        private System.Windows.Forms.Button btnTambahLagu;
        private System.Windows.Forms.TextBox txtPremium;
        private System.Windows.Forms.TextBox txtLimit;
        private System.Windows.Forms.ListBox lstDaftarLagu;
        private System.Windows.Forms.ComboBox cmbPlaylist2;
        private System.Windows.Forms.Button btnSemuaLagu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}