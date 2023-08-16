using UnityEngine;

namespace Assets.Scripts
{
    public class Player : MonoBehaviour
    {
        Shooter shooter = new Shooter();

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                shooter.SetWeapon(new Pistol());
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                shooter.SetWeapon(new InfinitePistol());
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                shooter.SetWeapon(new Shotgun());
            }
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                shooter.PerformAttack();
            }
        }
    }
}