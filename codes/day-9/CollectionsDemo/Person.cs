namespace CollectionsDemo
{
    public class Person//:Object
    {
        private int id;
        private string name;

        public Person()
        {

        }

        public Person(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj is Person)
            {
                Person other = (Person)obj;
                if (other.id != this.id) return false;
                if (!other.Name.Equals(name))
                    return false;

                return true;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            const int salt = 31;
            return this.id * salt;
        }

        public override string? ToString()
        {
            return $"Name={this.name}, Id={this.id}";
            //return this.GetType().FullName;
        }
    }
}
