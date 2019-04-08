using System;

namespace AvionKataDesign {
    public class TourDeControle {

        private string avionPosition;
        public TourDeControle() {

        }

        public string GetMessagePosition()
        {
            return avionPosition;
        }

        internal void WritePosition(string position)
        {
            this.avionPosition = position;
        }

        internal void sendMessage(string position)
        {
            Console.WriteLine(position);
        }
    }
}