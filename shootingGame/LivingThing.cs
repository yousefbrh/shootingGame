namespace shootingGame
{
    public abstract class LivingThing
    {
        protected int health;
        protected int attackDamage;

        public LivingThing(int health = 0 , int attackDamage = 0)
        {
            this.health = health;
            this.attackDamage = attackDamage;
        }

        public abstract int GetHealth();
        public abstract int GetAttackDamage();
        public abstract void Damage(LivingThing attacker);
    }
}