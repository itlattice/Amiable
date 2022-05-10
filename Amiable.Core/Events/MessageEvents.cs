using Amiable.Core.Service;
using Amiable.SDK.Enum;
using Amiable.SDK.EventArgs;

namespace Amiable.Core
{
    /* 目的是将所有的框架参数转换为Onebot标准的事件参数*/

    public static class MessageEvents
    {

        /// <summary>
        /// 私聊消息事件
        /// </summary>
        /// <returns></returns>
        public static int Event_PrivateMessage(long time, long self_id, string sub_type, int msg_id, long user_id, string message, int font, object sender_info)
        {
            AmiableMessageEventArgs eventArgs = new AmiableMessageEventArgs
            {
                EventType = EventType.MESSAGE,
                MessageType = MessageEventType.PRIVATE,
                MessageId = msg_id,
                Robot = self_id,
                RawMessage = message,
                Font = font,
                UserId = user_id,
                Sender = sender_info,
            };

            return Event_PrivateMessage(eventArgs);
        }

        /// <summary>
        /// 以Onebot标准参数触发私聊事件
        /// </summary>
        /// <param name="eventArgs"></param>
        /// <returns></returns>
        public static int Event_PrivateMessage(AmiableMessageEventArgs eventArgs)
        {
            AmiableEventType amiableEventType = AmiableEventType.Private;

            EventCore.InvokeEvents(amiableEventType, eventArgs);
            return (int)eventArgs.HandleResult;
        }

        public static int Event_GroupMessage(long time, long self_id, string sub_type, int msg_id, long group_id, long user_id, string message, int font, object sender_info)
        {

            AmiableMessageEventArgs eventArgs = new AmiableMessageEventArgs
            {
                EventType = EventType.MESSAGE,
                MessageType = MessageEventType.GROUP,
                Timestamp = time,
                Robot = self_id,
                RawMessage = message,
                Font = font,
                GroupId = group_id,
                MessageId = msg_id,
                UserId = user_id,
                Sender = sender_info,
            };
            return Event_GroupMessage(eventArgs);
        }

        public static int Event_GroupTempMessage(long time, long self_id, string sub_type, int msg_id, long group_id, long user_id, string message, int font, object sender_info)
        {

            AmiableMessageEventArgs eventArgs = new AmiableMessageEventArgs
            {
                EventType = EventType.MESSAGE,
                MessageType = MessageEventType.GROUPTEMP,
                Timestamp = time,
                Robot = self_id,
                RawMessage = message,
                Font = font,
                GroupId = group_id,
                MessageId = msg_id,
                UserId = user_id,
                Sender = sender_info,
            };
            return Event_GroupTempMessage(eventArgs);
        }

        public static int Event_GroupTempMessage(AmiableMessageEventArgs eventArgs)
        {
            AmiableEventType amiableEventType = AmiableEventType.GroupTempMessage;

            EventCore.InvokeEvents(amiableEventType, eventArgs);

            return (int)eventArgs.HandleResult;
        }

        /// <summary>
        /// 以Onebot标准参数触发群聊事件
        /// </summary>
        /// <param name="eventArgs"></param>
        /// <returns></returns>
        public static int Event_GroupMessage(AmiableMessageEventArgs eventArgs)
        {
            AmiableEventType amiableEventType = AmiableEventType.Group;

            EventCore.InvokeEvents(amiableEventType, eventArgs);

            return (int)eventArgs.HandleResult;
        }

        public static int Event_MoneyMessage(long time, long self_id, string sub_type, int msg_id, long user_id, string message, int font, object sender_info)
        {
            AmiableMessageEventArgs eventArgs = new AmiableMessageEventArgs
            {
                EventType = EventType.MESSAGE,
                MessageType = MessageEventType.PRIVATE,
                Timestamp = time,
                Robot = self_id,
                RawMessage = message,
                Font = font,
                MessageId = msg_id,
                UserId = user_id,
                Sender = sender_info,
            };

            return Event_MoneyMessage(eventArgs);
        }

        public static int Event_MoneyMessage(AmiableMessageEventArgs eventArgs)
        {
            AmiableEventType amiableEventType = AmiableEventType.Money;
            EventCore.InvokeEvents(amiableEventType, eventArgs);
            return (int)eventArgs.HandleResult;
        }

        public static int Event_TempMessage(long time, long self_id, string sub_type, int msg_id, long user_id, string message, int font, object sender_info)
        {
            AmiableMessageEventArgs eventArgs = new AmiableMessageEventArgs
            {
                EventType = EventType.MESSAGE,
                MessageType = MessageEventType.PRIVATE,
                Timestamp = time,
                Robot = self_id,
                RawMessage = message,
                Font = font,
                MessageId = msg_id,
                UserId = user_id,
                Sender = sender_info,
            };

            return Event_TempMessage(eventArgs);
        }

        public static int Event_TempMessage(AmiableMessageEventArgs eventArgs)
        {
            AmiableEventType amiableEventType = AmiableEventType.OnlineTmp;

            EventCore.InvokeEvents(amiableEventType, eventArgs);
            return (int)eventArgs.HandleResult;
        }
    }
}
