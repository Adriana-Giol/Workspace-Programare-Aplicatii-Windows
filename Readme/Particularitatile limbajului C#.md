# 1. Particularitatile limbajului C#
- Destructorul dispare in limbajul C# deoarece exista mecanismul de Garbage Collector care se ocupa de dezalocarea spatiului de memorie.</br>
- Constructorul de copiere nu se mai implementeaza ca in C++ (se poate realiza), dar in C# se foloseste Interfata ICloneable, care vine cu metoda dedicata Clone() care stie sa faca Deep Copy.</br>
- Toate variabilele pe care le declaram in C#, sunt alocate in HEAP, chiar daca alocarea este vizibila sau nu d.p.d.v. al codului.</br>
- Shallow Copy(Copie de referinte) vs. Deep Copy (Alocarea unui nou spatiu de memorie si copierea valorii din vechiul spatiu in noul spatiu - cu 2 zone distincte de memorie).</br>
- Pointeri nu folosim deoarece in limbajul C# sunt considerati UNSAFE deoarece ar putea referi niste zone de memorie ale unor alte variabile - Pointeri se includ in blocuri UNSAFE pentru ca sa stie compilatorul sa ii trateze cu atentie sporita.</br>

## Creare Proiect:
Windows Forms App (.NET Framework)
- Program.cs este o clasa care include si implementarea metodei Main (este o functie statica void, care primeste un vector de String-uri ca si parametru).</br>
- Functia Main nu este de sine statatoare, ci se afla in interiorul clasei Program si clasa la randul ei se afla intr-un namespace.</br>
- Faptul ca Main-ul se afla in interiorul unui clase ne spune ca limbajul este pur obiectual si nimic nu paote fi definit in aflara clasei).</br>

## Biblioteca de clase
- Observam ca avem incluse mai  multe biblioteci la inceputul programului si `using` este echivalentului lui `#include`. Sunt biblioteci standard pe care le includem:
1. `System` =  biblioteca de clase de baza, care include si Main si clasele de citire/afisare.</br>
2. `System.Collections.Generic` = namespace-ul care se foloseste pe folosirea colectiilor generice (List<> = lista simpla sau dubla).</br>
3. `System.Text` si `System.IO` sunt folosite la lucrul cu fisiere. 
Aceste biblioteci de clase, sunt niste DDL-uri, pe care le gasim in instalarea de .NET Framework.


<!--************************************ TABEL****************************************************-->
<table>
<tbody>
<!------------------------------------------ TITLU-------------------------------------------------->
<tr>
<th>Program.cs in Console App</th>
<th>Program.cs in Windows Forms App</th>
</tr>
<!----------------------------------------- TITLU--------------------------------------------------->	
<!--------------------------------------- PRIMA COLOANA - CONSOLE APP--------------------------------->
<tr>
<td>
	
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
           
        }
    }

}
```
				
</td>
<!------------------------------------ A DOUA COLOANA - WINDOWS FORMS APP------------------------------------>
<td>
	
```Csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkspaceProjectCode
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}


```

</td>
</tr>
</tbody>
</table>
<!--************************************ TABEL****************************************************-->
