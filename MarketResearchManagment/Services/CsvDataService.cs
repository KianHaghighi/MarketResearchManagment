using System.Collections.Generic;
using System.Globalization;
using Microsoft.VisualBasic.FileIO;
using MarketResearchManagment.Models;

namespace MarketResearchManagment.Services;

public class CsvDataService
{
    public List<Company> ReadCompaniesFromCsv(string filePath)
    {
        var Companys = new List<Company>();

        using (var parser = new TextFieldParser(filePath)) 
        {
            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(",");
            parser.HasFieldsEnclosedInQuotes = true;

            if (!parser.EndOfData) parser.ReadLine();

            while (!parser.EndOfData)
            {
                var fields = parser.ReadFields();
                if (fields != null && fields.Length >= 3)
                {
                    var Company = new Company
                    {
                        Id = int.Parse(fields[0], CultureInfo.InvariantCulture),
                        Name = fields[1],
                        Price = decimal.Parse(fields[2], CultureInfo.InvariantCulture)
                    };
                    Companys.Add(Company);
                }
            }
        }

        return Companys;
    }
}
