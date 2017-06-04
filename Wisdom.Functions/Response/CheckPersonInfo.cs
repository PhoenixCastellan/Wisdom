using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wisdom.Functions.Response
{
    public class CheckPersonInfo:Response<string>
    {
        public string compstatus { get; set; }
    }
}
