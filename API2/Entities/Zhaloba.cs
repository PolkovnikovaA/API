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
    
    public partial class Zhaloba
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Zhaloba()
        {
            this.Visits = new HashSet<Visits>();
        }
    
        public int Kod_zhaloba { get; set; }
        public string Zhaloba1 { get; set; }
        public Nullable<int> Kod_doctor { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Visits> Visits { get; set; }
    }
}
