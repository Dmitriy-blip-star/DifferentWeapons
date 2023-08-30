using UnityEngine;
public class Shooter
{
    private IWeapon _weapon;

    public void SetWeapon(IWeapon weapon)
    {
        _weapon = weapon;
    }

    public void PerformAttack(Vector2 placeOfShot)
    {
        _weapon?.Shoot(placeOfShot);
    }

    public void PerformReload()
    {
        _weapon?.Reload();
    }

    public int PerformGetAmmoCount()
    {
        return _weapon.GetAmmoCount();
    }
}






