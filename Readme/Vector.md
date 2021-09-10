# 3. Vector

1️⃣**PAS 1: DECLARARE VECTOR**</br>
**Vectorul este alocat in HEAP si initializat la declarare automat cu acele 4 valori.**

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkspaceProjectCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Declarare vector
            int[] vector1 = { 1, 2, 3, 4 };
        }
    }

}
```

2️⃣**PAS 2: TRAVERSARE SI AFISARE VECTOR 1**</br>
*Nu mai exista acel n pe care il foloseam in for, ci vectorii sunt subclase ale unei clase de baza care se numeste Array. De acolo ei mostenesc o serie de metode si proprietati printre care si `PROPRIETATEA LENGTH`*.</br>
**❗ ATENTIE ! Diferenta dintre propritatea (cheie) si metoda(cub) este ca proprietatea nu are paranteza ().**</br>
**Scopul proprietatii LENGTH este sa imi returneze numarul de elemente din structura.**
```Csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkspaceProjectCode
{
    class Program
    {
        static void Main(string[] args)
        {
              //1. Declarare vector1
            int[] vector1 = { 1, 2, 3, 4 };
            
            //2. Traversare si afisare vector
             Console.WriteLine("Vector 1: ");

              for (int i = 0; i < vector1.Length; i++)
                  { 
                   Console.WriteLine(vector1[i]);
                  }
        }
    }

}
```

3️⃣**PAS 3: DECLARARE VECTOR 2**</br>
**Vector 2 este identic cu Vector 1 pentru ca si Vector1 si Vector2 sunt 2 vectori alocati in HEAP, chiar daca la unul apare NEW, iar la celalalt nu apare. Totodata sunt initializati cu aceleasi valori.**
```Csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkspaceProjectCode
{
    class Program
    {
        static void Main(string[] args)
        {
              //1. Declarare Vector 1
            int[] vector1 = { 1, 2, 3, 4 };
            
            //2. Traversare si afisare Vector 1
            Console.WriteLine("Vector 1: ");

            for (int i = 0; i < vector1.Length; i++)
               {
                 Console.WriteLine(vector1[i]);
               }
                
                //3. Declarare Vector 2
                int[] vector2 = new int[4] { 1, 2, 3, 4 };
        }
    }

}
```
