using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriTabaniOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=ödev; user ID=postgres; password=61346134");
        private void AbtnListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from sema.alici";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void AbtnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into sema.alici (\"aliciNo\",\"aliciAdi\",\"aliciSoyadi\",\"adresIl\",\"kartNo\") values(@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut.Parameters.AddWithValue("@p1", int.Parse(TxtAliciNo.Text));
            komut.Parameters.AddWithValue("@p2", TxtAliciAdi.Text);
            komut.Parameters.AddWithValue("@p3", TxtAliciSoyadi.Text);
            komut.Parameters.AddWithValue("@p4", TxtAdresil.Text);
            komut.Parameters.AddWithValue("@p5", int.Parse(TxtKartNo.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Alıcı Kaydı Başarıyla Gerçekleşti..!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AbtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("delete from sema.alici where \"aliciNo\"=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", int.Parse(TxtAliciNo.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Alıcı Silme İşlemi Başarıyla Gerçekleşti..!");
        }

        private void AbtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("update sema.alici set \"adresIl\"=@p1,\"kartNo\"=@p2 where \"aliciNo\"=@p3", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtAdresil.Text);
            komut.Parameters.AddWithValue("@p2", int.Parse(TxtKartNo.Text));
            komut.Parameters.AddWithValue("@p3", int.Parse(TxtAliciNo.Text));
            komut.ExecuteNonQuery();
            MessageBox.Show("Alıcı Başarılı Bir Şekilde Güncellendi..!");
            baglanti.Close();
        }

        private void AbtnArama_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("select * from sema.alici where \"aliciAdi\" like '%" + TxtArama.Text + "%'", baglanti);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void KbtnListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from sema.kitap";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void KbtnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into sema.kitap (\"kitapNo\",\"kitapAdi\",\"tür\",\"sayfa\",\"yazar\") values(@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut.Parameters.AddWithValue("@p1", int.Parse(TxtKitapNo.Text));
            komut.Parameters.AddWithValue("@p2", TxtKitapAdi.Text);
            komut.Parameters.AddWithValue("@p3", TxtTur.Text);
            komut.Parameters.AddWithValue("@p4", int.Parse(TxtSayfa.Text));
            komut.Parameters.AddWithValue("@p5", TxtYazar.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Kaydı Başarıyla Gerçekleşti..!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void KbtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("delete from sema.kitap where \"kitapNo\"=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", int.Parse(TxtKitapNo.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Silme İşlemi Başarıyla Gerçekleşti..!");
        }

        private void KbtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("update sema.kitap set \"tür\"=@p1,\"sayfa\"=@p2 where \"kitapNo\"=@p3", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtTur.Text);
            komut.Parameters.AddWithValue("@p2", int.Parse(TxtSayfa.Text));
            komut.Parameters.AddWithValue("@p3", int.Parse(TxtKitapNo.Text));
            komut.ExecuteNonQuery();
            MessageBox.Show("Kitap Başarılı Bir Şekilde Güncellendi..!");
            baglanti.Close();
        }

        private void KbtnArama_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("select * from sema.kitap where \"kitapAdi\" like '%" + TxtAraKitap.Text + "%'", baglanti);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void YbtnListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from sema.yazar";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void YbtnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into sema.yazar (\"yazarNo\",\"yazarAdi\",\"yazarSoyadi\",\"tür\",\"dogumYili\") values(@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut.Parameters.AddWithValue("@p1", int.Parse(txtYazarNo.Text));
            komut.Parameters.AddWithValue("@p2", TxtYazarAdi.Text);
            komut.Parameters.AddWithValue("@p3", TxtYazarSoyadi.Text);
            komut.Parameters.AddWithValue("@p4", TxtYazarTur.Text);
            komut.Parameters.AddWithValue("@p5", int.Parse(TxtDogumYili.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yazar Kaydı Başarıyla Gerçekleşti..!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void YbtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("delete from sema.yazar where \"yazarNo\"=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", int.Parse(txtYazarNo.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yazar Silme İşlemi Başarıyla Gerçekleşti..!");
        }

        private void YbtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("update sema.yazar set \"tür\"=@p1 where \"yazarNo\"=@p3", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtYazarTur.Text);
            komut.Parameters.AddWithValue("@p3", int.Parse(txtYazarNo.Text));
            komut.ExecuteNonQuery();
            MessageBox.Show("Yazar Başarılı Bir Şekilde Güncellendi..!");
            baglanti.Close();
        }

        private void YbtnArama_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("select * from sema.yazar where \"yazarAdi\" like '%" + TxtAraYazar.Text + "%'", baglanti);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }
    }
}
