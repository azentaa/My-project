using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float gravity = 9.8f;
    private float _fallVelocity = 0;
 
    void Update()
    {
        _fallVelocity += gravity * Time.deltaTime;
        GetComponent<CharacterController>().Move(Vector3.down * _fallVelocity * Time.deltaTime);
    }
}
