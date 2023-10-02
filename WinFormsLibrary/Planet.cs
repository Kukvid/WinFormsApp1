namespace WinFormsLibrary
{
    public struct Planet
    {
        private string name = "";
        public string Name { 
            get { return name; }
            private set 
            { 
                if (value == "Солнце") {
                    name = "Нет, солнце - не планета"; }
                else { 
                    name = value; } 
            }
        }
        public double mass;
        public double volume;
        public double accelerationOfFreeFall;



       public Planet() { 
            this.mass = 0;
            this.volume = 0;   
            this.accelerationOfFreeFall = 0;
            this.Name = string.Empty;
        }
       public Planet(string Name, double mass, double Volume, double accelerationOfFreeFall)
        {
            this.mass = mass;
            this.volume = Volume;
            this.accelerationOfFreeFall = accelerationOfFreeFall;
            this.Name = Name;
        }
    }
}
