using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation.com.ryanafzal.api.resources.misc {

    public interface ILaTeXValue {
        string getLaTeXString();
        bool isMath();
    }
}
