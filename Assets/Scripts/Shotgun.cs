using UnityEngine;

public class Shotgun : IWeapon
{
    private int _ammo = 15;

    public int GetAmmoCount()
    {
        throw new System.NotImplementedException();
    }

    public void Reload()
    {
        throw new System.NotImplementedException();
    }

    public void Shoot(Vector2 placeOfShot)
    {
        if (_ammo >= 3)
        {
            Debug.Log($"The shotgun fired x3 Amount of ammo <color=yellow> {_ammo} </color>");
            _ammo -= 3;
        }
        else
        {
            Debug.Log("Not enough ammo");
        }
    }
}






