using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleAlienLogic : MonoBehaviour
{
    private LifeComponent myLifeComponent;
    private AttackComponent myAttackComponent;

    private void Awake()
    {
        myLifeComponent = GetComponent<LifeComponent>();
        myAttackComponent = GetComponent<AttackComponent>();
    }
}
