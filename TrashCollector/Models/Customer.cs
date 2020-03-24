using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        [Display(Name = "Zip Code")]
        public int ZipCode { get; set; }

        public static List<SelectListItem> DaysOfWeek()
        {
            return new List<SelectListItem>() {
            new SelectListItem ("Monday","Monday", true),
            new SelectListItem ( "Tuesday","Tuesday"),
            new SelectListItem ( "Wednesday", "Wednesday"),
            new SelectListItem ("Thursday","Thursday"),
            new SelectListItem ("Friday", "Friday" ),
            new SelectListItem ("Saturday","Saturday"),
            new SelectListItem ("Sunday", "Sunday")
        };
        }
        public DayOfWeek PickUpDay { get; set; }
        public DateTime ExtraPickUpDate { get; set; }
        public DateTime SuspendStart { get; set; }
        public DateTime SuspendEnd { get; set; }
        public double Balance { get; set; } = 0;
        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
    }
}
