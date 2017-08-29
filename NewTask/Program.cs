using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTask
{
     
    class Program
    {
        //private static string path;
        string path = @"C: \Users\Praveen Bhatt\Documents\Visual Studio 2015\Projects\NewTask\NewTask\bin\Debug\Fuels.csv";
        static void Main(string[] args)
        {
            var car = ProcessFile("Fuels.csv");
            
            //check121
            var query = car.OrderBy(ca => ca.ModelYear)
                .ThenBy(cs => cs.Division);
            foreach(var cars in query.Take(15))
            {
                Console.WriteLine($"{cars.ModelYear}: {cars.Division}");
            }
        }

        private static List<path> ProcessFile(string path)
        {
            StreamReader sr = new StreamReader(path);
            return File.ReadAllLines(path)
                .Skip(1)
                .Where(line => line.Length > 1)
                .Select(s => s.Split(new[] { ',' }))        
                 .Select(a => new path
                 {
                     ModelYear = Convert.ToInt32(a[0]),
                     Division = a[1],
                     Carline = a[2],
                     EngDispl = (a[3]),//Convert.ToInt64
                     CityFE = Convert.ToInt64(a[4]),
                     HwyFE = Convert.ToInt64(a[5]),
                     CombFE = Convert.ToInt64(a[6]),
                 })
                  .ToList();                                           // return combined.ToList();
            }
        }
    //now it has been changed
      
    //change project
       
    }

