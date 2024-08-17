namespace Proje_2023
{
    partial class Form2
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
            this.DepoView = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.KayitGuncelleme = new System.Windows.Forms.Button();
            this.Depo = new System.Windows.Forms.ListBox();
            this.AddText = new System.Windows.Forms.RichTextBox();
            this.Kaydet = new System.Windows.Forms.Button();
            this.Rapor = new System.Windows.Forms.Button();
            this.raporList = new System.Windows.Forms.ListBox();
            this.kapat1 = new System.Windows.Forms.Button();
            this.kapat2 = new System.Windows.Forms.Button();
            this.kapat3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DepoView
            // 
            this.DepoView.BackColor = System.Drawing.Color.Beige;
            this.DepoView.ForeColor = System.Drawing.Color.SeaGreen;
            this.DepoView.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.DepoView.Location = new System.Drawing.Point(12, 14);
            this.DepoView.Name = "DepoView";
            this.DepoView.Size = new System.Drawing.Size(269, 38);
            this.DepoView.TabIndex = 0;
            this.DepoView.Text = "Depo Görüntüleme";
            this.DepoView.UseVisualStyleBackColor = false;
            this.DepoView.Click += new System.EventHandler(this.button1_Click);
            // 
            // KayitGuncelleme
            // 
            this.KayitGuncelleme.BackColor = System.Drawing.Color.Beige;
            this.KayitGuncelleme.ForeColor = System.Drawing.Color.SeaGreen;
            this.KayitGuncelleme.Location = new System.Drawing.Point(290, 14);
            this.KayitGuncelleme.Name = "KayitGuncelleme";
            this.KayitGuncelleme.Size = new System.Drawing.Size(270, 36);
            this.KayitGuncelleme.TabIndex = 3;
            this.KayitGuncelleme.Text = "Kayıt Güncelleme";
            this.KayitGuncelleme.UseVisualStyleBackColor = false;
            this.KayitGuncelleme.Click += new System.EventHandler(this.button3_Click);
            // 
            // Depo
            // 
            this.Depo.BackColor = System.Drawing.Color.Beige;
            this.Depo.ForeColor = System.Drawing.Color.SeaGreen;
            this.Depo.FormattingEnabled = true;
            this.Depo.HorizontalScrollbar = true;
            this.Depo.ItemHeight = 24;
            this.Depo.Location = new System.Drawing.Point(12, 72);
            this.Depo.Name = "Depo";
            this.Depo.Size = new System.Drawing.Size(657, 364);
            this.Depo.TabIndex = 5;
            // 
            // AddText
            // 
            this.AddText.BackColor = System.Drawing.Color.Beige;
            this.AddText.ForeColor = System.Drawing.Color.SeaGreen;
            this.AddText.Location = new System.Drawing.Point(290, 72);
            this.AddText.Name = "AddText";
            this.AddText.Size = new System.Drawing.Size(270, 316);
            this.AddText.TabIndex = 7;
            this.AddText.Text = "";
            // 
            // Kaydet
            // 
            this.Kaydet.BackColor = System.Drawing.Color.Beige;
            this.Kaydet.ForeColor = System.Drawing.Color.SeaGreen;
            this.Kaydet.Location = new System.Drawing.Point(341, 396);
            this.Kaydet.Name = "Kaydet";
            this.Kaydet.Size = new System.Drawing.Size(159, 40);
            this.Kaydet.TabIndex = 8;
            this.Kaydet.Text = "Kaydet";
            this.Kaydet.UseVisualStyleBackColor = false;
            this.Kaydet.Click += new System.EventHandler(this.Kaydet_Click);
            // 
            // Rapor
            // 
            this.Rapor.BackColor = System.Drawing.Color.Beige;
            this.Rapor.ForeColor = System.Drawing.Color.SeaGreen;
            this.Rapor.Location = new System.Drawing.Point(585, 14);
            this.Rapor.Name = "Rapor";
            this.Rapor.Size = new System.Drawing.Size(492, 36);
            this.Rapor.TabIndex = 9;
            this.Rapor.Text = "Günlük Rapor";
            this.Rapor.UseVisualStyleBackColor = false;
            this.Rapor.Click += new System.EventHandler(this.Rapor_Click);
            // 
            // raporList
            // 
            this.raporList.BackColor = System.Drawing.Color.Beige;
            this.raporList.ForeColor = System.Drawing.Color.SeaGreen;
            this.raporList.FormattingEnabled = true;
            this.raporList.HorizontalScrollbar = true;
            this.raporList.ItemHeight = 24;
            this.raporList.Location = new System.Drawing.Point(597, 72);
            this.raporList.Name = "raporList";
            this.raporList.Size = new System.Drawing.Size(492, 364);
            this.raporList.TabIndex = 10;
            // 
            // kapat1
            // 
            this.kapat1.BackColor = System.Drawing.Color.SeaGreen;
            this.kapat1.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kapat1.ForeColor = System.Drawing.Color.Red;
            this.kapat1.Location = new System.Drawing.Point(635, 65);
            this.kapat1.Name = "kapat1";
            this.kapat1.Size = new System.Drawing.Size(43, 35);
            this.kapat1.TabIndex = 6;
            this.kapat1.Text = "x";
            this.kapat1.UseVisualStyleBackColor = false;
            this.kapat1.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // kapat2
            // 
            this.kapat2.BackColor = System.Drawing.Color.SeaGreen;
            this.kapat2.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kapat2.ForeColor = System.Drawing.Color.Red;
            this.kapat2.Location = new System.Drawing.Point(1046, 56);
            this.kapat2.Name = "kapat2";
            this.kapat2.Size = new System.Drawing.Size(43, 35);
            this.kapat2.TabIndex = 11;
            this.kapat2.Text = "X";
            this.kapat2.UseVisualStyleBackColor = false;
            this.kapat2.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // kapat3
            // 
            this.kapat3.BackColor = System.Drawing.Color.SeaGreen;
            this.kapat3.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kapat3.ForeColor = System.Drawing.Color.Red;
            this.kapat3.Location = new System.Drawing.Point(517, 67);
            this.kapat3.Name = "kapat3";
            this.kapat3.Size = new System.Drawing.Size(43, 33);
            this.kapat3.TabIndex = 12;
            this.kapat3.Text = "X";
            this.kapat3.UseVisualStyleBackColor = false;
            this.kapat3.Click += new System.EventHandler(this.kapat3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1099, 446);
            this.Controls.Add(this.kapat3);
            this.Controls.Add(this.kapat2);
            this.Controls.Add(this.raporList);
            this.Controls.Add(this.Rapor);
            this.Controls.Add(this.Kaydet);
            this.Controls.Add(this.AddText);
            this.Controls.Add(this.kapat1);
            this.Controls.Add(this.Depo);
            this.Controls.Add(this.KayitGuncelleme);
            this.Controls.Add(this.DepoView);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Detay Sayfası";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DepoView;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button KayitGuncelleme;
        private System.Windows.Forms.ListBox Depo;
        private System.Windows.Forms.RichTextBox AddText;
        private System.Windows.Forms.Button Kaydet;
        private System.Windows.Forms.Button Rapor;
        private System.Windows.Forms.ListBox raporList;
        private System.Windows.Forms.Button kapat1;
        private System.Windows.Forms.Button kapat2;
        private System.Windows.Forms.CheckedListBox Makarnalar;
        private System.Windows.Forms.CheckedListBox Salatalar;
        private System.Windows.Forms.CheckedListBox Yemekler;
        private System.Windows.Forms.CheckedListBox İçecekler;
        private System.Windows.Forms.CheckedListBox Tatlılar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button kapat3;
    }
}