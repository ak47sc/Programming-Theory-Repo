using UnityEngine;

public class PlayerInputManager : MonoBehaviour
{
    [SerializeField]private Vehicles vehicle;
    private const string HORIZONTAL_AXIS = "Horizontal";
    private const string VERTICLE_AXIS = "Vertical";

    float horizontalInput;
    float verticleInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis(HORIZONTAL_AXIS);
        verticleInput = Input.GetAxis(VERTICLE_AXIS);

        //ABSTRACTION & POLYMORPHISM
        vehicle.Move(verticleInput);
        vehicle.Turn(horizontalInput);
    }
}
