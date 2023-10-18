using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLogic : MonoBehaviour
{
    LifeComponent myLifeComponent;
    AttackComponent myAttackComponent;
    void Awake()
    {
        // Conecciones a los componentes de este objeto
        myLifeComponent = GetComponent<LifeComponent>();
        myAttackComponent = GetComponent<AttackComponent>();

    }

    // PENDIENTE
}