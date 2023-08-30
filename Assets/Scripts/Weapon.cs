﻿using UnityEngine;

namespace Assets.Scripts
{
    public abstract class Weapon : IWeapon
    {

        protected int _ammo;
        protected int _curentAmmo;
        protected int _magazin;

        protected Bullet _bullet;
        //protected Transform _bulletSpawnPoint;

        public int GetAmmoCount()
        {
            return _ammo;
        }

        public virtual void Reload()
        {
            int delta;
            delta = _magazin - _curentAmmo;

            if (_ammo > 0)
            {
                if (_ammo >= delta)
                {
                    _curentAmmo += delta;
                    _ammo -= delta;
                }
                else if (_ammo < delta)
                {
                    _curentAmmo += _ammo;
                    _ammo = 0;
                }
            }
            else
            {
                Debug.Log("Not enough ammo");
            }
        }
        public abstract void Shoot(Vector2 placeOfShot);

        protected bool CheckAmmo()
        {
            if (_curentAmmo > 0)
            {
                return true;
            }
            else
            {
                Debug.Log("Нет патронов! Перезарядитесь!");
                return false;
            }
        }

    }
}