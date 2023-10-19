using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLogic : MonoBehaviour
{
    private LifeComponent myLifeComponent;
    private AttackComponent myAttackComponent;
    void Awake()
    {
        // Conecciones a los componentes de este objeto
        myLifeComponent = GetComponent<LifeComponent>();
        myAttackComponent = GetComponent<AttackComponent>();

    }

}