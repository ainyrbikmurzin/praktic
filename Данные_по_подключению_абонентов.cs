//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sessia_1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Данные_по_подключению_абонентов
    {
        public int Порт { get; set; }
        public Nullable<int> Оборудование { get; set; }
        public string Адрес { get; set; }
        public Nullable<int> Тип_порта { get; set; }
        public string Имя { get; set; }
        public string Фамилия { get; set; }
        public string Отчество { get; set; }
    
        public virtual Данные_по_оборудованию Данные_по_оборудованию { get; set; }
        public virtual Тип_оборудования Тип_оборудования { get; set; }
        public virtual Тип_порта Тип_порта1 { get; set; }
    }
}
