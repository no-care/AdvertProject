//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Images
    {
        public int ID_Изображения { get; set; }
        public int ID_Объявления { get; set; }
        public string Ссылка_на_изображение { get; set; }
        public string Описание { get; set; }
    
        public virtual Adverts Adverts { get; set; }
    }
}
