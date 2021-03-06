/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Autopilot.V1.Assistant.Task 
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// FetchSampleOptions
    /// </summary>
    public class FetchSampleOptions : IOptions<SampleResource> 
    {
        /// <summary>
        /// The assistant_sid
        /// </summary>
        public string PathAssistantSid { get; }
        /// <summary>
        /// The task_sid
        /// </summary>
        public string PathTaskSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchSampleOptions
        /// </summary>
        /// <param name="pathAssistantSid"> The assistant_sid </param>
        /// <param name="pathTaskSid"> The task_sid </param>
        /// <param name="pathSid"> The sid </param>
        public FetchSampleOptions(string pathAssistantSid, string pathTaskSid, string pathSid)
        {
            PathAssistantSid = pathAssistantSid;
            PathTaskSid = pathTaskSid;
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
    /// ReadSampleOptions
    /// </summary>
    public class ReadSampleOptions : ReadOptions<SampleResource> 
    {
        /// <summary>
        /// The assistant_sid
        /// </summary>
        public string PathAssistantSid { get; }
        /// <summary>
        /// The task_sid
        /// </summary>
        public string PathTaskSid { get; }
        /// <summary>
        /// An ISO language-country string that specifies the language used for this sample. For example: en-US.
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// Construct a new ReadSampleOptions
        /// </summary>
        /// <param name="pathAssistantSid"> The assistant_sid </param>
        /// <param name="pathTaskSid"> The task_sid </param>
        public ReadSampleOptions(string pathAssistantSid, string pathTaskSid)
        {
            PathAssistantSid = pathAssistantSid;
            PathTaskSid = pathTaskSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Language != null)
            {
                p.Add(new KeyValuePair<string, string>("Language", Language));
            }

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
    /// CreateSampleOptions
    /// </summary>
    public class CreateSampleOptions : IOptions<SampleResource> 
    {
        /// <summary>
        /// The assistant_sid
        /// </summary>
        public string PathAssistantSid { get; }
        /// <summary>
        /// The task_sid
        /// </summary>
        public string PathTaskSid { get; }
        /// <summary>
        /// An ISO language-country string that specifies the language used for this sample. For example: en-US.
        /// </summary>
        public string Language { get; }
        /// <summary>
        /// The text example of how end-users may express this task. The sample may contain Field tag blocks.
        /// </summary>
        public string TaggedText { get; }
        /// <summary>
        /// The communication channel from which the sample was captured. It can be: voice, sms, chat, alexa, google-assistant, or slack. If not included the value will be null
        /// </summary>
        public string SourceChannel { get; set; }

        /// <summary>
        /// Construct a new CreateSampleOptions
        /// </summary>
        /// <param name="pathAssistantSid"> The assistant_sid </param>
        /// <param name="pathTaskSid"> The task_sid </param>
        /// <param name="language"> An ISO language-country string that specifies the language used for this sample. For
        ///                example: en-US. </param>
        /// <param name="taggedText"> The text example of how end-users may express this task. The sample may contain Field tag
        ///                  blocks. </param>
        public CreateSampleOptions(string pathAssistantSid, string pathTaskSid, string language, string taggedText)
        {
            PathAssistantSid = pathAssistantSid;
            PathTaskSid = pathTaskSid;
            Language = language;
            TaggedText = taggedText;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Language != null)
            {
                p.Add(new KeyValuePair<string, string>("Language", Language));
            }

            if (TaggedText != null)
            {
                p.Add(new KeyValuePair<string, string>("TaggedText", TaggedText));
            }

            if (SourceChannel != null)
            {
                p.Add(new KeyValuePair<string, string>("SourceChannel", SourceChannel));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// UpdateSampleOptions
    /// </summary>
    public class UpdateSampleOptions : IOptions<SampleResource> 
    {
        /// <summary>
        /// The assistant_sid
        /// </summary>
        public string PathAssistantSid { get; }
        /// <summary>
        /// The task_sid
        /// </summary>
        public string PathTaskSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// An ISO language-country string that specifies the language used for this sample. For example: en-US.
        /// </summary>
        public string Language { get; set; }
        /// <summary>
        /// The text example of how end-users may express this task. The sample may contain Field tag blocks.
        /// </summary>
        public string TaggedText { get; set; }
        /// <summary>
        /// The communication channel from which the sample was captured. It can be: voice, sms, chat, alexa, google-assistant, or slack. If not included the value will be null
        /// </summary>
        public string SourceChannel { get; set; }

        /// <summary>
        /// Construct a new UpdateSampleOptions
        /// </summary>
        /// <param name="pathAssistantSid"> The assistant_sid </param>
        /// <param name="pathTaskSid"> The task_sid </param>
        /// <param name="pathSid"> The sid </param>
        public UpdateSampleOptions(string pathAssistantSid, string pathTaskSid, string pathSid)
        {
            PathAssistantSid = pathAssistantSid;
            PathTaskSid = pathTaskSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Language != null)
            {
                p.Add(new KeyValuePair<string, string>("Language", Language));
            }

            if (TaggedText != null)
            {
                p.Add(new KeyValuePair<string, string>("TaggedText", TaggedText));
            }

            if (SourceChannel != null)
            {
                p.Add(new KeyValuePair<string, string>("SourceChannel", SourceChannel));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// DeleteSampleOptions
    /// </summary>
    public class DeleteSampleOptions : IOptions<SampleResource> 
    {
        /// <summary>
        /// The assistant_sid
        /// </summary>
        public string PathAssistantSid { get; }
        /// <summary>
        /// The task_sid
        /// </summary>
        public string PathTaskSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteSampleOptions
        /// </summary>
        /// <param name="pathAssistantSid"> The assistant_sid </param>
        /// <param name="pathTaskSid"> The task_sid </param>
        /// <param name="pathSid"> The sid </param>
        public DeleteSampleOptions(string pathAssistantSid, string pathTaskSid, string pathSid)
        {
            PathAssistantSid = pathAssistantSid;
            PathTaskSid = pathTaskSid;
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