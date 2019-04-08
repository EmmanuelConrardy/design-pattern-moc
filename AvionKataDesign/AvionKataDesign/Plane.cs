using System;
using System.Collections.Generic;
using System.Linq;

namespace AvionKataDesign {
    public class Plane {
        private static Plane instance = null;
        private string position;
        private List<TourDeControle> controlTowers;

        public List<Human> hooman { get; private set; }


        private Plane(){
            position = "0,0";
            controlTowers = new List<TourDeControle>();
        }
        public static Plane GetInstance() {
            if (instance == null)
                instance = new Plane();
            return instance;
        }

        public void SendMessageR2D2() { 
            foreach(var controlTower in controlTowers)
            {
                controlTower.sendMessage(position);

            }
        }

        public void KidnapR2D2(TourDeControle towerNotControlYet)
        {
            controlTowers.Add(towerNotControlYet);
        }

        public void R2D2Pit(List<Human> humen)
        {
            hooman.AddRange(humen);
        }

    }
}