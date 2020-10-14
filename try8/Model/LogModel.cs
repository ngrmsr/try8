using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using try8.Interface;

namespace try8.Model
{
    public class LogModel : ILogModel
    {
        public int LogModelId { get; set; }
        public string Massege { get; set; }
    }
}
