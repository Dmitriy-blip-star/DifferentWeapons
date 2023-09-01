using Assets.Scripts;
using UnityEngine;

public interface IWeapon
{
    void Shoot(Vector2 placeOfShot);
    void Reload();
    int GetAmmoCount();
}






