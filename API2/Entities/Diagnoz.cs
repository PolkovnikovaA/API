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
    
    public partial class Diagnoz
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Diagnoz()
        {
            this.Karta = new HashSet<Karta>();
        }
    
        public int Kod_diagnoz { get; set; }
        public string Diagnoz1 { get; set; }
        public string Surname_doctor { get; set; }
        public string Name_doctor { get; set; }
        public string Middle_name_doctor { get; set; }
        public System.DateTime Data_obrashcheniye { get; set; }
        public System.DateTime Data_vyzdorovleniya { get; set; }
        public Nullable<int> Kod_lecheniye { get; set; }
        public string Profilaktika { get; set; }
        public Nullable<int> Kod_slozhnost { get; set; }
    
        public virtual Lecheniye Lecheniye { get; set; }
        public virtual Slozhnost Slozhnost { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Karta> Karta { get; set; }
    }
}