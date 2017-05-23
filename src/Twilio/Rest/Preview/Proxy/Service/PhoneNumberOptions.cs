using System;
using System.Collections.Generic;
using Twilio.Base;

namespace Twilio.Rest.Preview.Proxy.Service 
{

    /// <summary>
    /// Add an existing phone-number to this service to be used as a Proxy Number
    /// </summary>
    public class CreatePhoneNumberOptions : IOptions<PhoneNumberResource> 
    {
        /// <summary>
        /// The service_sid
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Delete by unique phone-number Sid
        /// </summary>
        public string Sid { get; }

        /// <summary>
        /// Construct a new CreatePhoneNumberOptions
        /// </summary>
        ///
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="sid"> Delete by unique phone-number Sid </param>
        public CreatePhoneNumberOptions(string pathServiceSid, string sid)
        {
            PathServiceSid = pathServiceSid;
            Sid = sid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Sid != null)
            {
                p.Add(new KeyValuePair<string, string>("Sid", Sid.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// Delete a phone-number belonging to this service.
    /// </summary>
    public class DeletePhoneNumberOptions : IOptions<PhoneNumberResource> 
    {
        /// <summary>
        /// The service_sid
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Delete by unique phone-number Sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeletePhoneNumberOptions
        /// </summary>
        ///
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathSid"> Delete by unique phone-number Sid </param>
        public DeletePhoneNumberOptions(string pathServiceSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
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
    /// Retrieve a list of phone-numbers belonging to this service
    /// </summary>
    public class ReadPhoneNumberOptions : ReadOptions<PhoneNumberResource> 
    {
        /// <summary>
        /// The service_sid
        /// </summary>
        public string PathServiceSid { get; }

        /// <summary>
        /// Construct a new ReadPhoneNumberOptions
        /// </summary>
        ///
        /// <param name="pathServiceSid"> The service_sid </param>
        public ReadPhoneNumberOptions(string pathServiceSid)
        {
            PathServiceSid = pathServiceSid;
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
    /// Fetch a phone-number belonging to this service
    /// </summary>
    public class FetchPhoneNumberOptions : IOptions<PhoneNumberResource> 
    {
        /// <summary>
        /// The service_sid
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Fetch by unique phone-number Sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchPhoneNumberOptions
        /// </summary>
        ///
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathSid"> Fetch by unique phone-number Sid </param>
        public FetchPhoneNumberOptions(string pathServiceSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
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