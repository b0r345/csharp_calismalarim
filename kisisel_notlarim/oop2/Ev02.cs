using System;

class Ev02
{
    static public void Main(string[] args)
    {
        Ev ev1 = new Ev();
        ev1.sokakAdi = "Sırt Sk";
        Console.WriteLine(ev1.kapiNo);//eğer class değişkeninde bir değer yoksa default değerini yazar
        //eğer class içerğinde tanımlanan değer varsa onu yazdırır. class attribute değerlerini değiştirebiliriz
        Console.WriteLine(ev1.daireNo);//burda daire no ya atama yapılmadığı için ve default değeri 0 olduğundan ekrana 0 yazdırır.
        Ev ev2 = new Ev();
        ev2.kapiNo = 146;
        ev2.sokakAdi = "Sırt Sk.";
        //Aynı sokakta birden fazla ev olabilir bu yüzden her nesne yaratıldığında bellekte onlar için ayrı yer ayrılır
        //içeriğinde aynı değişken değerlerini saklayabilir.
    }
}

class Ev
{
    public int kapiNo=444;//bir sınıfın öğelerine dış dünyadan erişilmesi olayına kapsülleeme(encapsulation) ismi verilir
    public int daireNo;//hangi değişkene nereden erişileceği ve ne gibi işlemler yapılacağı erişim belirteçleri ile belirlenir
    public  string sokakAdi;
}