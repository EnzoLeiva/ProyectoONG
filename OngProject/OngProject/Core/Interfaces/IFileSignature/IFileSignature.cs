using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OngProject.Core.Interfaces.IFileSignature
{
    interface IFileSignature
    {
        Dictionary<string, List<byte[]>>.KeyCollection Keys { get; set; }
        List<byte[]> this[string index]
        {
            get;
            set;
        }
    }
}
