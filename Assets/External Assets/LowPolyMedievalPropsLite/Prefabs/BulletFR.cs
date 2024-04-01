using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFR : MonoBehaviour
{
    public float speed = 40.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }


    void OnCollisionEnter(Collision col)
    {
        if (col.transform.tag == "Enemy")
        {
            col.gameObject.GetComponent<Enemy>().health -= 1;
            Destroy(this.gameObject);
        }

    }
}
