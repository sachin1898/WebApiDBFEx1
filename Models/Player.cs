//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApiDBFirstEx1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Player
    {
        public int PId { get; set; }
        public string PName { get; set; }
        public Nullable<double> BattingAverage { get; set; }
        public Nullable<double> BowlingAverage { get; set; }
        public string PTeam { get; set; }
    }
}
