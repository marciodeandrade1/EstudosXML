using System;
using System.Xml;

namespace LerXML
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlTextReader reader = new XmlTextReader(@"C:/Labs/XmlEstudos/livros.xml");
            Console.WriteLine("Informações Gerais");
            Console.WriteLine("==================");
            Console.WriteLine(reader.Name);
            Console.WriteLine(reader.BaseURI);
            Console.WriteLine(reader.LocalName);

        }
    }
}
