using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewProjectile", menuName = "Projectile data")]
public class ProjectileTypeSO : ScriptableObject
{
    [SerializeField]
    private GameObject projectilePrefab;
    [SerializeField]
    private int speed, damage;

    public GameObject GetPrefab() { return projectilePrefab; }
    public int GetSpeed() { return speed; }
    public int GetDamage() { return damage; }
}