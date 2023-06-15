using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ChatApi.Models;

namespace ChatApi.Model
{
    public partial class ResponceChatRoomEmployee
    {
        public ResponceChatRoomEmployee(ChatroomEmploee chatroomEmploee)
        {
            id = chatroomEmploee.id;
            IdChatRoom = (int)chatroomEmploee.IdChatRoom;
            idEmployee = (int)chatroomEmploee.idEmployee;
        }
        
        public int id { get; set; }
        public int IdChatRoom { get; set; }
        public int idEmployee { get; set; }
    }
}