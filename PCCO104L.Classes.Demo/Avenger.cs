namespace PCCO104L.Classes.Demo
{
    // <access modifier> class <name>
    public class Avenger
    {
        #region Fields
        private string _heroName = string.Empty;
        #endregion

        #region Properties
        public string HeroName
        { 
            get { return _heroName; }
            set { _heroName = value; }
        }

        public string FirstName { get; set; } = "FirstName";
        
        private string _lastName = "LastName";
        public string LastName
        {
            get { return _lastName.ToUpper(); }
            set { _lastName = value.Replace("*", string.Empty); }
        }

        public string FullName 
        {
            get
            {
                return $"{HeroName} - {FirstName} {LastName}";
            }
        }

        public int Damage { get; private set; }

        private string _skill = string.Empty;
        public string Skill
        {
            get 
            {
                if (string.IsNullOrEmpty(_skill)) { return "Normal Attack"; }
                return _skill;
            }
            set
            {
                if (value == null)
                {
                    _skill = string.Empty;
                }
                else
                {
                    _skill = value;
                }
            }
        }
        #endregion

        #region Constructor and Constructor Overloading
        public Avenger() { }

        public Avenger(string heroName)
        { 
            HeroName=heroName;
        }

        public Avenger(string heroName, string first, string last) : this(heroName)
        {
            FirstName = first;
            LastName = last;
        }
        #endregion

        #region Methods and Method Overloading
        public void SetDamage(int damage)
        { 
            Damage = damage;
        }

        public string Attack()
        {
            return $"{FullName} attacks using {Skill} with {Damage} damage.";
        }

        public string Attack(int damage, string skill)
        {
            SetDamage(damage);
            _skill = skill;

            return Attack();
        }
        #endregion
    }
}
