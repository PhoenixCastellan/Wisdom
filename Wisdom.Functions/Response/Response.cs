using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wisdom.Functions.Response
{
    public class Response<T>
    {
        /// <summary>
        /// 响应码
        /// </summary>
        public string CODE { get; set; }

        /// <summary>
        /// 响应消息
        /// </summary>
        public string MESSAGE { get; set; }

        /// <summary>
        /// 响应数据
        /// </summary>
        public T data { set; get; }
    }
}
