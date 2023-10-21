# Documentación del Script: AttackComponent

Este script `AttackComponent` es un componente de Unity desarrollado en C# que se utiliza para gestionar la capacidad de disparo de un objeto en un juego. Permite disparar proyectiles en una dirección específica, con un tiempo de recarga entre disparos.

## Propiedades Privadas

- `loadedProjectile`: Proyectil que se cargará y disparará.
- `projectileContainer`: Contenedor de proyectiles.
- `projectilePool`: Lista que almacena proyectiles para su reutilización.
- `direction`: Dirección en la que se dispararán los proyectiles.
- `firingCooldown`: Tiempo de recarga entre disparos.
- `remainingTime`: Tiempo restante para el próximo disparo.

## Métodos Públicos

- `Fire()`: Método para disparar proyectiles. Verifica si ha transcurrido el tiempo de recarga antes de disparar.
- `GetAProjectile()`: Método para obtener un proyectil de la lista de proyectiles disponibles.

## Métodos Privados

- `StartCountdown()`: Método privado para contar el tiempo de recarga entre disparos.
- `InstantiateProjectile()`: Método privado para instanciar un nuevo proyectil si no hay proyectiles disponibles en la lista.

## Uso

Este script se puede adjuntar a objetos de juego en Unity que necesitan la capacidad de disparar proyectiles. Para utilizarlo, sigue estos pasos:

1. Asigna un proyectil al campo `loadedProjectile` en el Inspector de Unity.
2. Configura el tiempo de recarga deseado en `firingCooldown`.

```csharp
// Ejemplo de uso:
AttackComponent attackComponent = GetComponent<AttackComponent>();
attackComponent.Fire(); // Dispara un proyectil si ha transcurrido el tiempo de recarga.
