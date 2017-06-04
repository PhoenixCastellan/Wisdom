using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wisdom.Functions.Request
{
    public class HousePlaceOrderRequest
    {
        /// <summary>
    /// 被查询地址加密（必填）
    /// </summary>
    public string address { get; set; }
    /// <summary>
    /// 被查询邮箱加密（必填）
    /// </summary>
    public string email { get; set; }

    }
}
