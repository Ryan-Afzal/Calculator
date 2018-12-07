using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation.com.ryanafzal.api.resources.evaluation {
    public class Bracket : ITerm {

        private BracketType type;
        private IExpression inner;

        public Bracket(BracketType type, IExpression inner) {
            this.type = type;
            this.inner = inner;
        }

        public BracketType getBracketType() {
            return this.type;
        }

        public double GetDoubleValue() {
            throw new NotImplementedException();
        }

        public IExpression getInnerExpression() {
            return this.inner;
        }

        public sealed class BracketType {
            private static List<BracketType> values = new List<BracketType>();

            public static readonly BracketType PARENTHESES = new BracketType("(", ")");
            public static readonly BracketType CURLYBRACES = new BracketType("{", "}");
            public static readonly BracketType SQUAREBRACES = new BracketType("[", "]");
            public static readonly BracketType ANGLEBRACES = new BracketType("<", ">");

            private string open;
            private string close;

            private BracketType(string open, string close) {
                this.open = open;
                this.close = close;
                BracketType.values.Add(this);
            }

            public string GetOpen() {
                return this.open;
            }

            public string GetClose() {
                return this.close;
            }

            public static BracketType GetTypeFromBracket(string open, string close) {
                foreach (BracketType type in BracketType.values) {
                    if (type.GetOpen().Equals(open) && type.GetClose().Equals(close)) {
                        return type;
                    }
                }

                throw new ArgumentException("Bracket " + open + " " + close + " is undefined.");
            }
        }   

    }
}
