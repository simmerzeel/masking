using System.Text;
using System.Text.Json.Nodes;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace ConsoleApp;

[SimpleJob(RuntimeMoniker.Net80)]
[MemoryDiagnoser(false)]
public class SystemTextTest
{
    private static List<string> PropertiesToMask = ["stops.address.street", "stops.products.productType", "visits.address.street"];
    
    [Benchmark]
    public async Task<string> MaskWithSystemText()
    {
        var jsonNode = await JsonNode.ParseAsync(new MemoryStream(Encoding.UTF8.GetBytes(JsonStringTest.JsonString)));
        
        MaskBody(jsonNode.AsObject());
    
        return jsonNode.ToJsonString();
    }

    static void MaskBody(JsonNode node)
    {
        foreach (var pathToMask in PropertiesToMask)
        {
            MaskProperty(node, pathToMask);
        }
    }
    
    private static void MaskProperty(JsonNode jsonObject, string propertyName)
    {
        var propertyNames = propertyName.Split('.');

        for (var i = 0; i < propertyNames.Length - 1; i++)
        {
            if (jsonObject[propertyNames[i]] is null)
            {
                return;
            }

            var childObject = jsonObject[propertyNames[i]];
            
            if (childObject is JsonArray array)
            {
                foreach (var record in array)
                {
                    var nextPath = string.Join('.', propertyNames[new Range(i + 1, propertyNames.Length)]);
                    MaskProperty(record, nextPath);
                }

                continue;
            }

            jsonObject = childObject;
        }

        if (jsonObject[propertyNames[^1]] is null)
        {
            return;
        }

        jsonObject[propertyNames[^1]] = "*** mask ***";
    }
}