using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveOnInput : MonoBehaviour
{
    [SerializeField]
    private GameObject _target;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _target.SetActive(!_target.activeSelf);
        }
    }
}
