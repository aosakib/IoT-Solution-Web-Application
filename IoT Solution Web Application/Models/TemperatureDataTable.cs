//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IoT_Solution_Web_Application.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TemperatureDataTable
    {
        public int id { get; set; }
        public string Environment { get; set; }
        public string SetPoint { get; set; }
        public string Output { get; set; }
        public string Voltage { get; set; }
        public System.DateTime Time { get; set; }
    }
}
