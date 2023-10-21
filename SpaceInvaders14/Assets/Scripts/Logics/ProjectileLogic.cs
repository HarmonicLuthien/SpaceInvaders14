using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLogic : MonoBehaviour
{
    private Vector2 direction;
    private Rigidbody2D myRB2D;
    private int damage;
    
    public int Damage { get { return damage; } set { damage = value; } }

    private void Awake() { myRB2D = GetComponent<Rigidbody2D>(); }

    private void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.gameObject.tag)
        {
            case "ProjBarrier":
            gameObject.SetActive(false);
            Debug.Log("I got the death barrier");
            return;

            default:
            Debug.Log("I got NOTHING");
            return;
        }
    }
}
