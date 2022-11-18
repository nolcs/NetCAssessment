using System;
using System.Collections.Generic;

namespace FinalApp.Models
{
    public class Claim
    {

        public int Id { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }

        public string Date { get; set; }

        public int VehicleID { get; set; }

        public virtual Vehicle? Vehicle { get; set; }

    }
}

