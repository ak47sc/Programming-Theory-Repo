using UnityEngine;

public class PlaneController : Vehicles
{
    [SerializeField]private float forwardSpeed;

    private float currentForwardSpeed;
    void Update(){
        MoveForward();
    }

    //POLYMORPHISM
    public override void Move(float direction)
    {
        currentForwardSpeed = forwardSpeed; 
        transform.Rotate(speed * Time.deltaTime * direction * transform.right);
    }


    void MoveForward(){
        transform.Translate(currentForwardSpeed * Time.deltaTime * Vector3.forward);
    }

    public override void Damage()
    {
        forwardSpeed = 0;
        base.Damage();
    }

    void OnTriggerEnter(Collider col){
        if(col.transform.CompareTag("Ground")){
            Damage();
        }
    }
}
