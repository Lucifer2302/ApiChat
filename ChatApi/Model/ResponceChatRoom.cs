using ChatApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatApi.Model
{
    public partial class ResponceChatRoom
    {
        public ResponceChatRoom(Chatroom chatroom)
        {
            id = chatroom.id;
            Topic = chatroom.Topic;
            GetLastMessage = chatroom.GetLastMessage;
        }
        public int id { get; set; }
        public string Topic { get; set; }
        public string GetLastMessage { get; set; }
    }
}