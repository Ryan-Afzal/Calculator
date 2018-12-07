using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation.com.ryanafzal.api.resources.evaluation {
    public sealed class Operator : IExpression {

        public Operator ADD = new Operator("+", Associativity.LEFT, 1, delegate(IEnumerator<double> inputs) {
            double o1 = inputs.Current;
            inputs.MoveNext();
            return o1 + inputs.Current;
        });

        public Operator SUBTRACT = new Operator("-", Associativity.LEFT, 1, delegate (IEnumerator<double> inputs) {
            double o1 = inputs.Current;
            inputs.MoveNext();
            return o1 - inputs.Current;
        });

        public Operator MULTIPLY = new Operator("*", Associativity.LEFT, 2, delegate (IEnumerator<double> inputs) {
            double o1 = inputs.Current;
            inputs.MoveNext();
            return o1 * inputs.Current;
        });

        public Operator DIVIDE = new Operator("/", Associativity.LEFT, 2, delegate (IEnumerator<double> inputs) {
            double o1 = inputs.Current;
            inputs.MoveNext();
            return o1 / inputs.Current;
        });

        public Operator POW = new Operator("^", Associativity.LEFT, 3, delegate (IEnumerator<double> inputs) {
            double o1 = inputs.Current;
            inputs.MoveNext();
        return Math.Pow(o1, inputs.Current);
        });

        private static List<Operator> values = new List<Operator>();

        private delegate double Operation(IEnumerator<double> enumerator);
        private string symbol;
        private readonly Associativity associativity;
        private readonly int priority;
        private readonly Operation operation;

        private Operator(string symbol, Associativity associativity, int priority, Operation operation) {
            this.symbol = symbol;
            this.associativity = associativity;
            this.priority = priority;
            this.operation = operation;
            Operator.values.Add(this);
        }

        public string GetSymbol() {
            return this.symbol;
        }

        public Associativity GetAssociativity() {
            return this.associativity;
        }

        public int GetPriority() {
            return this.priority;
        }

        public double GetDoubleValue(IEnumerator<double> inputs) {
            return this.operation.Invoke(inputs);
        }

        public enum Associativity {
            NONE, LEFT, RIGHT
        }

        public static Operator GetOperatorFromSymbol(string symbol) {
            foreach (Operator type in Operator.values) {
                if (type.GetSymbol().Equals(symbol)) {
                    return type;
                }
            }

            throw new ArgumentException("Operator " + symbol + " is undefined.");
        }
    }

}

