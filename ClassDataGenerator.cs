using System.Reflection;

namespace MockDataGenerator
{
    class ClassDataGenerator
    {
        public string GetData()
        {
            ClassDataGenerator tmp = new ClassDataGenerator();

            PropertyInfo[] properties = typeof(ClassDataGenerator).GetProperties();
            
            string retVal = "";
            foreach(var property in properties)
            {
                var propName = property.Name;

                if(propName.Contains("FirstName"))
                    retVal += "new ClassDataGenerator() { " + propName + " = " + RandomDataGenerator.GetRandomFirstName() + ", ";
                else if(propName.Contains("LastName"))
                    retVal += "new ClassDataGenerator() { " + propName + " = " + RandomDataGenerator.GetRandomLastName() + ", ";
            }

            return retVal;

        }
    }
}