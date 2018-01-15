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
    /// <summary>
    /// 提问类
    /// </summary>
    public partial class Problems
    {
        /// <summary>
        /// 问题编号
        /// </summary>
        public int Problems_Id { get; set; }

        /// <summary>
        /// 问题类型编号
        /// </summary>
        public Nullable<int> Problems_Type_Id { get; set; }

        /// <summary>
        /// 提问用户
        /// </summary>
        public Nullable<int> Problems_UserId { get; set; }

        /// <summary>
        /// 提问时间
        /// </summary>
        public Nullable<System.DateTime> Problems_Time { get; set; }

        /// <summary>
        /// 问题标题
        /// </summary>
        public string Problems_Title { get; set; }

        /// <summary>
        /// 问题具体内容
        /// </summary>
        public string Problems_Content { get; set; }

        /// <summary>
        /// 浏览人数
        /// </summary>
        public Nullable<int> Problems_SeeCount { get; set; }

        /// <summary>
        /// 收藏人数
        /// </summary>
        public Nullable<int> Problems_CollectCount { get; set; }

        /// <summary>
        /// 是否解决
        /// </summary>
        public Nullable<int> Problems_IsSolve { get; set; }

        /// <summary>
        /// 悬赏积分
        /// </summary>
        public Nullable<int> Problems_Money { get; set; }
    }
}