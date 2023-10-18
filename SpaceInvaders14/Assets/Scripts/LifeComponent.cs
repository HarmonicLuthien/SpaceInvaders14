using System;
using UnityEngine;

public class LifeComponent : MonoBehaviour
{
    [SerializeField]
    private int life;
    [SerializeField]
    private int[] health, shield = new int[2];
    [SerializeField]
    private float shieldAbsorbtion, shieldRecoveryCoolDown;
    private float elapsedTime;

    // Llamadas de referencia y asignación para cada valor.
    public int CurrentLife { get { return life; } set { life = value; } }
    public int MaxHealth { get { return health[1]; } set {health[1] = value; } }
    public int CurrentHealth { get { return health[0]; } set { health[0] = value; } }
    public int MaxShield { get { return shield[1]; } set { shield[1] = value; } }
    public int CurrentShield { get { return shield[0]; } set { shield[0] = value; } }

    public void TakeDamage(int incomingDamage)
    {
        // Absorber daño entrante SI y SOLO SI el ESCUDO es mayor o igual a 1.
        if (CurrentShield > 0)
        {
            incomingDamage = (int)(incomingDamage/shieldAbsorbtion);
            CurrentShield = Math.Clamp(CurrentShield - incomingDamage, 0, MaxShield);
        }

        // Restar el daño restante a la salud total.
        CurrentLife = Mathf.Clamp(CurrentHealth - incomingDamage, 0, MaxHealth);

        // Si la salud total llegase a ser cero, iniciar el protocolo de muerte.
        if (CurrentLife == 0)
        {
            Die();
        }
    }

    // Método para recuperación de salud
    public void HealDamage(int healedDamage) => CurrentHealth = Mathf.Clamp(CurrentHealth + healedDamage, 0, MaxHealth);

    public void RecoverShield()
    {
        // PENDIENTE
    }

    // Método para desactivación del objeto
    public void Die() => gameObject.SetActive(false);
}