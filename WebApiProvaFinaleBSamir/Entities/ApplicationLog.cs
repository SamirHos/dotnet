using Microsoft.EntityFrameworkCore.Metadata.Internal;
using static System.Net.WebRequestMethods;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;
using System;
using System.ComponentModel.DataAnnotations;

namespace WebApiProvaFinaleBSamir.Entities
{
    public class ApplicationLog
    {
        [Required]
        public int IdLog { get; set; }
        [Required]
        public string Messaggio { get; set; }
        [Required]
        public Date Timestamp { get; set; }
        public string? EndPointUrl { get; set; }
      

    }
}
