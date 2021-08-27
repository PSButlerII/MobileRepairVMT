using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MobileRepairMT.Models
{
    public class Message
    {
        public Guid Id { get; set; }
        public Guid RoomId { get; set; }
        [Required]
        public string Contents { get; set; }
        [Required]
        public string UserName { get; set; }
        public DateTimeOffset PostedAt { get; set; }
    }
}