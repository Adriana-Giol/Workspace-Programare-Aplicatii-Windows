# 2. Scriere si citire pentru aplicatii de tip Consola App

1️⃣**PAS 1: SCRIERE: Afisare mesaj pe ecran se face cu Cout = Console.WriteLine():**</br>
 - **Console este o clasa.**</br>
 - **Write() este metoda care imi afiseaza un sir de caractere.**</br>
 - **WriteLine() imi afiseaza sirul de caractere si trece si pe linie noua.**</br>
 
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
            Console.WriteLine(" Bun venit la Biblioteca! Ce carte ati dori sa imprumutati?");
        }
    }

}

```


2️⃣**PAS 2: CITIRE: Citire de la tastatura un nume Cin = Console.ReadLine():**</br>
**Declaram  un string nume pe care il preiau cu metoda ReadLine()**</br>
Intr-un limbaj ca C# sirurile de caractere se initializeaza cu "string denumire" fara sa mai alocam spatiu, deoarece se aloca spatiu automat in HEAP si aceea denumire va fi defapt o referinta catre aceea adresa din HEAP care va contine denumirea pe care o citesc eu de la tastatura. </br>

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
            Console.WriteLine(" Bun venit la Biblioteca! Ce carte ati dori sa imprumutati?");
            string denumire = Console.ReadLine();
            string autor = Console.ReadLine();
            Console.Write("Cartea pe care doriti sa o imprumutati este {0} scrisa de {1}", denumire, autor);
        }
    }

}

```
*Apoi afisez mesajul "Cartea pe care doriti sa o imprumutati este ... si denumirea cartii introdusa anterior de la tastatura.*</br>
- {0} inseamna primul parametru care urmeaza in lista dupa virgula adica denumirea, iar {1} inseamna al doilea parametru in lista de parametri de dupa virgula, adica autorul. </br>

```cpp
 Console.Write("Cartea pe care doriti sa o imprumutati este {0} scrisa de {1}", denumire, autor);
```
