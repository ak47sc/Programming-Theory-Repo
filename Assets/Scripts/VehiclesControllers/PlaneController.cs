using UnityEngine;

public class PlaneController : Vehicles
{
    [SerializeField]private float forwardSpeed;
    void Update(){
        MoveForward();
    }

    //POLYMORPHISM
    public override void Move(float direction)
    {
        transform.Rotate(speed * Time.deltaTime * direction * transform.right);
    }
    public override void Turn(float direction)
    {
        transform.Rotate(direction * Time.deltaTime * turnSpeed * Vector3.forward);
    }


    void MoveForward(){
        transform.Translate(forwardSpeed * Time.deltaTime * Vector3.forward);
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
