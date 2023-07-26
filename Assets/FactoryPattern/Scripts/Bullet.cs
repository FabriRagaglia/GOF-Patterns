using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour, IProjectile
{
    public int damage;

    public void Damage()
    {
        Debug.Log($"Damage {damage}");
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }

}
