namespace WinFormsApp1
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
            referansad_tb = new TextBox();
            ekle_button = new Button();
            ara_button = new Button();
            sil_button = new Button();
            stokmiktar_tb = new TextBox();
            tarih_tb = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            güncelle_button = new Button();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // referansad_tb
            // 
            referansad_tb.Location = new Point(175, 110);
            referansad_tb.Name = "referansad_tb";
            referansad_tb.Size = new Size(164, 27);
            referansad_tb.TabIndex = 0;
            // 
            // ekle_button
            // 
            ekle_button.Location = new Point(444, 88);
            ekle_button.Name = "ekle_button";
            ekle_button.Size = new Size(113, 71);
            ekle_button.TabIndex = 1;
            ekle_button.Text = " EKLE";
            ekle_button.UseVisualStyleBackColor = true;
            ekle_button.Click += ekle_button_Click;
            // 
            // ara_button
            // 
            ara_button.Location = new Point(594, 88);
            ara_button.Name = "ara_button";
            ara_button.Size = new Size(113, 71);
            ara_button.TabIndex = 2;
            ara_button.Text = "ARA";
            ara_button.UseVisualStyleBackColor = true;
            ara_button.Click += ara_button_Click;
            // 
            // sil_button
            // 
            sil_button.Location = new Point(444, 194);
            sil_button.Name = "sil_button";
            sil_button.Size = new Size(113, 71);
            sil_button.TabIndex = 3;
            sil_button.Text = "SİL";
            sil_button.UseVisualStyleBackColor = true;
            sil_button.Click += sil_button_Click;
            // 
            // stokmiktar_tb
            // 
            stokmiktar_tb.Location = new Point(175, 165);
            stokmiktar_tb.Name = "stokmiktar_tb";
            stokmiktar_tb.Size = new Size(164, 27);
            stokmiktar_tb.TabIndex = 7;
            // 
            // tarih_tb
            // 
            tarih_tb.Location = new Point(175, 216);
            tarih_tb.Name = "tarih_tb";
            tarih_tb.Size = new Size(164, 27);
            tarih_tb.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 110);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 9;
            label1.Text = "REFERANS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 165);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 12;
            label4.Text = "STOK MİKTARI";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 216);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 13;
            label5.Text = "TARİH";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(123, 53);
            label6.Name = "label6";
            label6.Size = new Size(119, 20);
            label6.TabIndex = 20;
            label6.Text = "KAYIT İŞLEMLERİ";
            // 
            // güncelle_button
            // 
            güncelle_button.Location = new Point(594, 194);
            güncelle_button.Name = "güncelle_button";
            güncelle_button.Size = new Size(113, 71);
            güncelle_button.TabIndex = 21;
            güncelle_button.Text = "GÜNCELLE";
            güncelle_button.UseVisualStyleBackColor = true;
            güncelle_button.Click += güncelle_button_Click;
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.InactiveCaption;
            listView1.CheckBoxes = true;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Location = new Point(53, 310);
            listView1.Name = "listView1";
            listView1.Size = new Size(664, 216);
            listView1.TabIndex = 22;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(800, 677);
            Controls.Add(listView1);
            Controls.Add(güncelle_button);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(tarih_tb);
            Controls.Add(stokmiktar_tb);
            Controls.Add(sil_button);
            Controls.Add(ara_button);
            Controls.Add(ekle_button);
            Controls.Add(referansad_tb);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox referansad_tb;
        private Button ekle_button;
        private Button ara_button;
        private Button sil_button;
        private TextBox stokmiktar_tb;
        private TextBox tarih_tb;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button güncelle_button;
        private ListView listView1;
    }
}