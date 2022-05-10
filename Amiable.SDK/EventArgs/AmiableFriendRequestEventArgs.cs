using Amiable.SDK.Enum;
using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amiable.SDK.EventArgs
{
    /// <summary>
    /// 好友请求类事件
    /// </summary>
    public class AmiableFriendRequestEventArgs : AmiableEventArgs
    {
        [JsonPropertyName("message_type")]
        [JsonConverter(typeof(EnumConverter<FriendRequestEventType>))]
        public FriendRequestEventType RequestType { get; set; }

        [JsonPropertyName("message_id")]
        public int MessageId { get; set; }

        [JsonPropertyName("user_id")]
        public long UserId { get; set; }

        [JsonPropertyName("raw_message")]
        public string RawMessage { get; set; }
    }
}
