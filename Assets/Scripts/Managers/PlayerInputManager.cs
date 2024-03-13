using UnityEngine;

public class PlayerInputManager : MonoBehaviour
{
    public static PlayerInputManager Instance{get;private set;}
    [SerializeField]private Vehicles vehicle;
    private const string HORIZONTAL_AXIS = "Horizontal";
    private const string VERTICLE_AXIS = "Vertical";

    float horizontalInput;
    float verticleInput;
    void Awake(){
        if(Instance != null){
            Destroy(gameObject);
            return;
        }
        Instance = this;
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

    public void SetCurrentVehicle(Vehicles vehicle){
        this.vehicle = vehicle;
    }
}
