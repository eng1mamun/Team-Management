//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeamManagement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class InstituteInfo
    {
        public int InstituteId { get; set; }
        public string InsName { get; set; }
        public string InsShortName { get; set; }
        public Nullable<int> Upazilaid { get; set; }
        public Nullable<int> DistrictId { get; set; }
        public Nullable<int> division_id { get; set; }
        public Nullable<int> InsTypeId { get; set; }
        public Nullable<int> StatusId { get; set; }
        public Nullable<int> GrantedMemberId { get; set; }
    }
}