//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pract5_Teslyuk_PR._22_101.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductionRequests
    {
        public int production_request_id { get; set; }
        public int album_id { get; set; }
        public int manufacturer_id { get; set; }
        public int quantity { get; set; }
        public Nullable<System.DateTime> request_date { get; set; }
    
        public virtual Albums Albums { get; set; }
    }
}