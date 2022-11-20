using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule_Creator
{
    public class GenereazaVaribileAtStart
    {

        public void Load()
        {
            Form1.f.creeazaOrar.NrPrimaCls = 5;
            Form1.f.creeazaOrar.NrUltimaCls = 8;

            // Numarul de Grupe al fiecarei clase
            Form1.f.creeazaOrar.listGrupePerClasa = new int[] {0,0,0,0,0,2,1,1,1};

            string nume;
            int[,] program;
            int[,] nrOrePerClasa;
            bool O_oraPerClasaPerZi;

            nume = "Nicolae Veronica";
            O_oraPerClasaPerZi = true;
            program = new int[,] {
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 }, };
            nrOrePerClasa = new int[,] {
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 2, 2 },// a 5-a
                { 1, 0 },// a 6-a
                { 1, 0 },// a 7-a
                { 2, 0 } // a 8-a
                };
            GenereazaProfesor(nume, program, nrOrePerClasa, O_oraPerClasaPerZi);

            nume = "Ionete Angela";// Mai verifica idk
            O_oraPerClasaPerZi = true;
            program = new int[,] {
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 }, };
            nrOrePerClasa = new int[,] {
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 4, 3 },// a 5-a
                { 4, 0 },// a 6-a
                { 7, 0 },// a 7-a
                { 3, 0 } // a 8-a
                };
            GenereazaProfesor(nume, program, nrOrePerClasa, O_oraPerClasaPerZi);

            nume = "Zota Diana";
            O_oraPerClasaPerZi = true;
            program = new int[,] {
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 }, };
            nrOrePerClasa = new int[,] {
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 2, 3 },// a 5-a
                { 2, 0 },// a 6-a
                { 2, 0 },// a 7-a
                { 2, 0 } // a 8-a
                };
            GenereazaProfesor(nume, program, nrOrePerClasa, O_oraPerClasaPerZi);

            nume = "Tudorica Alina";
            O_oraPerClasaPerZi = true;
            program = new int[,] {
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 }, };
            nrOrePerClasa = new int[,] {
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 4, 3 },// a 5-a
                { 2, 0 },// a 6-a
                { 2, 0 },// a 7-a
                { 2, 0 } // a 8-a
                };
            GenereazaProfesor(nume, program, nrOrePerClasa, O_oraPerClasaPerZi);

            nume = "Pilescu Emil";
            O_oraPerClasaPerZi = true;
            program = new int[,] {
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 }, };
            nrOrePerClasa = new int[,] {
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 4, 4 },// a 5-a
                { 6, 0 },// a 6-a
                { 4, 0 },// a 7-a
                { 5, 0 } // a 8-a
                };
            GenereazaProfesor(nume, program, nrOrePerClasa, O_oraPerClasaPerZi);
            
            nume = "Capalau Maria";
            O_oraPerClasaPerZi = true;
            program = new int[,] {
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 }, };
            nrOrePerClasa = new int[,] {
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },// a 5-a
                { 2, 0 },// a 6-a
                { 2, 0 },// a 7-a
                { 2, 0 } // a 8-a
                };
            GenereazaProfesor(nume, program, nrOrePerClasa, O_oraPerClasaPerZi);

            nume = "Suica Marinela";
            O_oraPerClasaPerZi = true;
            program = new int[,] {
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 }, };
            nrOrePerClasa = new int[,] {
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },// a 5-a
                { 0, 0 },// a 6-a
                { 2, 0 },// a 7-a
                { 2, 0 } // a 8-a
                };
            GenereazaProfesor(nume, program, nrOrePerClasa, O_oraPerClasaPerZi);

            nume = "Badea Valentina";
            O_oraPerClasaPerZi = true;
            program = new int[,] {
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 }, };
            nrOrePerClasa = new int[,] {
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 1, 1 },// a 5-a
                { 2, 0 },// a 6-a
                { 2, 0 },// a 7-a
                { 1, 0 } // a 8-a
                };
            GenereazaProfesor(nume, program, nrOrePerClasa, O_oraPerClasaPerZi);
            
            nume = "Stanescu Corina";
            O_oraPerClasaPerZi = true;
            program = new int[,] {
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 }, };
            nrOrePerClasa = new int[,] {
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 1, 1 },// a 5-a
                { 0, 0 },// a 6-a
                { 0, 0 },// a 7-a
                { 0, 0 } // a 8-a
                };
            GenereazaProfesor(nume, program, nrOrePerClasa, O_oraPerClasaPerZi);

            nume = "Penteleciuc";
            O_oraPerClasaPerZi = true;
            program = new int[,] {
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 }, };
            nrOrePerClasa = new int[,] {
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },// a 5-a
                { 0, 0 },// a 6-a
                { 0, 0 },// a 7-a
                { 1, 0 } // a 8-a
                };
            GenereazaProfesor(nume, program, nrOrePerClasa, O_oraPerClasaPerZi);
            
            nume = "Ciuca";
            O_oraPerClasaPerZi = true;
            program = new int[,] {
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 }, };
            nrOrePerClasa = new int[,] {
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },// a 5-a
                { 1, 0 },// a 6-a
                { 1, 0 },// a 7-a
                { 0, 0 } // a 8-a
                };
            GenereazaProfesor(nume, program, nrOrePerClasa, O_oraPerClasaPerZi);

            nume = "Teodorescu Diana";
            O_oraPerClasaPerZi = true;
            program = new int[,] {
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 }, };
            nrOrePerClasa = new int[,] {
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 1, 1 },// a 5-a
                { 1, 0 },// a 6-a
                { 1, 0 },// a 7-a
                { 2, 0 } // a 8-a
                };
            GenereazaProfesor(nume, program, nrOrePerClasa, O_oraPerClasaPerZi);

            nume = "Cernaianu";
            O_oraPerClasaPerZi = true;
            program = new int[,] {
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 }, };
            nrOrePerClasa = new int[,] {
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 1, 1 },// a 5-a
                { 1, 0 },// a 6-a
                { 1, 0 },// a 7-a
                { 1, 0 } // a 8-a
                };
            GenereazaProfesor(nume, program, nrOrePerClasa, O_oraPerClasaPerZi);

            nume = "Cantea Lucian";
            O_oraPerClasaPerZi = true;
            program = new int[,] {
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 }, };
            nrOrePerClasa = new int[,] {
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 1, 1 },// a 5-a
                { 1, 0 },// a 6-a
                { 1, 0 },// a 7-a
                { 1, 0 } // a 8-a
                };
            GenereazaProfesor(nume, program, nrOrePerClasa, O_oraPerClasaPerZi);

            nume = "Barbulescu Madalina";
            O_oraPerClasaPerZi = true;
            program = new int[,] {
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 }, };
            nrOrePerClasa = new int[,] {
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },// a 5-a
                { 0, 0 },// a 6-a
                { 0, 0 },// a 7-a
                { 3, 0 } // a 8-a
                };
            GenereazaProfesor(nume, program, nrOrePerClasa, O_oraPerClasaPerZi);

            nume = "Popescu";
            O_oraPerClasaPerZi = true;
            program = new int[,] {
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 }, };
            nrOrePerClasa = new int[,] {
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 2, 2 },// a 5-a
                { 2, 0 },// a 6-a
                { 2, 0 },// a 7-a
                { 0, 0 } // a 8-a
                };
            GenereazaProfesor(nume, program, nrOrePerClasa, O_oraPerClasaPerZi);

            nume = "Stoica Razvan";
            O_oraPerClasaPerZi = true;
            program = new int[,] {
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 }, };
            nrOrePerClasa = new int[,] {
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 1, 1 },// a 5-a
                { 1, 0 },// a 6-a
                { 1, 0 },// a 7-a
                { 1, 0 } // a 8-a
                };
            GenereazaProfesor(nume, program, nrOrePerClasa, O_oraPerClasaPerZi);

            nume = "Ciovarnache Argentina";
            O_oraPerClasaPerZi = true;
            program = new int[,] {
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 }, };
            nrOrePerClasa = new int[,] {
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 1, 1 },// a 5-a
                { 1, 0 },// a 6-a
                { 1, 0 },// a 7-a
                { 1, 0 } // a 8-a
                };
            GenereazaProfesor(nume, program, nrOrePerClasa, O_oraPerClasaPerZi);

            nume = "Florescu";
            O_oraPerClasaPerZi = true;
            program = new int[,] {
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 }, };
            nrOrePerClasa = new int[,] {
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 1, 1 },// a 5-a
                { 1, 0 },// a 6-a
                { 1, 0 },// a 7-a
                { 1, 0 } // a 8-a
                };
            GenereazaProfesor(nume, program, nrOrePerClasa, O_oraPerClasaPerZi);
        }
      

        public void GenereazaProfesor(string nume, int[,] program, int [,] nrOrePerClasa, bool O_oraPerClasaPerZi)
        {
            CreeazaOrar.Profesor prof = new CreeazaOrar.Profesor();
            prof.Nume = nume;
            prof.Program = program;
            prof.NrOrePerClasa = nrOrePerClasa;
            prof.O_oraPerClasaPerZi = O_oraPerClasaPerZi;
            prof.culoareProf = func.GetColorFromList();
            Form1.f.creeazaOrar.Profesori.Add(prof);
        }

        /*
            nume = "";
            O_oraPerClasaPerZi = true;
            program = new int[,] { 
                { 0, 0, 0, 0, 0 }, 
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 }, 
                { 0, 0, 0, 0, 0 }, 
                { 0, 0, 0, 0, 0 }, 
                { 0, 0, 0, 0, 0 }, 
                { 0, 0, 0, 0, 0 }, 
                { 0, 0, 0, 0, 0 }, };
            nrOrePerClasa = new int[,] {
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },// a 5-a
                { 0, 0 },// a 6-a
                { 0, 0 },// a 7-a
                { 0, 0 } // a 8-a
                };
            GenereazaProfesor(nume, program, nrOrePerClasa, O_oraPerClasaPerZi);
         */
    }
}
