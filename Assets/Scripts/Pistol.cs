using Assets.Scripts;
using UnityEngine;

public class Pistol : Weapon
{
    public Pistol(Bullet bullet)
    {
        _ammo = 30;
        _curentAmmo = _magazin = 10;
        _bullet = bullet;
    }

    public override void Shoot(Vector2 placeOfShot)
    {
        if (CheckAmmo())
        {
            Bullet bullet = MonoBehaviour.Instantiate(_bullet, placeOfShot, Quaternion.identity);
            bullet.Initialize();
            Debug.Log($"The gun fired. Amount of ammo <color=yellow> {_curentAmmo} </color>");
            _curentAmmo--;
        }
    }
}






