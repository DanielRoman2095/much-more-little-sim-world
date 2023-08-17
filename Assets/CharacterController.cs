using UnityEngine;
using UnityEngine.InputSystem;
using Movement;


[RequireComponent(typeof(Rigidbody2D))]
public class CharacterController : MonoBehaviour
{
    private CharacterInputActions characterInput;

    [SerializeField] Rigidbody2D rb;

    [SerializeField] float movementSpeed;

    void Awake()
    {
        characterInput = new CharacterInputActions();
    }

    private void FixedUpdate()
    {
        Vector2 moveInput = characterInput.Movement.Move.ReadValue<Vector2>();
        rb.velocity = moveInput * movementSpeed;
    }

    private void OnEnable() {
        characterInput.Enable();
    }

    private void OnDisable() {
        characterInput.Disable();
    }

   

   


}
