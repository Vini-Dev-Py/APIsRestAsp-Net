using System.ComponentModel.DataAnnotations.Schema;

namespace RestApisWithAspNet.Model.Base
{
    public class BaseEntity
    {
        [Column("id")]
        public long Id { get; set; }
    }
}