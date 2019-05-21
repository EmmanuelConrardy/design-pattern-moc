using System;
using System.Collections.Generic;
using System.Linq;

//Factory method
namespace AvionKataDesign {

        public class Pilote : Human {
            protected override void SetAccessToCockpit() {
                CanAccessToCockpit = true;
            }
        }
        public class Passenger: Human {

            protected override void SetAccessToCockpit() {
                CanAccessToCockpit = false;
            }
        }

        public class Stewart : Human
        {
            protected override void SetAccessToCockpit() {
                CanAccessToCockpit = false;
            }
        }

        public abstract class Human {
            public bool CanAccessToCockpit {get; internal set;}

            public Human() {
                SetAccessToCockpit();
            }

            protected virtual void SetAccessToCockpit()
            {
                throw new NotImplementedException();
            }
        }
}