using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ChatApi.Models;
using ChatApi.Model;

namespace ChatApi.Controllers
{
    public class ChatroomEmploeesController : ApiController
    {
        private Chat_ApiEntities db = new Chat_ApiEntities();

        // GET: api/ChatroomEmploees
        public IHttpActionResult GetChatroomEmploee()
        {
            return Ok(db.ChatroomEmploee.ToList().ConvertAll(i => new ResponceChatRoomEmployee(i)));
        }

        // GET: api/ChatroomEmploees/5
        [ResponseType(typeof(ChatroomEmploee))]
        public IHttpActionResult GetChatroomEmploee(int id)
        {
            ChatroomEmploee chatroomEmploee = db.ChatroomEmploee.Find(id);
            if (chatroomEmploee == null)
            {
                return NotFound();
            }

            return Ok(chatroomEmploee);
        }

        // PUT: api/ChatroomEmploees/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutChatroomEmploee(int id, ChatroomEmploee chatroomEmploee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != chatroomEmploee.id)
            {
                return BadRequest();
            }

            db.Entry(chatroomEmploee).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChatroomEmploeeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/ChatroomEmploees
        [ResponseType(typeof(ChatroomEmploee))]
        public IHttpActionResult PostChatroomEmploee(ChatroomEmploee chatroomEmploee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ChatroomEmploee.Add(chatroomEmploee);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = chatroomEmploee.id }, chatroomEmploee);
        }

        // DELETE: api/ChatroomEmploees/5
        [ResponseType(typeof(ChatroomEmploee))]
        public IHttpActionResult DeleteChatroomEmploee(int id)
        {
            ChatroomEmploee chatroomEmploee = db.ChatroomEmploee.Find(id);
            if (chatroomEmploee == null)
            {
                return NotFound();
            }

            db.ChatroomEmploee.Remove(chatroomEmploee);
            db.SaveChanges();

            return Ok(chatroomEmploee);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ChatroomEmploeeExists(int id)
        {
            return db.ChatroomEmploee.Count(e => e.id == id) > 0;
        }
    }
}