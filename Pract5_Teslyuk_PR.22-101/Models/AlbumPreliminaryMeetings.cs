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
    
    public partial class AlbumPreliminaryMeetings
    {
        public int meeting_id { get; set; }
        public int request_id { get; set; }
        public System.DateTime meeting_date { get; set; }
        public string location { get; set; }
    
        public virtual AlbumRequests AlbumRequests { get; set; }
    }
}
