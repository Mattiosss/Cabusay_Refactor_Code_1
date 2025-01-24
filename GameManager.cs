using UnityEngine;

[RequireComponent(typeof(InputHandler), typeof(MovementController), typeof(CollisionHandler))]
public class GameManager : MonoBehaviour
{
     private InputHandler inputHandler;
    private MovementController movementController;

    private void Awake()
    {
        inputHandler = GetComponent<InputHandler>();
        movementController = GetComponent<MovementController>();
        movementController.Initialize();
    }

    private void Update()
    {
        movementController.Move(inputHandler.InputVector);
    }
}
