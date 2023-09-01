using Assets.Scripts;
using System.Transactions;
using UnityEngine;

public class Shotgun : Weapon
{
    public Shotgun(Bullet bullet)
    {
        _ammo = 30;
        _curentAmmo = _magazin = 15;
        _bullet = bullet;
        _ammoForShot = 3;
    }

    public override void Shoot(Vector2 placeOfShot)
    {
        if (CheckAmmo(_ammoForShot))
        {
            for (float i = -0.5f; i < 1; i += 0.5f)
            {
                Bullet bullet = Instantiate(_bullet, new Vector2(placeOfShot.x + i, placeOfShot.y),
                    Quaternion.identity);
                bullet.Initialize();
            }
            _curentAmmo -= 3;
        }
    }
}






