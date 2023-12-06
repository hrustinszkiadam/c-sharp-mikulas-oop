namespace mikulas
{
   class MikulasMuhely
   {
      public List<Ajandek> AjandekLista { get; set; }
      public Ajandek[] AjandekTomb { get; set; }
      public string MuhelyVezeto { get; set; }
      public bool MuhelyNyitva { get; set; }

      public MikulasMuhely(string muhelyVezeto)
      {
         AjandekLista = new List<Ajandek>();
         AjandekTomb = new Ajandek[] { };
         MuhelyVezeto = muhelyVezeto;
         MuhelyNyitva = false;
      }

      public void AjandekHozzaadasaListahoz(Ajandek ajandek)
      {
         AjandekLista.Add(ajandek);
      }

      public void AjandekHozzaadasaTombhoz(Ajandek ajandek, int index = -1)
      {
         if (index == -1)
         {
            AjandekTomb.ToList().Add(ajandek);
            AjandekTomb.ToArray();
         }
         else
         {
            AjandekTomb[index] = ajandek;
         }
      }

      public void BecsomagoltAjandekokMegjelenitese()
      {
         foreach (Ajandek ajandek in AjandekLista)
         {
            if (ajandek.Becsomagolva)
            {
               Console.WriteLine(ajandek.Nev);
            }
         }
      }

      public void LejartAjandekokEllenorzese()
      {
         foreach (Ajandek ajandek in AjandekLista)
         {
            if (ajandek.LejaratiDatum < DateTime.Now)
            {
               Console.WriteLine(ajandek.Nev);
            }
         }
      }

      public void TorekenyAjandekokEllenorzese()
      {
         foreach (Ajandek ajandek in AjandekLista)
         {
            if (ajandek.Torekeny)
            {
               Console.WriteLine(ajandek.Nev);
            }
         }
      }

      public void EredetiOrszagbeliAjandekokMegjelenitese(string orszag)
      {
         foreach (Ajandek ajandek in AjandekLista)
         {
            if (ajandek.GyartasiOrszag == orszag)
            {
               Console.WriteLine(ajandek.Nev);
            }
         }
      }

      public void MuhelyNyitas()
      {
         MuhelyNyitva = true;
      }

      public void MuhelyBezaras()
      {
         MuhelyNyitva = false;
      }

      public void MuhelyVezetoModositas(string ujVezeto)
      {
         MuhelyVezeto = ujVezeto;
      }

      public void AjandekTorlese(string nev)
      {
         AjandekLista.RemoveAll(ajandek => ajandek.Nev == nev);
         AjandekTomb.ToList().RemoveAll(ajandek => ajandek.Nev == nev);
      }

   }
}