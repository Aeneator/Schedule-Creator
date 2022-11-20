using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Schedule_Creator
{
    public class CreeazaOrar
    {
        // Structura Profesor
        public class Profesor
        {
            public string Nume { get; set; }

            public int[,] Program { get; set; }

            public int[,] NrOrePerClasa { get; set; }

            public bool O_oraPerClasaPerZi { get; set; }

            public Color culoareProf { get; set; }

        }

        // Lista Profesorilor
        public List<Profesor> Profesori = new List<Profesor>();

        // Numarul de Clase
        public int NrPrimaCls, NrUltimaCls;

        // Numarul de Grupe al fiecarei clase
        public int[] listGrupePerClasa = new int[1000];


        // Lista orarelor
        public List<Orar> orare = new List<Orar>();

        // Numarul de orare
        public int IndexOrare = 0;

        // Structura Orarului
        public struct Orar
        {
            public string[,] M { get; set; }
        }

        public void Start()
        {
            //LoopClase();
            LoopProfesori();
        }

        public void LoopProfesori()
        {

            for (int i = NrPrimaCls; i <= NrUltimaCls; i++)
            {
                for (int j = 0; j < listGrupePerClasa[i]; j++)
                {
                    Orar o = new Orar();
                    string[,] orar = new string[8, 5];
                    o.M = orar;
                    orare.Add(o);
                    IndexOrare++;
                }
            }


            foreach (Profesor prof in Profesori)
            {
                var O_oraPeZiValoareInitiala = prof.O_oraPerClasaPerZi;
                int c = 0;
                
                for (int i = NrPrimaCls; i <= NrUltimaCls; i++)
                {
                    for (int j = 0; j < listGrupePerClasa[i]; j++)
                    {
                        if (prof.NrOrePerClasa[i, j] != 0)
                        {

                            prof.O_oraPerClasaPerZi = O_oraPeZiValoareInitiala;

                            for (int a = 0; a < 7; a++)
                            {
                                for (int b = 0; b < 5; b++)
                                {
                                    if (prof.O_oraPerClasaPerZi && MaiAreOreLaClasaPeZi(orare[c].M, prof.Nume, b))
                                    {
                                        if (prof.NrOrePerClasa[i, j] != 0 && a == 6 && b == 4)
                                        {
                                            Console.WriteLine(prof.Nume + " a pierdut optiunea de O ora per clasa per zi pentru clasa " + i + func.IntToLetter(j));
                                            a = 0;
                                            prof.O_oraPerClasaPerZi = false;
                                            break;
                                        }
                                        else
                                            continue;
                                    }

                                    if (orare[c].M[a, b] == null && prof.Program[a, b] == 0 && prof.NrOrePerClasa[i, j] != 0)
                                    {
                                        orare[c].M[a, b] = prof.Nume;
                                        prof.NrOrePerClasa[i, j] -= 1;
                                        prof.Program[a, b] = 1;

                                    }

                                    VerificaFinalOrar(prof, i, j, a, b);

                                }
                            }
                        }
                        c++;
                    }
                   
                       
                }
            }
        }

        public bool MaiAreOreLaClasaPeZi(string[,]orar,string nume, int zi)
        {
            for (int i = 0; i < 7; i++)
                if (orar[i,zi] == nume)
                    return true;

            return false;
        }

        public void VerificaFinalOrar(Profesor prof, int clasa, int grupa, int i, int j)
        {
            if (i == 6 && j == 4)
            {
                if (prof.NrOrePerClasa[clasa, grupa] != 0)
                    Console.WriteLine("Atentie, " + prof.Nume + " are " + prof.NrOrePerClasa[clasa, grupa] + " ore neatribuite la clasa "+clasa+func.IntToLetter(grupa));
            }
        }

        public string[,] populeazaLista(int clasa, int grupa)
        {

            string[,] orar = new string[8, 5];

            for (int a = 0; a < 7; a++)
            {
                for (int b = 0; b < 5; b++)
                {
                    orar[a, b] = "Clasa a " + clasa + "-a " + func.IntToLetter(grupa) + " | " + a + " " + b;
                }
            }

            return orar;
        }

        /*
      public void LoopClase(){

          for (int i = NrPrimaCls; i <= NrUltimaCls; i++)
          {
              for (int j = 0; j<listGrupePerClasa[i]; j++)
              {
                  Orar o = new Orar();

                  string[,] orar = new string[8, 5];

                  foreach (Profesor prof in Profesori)
                  {
                      if (prof.NrOrePerClasa[i, j] != 0)
                      {
                          for (int a = 0; a < 7; a++)
                          {
                              for (int b = 0; b < 5; b++)
                              {
                                  if (orar[a, b] == null && prof.Program[a, b] == 0 && prof.NrOrePerClasa[i, j] != 0)
                                  {
                                      orar[a, b] = prof.Nume;
                                      prof.NrOrePerClasa[i, j] -= 1;
                                      prof.Program[a, b] = 1;

                                  }
                                  Console.WriteLine("Multa muite");
                                  //VerificaFinalOrar(prof, a, b);
                              }
                          }
                      }
                  }

                  o.M = orar;
                  orare.Add(o);
                  IndexOrare++;
              }
          }

      }
      */


    }



}
