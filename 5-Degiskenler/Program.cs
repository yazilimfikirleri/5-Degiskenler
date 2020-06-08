using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {

            // ****Sayısal Veri Tipleri ****

            //     ****Tam Sayı Veri Tipleri****

            //sbyte => s işareti signed'dan gelir. signed negatif deger alınabilecegini belirtir.

            sbyte degiskenBir = 120; //hem degişken tanımlama hem de aynı ifadede değer atama ifadesi
            //sbyte degiskenIki;
            //degiskenIki = 3;

            //byte => 

            byte degiskenIki = 2;
            //degiskenIki = 3;

            //short
            short degiskenUc = 32000;

            //ushort => unsigned (negatif deger alamaz)
            ushort degiskenDort = 32000;

            //int => aritmetik işlemler bu tipten başlar
            int degiskenBes = 10000000;

            //uint => negatif deger alamaz

            uint degiskenAlti = 3000000000;

            //long => degerlerinin sonuna L/l alabilirler. Ama büyük L olmasına özen gösterilir..
            long degiskenYedi = 3200000L;

            //ulong => negatif deger alamaz...
            ulong degiskenSekis = 9000000000;

            //****Ondalıklı Veri Tiplerimiz****

            //Ondalıklı veri tiplerinde sayıların ondalıklı kısımları . ile yazılmalıdır.

            //float => .'dan sonra 7 haneye kadar destek verebilen bir sayı tipidir. Bu degerler sonlarına F/f almalıdırlar.

            float ondalikliBir = 12.3F;

            //double => .'dan sonra 13-14 haneye kadar destek verir. Dilerseniz degerlerin sonuna D/d koyabilirsiniz ancak gerek yoktur.

            double ondalikliIki = 322.32D;

            //decimal => .'dan sonra 27-28 haneye kadar destek verir... Degerlerinin sonuna money'den gelen M/m konulabilir...

            decimal ondalikliUc = 122.34M;

            //****Metinsel Veri Tipleri****

            //char => Üzerinde tek bir karakteri barındırabilen veri tipimizdir. Aynı zamanda karakterlerin ascii kodlarını da tutabilen tek tiptir.

            char basHarf = 'ş'; //char degerler tek tırnak arasına yazılmalıdır. Ve sadece tek bir karakter olabilir.

            //string => Üzerinde ansiklopedik uzunlukta verilerden tutun da iki-tek karakterlik verilere kadar tüm metinsel ifadeleri icinde barındıran veri tipidir.

            string harf = "C"; //string degerler kesinlikle çift tırnak arasına yazılmalıdır.

            string roman = "Roman uzunluğunda paragrafların kümelendiği bir metin bile yazılabilir.";

            //******Mantıksal Veri Tipleri*********

            //bool : sadece iki deger alabilir (true,false)

            bool kayitVarmi = true;

            bool buyukMu = 19 > 2; //buyukMu isimli degişkenimize true degeri atanacaktır

            //

            /*
             
                isim = string 

                yas = byte,short,int,long

               adres => string
               boy => float,double,decimal
               ehliyet var mı => bool
             
              C#'taki = operator kesinlikle  matematikteki eşitlik operatorü degildir. Esitlik operatoru C#'ta baska bir sembolle belirtilir. = operatoru atama operatorüdür. Görevi , sagdaki veriyi soldaki alana atmaktır. Degişkenler aldıkları son degerleri tutarlar..
             
             
             */



        }
    }
}
