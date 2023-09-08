namespace _04._Opinion_Poll
{
    using System.Collections.Generic;

    public class Family
    {
        public List<Person> People { get; set; }
        public Family()
        {
            People = new List<Person>();
        }
        public void AddMember(Person member)
        {
            People.Add(member);
        }
        public Person GetOldestMember()
        {
            Person oldestMember = new Person();
            int maxAge = int.MinValue;
            foreach (Person person in People)
            {
                if (person.Age > maxAge)
                {
                    maxAge = person.Age;
                    oldestMember = person;
                }
            }
            return oldestMember;
        }
    }
}
