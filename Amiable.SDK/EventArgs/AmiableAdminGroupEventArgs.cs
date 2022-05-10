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
    /// 群管理类事件
    /// </summary>
   public class AmiableAdminGroupEventArgs : AmiableEventArgs
    {
        [JsonPropertyName("admin_type")]
        [JsonConverter(typeof(EnumConverter<AdminGroupEventType>))]
        public AdminGroupEventType AdminType { get; set; }

        [JsonPropertyName("message_id")]
        public int MessageId { get; set; }

        [JsonPropertyName("group_id")]
        public long GroupId { get; set; }

        [JsonPropertyName("user_id")]
        public long UserId { get; set; }

        [JsonPropertyName("be_user_id")]
        public long BeUserId { get; set; }
        [JsonPropertyName("raw_message")]
        public string RawMessage { get; set; }
    }
}
