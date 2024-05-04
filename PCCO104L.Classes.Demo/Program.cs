using System.Reflection.Metadata;

namespace PCCO104L.Classes.Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Without Class
            string heroNameIronMan = "Iron Man";
            string firstNameIronMan = "Tony";
            string lastNameIronMan = "Stark";
            string fullNameIronMan = $"{heroNameIronMan} - {firstNameIronMan} {lastNameIronMan}";

            string heroNameCaptainAmerica = "CaptainAmerica";
            string firstNameCaptainAmerica = "Steve";
            string lastNameCaptainAmerica = "Rogers";
            string fullNameCaptainAmerica = $"{heroNameCaptainAmerica} - {firstNameCaptainAmerica} {lastNameCaptainAmerica}";
            #endregion

            #region Using Class
            Avenger ironMan = new Avenger();
            ironMan.HeroName = "Iron Man";
            ironMan.FirstName = "Tony";
            ironMan.LastName = "Stark*";
            ironMan.Skill = "Proton Cannon";
            ironMan.SetDamage(150);
            Console.WriteLine(ironMan.Attack());

            Avenger captainAmerica = new Avenger
            {
                HeroName = "Captain America",
                FirstName = "Steve",
                LastName = "Rogers",
                Skill = "Final Justice",
            };
            captainAmerica.SetDamage(120);
            Console.WriteLine(captainAmerica.Attack());

            Avenger blackWidow = new Avenger
            {
                HeroName = "Black Widow",
                FirstName = "Natasha"
            };
            blackWidow.LastName = "Romanof";
            Console.WriteLine(blackWidow.Attack());

            Avenger hawkEye = new Avenger("HawkEye");
            hawkEye.SetDamage(30);
            Console.WriteLine(hawkEye.Attack());

            Avenger hulk = new Avenger("Hulk", "Bruce", "Banner");
            Console.WriteLine(hulk.Attack(100, "Hulk Smash"));
            #endregion
        }
    }
}
