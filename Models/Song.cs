//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShopMag.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Song
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Song()
        {
            this.Discs = new HashSet<Discs>();
        }
    
        public int ID_Base_Song { get; set; }
        public string Name { get; set; }
        public string Author_Of_The_Text { get; set; }
        public string Author_Of_The_Music { get; set; }
        public System.TimeSpan Time_Sound { get; set; }
        public int ID_Executor { get; set; }
        public int ID_Group { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Discs> Discs { get; set; }
        public virtual Executor Executor { get; set; }
        public virtual Group Group { get; set; }
    }
}
