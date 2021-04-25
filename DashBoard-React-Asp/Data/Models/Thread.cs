using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DashBoard_React_Asp.Data.Models
{
    public class Thread
    {
        [Key]
        public int Id { set; get; }
        public string Name { get; set; }
        public DateTime PostingTime { get; set; }
        public string Text { get; set; }
        public string Author { get; set; }
        public int BoardId { get; set; }
        public Board Board { get; set; }
        public ICollection<Reply> Replies { get; set; }
        public Thread()
        {
            Replies = new List<Reply>();
        }
    }
}
