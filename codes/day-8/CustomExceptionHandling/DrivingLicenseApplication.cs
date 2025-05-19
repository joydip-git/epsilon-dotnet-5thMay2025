namespace CustomExceptionHandling
{
    internal class DrivingLicenseApplication
    {
        private string name;
        private DateTime datOfBirth;
        private int age;

        public DrivingLicenseApplication() { }

        public DrivingLicenseApplication(string name, DateTime datOfBirth)
        {
            this.name = name;
            this.datOfBirth = datOfBirth;
            CalculateAge();
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public DateTime DatOfBirth
        {
            get => datOfBirth;
            set
            {
                datOfBirth = value;
                CalculateAge();
            }
        }

        public int Age
        {
            get => age;
        }

        private void CalculateAge()
        {
            //TimeSpan diff = DateTime.Now.Subtract(datOfBirth);
            TimeSpan diff = DateTime.Now - datOfBirth;
            int temp = diff.Days / 365;
            if (temp < 18)
            {
                throw new AgeLessThanEighteenException($"permissible age for driving license is eighteen");
            }
            else
                age = temp;
        }
    }
}
