//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SysMec
{
    using System;
    using System.Collections.Generic;
    
    public partial class Emp_Puesto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Emp_Puesto()
        {
            this.Exp_Expediente = new HashSet<Exp_Expediente>();
            this.Us_Usuario = new HashSet<Us_Usuario>();
        }
    
        public string vc_PK_id_puesto { get; set; }
        public string vc_nombre_puesto { get; set; }
        public string vc_id_empresa { get; set; }
    
        public virtual Emp_Empresa Emp_Empresa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Exp_Expediente> Exp_Expediente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Us_Usuario> Us_Usuario { get; set; }
    }
}
