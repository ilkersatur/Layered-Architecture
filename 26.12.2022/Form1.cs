using Model;
using PersonelBLL;
namespace _26._12._2022
{
    public partial class Form1 : Form
    {
        PersonelBLL.PersonelBLL bll;
        public Form1()
        {
            InitializeComponent();
            bll = new PersonelBLL.PersonelBLL();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bll.Personeller();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel() { Ad = "tas", Soyad = "asd", BolumID = 4 };
            bll.Ekle(personel);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bll.Personeller(int.Parse(textBox1.Text));
        }
    }
}