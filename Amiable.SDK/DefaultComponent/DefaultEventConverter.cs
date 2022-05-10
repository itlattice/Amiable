using Amiable.SDK.Enum;
using Amiable.SDK.EventArgs;
using Amiable.SDK.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amiable.SDK.DefaultComponent
{
    public class DefaultEventConverter
    {
        /// <summary>
        /// PCQQ标准的事件
        /// </summary>
        public enum CommonEventType
        {
            None = -1,
            /// <summary>
            /// 手动离线
            /// </summary>
            ManualOffline=11002,
            /// <summary>
            /// QQ掉线
            /// </summary>
            DropLine=11004,
            /// <summary>
            /// 强制离线
            /// </summary>
            ForceOffline=11003,
            /// <summary>
            /// 好友私聊消息
            /// </summary>
            Friend = 1,
            /// <summary>
            /// 群消息
            /// </summary>
            Group = 2,
            /// <summary>
            /// 来自群的临时消息
            /// </summary>
            GroupTmp = 4,
            /// <summary>
            /// 在线临时会话
            /// </summary>
            OnlineTmp=6,
            /// <summary>
            /// 来自好友验证的对话消息
            /// </summary>
            AddFriendReply = 7,
            /// <summary>
            /// 被请求添加好友
            /// </summary>
            SomeoneWantAddFriend = 1001,
            /// <summary>
            /// 被单向加好友
            /// </summary>
            AddFriendOne=1000,
            /// <summary>
            /// 申请加群
            /// </summary>
            WantAddGroup=2001,
            /// <summary>
            /// 已被邀请加入群
            /// </summary>
            InvitationedGroup = 20021,
            /// <summary>
            /// 群名片变动
            /// </summary>
            GroupNickChange= 2011,
            /// <summary>
            /// 群名称变动
            /// </summary>
            GroupNameChange= 2012,
            /// <summary>
            /// 退出群
            /// </summary>
            RemoveGroup = 2006,
            /// <summary>
            /// 被踢出群
            /// </summary>
            BanRemoveGroup= 2007,
            /// <summary>
            /// 群被解散
            /// </summary>
            Dissolution=2008,
            /// <summary>
            /// 邀请加群
            /// </summary>
            InvitationGroup =2002,
            /// <summary>
            /// 被删除好友
            /// </summary>
            BeRemovedFriend = 1003,
            /// <summary>
            /// QQ登录完成
            /// </summary>
            QQLogin = 11001,
            /// <summary>
            /// 插件启用
            /// </summary>
            PluginEnable = 12001,
            /// <summary>
            /// 插件被禁用
            /// </summary>
            PluginClicked = 12002
        }

    }
}
