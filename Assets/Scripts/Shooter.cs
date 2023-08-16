public class Shooter
{
    private IWeapon weapon;

    public void SetWeapon(IWeapon weapon)
    {
        this.weapon = weapon;
    }

    public void PerformAttack()
    {
        weapon?.Shoot();
    }
}






