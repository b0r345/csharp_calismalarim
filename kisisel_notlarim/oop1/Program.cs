using System;
class Ev
{
    public int kapiNo;
    public string sokakAdi;
}


class Uygulama
{
    static public void Main(string[] args)
    {
        Ev ilkEv;//referans tanımlama yaptık
        //soyut olarak ilkEv diye bellekte yer gösterici bir referans tanımladık
        ilkEv = new Ev();//instance (yani nesne tanımlamasını new operatörü ile somut hale çevirdik)
                         //bunu aşağıda ki gibi tek satırda da yapabilirdik burda açık bir şekilde ifade etmek için iki ayrı şekilde oluşturduk
        //Ev ilkEv=new Ev();//referans noktası ve nesneyi aynı anda oluşturmuş olduk  
        ilkEv.kapiNo = 123;
        ilkEv.sokakAdi = "Menekşe sk";
        Ev sonEv=new Ev();
        sonEv.kapiNo = 146;
        sonEv.sokakAdi = "Sırt sk";
        Console.WriteLine("Adres:" + ilkEv.sokakAdi + " Sokak, No: " + ilkEv.kapiNo);//burda kullanılan + stringlerde birleştirme işlemi yapar
        //sayısal ifadelerde ise toplama işlemi yapar. farklı veri türlerine göre farklı görev alan bu operatörlere (overloaded operator) denir
        Console.WriteLine("Adres: {1} Sokak, No: {0}",sonEv.kapiNo,sonEv.sokakAdi);//burda ise yer tutucu {} operatör ile yazdırılmıştır

    }
}


