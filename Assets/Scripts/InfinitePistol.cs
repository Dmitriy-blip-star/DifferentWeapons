using Assets.Scripts;
using UnityEngine;

public class InfinitePistol : Weapon
{
    public InfinitePistol(Bullet bullet)
    {
        _ammo = 1;
        _curentAmmo = _magazin = 1;
        _bullet = bullet;
        _ammoForShot = 0;
    }

    public override void Shoot(Vector2 placeOfShot)
    {
        if (CheckAmmo(_ammoForShot))
        {
            Bullet bullet = Instantiate(_bullet, placeOfShot, Quaternion.identity);
            bullet.Initialize();
        }

    }
}