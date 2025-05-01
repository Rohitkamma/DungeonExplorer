namespace DungeonExplorer_Simplified
{
    public interface IDamageable
    {
        void TakeDamage(int damage);
    }

    public interface ICollectible
    {
        void Collect();
    }
}
