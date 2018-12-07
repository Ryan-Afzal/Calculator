using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation.com.ryanafzal.api.resources.value {
    public class Value {

        private double value;

        public Value(double value) {
            this.value = value;
        }

        public double DoubleValue {
            get {
                return this.value;
            }

            set {
                this.value = value;
            }
        }

    }
}
