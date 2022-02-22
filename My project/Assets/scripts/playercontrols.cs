using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playercontrols : MonoBehaviour
{
    public float _speed = 0.1f;
    private PlayerInput playerInput;
    private Rigidbody playerphysics;
    private Vector3 _direction;
    // Start is called before the first frame update
    // private void Awake() {
    //     playerphysics = GetComponent<Rigidbody>();
    //     playerInput = GetComponent<PlayerInput>();
    //     Controls controls = new Controls();
    //     controls.Enable();
    //     controls.Player.Move.performed += Move;
    // }
     private void Start() {
        playerphysics = GetComponent<Rigidbody>();
        playerInput = GetComponent<PlayerInput>();
        Controls controls = new Controls();
        controls.Enable();
        controls.Player.Move.performed += Move;
    }

    // Update is called once per frame
    public void Move(InputAction.CallbackContext context)
    {
        Vector2 input = context.ReadValue<Vector2>();
        playerphysics.AddForce(new Vector3(input.x,0,input.y)* _speed, ForceMode.Force);
        Debug.Log("HOLD");
    }

  

}
