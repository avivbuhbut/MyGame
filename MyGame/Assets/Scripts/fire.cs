using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{

  

    GameObject other;
    GameObject EnemieNew;
    GameObject heavyBullet1;

    public float firespeed;
    // Start is called before the first frame update
    void Start()
    {
        EnemieNew = GameObject.Find("EnemieNew");
        heavyBullet1 = GameObject.Find("Heavy_Bullet1");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * firespeed * Time.deltaTime, Space.Self);



        void OnTriggerEnter2D(Collider2D colisor)
        {
            Debug.Log("Okay");
            if (colisor.gameObject.tag == "Enemy")
            {
                Destroy(colisor.gameObject);

                Debug.Log("Okay2");
            }


            /*
            void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Enemy")
            {
                //If the GameObject has the same tag as specified, output this message in the console
                Debug.Log("Do something else here");
            }*/
        }
      
    }





}
