//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryManagement2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            this.Issueds = new HashSet<Issued>();
        }
    
        public int EmployeeID { get; set; }
        [Required(ErrorMessage = "Please enter full name")]
        public string FullName { get; set; }
        public string Email { get; set; }
        public Nullable<int> RoleID { get; set; }
        public Nullable<int> LibraryID { get; set; }
    
        public virtual Library Library { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Issued> Issueds { get; set; }
    }
}
