using System.Collections.Generic;

namespace YonatanMankovich.KeyboardLightsFun
{
    public class Pattern
    {
        public string Name { get; set; }
        public List<ToggleableKeyStates> StatesList { get; }

        public Pattern(string name, IList<ToggleableKeyStates> statesList) : this(name)
        {
            StatesList = new List<ToggleableKeyStates>(statesList);
        }

        public Pattern(string name)
        {
            Name = name;
            StatesList = new List<ToggleableKeyStates>();
        }

        public Pattern() : this("") { }

        public Pattern Clone()
        {
            return new Pattern(Name, StatesList);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}