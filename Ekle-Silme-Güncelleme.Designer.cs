namespace WindowsFormsApplication1
{
    partial class Ekle_Silme_Güncelleme
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ekle_Silme_Güncelleme));
            this.button2 = new System.Windows.Forms.Button();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.button1 = new System.Windows.Forms.Button();
            this.ımageList3 = new System.Windows.Forms.ImageList(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.kayıtgetir1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.ımageList4 = new System.Windows.Forms.ImageList(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.ımageList5 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayıtgetir1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.DeepPink;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageKey = "sill.png";
            this.button2.ImageList = this.ımageList2;
            this.button2.Location = new System.Drawing.Point(13, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 70);
            this.button2.TabIndex = 1;
            this.button2.Text = "ÜRÜNÜ SİL";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "sill.png");
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.DeepPink;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.ImageKey = "indir (1).jpg";
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(206, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 70);
            this.button3.TabIndex = 2;
            this.button3.Text = "GÜNCELLE";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "indir (1).jpg");
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(13, 115);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(329, 161);
            this.player.TabIndex = 3;
            this.player.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.DeepPink;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageKey = "mzk.jpg";
            this.button1.ImageList = this.ımageList3;
            this.button1.Location = new System.Drawing.Point(190, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 90);
            this.button1.TabIndex = 4;
            this.button1.Text = "GETİR-ÇAL";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ımageList3
            // 
            this.ımageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList3.ImageStream")));
            this.ımageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList3.Images.SetKeyName(0, "mzk.jpg");
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 295);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 38);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // kayıtgetir1
            // 
            this.kayıtgetir1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kayıtgetir1.Location = new System.Drawing.Point(420, 18);
            this.kayıtgetir1.Name = "kayıtgetir1";
            this.kayıtgetir1.Size = new System.Drawing.Size(396, 258);
            this.kayıtgetir1.TabIndex = 6;
            this.kayıtgetir1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kayıtgetir_CellContentClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.Color.DeepPink;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.ImageIndex = 1;
            this.button4.ImageList = this.ımageList4;
            this.button4.Location = new System.Drawing.Point(553, 295);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 77);
            this.button4.TabIndex = 7;
            this.button4.Text = "YAZDIR";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ımageList4
            // 
            this.ımageList4.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList4.ImageStream")));
            this.ımageList4.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList4.Images.SetKeyName(0, "yazdir_buton.png");
            this.ımageList4.Images.SetKeyName(1, "yazdir.gif");
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.Color.DeepPink;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.ImageIndex = 0;
            this.button5.ImageList = this.ımageList5;
            this.button5.Location = new System.Drawing.Point(715, 323);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(118, 49);
            this.button5.TabIndex = 8;
            this.button5.Text = "HESAP";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ımageList5
            // 
            this.ımageList5.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList5.ImageStream")));
            this.ımageList5.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList5.Images.SetKeyName(0, "oke.gif");
            // 
            // Ekle_Silme_Güncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._109721_en_guzel_sade_arka_planlar_1;
            this.ClientSize = new System.Drawing.Size(862, 373);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.kayıtgetir1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Name = "Ekle_Silme_Güncelleme";
            this.Text = "Ekle_Silme_Güncelleme";
            this.Load += new System.EventHandler(this.Ekle_Silme_Güncelleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayıtgetir1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.ImageList ımageList1;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ImageList ımageList3;
        private System.Windows.Forms.DataGridView kayıtgetir1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ImageList ımageList4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ImageList ımageList5;
    }
}