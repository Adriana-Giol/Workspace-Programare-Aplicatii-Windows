using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkspaceProjectCode.Clase
{
    class Carte : ICloneable, IComparable
    {
        //************************************* DEFINIRE ATRIBUTE***************************************************************************
        private string denumire;
        private List<String> autor;
        private string editura;
        private int anAparitie;
        private bool esteImprumutata;
        private DateTime dataImprumut;
        private int[] isbn;
        private float pret;
        private char cutieDepozitare;
        private int[] nrZileImprumutata;

        private static int contorCartiDinBiblioteca;




        //************************************* CONSTRUCTOR FARA PARAMETRI******************************
        public Carte()
        {
            this.denumire = "Necunoscut";
            this.autor = new List<string>(new string[] { "Agatha Cristie", "Dan Brown" });
            this.editura = "Necunoscuta";
            this.anAparitie = 2021;
            this.esteImprumutata = false;
            this.dataImprumut = System.DateTime.Now;
            this.isbn = new int[] { 973, 95056, 0, 6 };
            this.pret = 0.0f;
            this.cutieDepozitare = '1';

            contorCartiDinBiblioteca++;

        }
        //************************************* CONSTRUCTOR CU PARAMETRI - LA VECTORI TREBUIE DEEP COPY*************************************
        public Carte(string denumire, List<String> autor, string editura, int anAparitie, bool esteImprumutata,
                     DateTime dataImprumut, int[] ISBN, float pret, char cutieDepozitare, int[] nrZileImprumutata)
        {
            //*************************************** LISTA* *************************
            this.autor = new List<string>();
            foreach (String s in autor)
            {
                this.autor.Add(s);
            }

            //************************************* VECTOR *****************************
            // DEEP COPY - VARIANTA 1 - CLASICA
            this.isbn = new int[isbn.Length];
            for (int i = 0; i < isbn.Length; i++)
            {
                this.isbn[i] = isbn[i];
            }

            //DEEP COPY - VARIANTA 2 - CLONE
            this.nrZileImprumutata = (int[])nrZileImprumutata.Clone();

            //************************************** ATRIBUTE SIMPLE***********************************
            this.denumire = denumire;
            this.editura = editura;
            this.anAparitie = anAparitie;
            this.esteImprumutata = esteImprumutata;
            this.dataImprumut = dataImprumut;
            this.pret = pret;
            this.cutieDepozitare = cutieDepozitare;

            contorCartiDinBiblioteca++;
        }

        //******************************************  ICLONEABLE - CLONE() *************************************
        public object Clone()
        {
            //DACA AVEM DOAR ATRIBUTE SIMPLE
            //return this.MemberwiseClone(); //daca lasam doar asa nu o sa stie sa copieze lista de string-uri

            Carte clona = (Carte)this.MemberwiseClone();

            //PENTRU LISTA
            List<string> autorNou = new List<string>();
            foreach (String s in autor)
            {
                autorNou.Add((string)s.Clone());
            }
            clona.autor = autorNou;

            //PENTRU VECTOR
            int[] ISBNnou = (int[])isbn.Clone();
            clona.isbn = ISBNnou;

            int[] imprumutNou= (int[])nrZileImprumutata.Clone();
            clona.nrZileImprumutata = imprumutNou;
            return clona;
        }

        //*************************************  ICOMPARABLE - COMPARE TO() ***************************************
        // COMPARE TO PENTRU STRING
        public int CompareTo(object obj)
        {
            Carte c = (Carte)obj;  //facem CAST

            string denumire1 = this.denumire;
            string denumire2 = c.denumire;

            if (denumire1.Equals(denumire2, StringComparison.OrdinalIgnoreCase))
            {
                return 1; //true
            }
            else
            {
                return -1;//false;
            }

        }

        //COMPARE TO PENTRU  INT/FLOAT
        /* public int CompareTo(object obj)
           {
               Carte c = (Carte)obj;
               if (this.pret < c.pret)
                   return -1;
               else
                   if (this.pret > c.pret)
                   return 1;
               else
                   return 0; // daca fac compararea dupa un singur criteriu
               return string.Compare(this.denumire, c.denumire); // daca vreau sa fac compararea dupa 2 criterii
           }*/

        //*******************************************  PROPRIETATI *************************************************
        public string Denumire { get => denumire; set => denumire = value; }
        public List<string> Autor { get => autor; set => autor = value; }
        public string Editura { get => editura; set => editura = value; }
        public int AnAparitie { get => anAparitie; set => anAparitie = value; }
        public bool EsteImprumutata { get => esteImprumutata; set => esteImprumutata = value; }
        public DateTime DataImprumut { get => dataImprumut; set => dataImprumut = value; }
        public int[] Isbn { get => isbn; set => isbn = value; }
        public float Pret { get => pret; set => pret = value; }
        public char CutieDepozitare { get => cutieDepozitare; set => cutieDepozitare = value; }
        public int[] NrZileImprumutata { get => nrZileImprumutata; set => nrZileImprumutata = value; }


        //******************************************* FUNCTIE DE AFISARE CLASICA *************************
        public void afisare()
        {
            Console.WriteLine("Cartea {0} de la editura {1} costa {2}", denumire, editura, pret);
        }

        //****************************************** TO STRING ***************************************************
        public override string ToString()
        {
            //Afisare pentru lista
            string afisare1 = "Cartea cu autorii: ";
            foreach (string s in autor)
            {
                afisare1 += s.ToString();
            }

            //Afisare pentru vector
            if (isbn != null)
            {
                afisare1 += " are urmatorul ISBN: ";
                for (int i = 0; i < isbn.Length; i++)
                    afisare1 += isbn[i] + Environment.NewLine;
            }
            else
                afisare1 += " .";

            if(nrZileImprumutata != null)
            {
                afisare1 += "Cartea a fost imprumutata de ";
                for (int i = 0; i < nrZileImprumutata.Length; i++)
                    afisare1 += nrZileImprumutata[i] + Environment.NewLine;
            }

            //Afisare pentru atribute normale
            string afisare2= "Cartea " + denumire + ","
                    + " este imprumutata = " + esteImprumutata + " de la data de " + dataImprumut
                    + " fiind tiparita la editura " + editura
                    + " in anul " + anAparitie
                    + " si avand pretul de " + pret + " lei."
                    + " Aceasta se afla depozitata in cutia " + cutieDepozitare;


            return afisare1 += afisare2;
        }

        //******************************************************* OPERATOR + ****************************************************************
        //                           OPERATOR + - VECTOR
        public static Carte operator +(Carte carte, int imprumutNou)
        {
            int [] imprumuturiNoi = new int[carte.nrZileImprumutata.Length + 1];
            for (int i = 0; i < carte.nrZileImprumutata.Length; i++)
                imprumuturiNoi[i] = carte.nrZileImprumutata[i];
            imprumuturiNoi[imprumuturiNoi.Length - 1] = imprumutNou;
            carte.nrZileImprumutata = imprumuturiNoi;
            return carte;
        }
        //Operator + comutativ
        public static Carte operator +(int imprumutNou, Carte carte)
        {
            return carte + imprumutNou;
        }

        //OPERATOR ++ - APELEAZA OPERATORUL + DE MAI SUS SI ADAUGA SALRIUL 250.9
        public static Carte operator ++(Carte carte)
        {
            return carte + 30;
        }

        //CAST
        public static explicit operator int(Carte carte)
        {
            if (carte.nrZileImprumutata != null)
            {
                int zile = 0;
                for (int i = 0; i < carte.nrZileImprumutata.Length; i++)
                    zile += carte.nrZileImprumutata[i];
                return (int)zile / carte.nrZileImprumutata.Length;
            }
            else
                return 0;
        }
    }
}
