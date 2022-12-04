using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace hometask
{
   class JSON
    {
        const string path = @"C:\Yura\KNU\oopOld\DZ_6\ConsoleApp1\fileJson.json";
        JsonSerializerOptions options = new JsonSerializerOptions
        {
            WriteIndented = true
        };
        static public void Deserialization()
        {
            using (var fs = new FileStream(path, FileMode.Open))
            {
                var houses =   JsonSerializer.Deserialize<List<House>>(fs);
                foreach (var house in houses)
                { 
                    Console.WriteLine("PublishingHouseId: " + house?.PublishingHouseId + "\n" + "Title: " + house?.Title + "\n" + "Id: " + house?.PublishingHouse?.Name + "\n" + "Name:" + house?.PublishingHouse?.Name + "\n" + "Adress: " + house?.PublishingHouse?.Adress + "\n\n\n");
                }
            }
        }
        static public void Serialization(params House[] houses)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                JsonSerializer.Serialize<House[]>(fs, houses);
            }
        }
    }
}
