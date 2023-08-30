using Assets.Scripts;
using UnityEngine;

public class InfinitePistol : Weapon
{
    public InfinitePistol()
    {
        _ammo = 1;
        _curentAmmo = _magazin = 1;
    }

    public override void Shoot(Vector2 placeOfShot)
    {

        Debug.Log($"Infinite gan fired");
    }

    public override void Reload()
    {
        Debug.Log("No recharge required");
    }
}






