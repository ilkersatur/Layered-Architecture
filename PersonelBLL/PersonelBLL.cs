using DAL;
using Model;
namespace PersonelBLL
{
    //DAL ve Model layer ekledik
    public class PersonelBLL
    {
        PersonelDAL dal;
        public PersonelBLL()
        {
            dal=new PersonelDAL();
        }
        public List<Personel> Personeller()
        {
            return dal.TumPersoneller();
        }
        public List<Personel> Personeller(int bolumID)
        {
            //LINQ Sorugusu
            //Expression Tree 
            return dal.TumPersoneller().Where(b=>b.BolumID==bolumID).ToList();
            
        }
        public void Ekle(Personel personel)
        {
            dal.PersonelEkle(personel);
        }
    }
}