using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Countwiki.Services
{
    public interface IWordCounter
    {
        int CountDistinct(string html);
    }
}
