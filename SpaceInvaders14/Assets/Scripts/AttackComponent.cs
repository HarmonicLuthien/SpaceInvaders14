using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackComponent : MonoBehaviour
{
    [SerializeField]
    private ProjectileTypeSO loadedProjectile;
    [SerializeField]
    private GameObject projectileContainer;
    private List<GameObject> projectilePool = new();
    [SerializeField]
    private Vector2 direction;
    [SerializeField]
    private float firingSpeed;
    private float elapsedTime;

    public void Fire()
    {
        // PENDIENTE
    }

    public GameObject GetAProjectile()
    {
        // Itera cada elemento en la lista de proyectos
        foreach (GameObject projectile in projectilePool)
        {
            // En caso de encontrar un objeto desactivado, retornar dicho objecto
            if (!projectile.activeSelf)
            {
                return projectile;
            }
        }

        // En caso de no encontrar algun objecto desactivado, crear uno y retornarlo
        return InstantiateProjectile();
    }

    private GameObject InstantiateProjectile()
    {
        GameObject newProjectile = Instantiate(loadedProjectile.GetPrefab(), projectileContainer.transform);
        projectilePool.Add(newProjectile);
        return newProjectile;
    }
}