
namespace App
{
    public static class Extensions
    {
        public static bool BalancedBraces(this string value)
        {
            List<char> braces = value
                .ToArray()
                .Where(character => character == '{' || character == '}')
                .ToList();

            if (!braces.Any())
                return true;
            else if (braces[0] == '}')
                return false;
           
            List<char> openBraces = new List<char>();

            for (int i = 0; i < braces.Count(); i++) 
            {
                char bracket = braces[i];

                if (bracket == '{')
                    openBraces.Add(bracket);

                else if (bracket == '}') // Process eliminating open brackets if an closing bracket is detected
                {
                    if (openBraces.Count() > 1 && openBraces[openBraces.Count() - 1] == '{')
                        openBraces.RemoveAt(openBraces.Count() - 1);
                    else if (openBraces.Count() == 1 && openBraces[0] == '{')
                        openBraces.RemoveAt(0);
                    else
                        return false;
                }
            }

            return !openBraces.Any();
        }
    }
}
