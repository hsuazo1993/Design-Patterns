namespace Design_Patterns_Dotnet.Factory_Method.CharacterExample
{
    // Define the Character interface
    public interface ICharacter
    {
        string Name { get; }
        int AttackPower { get; }
        int HP { get; set; }
        int Defense { get; }
        void Attack();
        void TakeDamage(int damage);
    }
}
