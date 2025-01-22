namespace Design_Patterns_Dotnet.Factory_Method.CharacterExample
{
    // Concrete Character classes
    public class Dragon : ICharacter
    {
        public string Name => "Dragon";
        public int AttackPower => 50;
        public int HP { get; set; } = 100;
        public int Defense => 10;

        public void Attack()
        {
            Console.WriteLine("Dragon breathes fire!");
        }

        public void TakeDamage(int damage)
        {
            int reducedDamage = Math.Max(0, damage - Defense);
            HP -= reducedDamage;
            Console.WriteLine($"Dragon takes {reducedDamage} damage! HP remaining: {HP}");
        }
    }
}
