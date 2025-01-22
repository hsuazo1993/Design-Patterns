namespace Design_Patterns_Dotnet.Factory_Method.CharacterExample
{
    // Concrete Character classes
    public class Goblin : ICharacter
    {
        public string Name => "Goblin";
        public int AttackPower => 10;
        public int HP { get; set; } = 20;
        public int Defense => 2;

        public void Attack()
        {
            Console.WriteLine("Goblin attacks with a rusty sword!");
        }

        public void TakeDamage(int damage)
        {
            int reducedDamage = Math.Max(0, damage - Defense);
            HP -= reducedDamage;
            Console.WriteLine($"Goblin takes {reducedDamage} damage! HP remaining: {HP}");
        }
    }
}
