using System.Diagnostics.Eventing.Reader;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("REFERANS", 100);
            listView1.Columns.Add("STOK MÝKTARI", 200);
            listView1.Columns.Add("TARÝH", 200);
            listView1.Width = 550;

        } 

        private void ekle_button_Click(object sender, EventArgs e)
        {
            string referans, stok_miktar, tarih;

            referans = referansad_tb.Text;
            stok_miktar = stokmiktar_tb.Text;
            tarih = tarih_tb.Text;

            string[] bilgiler = { referans, stok_miktar, tarih };
            ListViewItem ekle = new ListViewItem(bilgiler);
            listView1.Items.Add(ekle);
        }

        private void sil_button_Click(object sender, EventArgs e)
        {
            int secilen_sayi = listView1.CheckedItems.Count;
            foreach (ListViewItem secili_kayit in listView1.CheckedItems)
            {
                secili_kayit.Remove();
            }
            MessageBox.Show(secilen_sayi.ToString() + " ADET KAYIT SÝLÝNDÝ.");
        }

        private void ara_button_Click(object sender, EventArgs e)
        {
            bool kayit_kontrol = false;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[0].Text == referansad_tb.Text)
                {
                    kayit_kontrol = true;
                    stokmiktar_tb.Text = listView1.Items[i].SubItems[1].Text;
                    tarih_tb.Text = listView1.Items[i].SubItems[1].Text;
                }
            }
            if (kayit_kontrol == false)
                MessageBox.Show(referansad_tb.Text + " Referans Bulunamadý!");
        }

        private void güncelle_button_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0) 
            {
                listView1.SelectedItems[0].SubItems[0].Text = referansad_tb.Text;
                listView1.SelectedItems[0].SubItems[1].Text = stokmiktar_tb.Text;
                listView1.SelectedItems[0].SubItems[2].Text = tarih_tb.Text;
            }
        }
    }
}