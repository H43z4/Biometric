﻿using Models.ViewModels.VehicleRegistration.Core;
using System.ComponentModel.DataAnnotations;

namespace Representative.ViewModels
{
    public class ImPerson:CommonFeature
    {
        [Key]
        public long PersonId { get; set; }

        public long CountryId { get; set; }
        public string Country { get; set; }

        [Required]
        [StringLength(50)]
        public string PersonName { get; set; }

        [StringLength(50)]
        public string FatherHusbandName { get; set; }

        [Required]
        [StringLength(13)]
        public string CNIC { get; set; }

        [StringLength(40)]
        public string Email { get; set; }

        [StringLength(15)]
        public string OldCNIC { get; set; }

        [StringLength(20)]
        public string NTN { get; set; }

        [StringLength(20)]
        public string FTN { get; set; }

        public List<ImAddress> Addresses { get; set; }
        public List<ImPhoneNumber> PhoneNumbers { get; set; }

    }
}
