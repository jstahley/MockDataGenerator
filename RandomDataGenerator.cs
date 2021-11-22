namespace MockDataGenerator 
{
    static class RandomDataGenerator
    {
        public static string GetRandomFirstName()
        {
            string text = File.ReadAllText(@"C:\Users\devgu\OneDrive\Documents\FirstNames.txt");
            List<string> firstNames = text.Split('|').ToList();
            int maxCount = firstNames.Count();
            Random rnd = new Random();
            int index = rnd.Next(0, maxCount);
            return firstNames[index].ToString();
        }

            public static string GetRandomLastName()
        {
            string text = File.ReadAllText(@"C:\Users\devgu\OneDrive\Documents\LastNames.txt");
            List<string> lastNames = text.Split('|').ToList();
            int maxCount = lastNames.Count();
            Random rnd = new Random();
            int index = rnd.Next(0, maxCount);
            return lastNames[index].ToString();
        }
    }
}