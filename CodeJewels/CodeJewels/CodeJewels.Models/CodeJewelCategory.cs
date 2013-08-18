namespace CodeJewels.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;

    [DataContract]
    public class CodeJewelCategory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DataMember(IsRequired = true)]
        [Column(TypeName = "VARCHAR")]
        [StringLength(30)]
        public string Category { get; set; }
    }
}