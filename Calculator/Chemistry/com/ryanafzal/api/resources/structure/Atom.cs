using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chemistry.com.ryanafzal.api.resources.structure {
    public sealed class Atom {

        public List<Atom> atoms;

        /*
         * 'Meta' Information
         */
        private string name;
        private string symbol;
        private int number;

        /*
         * Required 'properties'
         * 
         * Mulliken Electronegativity | kJ/mol
         * Electron Affinity | kJ/mol^-1
         * Ionization Energy | kJ/mol
         * 
         * Energy State Properties.
         */

        public double Electronegativity {
            get {
                return (1.97 * Math.Pow(10, -3)) * (this.IonizationEnergy + this.ElectronAffinity) + 0.19;
            }
        }

        public double IonizationEnergy {
            get {
                return 0.0;
            }
        }

        public double ElectronAffinity {
            get {
                return 0.0;
            }
        }

        private Atom(string name, string symbol, int number) {
            this.name = name;
            this.symbol = symbol;
            this.number = number;
        }

    }
}
