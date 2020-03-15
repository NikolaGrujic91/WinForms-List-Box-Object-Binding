namespace WinFormsObjectListBinding
{
    internal class City
    {
        #region Constructors

        public City(string name, string country)
        {
            this.Name = name;
            this.Country = country;
        }

        #endregion

        #region Properties

        public string Name { get; set; }

        public string Country { get; set; }

        #endregion

        #region Overrides

        public override string ToString()
        {
            return Name + ", " + Country;
        }

        #endregion
    }
}
