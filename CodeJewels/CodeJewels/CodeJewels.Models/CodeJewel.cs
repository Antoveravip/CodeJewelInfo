namespace CodeJewels.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;

    [DataContract]
    public class CodeJewel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DataMember(IsRequired = true)]
        [ForeignKey("CodeJewelCategory")]
        public int CategoryId { get; set; }

        [DataMember]
        public virtual CodeJewelCategory CodeJewelCategory { get; set; }

        [DataMember]
        public string AuthorEmail { get; set; }

        [DataMember]
        public int Rating { get; set; }

        [Required]
        [DataMember(IsRequired = true)]
        public string Content { get; set; }
    }
}