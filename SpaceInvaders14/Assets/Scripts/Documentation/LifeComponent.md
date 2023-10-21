# Documentación del Script: LifeComponent

Este script `LifeComponent` es un componente de Unity desarrollado en C# que se utiliza para gestionar la vida, la salud y el escudo de un objeto en un juego. Permite el seguimiento de la salud actual, la recuperación del escudo, la absorción de daño y la desactivación del objeto en caso de que la vida alcance cero.

## Propiedades Públicas

- `CurrentLife`: Propiedad que representa la vida actual del objeto.
- `MaxHealth`: Propiedad que representa la salud máxima del objeto.
- `CurrentHealth`: Propiedad que representa la salud actual del objeto.
- `MaxShield`: Propiedad que representa el escudo máximo del objeto.
- `CurrentShield`: Propiedad que representa el escudo actual del objeto.

## Campos Privados

- `life`: Campo que almacena la vida actual.
- `health`: Campo que almacena un array de dos elementos, donde `health[0]` representa la salud actual y `health[1]` representa la salud máxima.
- `shield`: Campo que almacena un array de dos elementos, donde `shield[0]` representa el escudo actual y `shield[1]` representa el escudo máximo.
- `shieldAbsorbtion`: Campo que determina la cantidad de daño absorbido por el escudo.
- `shieldRecoveryCoolDown`: Campo que define el tiempo de recuperación del escudo.

## Métodos Públicos

- `TakeDamage(int incomingDamage)`: Método que permite al objeto recibir daño. Si el escudo actual es mayor que cero, absorbe parte del daño y actualiza la salud y el escudo restantes.
- `HealDamage(int healedDamage)`: Método para recuperar salud.
- `Die()`: Método que desactiva el objeto si la vida llega a cero.

## Métodos Privados

- `RecoverShield()`: Método privado que se utiliza para la recuperación gradual del escudo después de un período de enfriamiento.

## Uso

Este script se puede adjuntar a objetos de juego en Unity que necesitan un sistema de vida y escudo. Al ajustar las propiedades públicas y privadas, se puede personalizar el comportamiento de la vida y el escudo del objeto.

```csharp
// Ejemplo de uso:
LifeComponent lifeComponent = GetComponent<LifeComponent>();
lifeComponent.TakeDamage(10); // El objeto recibe 10 de daño.
lifeComponent.HealDamage(5);  // Se curan 5 puntos de salud.
