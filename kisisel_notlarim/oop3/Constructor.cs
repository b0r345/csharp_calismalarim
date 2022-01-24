using System;

class Ev
{
    public static int kapiNo;
    //eğer bir sınıfta değişken static olarak tanımlanmışsa ona nesne işaretçisi ile değil sınıf işaretçisi ile erişilebilir
    //static olarak tanımlanan attribute nesnenin bulunduğu bellekte yer almaz o yüzden nesne işaretçisi ile erişilemez
    public string sokakAdi;
}

class Uygulama
{
    static public void Main(string[] args)
    {
        //Ev isminde bir nesne tanımlamadığımız halde program bunu kendisi yapar buna default constractor denir static değişkenlere bununla erişilir
        Ev.kapiNo = 123;//sınıf işaretçisi
        Ev ev1 = new Ev();
        ev1.sokakAdi = "Sırt Sk";//nesne işaretçisi

    }
}