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
    
    public partial class Discs
    {
        public int ID_Discs { get; set; }
        public string Name_Discs { get; set; }
        public int ID_Base_Song { get; set; }
        public string Executor { get; set; }
        public System.TimeSpan Time_Sound { get; set; }
        public int Nomber_Song { get; set; }
    
        public virtual Song Song { get; set; }
    }
}