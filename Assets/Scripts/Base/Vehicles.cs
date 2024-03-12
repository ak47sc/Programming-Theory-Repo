using UnityEngine;

//Vehicle Base Class
public abstract class Vehicles : MonoBehaviour
{
    [SerializeField]
    private VehicleTypes vehicleType;

    //ENCAPSULATION
    [SerializeField]
    protected float speed;
    [SerializeField]
    protected float turnSpeed;

    public virtual void Move(float direction){
        transform.Translate( speed * Time.deltaTime * direction * Vector3.forward);
    }
    public virtual void Turn(float direction)
    {
        transform.Rotate(turnSpeed * Time.deltaTime * direction * Vector3.up);
    }

    public virtual void Damage(){
        speed = 0;
        turnSpeed = 0;
    }
}
