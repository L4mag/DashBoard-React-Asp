using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DashBoard_React_Asp.Data.Models
{
    public class Board
    {
        [Key]
        public int Id { set; get; }
        public string Name { get; set; }
        public string Url { get; set; }

        public ICollection<Thread> Threads { get; set; }
        public Board()
        {
            Threads = new List<Thread>();
        }
    }
}
