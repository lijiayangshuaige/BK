using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BKMvcApplication.DTO.Problems
{
    public class DTO_Problems
    {
        /// <summary>
        /// 问题编号
        /// </summary>
        public int Problems_Id { get; set; }

        /// <summary>
        /// 问题类型
        /// </summary>
        public string Problems_Type_Problem { get; set; }

        /// <summary>
        /// 提问用户
        /// </summary>
        public string Problems_Name { get; set; }

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