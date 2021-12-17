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
            //abre cocumento
            writer.WriteStartDocument();
            //escreve comentários
            writer.WriteComment("Este programa usa XmlTextWriter");
            writer.WriteComment("Desenvolvido por: Marcio");
            writer.WriteComment("===============================");

            //escreve o primeiro elemento
            writer.WriteStartElement("root");
            writer.WriteStartElement("r", "Record", "urn: record");

            //escreve o próximo elemento
            writer.WriteStartElement("Nome", "");
            writer.WriteString("Marcio");
            writer.WriteEndElement();

            //escreve mais um elemento
            writer.WriteStartElement("Sobrenome", "");
            writer.WriteString("Andrade");
            writer.WriteEndElement();


        }
    }
}
