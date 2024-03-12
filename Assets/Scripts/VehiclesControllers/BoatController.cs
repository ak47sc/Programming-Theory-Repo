using UnityEngine;

public class BoatController : Vehicles
{
    void OnTriggerEnter(Collider col){
        if(col.transform.CompareTag("Ground")){
            Damage();
        }
    }
}
