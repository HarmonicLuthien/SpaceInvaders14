# Documentación del Script: PlayerLogic

Este script `PlayerLogic` es un componente de Unity desarrollado en C# que controla la lógica de un jugador en un juego. Gestiona la vida del jugador, su capacidad de disparo y su movimiento.

## Propiedades Privadas

- `myLifeComponent`: Componente que almacena la vida del jugador.
- `myAttackComponent`: Componente que maneja la capacidad de disparo del jugador.
- `myRB2D`: Componente `Rigidbody2D` que controla el movimiento del jugador.
- `movingSpeed`: Velocidad de movimiento del jugador.
- `minBounds` y `maxBounds`: Limites del juego en los que el jugador puede moverse.

## Métodos Privados

- `Awake()`: Método que se ejecuta al iniciar el juego. Realiza conexiones a los componentes y llama a `InitBounds()` para configurar los límites del juego.
- `OnMove(InputValue value)`: Método que se llama cuando se detecta entrada de movimiento. Controla el movimiento del jugador en respuesta a la entrada del jugador.
- `OnFire()`: Método que se llama cuando se dispara. Llama al método `Fire()` del componente `myAttackComponent` para disparar proyectiles.
- `InitBounds()`: Método para inicializar los límites del juego en función de la cámara.

## Uso

Este script se utiliza para controlar un personaje jugable en un juego. Para configurar un jugador con este script, sigue estos pasos:

1. Asegúrate de que el objeto jugador tenga el componente `LifeComponent` y `AttackComponent` adjuntos en el Inspector de Unity.

2. Asigna la velocidad de movimiento deseada en `movingSpeed`.

3. Asegúrate de que la cámara principal en la escena esté configurada adecuadamente, ya que `InitBounds()` utiliza la cámara para establecer los límites del juego.

```csharp
// Ejemplo de uso:
PlayerLogic playerLogic = GetComponent<PlayerLogic>();
playerLogic.OnMove(inputValue); // Controla el movimiento del jugador.
playerLogic.OnFire(); // El jugador dispara.
