using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Preview.BulkExports 
{

    /// <summary>
    /// ExportConfigurationResource
    /// </summary>
    public class ExportConfigurationResource : Resource 
    {
        private static Request BuildFetchRequest(FetchExportConfigurationOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Preview,
                "/BulkExports/Exports/" + options.PathResourceType + "/Configuration",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="options"> Fetch ExportConfiguration parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ExportConfiguration </returns> 
        public static ExportConfigurationResource Fetch(FetchExportConfigurationOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="options"> Fetch ExportConfiguration parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ExportConfiguration </returns> 
        public static async System.Threading.Tasks.Task<ExportConfigurationResource> FetchAsync(FetchExportConfigurationOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="pathResourceType"> The resource_type </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ExportConfiguration </returns> 
        public static ExportConfigurationResource Fetch(string pathResourceType, ITwilioRestClient client = null)
        {
            var options = new FetchExportConfigurationOptions(pathResourceType);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="pathResourceType"> The resource_type </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ExportConfiguration </returns> 
        public static async System.Threading.Tasks.Task<ExportConfigurationResource> FetchAsync(string pathResourceType, ITwilioRestClient client = null)
        {
            var options = new FetchExportConfigurationOptions(pathResourceType);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildUpdateRequest(UpdateExportConfigurationOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Preview,
                "/BulkExports/Exports/" + options.PathResourceType + "/Configuration",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="options"> Update ExportConfiguration parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ExportConfiguration </returns> 
        public static ExportConfigurationResource Update(UpdateExportConfigurationOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="options"> Update ExportConfiguration parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ExportConfiguration </returns> 
        public static async System.Threading.Tasks.Task<ExportConfigurationResource> UpdateAsync(UpdateExportConfigurationOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="pathResourceType"> The resource_type </param>
        /// <param name="enabled"> The enabled </param>
        /// <param name="webhookUrl"> The webhook_url </param>
        /// <param name="webhookMethod"> The webhook_method </param>
        /// <param name="email"> The email </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ExportConfiguration </returns> 
        public static ExportConfigurationResource Update(string pathResourceType, bool? enabled = null, Uri webhookUrl = null, string webhookMethod = null, string email = null, ITwilioRestClient client = null)
        {
            var options = new UpdateExportConfigurationOptions(pathResourceType){Enabled = enabled, WebhookUrl = webhookUrl, WebhookMethod = webhookMethod, Email = email};
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="pathResourceType"> The resource_type </param>
        /// <param name="enabled"> The enabled </param>
        /// <param name="webhookUrl"> The webhook_url </param>
        /// <param name="webhookMethod"> The webhook_method </param>
        /// <param name="email"> The email </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ExportConfiguration </returns> 
        public static async System.Threading.Tasks.Task<ExportConfigurationResource> UpdateAsync(string pathResourceType, bool? enabled = null, Uri webhookUrl = null, string webhookMethod = null, string email = null, ITwilioRestClient client = null)
        {
            var options = new UpdateExportConfigurationOptions(pathResourceType){Enabled = enabled, WebhookUrl = webhookUrl, WebhookMethod = webhookMethod, Email = email};
            return await UpdateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a ExportConfigurationResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> ExportConfigurationResource object represented by the provided JSON </returns> 
        public static ExportConfigurationResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<ExportConfigurationResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The enabled
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; private set; }
        /// <summary>
        /// The webhook_url
        /// </summary>
        [JsonProperty("webhook_url")]
        public Uri WebhookUrl { get; private set; }
        /// <summary>
        /// The webhook_method
        /// </summary>
        [JsonProperty("webhook_method")]
        public string WebhookMethod { get; private set; }
        /// <summary>
        /// The email
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; private set; }
        /// <summary>
        /// The resource_type
        /// </summary>
        [JsonProperty("resource_type")]
        public string ResourceType { get; private set; }
        /// <summary>
        /// The url
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        private ExportConfigurationResource()
        {

        }
    }

}