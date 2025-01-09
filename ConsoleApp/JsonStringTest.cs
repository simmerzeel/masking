namespace ConsoleApp;

public class JsonStringTest
{
  public static string JsonString = @"{
  ""id"": 252,
  ""externalId"": 999,
  ""name"": ""b3d875b4-e969-4593-8b14-d57a7917ac0b"",
  ""alias"": ""4a1641f9-9e55-4308-871a-4da4727c4c77"",
  ""routeNumber"": 213,
  ""plannedStart"": ""2023-02-21T00:02:21.9474141Z"",
  ""plannedEnd"": ""2023-12-16T00:21:42.9858496Z"",
  ""plannedTotalDistanceInMeters"": 243,
  ""totalVolumeInCm3"": 182,
  ""totalWeightInGrams"": 62,
  ""deliveryNetwork"": ""Bike"",
  ""drivers"": {},
  ""deviceInformation"": {},
  ""stops"": [
    {
      ""id"": 89,
      ""externalId"": 178,
      ""sequenceNumber"": 1,
      ""type"": ""Customer"",
      ""reference"": {
        ""id"": ""123"",
        ""type"": ""CustomerOrder""
      },
      ""status"": ""Pending"",
      ""deliveryStatus"": ""Failed"",
      ""earliestArrival"": ""2025-04-17T12:12:02.9112735Z"",
      ""latestArrival"": ""2024-10-16T07:22:09.7654283Z"",
      ""plannedArrival"": ""2025-08-04T20:42:37.1947935Z"",
      ""plannedDeparture"": ""2026-01-18T16:57:38.1502934Z"",
      ""durationInSeconds"": 76,
      ""address"": {
        ""street"": ""f461819b-072c-4b6b-95ef-7231ffaa3160"",
        ""houseNumber"": ""104"",
        ""postalCode"": ""63"",
        ""city"": ""2826ad4d-2afa-4625-93be-1fa1fcdc9e60"",
        ""countryCode"": ""NL"",
        ""geoLocation"": {
          ""latitude"": 198,
          ""longitude"": 48
        },
        ""remarks"": []
      },
      ""customer"": {
        ""number"": 197,
        ""name"": ""3e6c785a-3026-4d89-9543-2aa051a808cc""
      },
      ""contactInformation"": {
        ""name"": ""8b4baed1-f7fb-46c6-a9f6-83e5fef87dec"",
        ""phoneNumber"": ""3a4b12a7-7b92-4a0d-97bd-f804053aa0f1"",
        ""mobilePhoneNumber"": ""84b1122b-56d2-4f5e-af3f-aa50372d2e50"",
        ""languageCode"": ""a580aac8-4572-435d-9f52-e330c2734a05""
      },
      ""products"": [
        {
          ""id"": ""c21eed14-5273-438d-bd15-d5f1d4d6eef3"",
          ""productId"": 0,
          ""description"": ""f4685727-28aa-4c9d-a17e-9316487d366e"",
          ""volumeInCm3"": 133,
          ""weightInGrams"": 21,
          ""productType"": ""CoolblueProduct"",
          ""services"": [],
          ""packages"": [
            {
              ""barcode"": ""HJS47"",
              ""scanType"": ""None""
            },
            {
              ""barcode"": ""HJS190"",
              ""scanType"": ""None""
            },
            {
              ""barcode"": ""HJS106"",
              ""scanType"": ""None""
            }
          ],
          ""productLocation"": ""Vehicle""
        }
      ],
      ""addedStop"": false,
      ""removedStop"": false,
      ""services"": [],
      ""orderInsightAvailable"": false,
      ""metadata"": {
        ""added"": false,
        ""removed"": false,
        ""postponed"": false,
        ""deactivated"": false,
        ""orderInsightAvailable"": false
      }
    },
{
      ""id"": 89,
      ""externalId"": 178,
      ""sequenceNumber"": 1,
      ""type"": ""Customer"",
      ""reference"": {
        ""id"": ""123"",
        ""type"": ""CustomerOrder""
      },
      ""status"": ""Pending"",
      ""deliveryStatus"": ""Failed"",
      ""earliestArrival"": ""2025-04-17T12:12:02.9112735Z"",
      ""latestArrival"": ""2024-10-16T07:22:09.7654283Z"",
      ""plannedArrival"": ""2025-08-04T20:42:37.1947935Z"",
      ""plannedDeparture"": ""2026-01-18T16:57:38.1502934Z"",
      ""durationInSeconds"": 76,
      ""address"": {
        ""street"": ""f461819b-072c-4b6b-95ef-7231ffaa3160"",
        ""houseNumber"": ""104"",
        ""postalCode"": ""63"",
        ""city"": ""2826ad4d-2afa-4625-93be-1fa1fcdc9e60"",
        ""countryCode"": ""NL"",
        ""geoLocation"": {
          ""latitude"": 198,
          ""longitude"": 48
        },
        ""remarks"": []
      },
      ""customer"": {
        ""number"": 197,
        ""name"": ""3e6c785a-3026-4d89-9543-2aa051a808cc""
      },
      ""contactInformation"": {
        ""name"": ""8b4baed1-f7fb-46c6-a9f6-83e5fef87dec"",
        ""phoneNumber"": ""3a4b12a7-7b92-4a0d-97bd-f804053aa0f1"",
        ""mobilePhoneNumber"": ""84b1122b-56d2-4f5e-af3f-aa50372d2e50"",
        ""languageCode"": ""a580aac8-4572-435d-9f52-e330c2734a05""
      },
      ""products"": [
        {
          ""id"": ""c21eed14-5273-438d-bd15-d5f1d4d6eef3"",
          ""productId"": 0,
          ""description"": ""f4685727-28aa-4c9d-a17e-9316487d366e"",
          ""volumeInCm3"": 133,
          ""weightInGrams"": 21,
          ""productType"": ""CoolblueProduct"",
          ""services"": [],
          ""packages"": [
            {
              ""barcode"": ""HJS47"",
              ""scanType"": ""None""
            },
            {
              ""barcode"": ""HJS190"",
              ""scanType"": ""None""
            },
            {
              ""barcode"": ""HJS106"",
              ""scanType"": ""None""
            }
          ],
          ""productLocation"": ""Vehicle""
        }
      ],
      ""addedStop"": false,
      ""removedStop"": false,
      ""services"": [],
      ""orderInsightAvailable"": false,
      ""metadata"": {
        ""added"": false,
        ""removed"": false,
        ""postponed"": false,
        ""deactivated"": false,
        ""orderInsightAvailable"": false
      }
    },
{
      ""id"": 89,
      ""externalId"": 178,
      ""sequenceNumber"": 1,
      ""type"": ""Customer"",
      ""reference"": {
        ""id"": ""123"",
        ""type"": ""CustomerOrder""
      },
      ""status"": ""Pending"",
      ""deliveryStatus"": ""Failed"",
      ""earliestArrival"": ""2025-04-17T12:12:02.9112735Z"",
      ""latestArrival"": ""2024-10-16T07:22:09.7654283Z"",
      ""plannedArrival"": ""2025-08-04T20:42:37.1947935Z"",
      ""plannedDeparture"": ""2026-01-18T16:57:38.1502934Z"",
      ""durationInSeconds"": 76,
      ""address"": {
        ""street"": ""f461819b-072c-4b6b-95ef-7231ffaa3160"",
        ""houseNumber"": ""104"",
        ""postalCode"": ""63"",
        ""city"": ""2826ad4d-2afa-4625-93be-1fa1fcdc9e60"",
        ""countryCode"": ""NL"",
        ""geoLocation"": {
          ""latitude"": 198,
          ""longitude"": 48
        },
        ""remarks"": []
      },
      ""customer"": {
        ""number"": 197,
        ""name"": ""3e6c785a-3026-4d89-9543-2aa051a808cc""
      },
      ""contactInformation"": {
        ""name"": ""8b4baed1-f7fb-46c6-a9f6-83e5fef87dec"",
        ""phoneNumber"": ""3a4b12a7-7b92-4a0d-97bd-f804053aa0f1"",
        ""mobilePhoneNumber"": ""84b1122b-56d2-4f5e-af3f-aa50372d2e50"",
        ""languageCode"": ""a580aac8-4572-435d-9f52-e330c2734a05""
      },
      ""products"": [
        {
          ""id"": ""c21eed14-5273-438d-bd15-d5f1d4d6eef3"",
          ""productId"": 0,
          ""description"": ""f4685727-28aa-4c9d-a17e-9316487d366e"",
          ""volumeInCm3"": 133,
          ""weightInGrams"": 21,
          ""productType"": ""CoolblueProduct"",
          ""services"": [],
          ""packages"": [
            {
              ""barcode"": ""HJS47"",
              ""scanType"": ""None""
            },
            {
              ""barcode"": ""HJS190"",
              ""scanType"": ""None""
            },
            {
              ""barcode"": ""HJS106"",
              ""scanType"": ""None""
            }
          ],
          ""productLocation"": ""Vehicle""
        }
      ],
      ""addedStop"": false,
      ""removedStop"": false,
      ""services"": [],
      ""orderInsightAvailable"": false,
      ""metadata"": {
        ""added"": false,
        ""removed"": false,
        ""postponed"": false,
        ""deactivated"": false,
        ""orderInsightAvailable"": false
      }
    },
{
      ""id"": 89,
      ""externalId"": 178,
      ""sequenceNumber"": 1,
      ""type"": ""Customer"",
      ""reference"": {
        ""id"": ""123"",
        ""type"": ""CustomerOrder""
      },
      ""status"": ""Pending"",
      ""deliveryStatus"": ""Failed"",
      ""earliestArrival"": ""2025-04-17T12:12:02.9112735Z"",
      ""latestArrival"": ""2024-10-16T07:22:09.7654283Z"",
      ""plannedArrival"": ""2025-08-04T20:42:37.1947935Z"",
      ""plannedDeparture"": ""2026-01-18T16:57:38.1502934Z"",
      ""durationInSeconds"": 76,
      ""address"": {
        ""street"": ""f461819b-072c-4b6b-95ef-7231ffaa3160"",
        ""houseNumber"": ""104"",
        ""postalCode"": ""63"",
        ""city"": ""2826ad4d-2afa-4625-93be-1fa1fcdc9e60"",
        ""countryCode"": ""NL"",
        ""geoLocation"": {
          ""latitude"": 198,
          ""longitude"": 48
        },
        ""remarks"": []
      },
      ""customer"": {
        ""number"": 197,
        ""name"": ""3e6c785a-3026-4d89-9543-2aa051a808cc""
      },
      ""contactInformation"": {
        ""name"": ""8b4baed1-f7fb-46c6-a9f6-83e5fef87dec"",
        ""phoneNumber"": ""3a4b12a7-7b92-4a0d-97bd-f804053aa0f1"",
        ""mobilePhoneNumber"": ""84b1122b-56d2-4f5e-af3f-aa50372d2e50"",
        ""languageCode"": ""a580aac8-4572-435d-9f52-e330c2734a05""
      },
      ""products"": [
        {
          ""id"": ""c21eed14-5273-438d-bd15-d5f1d4d6eef3"",
          ""productId"": 0,
          ""description"": ""f4685727-28aa-4c9d-a17e-9316487d366e"",
          ""volumeInCm3"": 133,
          ""weightInGrams"": 21,
          ""productType"": ""CoolblueProduct"",
          ""services"": [],
          ""packages"": [
            {
              ""barcode"": ""HJS47"",
              ""scanType"": ""None""
            },
            {
              ""barcode"": ""HJS190"",
              ""scanType"": ""None""
            },
            {
              ""barcode"": ""HJS106"",
              ""scanType"": ""None""
            }
          ],
          ""productLocation"": ""Vehicle""
        }
      ],
      ""addedStop"": false,
      ""removedStop"": false,
      ""services"": [],
      ""orderInsightAvailable"": false,
      ""metadata"": {
        ""added"": false,
        ""removed"": false,
        ""postponed"": false,
        ""deactivated"": false,
        ""orderInsightAvailable"": false
      }
    }
  ]
}";
}
