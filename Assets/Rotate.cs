using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    [SerializeField]
    private float _Speed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, _Speed * Time.deltaTime, 0f);
    }
}
