class Program
{
    static void Main(string[] args)
    {
        /// <summary>
        /// A sample json object in a string.
        /// </summary>
        const string jsonString = @"{
            ""ErrorNumber"": 10,
            ""Type"": ""ValidationException"",
            ""Message"": ""A validation exception occurred"",
            ""Elements"": [
              {
                ""Type"": ""ACCPAY"",
                ""InvoiceID"": ""00000000-0000-0000-0000-000000000000"",
                ""InvoiceNumber"": ""0176"",
                ""Reference"": ""0176"",
                ""Payments"": [],
                ""CreditNotes"": [],
                ""Prepayments"": [],
                ""Overpayments"": [],
                ""SentToContact"": true,
                ""IsDiscounted"": false,
                ""HasErrors"": true,
                ""Contact"": {
            ""ContactID"": ""b4bf8774-7cc1-4659-ad90-1b0bb4d20cd0"",
                  ""ContactNumber"": ""1090"",
                  ""Addresses"": [],
                  ""Phones"": [],
                  ""ContactGroups"": [],
                  ""ContactPersons"": [],
                  ""HasValidationErrors"": false,
                  ""ValidationErrors"": []
                },
                ""DateString"": ""2022-04-14T00:00:00"",
                ""Date"": ""\/Date(1649894400000+0000)\/"",
                ""DueDateString"": ""2022-04-21T00:00:00"",
                ""DueDate"": ""\/Date(1650499200000+0000)\/"",
                ""Status"": ""AUTHORISED"",
                ""LineAmountTypes"": ""Exclusive"",
                ""LineItems"": [
                  {
                    ""ItemCode"": ""SD"",
                    ""Description"": ""Imported from Wise Owl Legal Purchase '0176' on 14/04/2022. "",
                    ""UnitAmount"": 138.25,
                    ""TaxType"": ""EXEMPTOUTPUT"",
                    ""TaxAmount"": 0.00,
                    ""LineAmount"": 138.25,
                    ""AccountCode"": ""CLOUT:SD"",
                    ""Tracking"": [],
                    ""Quantity"": 1.0000,
                    ""AccountID"": ""0d662179-f6d9-4fe4-b362-83d30c8aae7b"",
                    ""ValidationErrors"": []
                  }
                ],
                ""SubTotal"": 138.25,
                ""TotalTax"": 0.00,
                ""Total"": 138.25,
                ""CurrencyCode"": ""AUD"",
                ""ValidationErrors"": [
                  {
                    ""Message"": ""Message 1 = The TaxType code 'EXEMPTOUTPUT' cannot be used with account code 'CLOUT:SD'.""
                  },
                  {
                    ""Message"": ""Message 2 = Another message.""
                  }
                ]
              }
            ]
          }";

        PrintHeader("LearningZ.CS.JsonObject Start");

        // Convert the string to a dynamic type.
        var jsonObject = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(jsonString);

        int validationErrorCount = jsonObject?.Elements[0].ValidationErrors.Count;
        for (int i = 0; i < validationErrorCount; i++)
        {
            Console.WriteLine($"jsonObject.Elements[0].ValidationErrors[{i}].Message = {jsonObject?.Elements[0].ValidationErrors[i].Message}");
        }

        PrintHeader("LearningZ.CS.JsonObject End");
    }

    private static void PrintDividingLine()
    {
        Console.WriteLine("----------------------------------------------------------------");
    }

    private static void PrintHeader(string header)
    {
        PrintDividingLine();
        Console.WriteLine($"{header}");
        Console.WriteLine($"{string.Join("", Enumerable.Repeat('-', header.Length))}");
    }
}