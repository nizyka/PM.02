//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace практика_11
{
    using System;
    using System.Collections.Generic;
    
    public partial class Поставки
    {
        public int Код { get; set; }
        public Nullable<int> Размер_поставки { get; set; }
        public Nullable<int> Код_Поставщика { get; set; }
        public Nullable<int> Код_Магазина { get; set; }
    
        public virtual Магазины Магазины { get; set; }
        public virtual Поставщики Поставщики { get; set; }
    }
}
