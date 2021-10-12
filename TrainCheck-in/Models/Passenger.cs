using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TrainCheck_in.Models
{
    public class Passenger
    {
        [Required(ErrorMessage = "Введіть, будь ласка, номер квитка")]
        [StringLength(10, MinimumLength = 10)]
        [Key]
        public string TicketID { get; set; }

        [Required(ErrorMessage = "Введіть, будь ласка, ім'я")]
        [StringLength(15, MinimumLength = 2)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Введіть, будь ласка, прізвище")]
        [StringLength(20, MinimumLength = 2)]
        public string SurName { get; set; }
     
        public string TypeOfTicket { get; set; }
        public bool Linens { get; set; }
        public bool Tea { get; set; }

    }
}
