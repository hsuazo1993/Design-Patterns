namespace Design_Patterns_Dotnet.Factory_Method.CharacterExample
{
    // Character Factory
    public static class CharacterFactory
    {
        public static ICharacter CreateCharacter(string characterType)
        {
            switch (characterType.ToLower())
            {
                case "goblin":
                    return new Goblin();
                case "orc":
                    return new Orc();
                case "dragon":
                    return new Dragon();
                default:
                    throw new ArgumentException("Invalid character type.");
            }
        }
    }
}
