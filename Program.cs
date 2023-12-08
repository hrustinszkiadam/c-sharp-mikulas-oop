using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mikulas
{
   internal class Program
   {
      static void Main(string[] args)
      {
         Ajandek torpe = new Ajandek("torpe", 3, 1000, "Petya", "jatek", false, "Torpe Inc.", 20000, "muanyag", new DateTime(2024, 8, 24), false, "Dánia");
         Ajandek pulcsi = new Ajandek("pulcsi", 1, 5000, "Józsi", "ruha", true, "Pulcsi Ltd.", 1000, "pamut", new DateTime(2022, 12, 31), false, "Németország");
         Ajandek borosUveg = new Ajandek("borosUveg", 2, 2000, "Petya", "ital", false, "Boros Uveg Kft.", 5000, "üveg", new DateTime(2023, 12, 31), true, "Magyarország");

         Console.WriteLine(torpe.Becsomagolva ? "törpe becsomagolva" : "törpe nincs becsomagolva");
         torpe.Becsomagolas();
         Console.WriteLine(torpe.Becsomagolva ? "törpe becsomagolva" : "törpe nincs becsomagolva");
         Console.WriteLine();

         Console.WriteLine(pulcsi.SzallitasiCim);
         pulcsi.Szallitas("Budapest");
         Console.WriteLine(pulcsi.SzallitasiCim);

         borosUveg.Kiszallitas();

         Console.WriteLine("torpe ára: " + torpe.Ar);
         torpe.ArModositas(2000);
         Console.WriteLine("torpe ára: " + torpe.Ar);
         Console.WriteLine();

         pulcsi.Ellenorzes();

         MikulasMuhely borsodiMuhely = new MikulasMuhely("Borsodi János", new Ajandek[10] { torpe, pulcsi, torpe, borosUveg, pulcsi, borosUveg, torpe, pulcsi, borosUveg, torpe  });

         borsodiMuhely.AjandekHozzaadasaListahoz(torpe);
         borsodiMuhely.AjandekHozzaadasaListahoz(pulcsi);
         borsodiMuhely.AjandekHozzaadasaListahoz(borosUveg);

         Console.WriteLine("Ajándékok listája:");
         foreach (Ajandek aji in borsodiMuhely.AjandekLista)
         {
            Console.WriteLine(aji.Nev);
         }
         Console.WriteLine();

         borsodiMuhely.AjandekHozzaadasaTombhoz(torpe, 1);
         borsodiMuhely.AjandekHozzaadasaTombhoz(pulcsi, 0);
         borsodiMuhely.AjandekHozzaadasaTombhoz(borosUveg);
         borsodiMuhely.AjandekHozzaadasaTombhoz(borosUveg, 2);

         Console.WriteLine("Ajándékok tömbje:");
         foreach (Ajandek aji in borsodiMuhely.AjandekLista)
         {
            Console.WriteLine(aji.Nev);
         }
         Console.WriteLine();

         borsodiMuhely.BecsomagoltAjandekokMegjelenitese();
         Console.WriteLine();
         borsodiMuhely.LejartAjandekokEllenorzese();
         Console.WriteLine();
         borsodiMuhely.TorekenyAjandekokEllenorzese();
         Console.WriteLine();

         borsodiMuhely.EredetiOrszagbeliAjandekokMegjelenitese("Magyarország");
         Console.WriteLine();
         borsodiMuhely.EredetiOrszagbeliAjandekokMegjelenitese("Németország");
         Console.WriteLine();

         borsodiMuhely.MuhelyNyitas();
         borsodiMuhely.MuhelyNyitas();
         Console.WriteLine();

         borsodiMuhely.MuhelyBezaras();
         borsodiMuhely.MuhelyBezaras();
         Console.WriteLine();

         borsodiMuhely.MuhelyVezetoModositas("Borsodi Sándor");
         Console.WriteLine();

         borsodiMuhely.AjandekTorlese("torpe");
         Console.WriteLine();
         Console.WriteLine("Ajándékok listája:");
         foreach (Ajandek aji in borsodiMuhely.AjandekLista)
         {
            Console.WriteLine(aji.Nev);
         }
         Console.WriteLine();
         Console.WriteLine("Ajándékok tömbje:");
         foreach (Ajandek aji in borsodiMuhely.AjandekTomb)
         {
            Console.WriteLine(aji.Nev);
         }

         Console.ReadKey();
      }
   }
}