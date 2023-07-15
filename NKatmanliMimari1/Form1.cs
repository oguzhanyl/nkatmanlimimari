using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using EntityLayer;
using LogicLayer;

namespace NKatmanliMimari1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<EntityPersonel> PerList = LogicPersonel.LLPersonelListesi();
            dataGridView1.DataSource = PerList;
        }

        private void BTNEKLE_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Ad = Txtad.Text;
            ent.Soyad = Txtsoyad.Text;
            ent.Maas = short.Parse(Txtmaas.Text);
            ent.Gorev = Txtgorev.Text;
            ent.Sehir = Txtsehir.Text;
            LogicPersonel.LLPersonelEkle(ent);
        }

        private void Btnsil_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Id = Convert.ToInt32(textBox1.Text);
            LogicPersonel.LLPersonelSil(ent.Id);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Id = Convert.ToInt32(textBox1.Text);
            ent.Ad = Txtad.Text;
            ent.Soyad = Txtsoyad.Text;
            ent.Maas = short.Parse(Txtmaas.Text);
            ent.Gorev = Txtgorev.Text;
            ent.Sehir = Txtsehir.Text;
            LogicPersonel.LLPersonelGuncelle(ent);
        }
    }
}
