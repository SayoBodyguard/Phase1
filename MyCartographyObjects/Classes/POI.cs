namespace MyCartographyObjects
{
    public class POI : Coordonnees
    {
        #region VARIABLES
        private string _Description;
        #endregion

        #region MODIFACC
        public string description
        {
            get { return _Description; }
            set { _Description = value; }
        }
        #endregion

        #region CONSTRUCTORS
        public POI(string desc, double longitude, double latitude) : base(longitude, latitude)
        {
            description = desc;
        }
        public POI() : this("HEPL", 50.610746, 5.510144) { }
        #endregion

        #region METHODS
        public override string ToString()
        {
            return "Desc: " + description + "Coordonnées:  " + base.ToString() +  "  ID:" + id;
        }
        #endregion


    }
}

