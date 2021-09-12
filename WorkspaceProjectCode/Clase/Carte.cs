using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkspaceProjectCode.Clase
{
    class Carte
    {
        //*************************************1. DEFINIRE ATRIBUTE***************************************************************************
        private string denumire;
        private List<String> autor;
        private string editura;
        private int anAparitie;
        private bool esteImprumutata;
        private DateTime dataImprumut;
        private int[] ISBN;
        private float pret;
        private char cutieDepozitare;

        private static int contorCartiDinBiblioteca;

        //*************************************2. CONSTRUCTOR FARA PARAMETRI******************************
        public Carte()
        {
            this.denumire = "Necunoscut";
            this.autor = new List<string>(new string[] { "Agatha Cristie", "Dan Brown" });
            this.editura = "Necunoscuta";
            this.anAparitie = 2021;
            this.esteImprumutata = false;
            this.dataImprumut = System.DateTime.Now;
            this.ISBN = new int[] { 973, 95056, 0, 6 };
            this.pret = 0.0f;
            this.cutieDepozitare = '1';

            contorCartiDinBiblioteca++;

        }
        //*************************************2. CONSTRUCTOR CU PARAMETRI - LA VECTORI TREBUIE DEEP COPY*************************************
        public Carte(string denumire, List<String> autor, string editura, int anAparitie, bool esteImprumutata, 
                     DateTime dataImprumut, int[] ISBN, float pret, char cutieDepozitare)
        {
            //*************************************** LISTA* *************************
            this.autor = new List<string>();
            foreach (String s in autor)
            {
                this.autor.Add(s);
            }

            //************************************* VECTOR *****************************
            // DEEP COPY - VARIANTA 1 - CLASICA
            this.ISBN = new int[ISBN.Length];
            for(int i = 0; i < ISBN.Length; i++)
            {
                this.ISBN[i] = ISBN[i];
            }

            //DEEP COPY - VARIANTA 2 - CLONE
            this.ISBN = (int[])ISBN.Clone();

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
    }
}
