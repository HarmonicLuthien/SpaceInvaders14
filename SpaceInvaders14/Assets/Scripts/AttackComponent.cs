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
    private float firingCooldown;
    private float remainingTime;


    public void Fire()
    {
        // Verifica que haya transcurrido el tiempo establecido para el intervado entre disparos.
        if (remainingTime == 0)
        {
            GameObject projectileToBeFired = GetAProjectile();
            projectileToBeFired.transform.position = transform.position;
            projectileToBeFired.GetComponent<Rigidbody2D>().velocity = direction * loadedProjectile.GetSpeed();
            StartCoroutine(StartCountdown());
        }
    }

    private IEnumerator StartCountdown()
    {
        // Método para cronometración del intervalo entre disparos.
        float remainingTime = firingCooldown;
        while (remainingTime > 0)
        {
            yield return new WaitForSeconds(1.0f);
            remainingTime = Mathf.Clamp(remainingTime--, 0f, firingCooldown);
        }
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