using CsvHelper;
using System.IO;
using System;
using System.Collections.Generic;
using Police.Models;

namespace police.Models.Repositories
{
  public class RecordsRepository
  {
    public static IEnumerable<Record> getCrimesByMonth()
    {
     string text = File.ReadAllText(@"csv/2017.csv");
     Console.WriteLine(text);
     return new List<Record>();
      // {crimeDescription: blah, crimeDate}
    }
  }
}
