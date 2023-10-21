# Documentación del Script: ProjectileLogic

Este script `ProjectileLogic` es un componente de Unity desarrollado en C# que controla la lógica de un proyectil en un juego. Gestiona la dirección, el daño y las colisiones del proyectil.

## Propiedades Privadas

- `direction`: Dirección en la que se desplaza el proyectil.
- `myRB2D`: Componente `Rigidbody2D` que controla el movimiento del proyectil.
- `damage`: Daño que inflige el proyectil.

## Propiedades Públicas

- `Damage`: Propiedad que permite obtener y establecer el valor del daño del proyectil.

## Métodos Privados

- `Awake()`: Método que se ejecuta al iniciar el juego. Inicializa el componente `Rigidbody2D`.
- `OnTriggerEnter2D(Collider2D other)`: Método que se llama cuando el proyectil colisiona con otro objeto. Controla el comportamiento del proyectil en función del objeto con el que colisiona.

## Uso

Este script se utiliza para controlar la lógica de los proyectiles en un juego. Para configurar un proyectil con este script, sigue estos pasos:

1. Asegúrate de que el proyectil tenga el componente `Rigidbody2D` adjunto en el Inspector de Unity.

2. Asigna el valor de daño deseado en la propiedad `Damage`.

```csharp
// Ejemplo de uso:
ProjectileLogic projectileLogic = GetComponent<ProjectileLogic>();
int damage = projectileLogic.Damage; // Obtén el valor de daño del proyectil.
projectileLogic.OnTriggerEnter2D(collider2D); // Controla la colisión del proyectil.
