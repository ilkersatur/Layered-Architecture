namespace Model
{
    //Verileri tutan sınıf
    //SQL tablo sayısı kadar model oluşturulur
    //Doğrudan çalıştıralamaz
    public class Personel
    {
        public int PerID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int BolumID { get; set; }
    }
}