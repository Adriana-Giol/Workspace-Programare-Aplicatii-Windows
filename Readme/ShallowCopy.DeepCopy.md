# 4. Shallow Copy vs. Deep Copy
## 🎯 SHALLOW COPY </br>
- **Declar o noua referinta vector3 (adica un nou vector), dar vreau sa fie initializat cu valaorea vectorului vector2.**</br>
- **❗ ATENTIE -> In C# `operatorul=` NU se supraincarca deoarece el face doar copie de referinta (de adresa). Adica imi copiaza adresa spatiului de memorie aferent vectorului vector2 catre referinta vector3 - adica si vector3 si vector2 vor referi acelasi spatiu de memorie.**

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
         //Shallow Copy
            //1. Declarare vector3 si initializarea lui cu valoarea vectorului vector2
            int[] vector3 = vector2;
         }
     }
}
```

- **Asta inseamna ca daca modific vector2 atunci o sa se modifice si vector3.**

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
         //Shallow Copy
            //1. Declarare vector3 si initializarea lui cu valoarea vectorului vector2
            int[] vector3 = vector2;
            
            //2. Modicare vector2
                vector2[1] = 10;
            
         }
     }
}
```

- **Il afisam pe vector3 pentru a vedea ca intr-adevar s-a modificat si el.**

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
         //Shallow Copy
            //1. Declarare vector3 si initializarea lui cu valoarea vectorului vector2
            int[] vector3 = vector2;
            
            //2. Modicare vector2
                vector2[1] = 10;
            
            //3. Afisarea vectorului vector3
            for (int i = 0; i < vector3.Length; i++)
                 {
                   Console.WriteLine(vector3[i]);
                 }
         }
     }
}
```

## 🎯 DEEP COPY </br>
## 🅰️ Varianta A - Varianta Clasica
1️⃣**PAS 1: Declararea vectorului vector4 si alocarea unui nou spatiu de memorie de aceeasi dimensiune ca a vectorului vector2.**</br>

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
         //Deep Copy - Varianta 1 - Clasica
            //1. Declarare vector4 si alocarea spatiului de memorie
               int[] vector4 = new int[vector2.Length];
         }
     }
}
```

2️⃣**PAS 2: Copiere element cu element: din vectorul vector2 in vectorul vector4.**</br>
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
         //Deep Copy - Vsrianta 1 - Clasica
            //1. Declarare vector4 si alocarea spatiului de memorie
               int[] vector4 = new int[vector2.Length];
               
           //2. Copiere element cu element di vector2 in vector4
             Console.WriteLine("Vector 4 inainte de modificare: ");
               for (int i = 0; i < vector2.Length; i++)
                    {
                      vector4[i] = vector2[i];
                    }
         }
     }
}
```

3️⃣**PAS 3: Daca modific valoarea lui vector2 ca sa ia valoarea 20, vector4 o sa ramana cu valoarea initiala adica 10.**</br>
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
         //Deep Copy - Varianta 1 - Clasica
            //1. Declarare vector4 si alocarea spatiului de memorie
               int[] vector4 = new int[vector2.Length];
               
           //2. Copiere element cu element di vector2 in vector4
             Console.WriteLine("Vector 4 inainte de modificare: ");
               for (int i = 0; i < vector2.Length; i++)
                    {
                      vector4[i] = vector2[i];
                    }
          
          //3. Modificare vector2 pentru a vedea ca vector4 nu se modifica
            vector2[1] = 20;
               Console.WriteLine("Vector 4 dupa modificare: ");
                 for (int i = 0; i < vector4.Length; i++)
                     {
                        Console.WriteLine(vector4[i]);
                     }
         }
     }
}
```

## 🅱️ Varianta B - Metoda Clone
1️⃣**PAS 1: Declarare vector vector4 si alocare spatiu.**</br>
**Metoda Clone este mostenita automat din clasa Array care implementeaza interfata ICloneable - si returneaza un object.**</br>
**Aceasta linie face tot ce am scris in Varianta A de mai sus.**</br>

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
         //Deep Copy - Vsrianta 2 - Moteda Clone
            //1. Declarare vector5, alocarea unui nou spatiu de memorie si copiere elementelor din vector2 si in vector5
             int[] vector5 = (int[])vector2.Clone();
         }
     }
}
```


2️⃣**PAS 2: Daca modificam valoarea lui vector2 si il afisam din nou , vector5 ar trebui sa fie cu valoarea 20, iar vector2 cu valoarea 100.**
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
         //Deep Copy - Vsrianta 2 - Moteda Clone
            //1. Declarare vector5, alocarea unui nou spatiu de memorie si copiere elementelor din vector2 si in vector5
             int[] vector5 = (int[])vector2.Clone();
             
             //2. Modificare vector2 si afisare vector5
             vector2[1] = 100;
             Console.WriteLine("Vector 5 dupa modificare: ");
             for (int i = 0; i < vector5.Length; i++)
                  {
                    Console.WriteLine(vector5[i]);
                   }
         }
     }
}
```
**⚠️ Deci Shallow Copy partajeaza acelasi spatiu de memorie, iar Deep Copy nu partajeaza acelasi spatiu de memorie!**
