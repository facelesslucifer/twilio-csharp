using System;
using System.Collections.Generic;
using Twilio.Base;

namespace Twilio.Rest.Preview.BulkExports 
{

    /// <summary>
    /// FetchExportConfigurationOptions
    /// </summary>
    public class FetchExportConfigurationOptions : IOptions<ExportConfigurationResource> 
    {
        /// <summary>
        /// The resource_type
        /// </summary>
        public string PathResourceType { get; }

        /// <summary>
        /// Construct a new FetchExportConfigurationOptions
        /// </summary>
        ///
        /// <param name="pathResourceType"> The resource_type </param>
        public FetchExportConfigurationOptions(string pathResourceType)
        {
            PathResourceType = pathResourceType;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// UpdateExportConfigurationOptions
    /// </summary>
    public class UpdateExportConfigurationOptions : IOptions<ExportConfigurationResource> 
    {
        /// <summary>
        /// The resource_type
        /// </summary>
        public string PathResourceType { get; }
        /// <summary>
        /// The enabled
        /// </summary>
        public bool? Enabled { get; set; }
        /// <summary>
        /// The webhook_url
        /// </summary>
        public Uri WebhookUrl { get; set; }
        /// <summary>
        /// The webhook_method
        /// </summary>
        public string WebhookMethod { get; set; }
        /// <summary>
        /// The email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Construct a new UpdateExportConfigurationOptions
        /// </summary>
        ///
        /// <param name="pathResourceType"> The resource_type </param>
        public UpdateExportConfigurationOptions(string pathResourceType)
        {
            PathResourceType = pathResourceType;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Enabled != null)
            {
                p.Add(new KeyValuePair<string, string>("Enabled", Enabled.Value.ToString()));
            }

            if (WebhookUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("WebhookUrl", WebhookUrl.ToString()));
            }

            if (WebhookMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("WebhookMethod", WebhookMethod));
            }

            if (Email != null)
            {
                p.Add(new KeyValuePair<string, string>("Email", Email));
            }

            return p;
        }
    }

}