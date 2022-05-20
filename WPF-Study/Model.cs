using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace WPF_Study
{
    public class Person
    {
        public string FullName { get; set; }
        public string Id { get; set; }
        public string Roll { get; set; }

        public Person(string s1, string s2, string s3)
        {
            FullName = s1; Id = s2; Roll = s3;  
        }
    }
    class Model : Abstractions.IModel
    {
        public List<Person> people;
        public bool read = false;
        public string path = "list.csv";

        public void ReadFile()
        {
            people = new List<Person>();
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string id = line.Substring(0, line.IndexOf(';'));
                    string name = line.Substring(line.IndexOf(';') + 1, line.LastIndexOf(';') - 2);
                    name = name.Replace(';', ' ');
                    string roll = line.Substring(line.LastIndexOf(';') + 1);
                    Person person = new Person(name, id, roll);
                    people.Add(person);
                }
            }
            read = true;
        }
        public void ShowIn(string message)
        {
            Debug.WriteLine(message);
        }
        public string ListSize()
        {
            return people.Count.ToString();
        }
        public Person FindIn(string message, string b)
        {
            if(!read)
                ReadFile();

            Person p = null;
            if (b == "search" && message != "")
            {
                int index = Int32.Parse(message);
                if (index > 0 && index <= people.Count)
                    p = people[index - 1];
            }
            else if (b == "next")
            {
                if (message != "")
                {
                    int index = Int32.Parse(message);
                    if (index > 0 && index < people.Count)
                        p = people[index];
                    else
                        p = people[0];
                }
                else
                    p = people[0];
            }
            else if (b == "previous")
            {
                if (message != "")
                {
                    int index = Int32.Parse(message);
                    if (index > 1 && index <= people.Count)
                        p = people[index - 2];
                    else
                        p = people[people.Count - 1];
                }
                else
                    p = people[people.Count - 1];
            }
            else if (b == "last")
                p = people[people.Count - 1];
            else if (b == "first")
                p = people[0];

            return p;
        }
        
    }
}
