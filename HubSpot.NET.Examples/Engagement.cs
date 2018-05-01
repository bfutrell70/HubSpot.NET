using HubSpot.NET.Api.Engagement.Dto;
using HubSpot.NET.Core;
using System.Collections.Generic;
using System.Dynamic;

namespace HubSpot.NET.Examples
{
    public class Engagement
    {
        public static void Example()
        {
            /**
             * Initialize the API with your API Key
             * You can find or generate this under Integrations -> HubSpot API key
             */
            var api = new HubSpotApi("YOUR API KEY HERE");

            /**
             * Create a note engagement
             */
            dynamic noteMetaData = new ExpandoObject();
            noteMetaData.Body = "This is a sample note";

            var note = new EngagementHubSpotModel
            {
                Engagement = new EngagementHubSpotEngagementModel
                {
                    Type = "NOTE"
                },
                // need to supply valid values for associations
                //Associations = new EngagementHubSpotAssociationsModel
                //{
                //    DealIds = new List<long> { 1234567890 },
                //    CompanyIds = new List<long> { 2345678901 },
                //    ContactIds = new List<long> { 3456789012 },
                //    OwnerIds = new List<long> { 4567890123 }
                //},

                // the metadata part of the EngagementHubSpotModel is a dynamic object.
                Metadata = noteMetaData
            };
            var engagementNote = api.Engagement.Create(note);

            /**
             * Delete an engagement
             */
            api.Engagement.Delete(engagementNote.Engagement.Id.Value);

            /**
             * Get all engagements
             */
            var engagements = api.Engagement.List<EngagementHubSpotModel>();

            /**
             * Get an engagement by ID
             */

        }

    }
}
