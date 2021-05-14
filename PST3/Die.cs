using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PST3 {
    public class Die {
        // public properties accessible from the outside (public)
        //   - can only be modified from the inside (private set)
        //   - a Die must be created before these can be accessed
        public int FaceValue { get; private set; }
        public int NumSides { get; private set; }

        // private field accessible only from the inside
        private static Random _numberGenerator = new Random();

        // private constant accessible only from the inside
        private const int DEFAULT_NUM_SIDES = 6;

        // object constructor - has the same name as the class
        //                    - used to create new Die objects
        //                    - sets up data members
        //                    - must always be public
        //                    - no return type (not even void)
        public Die() {
            NumSides = DEFAULT_NUM_SIDES;
            FaceValue = 1;
        }

        // overriden object constructor
        //                    - has the same name as the default constructor
        //                    - has a different parameter set
        public Die(int numSides) {
            NumSides = numSides;
            FaceValue = 1;
        }

        // behaviour method - this one is public
        //                  - a Die must be created before this can be used
        public void Roll() {
            FaceValue = _numberGenerator.Next(1, NumSides + 1);
        }
    }
}
