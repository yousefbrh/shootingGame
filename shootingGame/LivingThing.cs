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

        public abstract int showHealth();
        public abstract int showAttackDamage();
        public abstract void damage(LivingThing attacker);
    }
}