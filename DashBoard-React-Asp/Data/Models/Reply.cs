using System;
using System.ComponentModel.DataAnnotations;

namespace DashBoard_React_Asp.Data.Models
{
    public class Reply
    {
        [Key]
        public int Id { set; get; }
        public string Name { get; set; }
        public DateTime PostingTime { get; set; }
        public string Text { get; set; }
        public string Author { get; set; }
        public int ReplyTo { get; set; }
        public int ThreadId { get; set; }
        public Thread Thread { get; set; }
    }
}
