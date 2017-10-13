/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System.IO;
using System.Text;
using System.Xml.Linq;

namespace Twilio.TwiML.Voice 
{

    /// <summary>
    /// Task TwiML Noun
    /// </summary>
    public class Task : TwiML 
    {
        /// <summary>
        /// TaskRouter task attributes
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Create a new Task
        /// </summary>
        /// <param name="body"> TaskRouter task attributes, the body of the TwiML Element. Also accepts stringified object
        ///            </param>
        public Task(string body = null) : base("Task")
        {
            this.Body = body;
        }

        /// <summary>
        /// Return the body of the TwiML tag
        /// </summary>
        protected override string GetElementBody()
        {
            return this.Body != null ? this.Body : string.Empty;
        }

        /// <summary>
        /// Append a child TwiML element to this element returning this element to allow chaining.
        /// </summary>
        /// <param name="childElem"> Child TwiML element to add </param>
        public new Task Append(TwiML childElem)
        {
            return (Task) base.Append(childElem);
        }

        /// <summary>
        /// Add freeform key-value attributes to the generated xml
        /// </summary>
        /// <param name="key"> Option key </param>
        /// <param name="value"> Option value </param>
        public new Task SetOption(string key, object value)
        {
            return (Task) base.SetOption(key, value);
        }
    }

}