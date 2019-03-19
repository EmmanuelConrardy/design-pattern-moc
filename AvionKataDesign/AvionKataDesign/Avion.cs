using System;
using System.Collections.Generic;
using System.Linq;

namespace AvionKataDesign {
    public class Avion {
        private static Avion instance = new Avion();
        private string position;
        private List<TourDeControle> toursDeControle;
        private Avion(){
            position = "0,0";
            toursDeControle = new List<TourDeControle>();
        }
        public static Avion GetInstance()
        {
            return instance;
        }

        public void EmitPosition()
        {
            foreach (var tour in toursDeControle)
            {
                tour.WritePosition(position);
            }
        }

        public void Attach(TourDeControle tourDeControle)
        {
            toursDeControle.Add(tourDeControle);
        }
    }
}