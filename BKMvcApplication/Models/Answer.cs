//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace BKMvcApplication.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Answer
    {
        public int Answer_Id { get; set; }
        public Nullable<int> Problems_Id { get; set; }
        public Nullable<int> Answer_UserId { get; set; }
        public string Answer_Content { get; set; }
    }
}
