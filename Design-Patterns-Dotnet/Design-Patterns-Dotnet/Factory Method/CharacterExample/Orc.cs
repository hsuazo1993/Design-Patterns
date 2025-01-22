namespace Design_Patterns_Dotnet.Factory_Method.CharacterExample
{
    // Concrete Character classes
    public class Orc : ICharacter
    {
        public string Name => "Orc";
        public int AttackPower => 20;
        public int HP { get; set; } = 50;
        public int Defense => 5;

        public void Attack()
        {
            Console.WriteLine("Orc swings a massive club!");
        }

        public void TakeDamage(int damage)
        {
            int reducedDamage = Math.Max(0, damage - Defense);
            HP -= reducedDamage;
            Console.WriteLine($"Orc takes {reducedDamage} damage! HP remaining: {HP}");
        }
    }
}
