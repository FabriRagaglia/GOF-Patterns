using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="ProjectileFactory", menuName ="Projectile factory", order =0)]
public class ProjectileFactory:ScriptableObject
{
    [SerializeField] private GameObject _bullet;
    [SerializeField] private GameObject _bomb;
    [SerializeField] private GameObject _grenade;

    public IProjectile GetProjectile(string type)
    {
        switch (type)
        {
            case "Bullet":
                var bullet = Instantiate(_bullet).GetComponent<IProjectile>();
                return bullet;

            case "Bomb":
                var bomb = Instantiate(_bomb).GetComponent<IProjectile>();
                return bomb;

            case "Grenade":
                var grenade = Instantiate(_grenade).GetComponent<IProjectile>();
                return grenade;

            default:
                Debug.LogError($"The type {type} is not exist");
                return null;
        }

    }
}
