using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDamage : MonoBehaviour
{
    public float can, zaman;
    public bool yerde;

    // Start is called before the first frame update
    void Start()
    {
        can = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<CharacterController>().isGrounded)
        {
            yerde = true;
        }
        else
        {
            yerde = false;
        }
        if (yerde)
        {
            if (zaman > 1.5f)
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
    }

    void Canhesapla(float sure)
    {
        can -= sure * 10;
    }
}