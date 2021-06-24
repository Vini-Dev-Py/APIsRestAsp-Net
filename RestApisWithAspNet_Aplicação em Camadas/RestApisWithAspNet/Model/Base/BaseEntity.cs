using System.ComponentModel.DataAnnotations.Schema;

namespace RestApisWithAspNet.Model.Base
{
    public class BaseEntity
    {
        [Column("id")]
        public int Id { get; set; }
    }
}