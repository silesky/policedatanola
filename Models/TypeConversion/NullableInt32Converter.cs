using System;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;

namespace Police.Models.TypeConversion {

    public class NullableInt32Converter : Int32Converter {

        public NullableInt32Converter () {}

        public override object ConvertFromString(string text, ICsvReaderRow row, CsvPropertyMapData propertyMapData) {
            if (string.IsNullOrWhiteSpace(text)) return null;

            return base.ConvertFromString(text, row, propertyMapData);
        }

    }

}