
namespace EXAMENWEB
{
    using System;
    using System.Collections.Generic;
    
    public partial class catedratico
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public catedratico()
        {
            this.CURSO = new HashSet<CURSO>();
        }
    
        public int ID { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDOS { get; set; }
        public string DPI { get; set; }
        public string ACTIVO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CURSO> CURSO { get; set; }
    }
}
