using ChatApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatApi.Model
{
    public partial class ResponceChatMessage
    {
        public ResponceChatMessage(ChatMessage chatMessage)
        {
            Id = chatMessage.Id;
            idEmployee = (int)chatMessage.idEmployee;
            IdChatRoom = (int)chatMessage.IdChatRoom;
            TextMessage = chatMessage.TextMessage;
            DateTime = (DateTime)chatMessage.DateTime;
            GetMessage = chatMessage.GetMessage;
        }
        public int Id { get; set; }
        public int idEmployee { get; set; }
        public int IdChatRoom { get; set; }
        public string TextMessage { get; set; }
        public DateTime DateTime { get; set; }
        public string GetMessage { get; set; }
    }
}