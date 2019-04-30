using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstDemo.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 是否完成
        /// </summary>
        public bool IsComplete { get; set; }

    }
}
