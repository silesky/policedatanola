
using System;

namespace Police.Models
{
  public class Record
  {
    public string ItemNumber { get; set; }
    public int District { get; set; } // e.g 4
    public string ChargeDescription { get; set; } // e.g. "Drug paraphanelia"
    public int? OffenderAge { get; set; }
    public string OffenderGender { get; set; } // it can only be male or female
    public string OffenderRace { get; set; }
    public string OccurredDateTime { get; set; } // should be an isoString
    public string Location { get; set; }
    public string SignalDescription { get; set; } // e.g "Attempted Armed Robbery (Gun);
    public string SignalType { get; set; } //	Signal_Typ
    public int? VictimAge { get; set; }
    public string VictimGender { get; set; }
    public string VictimRace { get; set; }

  }


  // public enum Gender
  // {
  //   Male = 0, // eventually I need to convert the 0 enum -> back to a string "Male";
  //   Female = 1
  // }

  // public enum Race
  // {
  //   Black = 0,
  //   White = 1,
  //   Hispanic = 2
  // }


}
