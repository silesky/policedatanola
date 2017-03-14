using CsvHelper;
using System.IO;
using System;
using System.Collections.Generic;
using Police.Models;
using CsvHelper.Configuration;
using System.Collections;
using System.Linq;

namespace police.Models.Repositories
{
  //
  public class RecordsRepository
  {

    public sealed class RecordsMap : CsvClassMap<Record>
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
        Map(rec => rec.District).Index(1);
        Map(rec => rec.Location).Index(2);
        // Map(rec => rec.ChargeDescription).Name("Charge_Description");
        // Map(rec => rec.OffenderAge).Name("Offender_Age");
        // Map(rec => rec.OffenderGender).Name("Offender_Gender");
        // Map(rec => rec.OccurredDateTime).Name("Occurred_Date_Time");

        // Map(rec => rec.SignalDescription).Name("Signal_Description");
        // Map(rec => rec.SignalType).Name("Signal_Type");
        // Map(rec => rec.VictimAge).Name("Victim_Age");
        // Map(rec => rec.VictimRace).Name("Victim_Race");
      }
    }

    public static IEnumerable<Record> GetCrimesByMonth()
    {

      using (var reader = File.OpenText(@"csv/2017.csv"))
      {

        var csv = new CsvReader(reader);
        csv.Configuration.WillThrowOnMissingField = false;
        csv.Configuration.Delimiter = ",";
        csv.Configuration.IgnoreBlankLines = true;
        csv.Configuration.HasHeaderRecord = true;
        csv.Configuration.RegisterClassMap<RecordsMap>();
        // needs to go in this scope, otherwise "type conversion can't be performed error"
        var recordList = new List<Record>();
        while (csv.Read())
        {
          var records = csv.GetRecords<Record>(); // failing 'fields Charge
          recordList = records.ToList();
          foreach (var r in recordList) {
            Console.WriteLine(r.District.ToString());
            Console.WriteLine(r.Location.ToString());
          }
        }
        // {crimeDescription: blah, crimeDate}
        return new List<Record>();
      }
    }
  }
}
