using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {   
        static int charToInt(char x)
        {
            return x - '0';
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Sayiyi Girin");
            string sayi = Console.ReadLine();
            string[] ondalik = {"", " on", " yirmi"," otuz", " kırk", " elli", " altmış",  " yetmiş", " seksen" , " doksan"  };
            string[] rakamlar = {""," bir", " iki" , " üç", " dört", " beş", " altı", " yedi", " sekiz" , " dokuz"};
            string[] basamak = {""," bin", " milyon", " milyar"};
            int BasSayisi = sayi.Length;
            int BasamakIndex = (BasSayisi -1) / 3;
            String Kelime = "";     
            int rakam;
            bool dortbasamaklimi = false;
            if (BasSayisi == 4)
                dortbasamaklimi = true;
            for (int i = 0; i < sayi.Length; i++)
            {
                rakam = charToInt(sayi[i]);
                int tmp = BasSayisi % 3;
                switch (tmp)
                {
                    case 0:
                        if(rakam > 0)
                        {
                            if(rakam !=1)
                                Kelime += rakamlar[rakam];
                            Kelime += " yüz";
                        }
                        break;
                    case 1:
                        if(dortbasamaklimi == true && rakam == 1) { }
                        else if(rakam > 1)
                            Kelime += rakamlar[rakam];
                        Kelime += basamak[BasamakIndex];
                        BasamakIndex--;
                        break;
                    case 2:
                        if(rakam > 0)
                            Kelime += ondalik[rakam];
                        break;
                }
                BasSayisi--;
            }
            if(Kelime == "")//Sayı Sıfır ise
                Kelime = "sıfır";
            Console.WriteLine(Kelime);
            Console.ReadKey();
        }
    }
}