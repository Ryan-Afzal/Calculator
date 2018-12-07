using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation.com.ryanafzal.api.resources.evaluation {
    /// <summary>
    /// Represents a literal number value.
    /// </summary>
    public class Literal : ITerm {

        private readonly double value;

        public Literal(double value) {
            this.value = value;
        }

        public double GetDoubleValue() {
            return this.value;
        }
    }
}
