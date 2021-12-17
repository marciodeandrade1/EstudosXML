using System;
using System.Xml;

namespace CriaXML
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cria novo arquivo 
            XmlTextWriter writer = new XmlTextWriter("C:\\Labs\\ArquivoXML.xml", null);
        }
    }
}
