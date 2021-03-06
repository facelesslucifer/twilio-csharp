/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Autopilot.V1.Assistant 
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// FetchFieldTypeOptions
    /// </summary>
    public class FetchFieldTypeOptions : IOptions<FieldTypeResource> 
    {
        /// <summary>
        /// The assistant_sid
        /// </summary>
        public string PathAssistantSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchFieldTypeOptions
        /// </summary>
        /// <param name="pathAssistantSid"> The assistant_sid </param>
        /// <param name="pathSid"> The sid </param>
        public FetchFieldTypeOptions(string pathAssistantSid, string pathSid)
        {
            PathAssistantSid = pathAssistantSid;
            PathSid = pathSid;
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
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// ReadFieldTypeOptions
    /// </summary>
    public class ReadFieldTypeOptions : ReadOptions<FieldTypeResource> 
    {
        /// <summary>
        /// The assistant_sid
        /// </summary>
        public string PathAssistantSid { get; }

        /// <summary>
        /// Construct a new ReadFieldTypeOptions
        /// </summary>
        /// <param name="pathAssistantSid"> The assistant_sid </param>
        public ReadFieldTypeOptions(string pathAssistantSid)
        {
            PathAssistantSid = pathAssistantSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// CreateFieldTypeOptions
    /// </summary>
    public class CreateFieldTypeOptions : IOptions<FieldTypeResource> 
    {
        /// <summary>
        /// The assistant_sid
        /// </summary>
        public string PathAssistantSid { get; }
        /// <summary>
        /// A user-provided string that uniquely identifies this resource as an alternative to the sid. Unique up to 64 characters long.
        /// </summary>
        public string UniqueName { get; }
        /// <summary>
        /// A user-provided string that identifies this resource. It is non-unique and can be up to 255 characters long.
        /// </summary>
        public string FriendlyName { get; set; }

        /// <summary>
        /// Construct a new CreateFieldTypeOptions
        /// </summary>
        /// <param name="pathAssistantSid"> The assistant_sid </param>
        /// <param name="uniqueName"> A user-provided string that uniquely identifies this resource as an alternative to the
        ///                  sid. Unique up to 64 characters long. </param>
        public CreateFieldTypeOptions(string pathAssistantSid, string uniqueName)
        {
            PathAssistantSid = pathAssistantSid;
            UniqueName = uniqueName;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// UpdateFieldTypeOptions
    /// </summary>
    public class UpdateFieldTypeOptions : IOptions<FieldTypeResource> 
    {
        /// <summary>
        /// The assistant_sid
        /// </summary>
        public string PathAssistantSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// A user-provided string that identifies this resource. It is non-unique and can be up to 255 characters long.
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// A user-provided string that uniquely identifies this resource as an alternative to the sid. Unique up to 64 characters long.
        /// </summary>
        public string UniqueName { get; set; }

        /// <summary>
        /// Construct a new UpdateFieldTypeOptions
        /// </summary>
        /// <param name="pathAssistantSid"> The assistant_sid </param>
        /// <param name="pathSid"> The sid </param>
        public UpdateFieldTypeOptions(string pathAssistantSid, string pathSid)
        {
            PathAssistantSid = pathAssistantSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// DeleteFieldTypeOptions
    /// </summary>
    public class DeleteFieldTypeOptions : IOptions<FieldTypeResource> 
    {
        /// <summary>
        /// The assistant_sid
        /// </summary>
        public string PathAssistantSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteFieldTypeOptions
        /// </summary>
        /// <param name="pathAssistantSid"> The assistant_sid </param>
        /// <param name="pathSid"> The sid </param>
        public DeleteFieldTypeOptions(string pathAssistantSid, string pathSid)
        {
            PathAssistantSid = pathAssistantSid;
            PathSid = pathSid;
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

}