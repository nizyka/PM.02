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
    
    public partial class Магазины
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Магазины()
        {
            this.Доли = new HashSet<Доли>();
            this.Поставки = new HashSet<Поставки>();
        }
    
        public int Код { get; set; }
        public string Название { get; set; }
        public string Адрес { get; set; }
        public string Телефон { get; set; }
        public Nullable<int> Уставной_капитал { get; set; }
        public Nullable<int> Код_Профиля { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Доли> Доли { get; set; }
        public virtual Профиль Профиль { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Поставки> Поставки { get; set; }
    }
}
