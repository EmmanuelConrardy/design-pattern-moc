namespace CityKataDesign
{
    public class EducationalArea
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

        //Report

    }
    public interface IEducationalService{
        List<Sergent> GetSergents();
    }

    public class Educator
    {
        public string Name {get; set;}
        public int Degree {get; set;}
        public Sergent(string name, int Degree = 1)
        {
            Name = name;
            Degree = degree; 
        }
    }
}