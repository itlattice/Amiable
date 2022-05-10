using Amiable.SDK.Enum;
using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amiable.SDK.EventArgs
{
    public class AmiableAppEventArgs : AmiableEventArgs
    {

        [JsonPropertyName("message_type")]
        [JsonConverter(typeof(EnumConverter<AppEventType>))]
        public AppEventType AppType { get; set; }

        [JsonPropertyName("user_id")]
        public long UserId { get; set; }

        [JsonPropertyName("raw_message")]
        public string RawMessage { get; set; }
    }
}
