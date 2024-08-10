using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    public class BaseEntity
    {

       [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        //[Key]
       // [DatabaseGeneratedAttribute(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
    }
}