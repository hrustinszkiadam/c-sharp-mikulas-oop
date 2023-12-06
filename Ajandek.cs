using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mikulas
{
   class Ajandek
   {
      public string Nev { get; set;}
      public double Suly { get; set;}
      public int Ar { get; set;}
      public string Cimzett { get; set;}
      public string Kategoria { get; set;}
      public bool Becsomagolva { get; set;}
      public string Gyarto { get; set;}
      public int RaktaronMennyiseg { get; set;}
      public string Anyag { get; set;}
      public DateTime LejaratiDatum { get; set;}
      public bool Torekeny { get; set;}
      public string GyartasiOsztaly { get; set;}
      public string SzallitasiCim { get; set;}
      public bool Kiszallitva { get; set;}

      public Ajandek(string nev, double suly, int ar, string cimzett, string kategoria, bool becsomagolva, string gyarto, int raktaronMennyiseg, string anyag, DateTime lejaratiDatum, bool torekeny, string gyartasiOsztaly, string szallitasiCim = "")
      {
         Nev = nev;
         Suly = suly;
         Ar = ar;
         Cimzett = cimzett;
         Kategoria = kategoria;
         Becsomagolva = becsomagolva;
         Gyarto = gyarto;
         RaktaronMennyiseg = raktaronMennyiseg;
         Anyag = anyag;
         LejaratiDatum = lejaratiDatum;
         Torekeny = torekeny;
         GyartasiOsztaly = gyartasiOsztaly;
         SzallitasiCim = szallitasiCim;
         Kiszallitva = false;
      }

      public void Becsomagolas()
      {
         Becsomagolva = true;
      }

      public void Szallitas(string cel = "")
      {
         if (cel != "")
         {
            SzallitasiCim = cel;
         }
      }

      public void Kiszallitas()
      {
         Kiszallitva = true;
      }

      public void ArModositas(int ujAr)
      {
         Ar = ujAr;
      }


   }
}