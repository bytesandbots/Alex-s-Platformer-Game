using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flipCharacter : MonoBehaviour
{
    SpriteRenderer sp;
    // Start is called before the first frame update
    void Start()
    {
        sp = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        if(x > 0){
            sp.flipX = false;

        }
        if(x < 0){
            sp.flipX = true;

        }
    }
}
