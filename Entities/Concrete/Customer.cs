using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;

namespace Entities.Concrete
{
    public class Customer:IEntity
    {
        [Key] // Bu satır, Id özelliğinin birincil anahtar olduğunu belirtir
        public int UserId { get; set; }
        public string CompanyName { get; set; }

        [ForeignKey("UserId")] // Bu satır, UserId'nin Users tablosundaki birincil anahtar ile ilişkilendirildiğini belirtir
        public User User { get; set; }
    }

}
