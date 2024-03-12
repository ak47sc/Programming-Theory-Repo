using UnityEngine;

//INHERITANCE
public class CarController : Vehicles
{
    void OnTriggerEnter(Collider col){
        if(col.transform.CompareTag("Water")){
            Damage();
        }
    }
}
