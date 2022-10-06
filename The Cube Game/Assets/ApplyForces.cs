using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyForces : MonoBehaviour
{
    Rigidbody ourRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        ourRigidBody = GetComponent<Rigidbody>();  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
         {
            ourRigidBody.AddExplosionForce(100, transform.position + Vector3.down, 2);
         }
    }

    private void OnCollisionEnter(Collision collision)
    {
     S1 ObjectHitHealth =  collision.gameObject.GetComponent<S1>();

        if (ObjectHitHealth)
        {
            print("found health script in object hit");
            ObjectHitHealth.takeDamage(20);

            int ObjectMaxHealth = ObjectHitHealth.whatsYourMaxHealth();
            if (ObjectMaxHealth > 100)
                ObjectHitHealth.takeDamage(100);
        }
        else
        {
            print("Did not find health script in object hit");
        }
    }
}

    
