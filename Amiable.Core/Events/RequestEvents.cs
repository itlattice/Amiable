using Amiable.Core.Service;
using Amiable.SDK.Enum;
using Amiable.SDK.EventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amiable.Core.Events
{
   public class RequestEvents
    {
        public static int Event_AddFriendOne(long time, long self_id, string sub_type, int msg_id, long user_id, string message, int font, object sender_info)
        {
            AmiableFriendRequestEventArgs eventArgs = new AmiableFriendRequestEventArgs
            {
                EventType = EventType.FRIENDREQUEST,
                RequestType = FriendRequestEventType.AddFriendOne,
                Timestamp = time,
                Robot = self_id,
                RawMessage = message,
                MessageId = msg_id,
                UserId = user_id,
            };
            return Event_AddFriendOne(eventArgs);
        }

        public static int Event_SomeoneWantAddFriend(long time, long self_id, string sub_type, int msg_id, long user_id, string message, int font, object sender_info)
        {
            AmiableFriendRequestEventArgs eventArgs = new AmiableFriendRequestEventArgs
            {
                EventType = EventType.FRIENDREQUEST,
                RequestType = FriendRequestEventType.SomeoneWantAddFriend,
                Timestamp = time,
                Robot = self_id,
                RawMessage = message,
                MessageId = msg_id,
                UserId = user_id,
            };
            return Event_SomeoneWantAddFriend(eventArgs);
        }

        public static int Event_SomeoneWantAddFriend(AmiableFriendRequestEventArgs eventArgs)
        {
            AmiableEventType amiableEventType = AmiableEventType.SomeoneWantAddFriend;

            EventCore.InvokeEvents(amiableEventType, eventArgs);
            return (int)eventArgs.HandleResult;
        }

        public static int Event_BeRemovedFriend(long time, long self_id, string sub_type, int msg_id, long user_id, string message, int font, object sender_info)
        {
            AmiableFriendRequestEventArgs eventArgs = new AmiableFriendRequestEventArgs
            {
                EventType = EventType.FRIENDREQUEST,
                RequestType = FriendRequestEventType.BeRemovedFriend,
                Timestamp = time,
                Robot = self_id,
                RawMessage = message,
                MessageId = msg_id,
                UserId = user_id,
            };
            return Event_BeRemovedFriend(eventArgs);
        }

        public static int Event_BeRemovedFriend(AmiableFriendRequestEventArgs eventArgs)
        {
            AmiableEventType amiableEventType = AmiableEventType.BeRemovedFriend;

            EventCore.InvokeEvents(amiableEventType, eventArgs);
            return (int)eventArgs.HandleResult;
        }

        /// <summary>
        /// 以Onebot标准参数触发私聊事件
        /// </summary>
        /// <param name="eventArgs"></param>
        /// <returns></returns>
        public static int Event_AddFriendOne(AmiableFriendRequestEventArgs eventArgs)
        {
            AmiableEventType amiableEventType = AmiableEventType.AddFriendOne;

            EventCore.InvokeEvents(amiableEventType, eventArgs);
            return (int)eventArgs.HandleResult;
        }

        public static int Event_AddFriendReply(long time, long self_id, string sub_type, int msg_id, long user_id, string message, int font, object sender_info)
        {
            AmiableFriendRequestEventArgs eventArgs = new AmiableFriendRequestEventArgs
            {
                EventType = EventType.FRIENDREQUEST,
                RequestType = FriendRequestEventType.AddFriendReply,
                Timestamp = time,
                Robot = self_id,
                RawMessage = message,
                MessageId = msg_id,
                UserId = user_id,
            };
            return Event_AddFriendReply(eventArgs);
        }

        /// <summary>
        /// 以Onebot标准参数触发私聊事件
        /// </summary>
        /// <param name="eventArgs"></param>
        /// <returns></returns>
        public static int Event_AddFriendReply(AmiableFriendRequestEventArgs eventArgs)
        {
            AmiableEventType amiableEventType = AmiableEventType.AddFriendReply;

            EventCore.InvokeEvents(amiableEventType, eventArgs);
            return (int)eventArgs.HandleResult;
        }
    }
}
