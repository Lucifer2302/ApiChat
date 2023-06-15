using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatApi.Models
{
    public partial class Chatroom
    {
        public string GetLastMessage
        {
            get
            {
                string message = "Ничего нет ";
               
                 try
                {
                    message = ChatMessage
                        .ToList()
                        .LastOrDefault()?
                        .TextMessage ?? "Нет Сообщений";
                    return message;
                }
                catch
                {
                    return message;
                }

            }
        }
    }
}