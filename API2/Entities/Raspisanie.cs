//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace API2.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Raspisanie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Raspisanie()
        {
            this.Doctor = new HashSet<Doctor>();
        }
    
        public int Kod_raspisanie { get; set; }
        public Nullable<int> N_raspisanie { get; set; }
        public System.DateTime Data_priema { get; set; }
        public Nullable<int> N_kabineta { get; set; }
        public Nullable<int> Kod_smena { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Doctor> Doctor { get; set; }
        public virtual Smena Smena { get; set; }
    }
}
