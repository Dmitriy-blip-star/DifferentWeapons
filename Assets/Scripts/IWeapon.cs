using UnityEngine;

public interface IWeapon
{
    void Shoot();
}

public class Pistol : IWeapon
{
    public int ammo = 10;

    public void Shoot()
    {
        if (ammo > 0)
        {
            Debug.Log($"The gun fired. Amount of ammo <color=yellow> {ammo} </color>");
            ammo--;
        }
        else
        {
            Debug.Log("Not enough ammo");
        }
    }
}

public class Shotgun : IWeapon
{
    public int ammo = 15;

    public void Shoot()
    {
        if (ammo >= 3)
        {
            Debug.Log($"The shotgun fired x3 Amount of ammo <color=yellow> {ammo} </color>");
            ammo -= 3;
        }
        else
        {
            Debug.Log("Not enough ammo");
        }
    }
}

public class InfinitePistol : IWeapon
{
    public void Shoot()
    {
        Debug.Log("The  infinite pistol fired");
    }
}






