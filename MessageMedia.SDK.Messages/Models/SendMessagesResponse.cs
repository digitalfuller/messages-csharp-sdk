/*
 * MessageMediaMessages.PCL
 *
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using APIMATIC.SDK.Common;


namespace MessageMedia.Messages.Models
{
    public class SendMessagesResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private IList<Message> messages;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("messages")]
        public IList<Message> Messages 
        { 
            get 
            {
                return this.messages; 
            } 
            set 
            {
                this.messages = value;
                onPropertyChanged("Messages");
            }
        }
    }
} 