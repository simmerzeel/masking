using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using Newtonsoft.Json.Linq;

namespace ConsoleApp;

[SimpleJob(RuntimeMoniker.Net80)]
[MemoryDiagnoser(false)]
public class NewtonsoftTest
{
    private static List<string> PropertiesToMask = [
        "visits[*].address.street", 
        "stops[*].address.street",
        "stops[*].products[*].productType"
    ];
    
    [Benchmark]
    public string MaskWithNewtonsoft()
    {
        //this can potentially fail, need to catch/try it.
        var jObject = JObject.Parse(JsonStringTest.JsonString);
        MaskBody(jObject);
    
        return jObject.ToString();
    }

    static void MaskBody(JObject token)
    {
        var tokenToMask = PropertiesToMask.SelectMany(token.SelectTokens);
        foreach (var mask in tokenToMask)
        {
            mask.Replace("*** mask ***");
        }
    }
}