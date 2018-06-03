using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            using (StreamReader r = new StreamReader("test.json"))
            {
                string JsonFileData = r.ReadToEnd();
                List<RootObject> items = JsonConvert.DeserializeObject<List<RootObject>>(JsonFileData);
                Console.WriteLine("資料標題:法務部編印「信託法令解釋及裁判要旨彙編」 \n" + "資料組筆為數 : " + items.Count + "\n");

                foreach (var item in items)
                {
                    Console.WriteLine("資料集名稱 :{0} 資料集連結:{1} \n", item.資料集名稱, item.資料集連結);
                }

            }
            Console.ReadLine();
        }
    }


    public class RootObject
    {
        public string 資料集名稱 { get; set; }
        public string 資料集連結 { get; set; }
    }


}
