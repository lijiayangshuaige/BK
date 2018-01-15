using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BKMvcApplication.DTO.Problems
{
    /// <summary>
    /// 分页
    /// </summary>
    public class DTO_Num
    {
        /// <summary>
        /// 总页数
        /// </summary>
        public int Num { get; set; }
        /// <summary>
        /// 问题信息
        /// </summary>
        public List<DTO_Problems> DTO_Problems { get; set; }
    }
}