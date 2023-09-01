using UnityEngine;

namespace Assets.Scripts
{
    public class Player : MonoBehaviour
    {
        private Shooter _shooter = new Shooter();
        private Shooter _pistol = new Shooter();
        private Shooter _shotgun = new Shooter();
        private Shooter _infinitePistol = new Shooter();

        [SerializeField] private Bullet _pistolBullet;

        private Vector2 _mousePosition;

        [SerializeField] private GameObject _pistolPoint;
        private Vector2 _bulletSpawnPoint;

        private void Start()
        {
            _pistol.SetWeapon(new Pistol(_pistolBullet));
            _shotgun.SetWeapon(new Shotgun(_pistolBullet));
            _infinitePistol.SetWeapon(new InfinitePistol(_pistolBullet));
        }

        private void Update()
        {
            _mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            _bulletSpawnPoint = _pistolPoint.gameObject.transform.position;

            transform.position = _mousePosition;

            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                _shooter = _pistol;
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                _shooter = _shotgun;
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                _shooter = _infinitePistol;
            }
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                _shooter.PerformAttack(_bulletSpawnPoint);
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                _shooter.PerformReload();
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                Debug.Log($"Ammo is {_shooter.PerformGetAmmoCount()}");
            }
        }
    }
}