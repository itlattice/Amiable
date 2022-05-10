using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amiable.SDK.Enum
{
    /// <summary>
    /// Onebot标准的事件类型
    /// </summary>
    public enum EventType
    {
        /// <summary>
        /// 消息事件
        /// </summary>
        MESSAGE,
        /// <summary>
        /// 通知事件
        /// </summary>
        NOTICE,
        /// <summary>
        /// 好友类请求事件
        /// </summary>
        FRIENDREQUEST,
        /// <summary>
        /// 群类请求事件
        /// </summary>
        GROUPREQUEST,
        /// <summary>
        /// 元事件
        /// </summary>
        META_EVENT,
        /// <summary>
        /// 群管理类事件
        /// </summary>
        GROUPADMIN,
        /// <summary>
        /// 框架或插件事件
        /// </summary>
        APPPLUGIN
    }
    /// <summary>
    /// Onebot标准的消息事件类型
    /// </summary>
    public enum MessageEventType
    {
        /// <summary>
        /// 私聊消息
        /// </summary>
        PRIVATE = 1,
        /// <summary>
        /// 群聊消息
        /// </summary>
        GROUP = 2,
        /// <summary>
        /// 在线临时会话
        /// </summary>
        TEMP = 6,
        /// <summary>
        /// 群内临时会话
        /// </summary>
        GROUPTEMP = 4

    }

    public enum MessageEventSubType
    {
        /// <summary>
        /// 私聊子事件类型:好友
        /// </summary>
        FRIEND,
        /// <summary>
        /// 私聊子事件类型:群临时消息
        /// </summary>
        GROUP,
        /// <summary>
        /// 私聊子事件类型:其他人
        /// </summary>
        OTHER,
        /// <summary>
        /// 群聊子事件类型:正常
        /// </summary>
        NORMAL,
        /// <summary>
        /// 群聊子事件类型:匿名
        /// </summary>
        ANONYMOUS,
        /// <summary>
        /// 群聊子事件类型:通知
        /// </summary>
        NOTICE
    }
    /// <summary>
    /// 请求相关事件类型
    /// </summary>
    public enum FriendRequestEventType
    {
        /// <summary>
        /// 单向添加好友
        /// </summary>
        AddFriendOne = 1000,
        /// <summary>
        /// 好友验证对话消息
        /// </summary>
        AddFriendReply = 7,
        /// <summary>
        /// 被删除好友
        /// </summary>
        BeRemovedFriend = 1003,
        /// <summary>
        /// 好友添加请求
        /// </summary>
        SomeoneWantAddFriend=1001
    }
    /// <summary>
    /// 群管理类
    /// </summary>
    public enum AdminGroupEventType
    {
        /// <summary>
        /// 被移出群
        /// </summary>
        BanRemoveGroup = 2007,
        /// <summary>
        /// 群被解散
        /// </summary>
        Dissolution = 2008,
        /// <summary>
        /// 群名称变动
        /// </summary>
        GroupNameChange=2012,
        /// <summary>
        /// 群备注被改变
        /// </summary>
        GroupNickChange=2011,
        /// <summary>
        /// 已被邀请进群
        /// </summary>
        InvitationedGroup=20021,
        /// <summary>
        /// 邀请进群
        /// </summary>
        InvitationGroup=2002,
        /// <summary>
        /// 退出群
        /// </summary>
        RemoveGroup=2006,
        /// <summary>
        /// 群添加请求
        /// </summary>
        WantAddGroup=2001
    }

    public enum AppEventType
    {
        /// <summary>
        /// QQ掉线
        /// </summary>
        DropLine=11004,
        /// <summary>
        /// QQ强制离线
        /// </summary>
        ForceOffline=11003,
        /// <summary>
        /// 手动离线
        /// </summary>
        ManualOffline=11002,
        /// <summary>
        /// QQ登录完成
        /// </summary>
        QQLogin=11001
    }
}
