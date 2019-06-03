using System.Collections.Generic;
using System.Linq;

namespace CityKataDesign
{
    public class EducationalArea : Visitable
    {
        public EducationalArea(string name, string director, List<Educator> educators)
        {
            Name = name;
            Director = director;
            _educators = educators;
        }
        public string Name {get; internal set;}
        public string Director {get; set;}
        
        private List<Educator> _educators;
        public void AddEducator(List<Educator> educators){
            _educators.AddRange(educators);
        }
        public List<Educator> GetEducator(){
            return _educators;
        }

        public void Accept(IVisitor visitor) {
            visitor.Visit(this);
        }
    }
    public interface IEducationalService{
        List<Sergent> GetSergents();
    }

    public class Educator
    {
        public string Name {get; set;}
        public int Degree {get; set;}
        public Educator(string name, int degree = 1)
        {
            Name = name;
            Degree = degree; 
        }
    }
}