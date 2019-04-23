using System;

namespace DeveloperKataDesign
{
    public abstract class Component {
        private List<Component> components;
        private double score;

        public Component(double score = 0.2)
        {
            components = new List<Component>();
            this.score = score;
        }

        public void AddComponent(Component component) {
            components.Add(component);
        }

        public List<Component> GetComponents() {
            return components;
        }

        public int GetComponentsCount()
        {
            int count = components.Count;
            foreach (var component in components)
            {
                count += component.GetComponentsCount();
            }
            return count;
        }

        public double GetScore()
        {
            double score = 0;
            if (components.Count == 0)
            {
                return this.score;
            }

            foreach (var component in components)
            {
                score += component.GetScore();
            }
            return score;
        }

        //getChildren
    }
}
