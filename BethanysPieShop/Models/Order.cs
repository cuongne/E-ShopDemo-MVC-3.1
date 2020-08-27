using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class Order
    {
        [BindNever]
        public int OrderId { get; set; }
        
        public List<OrderDetail> OrderDetails { get; set; }
        [Required(ErrorMessage = "Plese Enter Your FirstName")]
        [Display(Name ="First Name")]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Plese Enter Your LastName")]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Plese Enter Your AddressLine1")]
        [Display(Name = "Address Line1 ")]
        [StringLength(100)]
        public string AddressLine1 { get; set; }
        [Display(Name = "Address Line2 ")]
        public string AddressLine2 { get; set; }
        [Required(ErrorMessage = "Please enter your zip code")]
        [Display(Name = "Zip code")]
        [StringLength(10, MinimumLength = 4)]
        public string ZipCode { get; set; }
        [Required(ErrorMessage = "Please enter your zip code")]
        [StringLength(50)]
        public string City { get; set; }
        [StringLength(10)]
        public string State { get; set; }
        [Required(ErrorMessage = "Please enter your Country")]
        [StringLength(50)]
        public string Country { get; set; }
        [Required(ErrorMessage = "Please enter your Phone Number")]
        [StringLength(25)]
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        
        public string PhoneNumber { get; set; }
        [Required]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])",
            ErrorMessage = "The email address is not entered in a correct format")]
        public string Email { get; set; }
        [BindNever]
        [ScaffoldColumn(false)]
        public decimal OrderTotal { get; set; }
        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderPlaced { get; set; }
    }
}
