using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formQuestCreator
{
    class Binaries
    {
        static void guardarArchivoBinario(string nombre, int edad, string mail)
20         {
21             try 
22             {
23                 //Inicializamos una nueva instancia de la clase BinaryWriter que escribe en una secuencia
24                 BinaryWriter binaryWriter = new BinaryWriter(File.Open("quest.dat", FileMode.Create));
25                 //Se escribe en el archivo
26                 binaryWriter.Write(idQuest);
27                 binaryWriter.Write(nameQuest);
28                 binaryWriter.Write(requestQuest);
29                 binaryWriter.Close();//se cierra archivo
30             }            
31             catch (Exception ex)
32             {
33                 Console.WriteLine("Error:" +ex.Message );
34             }
35         }
36 
37         static void leerArchivoBinario()
38         {
39             try
40             {
41                 BinaryReader binaryReader = new BinaryReader(File.Open("quest.dat", FileMode.Open));
42                 //se leen los datos en el orden en los que se guardaron y se imprimen en pantalla 
43                 imprimir(binaryReader.ReadString() , binaryReader.ReadInt32() , binaryReader.ReadString() );                
44                 binaryReader.Close();//se cierra el archivo
45             }
46             catch (Exception ex)
47             {
48                 Console.WriteLine("Error:" +ex.Message );
49                 Console.ReadKey();
50             }            
51         }
52 
53         static void imprimir(string nombre, int edad, string mail)
54         {
55             Console.WriteLine("========================================================");
56             Console.WriteLine(" > Id: {0}", idQuest);
57             Console.WriteLine(" > Name: {0}", nameQuest);
58             Console.WriteLine(" > Request: {0}", requestQuest);
59             Console.WriteLine("========================================================");
60             Console.ReadKey();
61         }
    }
}
