namespace MusicPlayer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtPlayer = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnOynat = new System.Windows.Forms.Button();
            this.btnDurdur = new System.Windows.Forms.Button();
            this.btnDuraklat = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtPlayer
            // 
            this.txtPlayer.Location = new System.Drawing.Point(2, 196);
            this.txtPlayer.Multiline = true;
            this.txtPlayer.Name = "txtPlayer";
            this.txtPlayer.Size = new System.Drawing.Size(150, 33);
            this.txtPlayer.TabIndex = 1;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAra.Location = new System.Drawing.Point(2, 244);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(98, 43);
            this.btnAra.TabIndex = 1;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnOynat
            // 
            this.btnOynat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnOynat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOynat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOynat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOynat.Location = new System.Drawing.Point(121, 244);
            this.btnOynat.Name = "btnOynat";
            this.btnOynat.Size = new System.Drawing.Size(98, 43);
            this.btnOynat.TabIndex = 2;
            this.btnOynat.Text = "Oynat";
            this.btnOynat.UseVisualStyleBackColor = false;
            this.btnOynat.Click += new System.EventHandler(this.btnOynat_Click);
            // 
            // btnDurdur
            // 
            this.btnDurdur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDurdur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDurdur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDurdur.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDurdur.Location = new System.Drawing.Point(247, 244);
            this.btnDurdur.Name = "btnDurdur";
            this.btnDurdur.Size = new System.Drawing.Size(98, 43);
            this.btnDurdur.TabIndex = 2;
            this.btnDurdur.Text = "Durdur";
            this.btnDurdur.UseVisualStyleBackColor = false;
            this.btnDurdur.Click += new System.EventHandler(this.btnDurdur_Click);
            // 
            // btnDuraklat
            // 
            this.btnDuraklat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDuraklat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDuraklat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDuraklat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDuraklat.Location = new System.Drawing.Point(368, 244);
            this.btnDuraklat.Name = "btnDuraklat";
            this.btnDuraklat.Size = new System.Drawing.Size(98, 43);
            this.btnDuraklat.TabIndex = 2;
            this.btnDuraklat.Text = "Duraklat";
            this.btnDuraklat.UseVisualStyleBackColor = false;
            this.btnDuraklat.Click += new System.EventHandler(this.btnDuraklat_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCikis.Location = new System.Drawing.Point(490, 244);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(98, 43);
            this.btnCikis.TabIndex = 2;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // Player
            // 
            this.Player.Enabled = true;
            this.Player.Location = new System.Drawing.Point(2, 0);
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            this.Player.Size = new System.Drawing.Size(861, 190);
            this.Player.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(857, 286);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnDuraklat);
            this.Controls.Add(this.btnDurdur);
            this.Controls.Add(this.btnOynat);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtPlayer);
            this.Controls.Add(this.Player);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MUSIC PLAYER";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private AxWMPLib.AxWindowsMediaPlayer Player;
        private System.Windows.Forms.TextBox txtPlayer;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnOynat;
        private System.Windows.Forms.Button btnDurdur;
        private System.Windows.Forms.Button btnDuraklat;
        private System.Windows.Forms.Button btnCikis;
    }
}

