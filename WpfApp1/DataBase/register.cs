//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class register
    {
        public int userID { get; set; }
        public string userLogin { get; set; }
        public string userPassword { get; set; }
        public string userEmail { get; set; }
    
        public virtual userData userData { get; set; }
    }
}
