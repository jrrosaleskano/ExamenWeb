
namespace EXAMENWEB
{
    using System;
    using System.Collections.Generic;
    
    public partial class CURSO
    {
        public int ID { get; set; }
        public Nullable<int> ID_CATEDRATICO { get; set; }
        public string NOMBRE { get; set; }
        public string APROVADO { get; set; }
    
        public virtual catedratico catedratico { get; set; }
    }
}
