namespace mikulas
{
   class MikulasMuhely
   {
      private List<Ajandek> ajandekLista;
      private Ajandek[] ajandekTomb;
      private string muhelyVezeto;
      private bool muhelyNyitva;

      public MikulasMuhely(string muhelyVezeto, Ajandek[] ajandekTomb)
      {
         ajandekLista = new List<Ajandek>();
         this.ajandekTomb = ajandekTomb;
         this.muhelyVezeto = muhelyVezeto;
         Array.Copy(ajandekTomb, this.ajandekTomb, ajandekTomb.Length);
         this.muhelyVezeto = muhelyVezeto;
         muhelyNyitva = false;
      }

      public List<Ajandek> AjandekLista
      {
         get { return ajandekLista; }
      }

      public Ajandek[] AjandekTomb
      {
         get { return ajandekTomb; }
      }

      public string MuhelyVezeto
      {
         get { return muhelyVezeto; }
      }

      public bool MuhelyNyitva
      {
         get { return muhelyNyitva; }
      }

      public void AjandekHozzaadasaListahoz(Ajandek ajandek)
      {
         ajandekLista.Add(ajandek);
      }

      public void AjandekHozzaadasaTombhoz(Ajandek ajandek, int index = -1)
      {
         if (index == -1)
         {
            ajandekTomb.ToList().Add(ajandek);
            ajandekTomb.ToArray();
         }
         else
         {
            ajandekTomb[index] = ajandek;
         }
      }

      public void BecsomagoltAjandekokMegjelenitese()
      {
         Console.WriteLine("Becsomagolt ajándékok:");
         foreach (Ajandek ajandek in ajandekLista)
         {
            if (ajandek.Becsomagolva)
            {
               Console.WriteLine(ajandek.Nev);
            }
         }
      }

      public void LejartAjandekokEllenorzese()
      {
         Console.WriteLine("Lejárt ajándékok:");
         foreach (Ajandek ajandek in ajandekLista)
         {
            if (ajandek.LejaratiDatum < DateTime.Now)
            {
               Console.WriteLine(ajandek.Nev);
            }
         }
      }

      public void TorekenyAjandekokEllenorzese()
      {
         Console.WriteLine("Törékeny ajándékok:");
         foreach (Ajandek ajandek in ajandekLista)
         {
            if (ajandek.Torekeny)
            {
               Console.WriteLine(ajandek.Nev);
            }
         }
      }

      public void EredetiOrszagbeliAjandekokMegjelenitese(string orszag)
      {
         Console.WriteLine($"{orszag} országbéli ajándékok:");
         foreach (Ajandek ajandek in ajandekLista)
         {
            if (ajandek.GyartasiOrszag == orszag)
            {
               Console.WriteLine(ajandek.Nev);
            }
         }
      }

      public void MuhelyNyitas()
      {
         if (muhelyNyitva)
         {
            Console.WriteLine("A műhely már nyitva van.");
         }
         else
         {
            muhelyNyitva = true;
            Console.WriteLine("A műhely nyitva van.");
         }
      }

      public void MuhelyBezaras()
      {
         if (!muhelyNyitva)
         {
            Console.WriteLine("A műhely már zárva van.");
         }
         else
         {
            muhelyNyitva = false;
            Console.WriteLine("A műhely zárva van.");
         }
      }

      public void MuhelyVezetoModositas(string ujVezeto)
      {
         muhelyVezeto = ujVezeto;
         Console.WriteLine("A műhely vezetője: " + muhelyVezeto);
      }

      public void AjandekTorlese(string nev)
      {
         ajandekLista.RemoveAll(ajandek => ajandek.Nev == nev);
         ajandekTomb.ToList().RemoveAll(ajandek => ajandek.Nev == nev);
         Console.WriteLine($"{nev} törölve lett.");
      }

   }
}