using System;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;

namespace Police.Models.TypeConversion {

    public class NullableStringToInt32Converter : Int32Converter {

        public override Object ConvertFromString(string textToConvert, ICsvReaderRow row, CsvPropertyMapData propertyMapData) {
            if (string.IsNullOrWhiteSpace(textToConvert)) return null;
            try {
              int m = Int32.Parse(textToConvert);
            } catch {
              return null; // sometimes the CSV data says "Black" instead of "22"
            }
            return base.ConvertFromString(textToConvert, row, propertyMapData);
        }

    }

    // public class StringToGenderEnumConverter : EnumerableConverter {
    //   public override Object ConvertFromString(string textToConvert, ICsvReaderRow row, CsvPropertyMapData propertyMapData) {
    //         if (string.IsNullOrWhiteSpace(textToConvert)) return null;
    //         try {
    //           Object myEnum  = Enum.Parse(typeof(Gender), textToConvert.ToLower());
    //           return myEnum;
    //         } catch(FormatException e) {
    //           return null; // sometimes the CSV data says "Black" instead of "22"
    //         }
    //     }



    // }

    // public class StringToRaceEnumConverter : EnumerableConverter {


    // }

}
