using System;
using System.Xml;

namespace TCMB_Doviz_Kur
{
    class Program
    {
        static void Main(string[] args)
        {
            string bugun = "http://www.tcmb.gov.tr/kurlar/today.xml";

            var xmlDoc = new XmlDocument();
            xmlDoc.Load(bugun);

            string EURO_Alis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            string EURO_Satis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;

            string USD_Alis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            string USD_Satis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;

            Console.WriteLine(string.Format("Euro Alış: {0:C2}", EURO_Alis));
            Console.WriteLine(string.Format("Euro Satış: {0:C2}", EURO_Satis));
            Console.WriteLine(string.Format("USD Alış: {0:C2}", USD_Alis));
            Console.WriteLine(string.Format("USD Satış: {0:C2}", USD_Satis));
            Console.ReadKey();
        }
    }
}
