using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackComponent : MonoBehaviour
{
    [SerializeField]
    private ProjectileTypeSO loadedProjectile;
    private ProjectilePool projectilePool;
    [SerializeField]
    private Vector2 direction;
    [SerializeField]
    private float firingCooldown;
    private float remainingTime;

    private void Awake()
    {
        projectilePool = FindAnyObjectByType<ProjectilePool>();
    }

    public void Fire()
    {
        // Verifica que haya transcurrido el tiempo establecido para el intervado entre disparos.
        if (remainingTime == 0)
        {
            GameObject projectileToBeFired = GetAProjectile();
            projectileToBeFired.SetActive(true);

            projectileToBeFired.transform.position = transform.position;
            ProjectileLogic currentProjLogic = projectileToBeFired.GetComponent<ProjectileLogic>();
            projectileToBeFired.GetComponent<Rigidbody2D>().velocity = loadedProjectile.GetSpeed() * direction;
            currentProjLogic.Damage = loadedProjectile.GetDamage();

            StartCoroutine(StartCountdown());
        }
    }

    private IEnumerator StartCountdown()
    {
        // Método para cronometración del intervalo entre disparos.
        float remainingTime = firingCooldown;
        while (remainingTime > 0f)
        {
            yield return new WaitForSeconds(1.0f);
            remainingTime--;
        }
        remainingTime = 0f;
    }

    private GameObject GetAProjectile()
    {
        // Itera cada elemento en la lista de proyectos
        foreach (GameObject projectile in projectilePool.pool)
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
        GameObject newProjectile = Instantiate(loadedProjectile.GetPrefab(), projectilePool.gameObject.transform);
        projectilePool.pool.Add(newProjectile);
        return newProjectile;
    }
}