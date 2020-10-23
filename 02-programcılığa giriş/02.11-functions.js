var deger="Deger"//global bir değişken olduğu için her yerden erişilebilir
function sayiUret(ustLimit=49){//default değer verilirse parametre verilmediği zaman varsayılan değer tercih edilir
    console.log(deger)
    return Math.ceil(Math.random() *ustLimit)
}
console.log(deger)
//console.log(ustLimit)//fonksiyon içeriğinde tanımlanan değişken global olmadığı için ana programdan erişilemez
var sayi1=sayiUret()
var sayi2=sayiUret(60)
var sayi3=sayiUret()
var sayi4=sayiUret(30)
var sayi5=sayiUret(49)
var sayi6=sayiUret(60)
//her yerde değişiklik yapmak istediğimiz için fonksiyonlar bu konuda bize yardımcı oluyor


console.log("Kolon: "+sayi1+" "+sayi2+" "+sayi3+" "+sayi4+" "+sayi5+" "+sayi6)
