using System;
using System.Collections.ObjectModel;

namespace Aufgabe2
{
    public enum Relationship { Family, Friend, Colleague }
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateofBirth { get; set; }
        public Relationship Relation { get; set; }
        public Uri Image { get; set; }
    }
    public class Contacts : ObservableCollection<Person>
    {
        public Contacts()
        {
            Add(new Person
            {
                FirstName = "Luzie",
                LastName = "Engel",
                Email = "luzie.engel@web.de",
                DateofBirth = new DateTime(1996, 2, 11),
                Image = new Uri("pack://application:,,,/images/bild1.jpg"),
                Relation = Relationship.Colleague
            });
            Add(new Person
            {
                FirstName = "Peter",
                LastName = "Sommer",
                Email = "peter.sommer@gmail.com",
                DateofBirth = new DateTime(1993, 10, 22),
                Image = new Uri("pack://application:,,,/images/bild2.jpg"),
                Relation = Relationship.Friend
            });
            Add(new Person
            {
                FirstName = "Adrian",
                LastName = "Steinberg",
                Email = "adrian.steinberg@web.de",
                DateofBirth = new DateTime(1998, 1, 18),
                Image = new Uri("pack://application:,,,/images/bild0.png"),
                Relation = Relationship.Family
            });
            Add(new Person
            {
                FirstName = "Laura",
                LastName = "Jung",
                Email = "laura.jung@o2mail.de",
                DateofBirth = new DateTime(2001, 12, 22),
                Image = new Uri("pack://application:,,,/images/bild3.jpg"),
                Relation = Relationship.Colleague
            });
        }
    }
}
