# 🎯 V. MASIVE BI-DIMENSIONALE </br>
**Sunt doua forme de masive bi-dimensionala utilizate in C#:**</br>
    A. Masive bi-dimensionale - cu n linii si m coloane</br>
    B. Masive bi-dimensionale - masiv in scara (zig-zag)</br>
    
## 🅰️ Varianta A - Matrice cu n linii si m coloane
1️⃣**PAS 1: DECLARARE masiv cu n  linii si m coloane**</br>
```Csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 
{
    class Program
    {
        static void Main(string[] args)
        {
          //1. Declarare masiv cu n linii si m coloane         
            int[,] matrice1 = new int[2, 3] { { 10, 20, 30 }, { 40, 50, 60 } };
        }
    }

}
           
```

2️⃣**PAS 2: Traversare matrice cu n linii si m coloane**</br>
-  **Daca dau matrice1.Lenght imi da cate elemente sunt in total deoarece un masiv reprezinta un spatiu contiguu de memorie unde avem liniile dispuse una in continuarea celeilalte 
 => eu am 2 linii - 3 coloane = 6 elemente**</br>
 
**EXEMPLU matrice1** </br>
**[ 10 20 30 ]**   </br>
**[ 40 50 60 ]**   </br>

- **Pentru acest lucru avem metoda GetLenght(0) = metoda face parte tot din clasa Array care pentru fiecare dimensiune a masivului cu mai multe 
dimensiuni, getLenght(0) inseamna nr de elemente pentru prima dimensiune => Adica numarul de elemente pe linii.**
 
 ```Csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 
{
    class Program
    {
        static void Main(string[] args)
        {
          //1. Declarare masiv cu n linii si m coloane         
            int[,] matrice1 = new int[2, 3] { { 10, 20, 30 }, { 40, 50, 60 } };
            
          //2. Traversare matrice cu n linii si m coloane
            for (int i = 0; i < matrice1.GetLength(0); i++)
                {
                  for (int j = 0; j < matrice1.GetLength(1); j++)
                      {
                        Console.Write("{0} ", matrice1[i, j]);
                      }
                  Console.WriteLine();
                }
        }
    }

}
     
 ```
 

            

## 🅱️ Varianta B - MASIV IN ZIG ZAG (SCARA)
1️⃣**PAS 1: DECLARARE masiv in scara**</br>

 ```Csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 
{
    class Program
    {
        static void Main(string[] args)
        {
          //1. Declarare masiv in scara si alocare spatiu        
            int[][] matrice2 = new int[2][];
            matrice2[0] = new int[2] { 10, 20 };
            matrice2[1] = new int[3] { 30, 40, 50 };
        }
    }

}
     
 ```


2️⃣**PAS 2: Traversare matrice in scara**</br>
**De data aceasta masivul este vazut ca vectori de vectori si se poate apela si proprietatea Length si pe linii si pe coloane.** </br>   

 ```Csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 
{
    class Program
    {
        static void Main(string[] args)
        {
          //1. Declarare masiv in scara si alocare spatiu        
            int[][] matrice2 = new int[2][];
            matrice2[0] = new int[2] { 10, 20 };
            matrice2[1] = new int[3] { 30, 40, 50 };
            
          //2. Traversare si afisare matrice in scara
          for (int i = 0; i < matrice2.Length; i++)
              {
                for (int j = 0; j < matrice2[i].Length; j++)
                   {
                      Console.Write("{0} ", matrice2[i][j]);
                   }
                 Console.WriteLine();
               }
        }
    }

}
     
 ```
