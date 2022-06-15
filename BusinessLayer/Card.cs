using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer
{
    public class Card
    {
        [Key]
        [MaxLength(10)]
        public string EGN { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(30)]
        public string MidleName { get; set; }
        [Required]
        [MaxLength(30)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(1)]
        public string Gender { get; set; }
        [Required]
        [MaxLength(14)]
        public string BirthDate { get; set; }
        [Required]
        [MaxLength(14)]
        public string ExpireDate { get; set; }
        [Required]
        [MaxLength(30)]
        public string PlaceOfBirth { get; set; }
        [Required]
        [MaxLength(50)]
        public string Adress { get; set; }
        [Required]
        [MaxLength(300)]
        public int Height { get; set; }
        [Required]
        [MaxLength(15)]
        public string EyeColor { get; set; }
        [Required]
        [MaxLength(20)]
        public string Authority { get; set; }
        [Required]
        [MaxLength(14)]
        public string CreationDate { get; set; }

        private Card()
        {

        }
        public Card(string egn, string image, string fname, string mname, string lname, string gender, string birth, string expire, string placeofb, string adress, int height, string eyercolor, string authority, string creation, int points, string category)
        {
            this.EGN = egn;
            this.FirstName = fname;
            this.MidleName = mname;
            this.LastName = lname;
            this.Gender = gender;
            this.BirthDate = birth;
            this.ExpireDate = expire;
            this.PlaceOfBirth = placeofb;
            this.Adress = adress;
            this.Height = height;
            this.EyeColor = eyercolor;
            this.Authority = authority;
            this.CreationDate = creation;
        }
    }
}
