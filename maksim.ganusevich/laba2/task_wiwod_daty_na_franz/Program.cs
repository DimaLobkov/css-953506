using System;
using System.Globalization;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo[] cultures = new CultureInfo[] {new CultureInfo("en-us"),
                                                        new CultureInfo("fr-FR"),
                                                        new CultureInfo("de-DE"),
                                                        new CultureInfo("es-ES"),
                                                        new CultureInfo("ja-JP"),
                                                        new CultureInfo("sl-SI"),
                                                        new CultureInfo("zh-CN"),
                                                        new CultureInfo("ru-RU"),
                                                        new CultureInfo("hr-HR")};
            
            DateTime dateNow = new DateTime();
            dateNow = DateTime.Now;

            foreach (CultureInfo culture in cultures)
            {
                CultureInfo.CurrentCulture = culture;
                Console.WriteLine("In {0}, {1:f}", culture.Name.ToString(), dateNow);
            }
            DateTime date1 = new DateTime();
            date1 = DateTime.Now;
        }
    }
}
