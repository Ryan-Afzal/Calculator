using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation.com.ryanafzal.api.resources.evaluation {
    public interface ITerm : IExpression {
        double GetDoubleValue();
    }
}
