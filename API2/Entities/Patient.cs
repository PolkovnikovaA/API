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
    
    public partial class Patient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Patient()
        {
            this.Priem = new HashSet<Priem>();
        }
    
        public int Kod_patient { get; set; }
        public Nullable<int> N_karta { get; set; }
        public string Surname { get; set; }
        public string Name_ { get; set; }
        public string Middle_name { get; set; }
        public string Tel_ { get; set; }
        public Nullable<int> Kod_rayon { get; set; }
        public System.DateTime Date_of_birth { get; set; }
        public Nullable<int> N_plot { get; set; }
        public Nullable<int> Kod_pol { get; set; }
        public string Mail { get; set; }
        public string Sostoyaniye { get; set; }
        public Nullable<int> Kod_pasporta { get; set; }
        public Nullable<int> Kod_SNILSA { get; set; }
        public Nullable<int> Kod_POLISA { get; set; }
        public string Image { get; set; }
    
        public virtual Pasport Pasport { get; set; }
        public virtual Pol Pol { get; set; }
        public virtual POLIS POLIS { get; set; }
        public virtual Rayon Rayon { get; set; }
        public virtual SNILS SNILS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Priem> Priem { get; set; }
    }
}
