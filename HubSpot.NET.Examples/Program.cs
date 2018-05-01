using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HubSpot.NET.Api.Contact.Dto;
using HubSpot.NET.Api.Engagement.Dto;
using HubSpot.NET.Api.Files.Dto;
using HubSpot.NET.Core;

namespace HubSpot.NET.Examples
{
    public class Examples
    {
        /*
         *   Change "demo" to your API key to work with your data.
         *   Leaving it as the default value will use HubSpot's 'demo' API key in the example methods.
         */
        static string _apiKey = "YOUR API KEY HERE";

        static void Main(string[] args)
        {
            if (_apiKey == "YOUR API KEY HERE")
            {
                _apiKey = "demo";
            }

            Deals.Example(_apiKey);

            Companies.Example(_apiKey);

            Contacts.Example(_apiKey);

            CompanyProperties.Example(_apiKey);

            EmailSubscriptions.Example(_apiKey);
        }
    }
}
