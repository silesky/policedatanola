using CsvHelper;
using System.IO;
using System;
using System.Collections.Generic;
using Police.Models;
using CsvHelper.Configuration;
using System.Collections;
using System.Linq;
using Police.Models.TypeConversion;

namespace police.Models.Repositories
{
  //
  public class RecordsRepository
  {
    public static IEnumerable<Record> GetCrimesByMonth()
    {

      using (var fileReader = File.OpenText(@"csv/2017.csv"))
      using (var csvReader = new CsvReader(fileReader))
      {

        csvReader.Configuration.WillThrowOnMissingField = false;
        csvReader.Configuration.Delimiter = ",";
        csvReader.Configuration.IgnoreBlankLines = true;
        csvReader.Configuration.HasHeaderRecord = true;
        csvReader.Configuration.RegisterClassMap<RecordsMap>();
        
        // needs to go in this scope, otherwise "type conversion can't be performed error"
        var records = csvReader.GetRecords<Record>().ToList(); // failing 'fields Charge
        var r = records.ElementAt(0);
        Console.WriteLine(r.District.ToString());
        Console.WriteLine(r.Location.ToString());
        Console.WriteLine(r.ChargeDescription);
        
        // {crimeDescription: blah, crimeDate}
        return records;
      }
    }
  }

  public class RecordsMap : CsvClassMap<Record>
  {
      /*
      00 Item_Number,
      01 District,
      02 Location,
      03 Disposition,
      04 Signal_Type,
      05 Signal_Description,
      06 Occurred_Date_Time,
      07 Charge_Code,
      08 Charge_Description,
      09 Offender_Race,
      10 Offender_Gender,
      11 Offender_Age,
      12 Victim_Race,
      13 Victim_Gender,
      14 Victim_Age,
      15 Report_Type
      */
      public RecordsMap()
      {
        
        Map(rec => rec.District).Name("District");
        
        Map(rec => rec.Location).Name("Location");
        
        Map(rec => rec.ChargeDescription).Name("Charge_Description");
        
        Map(rec => rec.OffenderAge).Name("Offender_Age").TypeConverter<NullableInt32Converter>();
        
        // Map(rec => rec.OffenderGender).Name("Offender_Gender");
        
        // Map(rec => rec.OccurredDateTime).Name("Occurred_Date_Time");

        // Map(rec => rec.SignalDescription).Name("Signal_Description");
        
        // Map(rec => rec.SignalType).Name("Signal_Type");
        
        // Map(rec => rec.VictimAge).Name("Victim_Age");
        
        // Map(rec => rec.VictimRace).Name("Victim_Race");
      }
    }
}
