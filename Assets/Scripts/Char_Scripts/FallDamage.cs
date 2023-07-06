using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallDamage : MonoBehaviour
{
    public float can, zaman;
    public bool yerde;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        can = 100;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (yerde)
        {
            if (zaman > 0.2f)
            {
                Canhesapla(zaman);
                zaman = 0;
            }
            else
            {
                zaman = 0;
            }
        }
        else
        {
            zaman += Time.deltaTime;
        }


        if (can <=0)
        {
            SceneManager.LoadScene(0);
        }
    }

    void Canhesapla(float sure)
    {
        can -= sure * 10;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            yerde = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            yerde = false;
        }
    }
}