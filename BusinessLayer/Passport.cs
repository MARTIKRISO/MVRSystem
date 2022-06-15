using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLayer
{
    public class Passport
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [ForeignKey("Card")]
        public Card Card_Owner { get; set; }
        
        [ForeignKey("Visa")]
        public List<Visa> Visas { get; set; }

        private Passport()
        {

        }

        public Passport(Card ownercard)
        {
            this.Card_Owner = ownercard;
            this.Visas = new List<Visa>();
        }
    }
}
