using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    [SerializeField] private ProjectileFactory _factory;
    public void GetProjectile(string projectileID)
    {
        var projectile = _factory.GetProjectile(projectileID);
        projectile?.Damage();
        projectile?.Destroy();
    }
}
