//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Metalika.Podatkovni_sloj
{
    using System;
    using System.Collections.Generic;
    
    public partial class materijal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public materijal()
        {
            this.stanje_skladista = new HashSet<stanje_skladista>();
            this.stavke_izdatnice = new HashSet<stavke_izdatnice>();
            this.stavke_primke = new HashSet<stavke_primke>();
            this.stavke_naloga = new HashSet<stavke_naloga>();
        }
    
        public int ID_materijal { get; set; }
        public string naziv_materijala { get; set; }
        public string dimenzije { get; set; }
        public string sastav { get; set; }
        public string dodatne_informacije { get; set; }
        public string ID_jed_mjere { get; set; }
    
        public virtual jedinica_mjere jedinica_mjere { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<stanje_skladista> stanje_skladista { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<stavke_izdatnice> stavke_izdatnice { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<stavke_primke> stavke_primke { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<stavke_naloga> stavke_naloga { get; set; }
    }
}
