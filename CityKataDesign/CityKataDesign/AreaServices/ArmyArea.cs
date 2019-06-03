using System.Drawing;
using System.Collections.Generic;
using System.Linq;

namespace CityKataDesign
{
    public class ArmyArea : IArmyService, Visitable
    {
        public ArmyArea(string name, int size, List<Sergent> sergents)
        {
            Name = name;
            Size = size;
            _sergents = sergents;
        }
        public string Name {get; internal set;}
        public int Size {get; set;}
        
        private List<Sergent> _sergents;
        public List<Sergent> GetSergents(){
            return _sergents;
        }
        
        public void Accept(IVisitor visitor) {
            visitor.Visit(this);
        }
    }
    public interface IArmyService{
        List<Sergent> GetSergents();
    }

    public class Sergent
    {
        public string Name {get; set;}
        public int Seniority {get; set;}
        public Sergent(string name, int seniority = 1)
        {
            Name = name;
            Seniority = seniority; 
        }
    }
}