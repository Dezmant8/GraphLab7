using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetAxis : MonoBehaviour
{
    private float horiz;

    void Update()
    {
        horiz = Input.GetAxis("Horizontal");
        
        Debug.Log(horiz);

        transform.Translate(new Vector3(horiz, 0.0f, 0.0f));
    }

}
