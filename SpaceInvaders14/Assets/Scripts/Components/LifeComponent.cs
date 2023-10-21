using System;
using System.Collections;
using UnityEngine;

public class LifeComponent : MonoBehaviour
{
    [SerializeField]
    private int life;
    [SerializeField]
    private int[] health, shield = new int[2];
    [SerializeField]
    private float shieldAbsorbtion, shieldRecoveryCoolDown;

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
        if (CurrentLife == 0) { Die(); }

        // Reinicia el proceso para la recuperación de escudos al recibir daño.
        StopCoroutine(RecoverShield());
        StartCoroutine(RecoverShield());
    }

    // Método para recuperación de salud
    public void HealDamage(int healedDamage) => CurrentHealth = Mathf.Clamp(CurrentHealth + healedDamage, 0, MaxHealth);

    private IEnumerator RecoverShield()
    {
        // Cronometración del tiempo de recarga para recuperación de escudos.
        float remainingTime = shieldRecoveryCoolDown;
        while (remainingTime > 0f)
        {
            yield return new WaitForSeconds(1.0f);
            remainingTime = Mathf.Clamp(remainingTime--, 0f, shieldRecoveryCoolDown);
        }

        // Una vez terminada la cuenta regresiva, comenzar con la recuperación de escudos.
        while (CurrentShield < MaxShield)
        {
            CurrentShield = Mathf.Clamp(CurrentShield++, 0, MaxShield);
            yield return new WaitForSeconds(1.0f);
        }
    }

    // Método para desactivación del objeto
    public void Die() => gameObject.SetActive(false);
}