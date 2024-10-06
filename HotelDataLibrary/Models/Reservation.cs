using System;

using System.ComponentModel.DataAnnotations;

namespace HotelDataLibrary.Models {
    public partial class Reservation {
        [Key]
        public int Id { get; set; }
        public int? Roomnr { get; set; }
        public int? Usernr { get; set; }

        public virtual Room RoomnrNavigation { get; set; }
        public virtual User UsernrNavigation { get; set; }
    }
}
