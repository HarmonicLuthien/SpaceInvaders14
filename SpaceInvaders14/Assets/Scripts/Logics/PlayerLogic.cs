using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerLogic : MonoBehaviour
{
    private LifeComponent myLifeComponent;
    private AttackComponent myAttackComponent;
    private Rigidbody2D myRB2D;
    [SerializeField]
    private float movingSpeed;
    private Vector2 minBounds, maxBounds;

    private void Awake()
    {
        // Conecciones a los componentes de este objeto
        myLifeComponent = GetComponent<LifeComponent>();
        myAttackComponent = GetComponent<AttackComponent>();
        myRB2D = GetComponent<Rigidbody2D>();

        InitBounds();
    }

    private void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>();
        myRB2D.velocityX = moveInput.x * movingSpeed;
    }

    private void OnFire()
    {
        myAttackComponent.Fire();
    }

    private void InitBounds()
    {
        minBounds = Camera.main.ViewportToWorldPoint(Vector2.zero);
        maxBounds = Camera.main.ViewportToWorldPoint(Vector2.one);
    }
}