using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConferenceDemo.Data.Models
{
    public class ConferenceSession
    {
        [Key]
        public int ConferenceSessionId { get; set; }

        [Required]
        [StringLength(500)]
        public string SessionName { get; set; }

        [Required]
        [StringLength(5000)]
        public string SessionDescription { get; set; }

        [Required]
        [StringLength(128)]
        public string SpeakerUserId { get; set; }

        [ForeignKey("SpeakerUserId")]
        public virtual UserProfile Speaker { get; set; }
    }
}