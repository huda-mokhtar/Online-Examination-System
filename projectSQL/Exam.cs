//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace projectSQL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Exam
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Exam()
        {
            this.Student_Exam = new HashSet<Student_Exam>();
        }
    
        public int Ex_id { get; set; }
        public string Ex_Des { get; set; }
        public Nullable<int> Duration { get; set; }
        public Nullable<int> C_id { get; set; }
        public Nullable<int> MC { get; set; }
        public Nullable<int> T_F { get; set; }
    
        public virtual course course { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student_Exam> Student_Exam { get; set; }
    }
}
