
namespace Police.Models
{
  public class Record
  {
    public string ChargeDescription { get; set; } // e.g. "Drug paraphanelia"
    public int District { get; set; } // e.g 4
    public int OffenderAge { get; set; }
    public Gender OffenderGender { get; set; } // it can only be make or famle
    public Race OffenderRace { get; set; }
    public string occurredDateTime { get; set; } // should be an isoString
    public string Location { get; set; }
    public string SignalDescription { get; set; } // e.g "Attempted Armed Robbery (Gun);
    public string SignalType { get; set; } //	Signal_Typ
    public int VictimAge { get; set; }
    public Gender VictimGender { get; set; }
    public Race VictimRace { get; set; }
  }
  public enum Gender
  {
    Male = 0, // eventually I need to a mapping so the string "MALE" equals Male
    Female = 1
  }

  public enum Race
  {
    Black = 0,
    White = 1,
    Hispanic = 2
  }


}
