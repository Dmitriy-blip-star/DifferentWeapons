using Assets.Scripts;
using UnityEngine;

public class Pistol : Weapon
{
    public Pistol(Bullet bullet)
    {
        _ammo = 30;
        _curentAmmo = _magazin = 10;
        _bullet = bullet;
        _ammoForShot = 1;
    }

    public override void Shoot(Vector2 placeOfShot)
    {
        if (CheckAmmo(_ammoForShot))
        {
            Bullet bullet = Instantiate(_bullet, placeOfShot, Quaternion.identity);
            bullet.Initialize();
            Debug.Log($"The gun fired. Amount of ammo <color=yellow> {_curentAmmo} </color>");
            _curentAmmo--;
        }
    }
}






