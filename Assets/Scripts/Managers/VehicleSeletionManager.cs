using UnityEngine;

public class VehicleSeletionManager : MonoBehaviour
{
    [SerializeField]private Transform indicator;
    [SerializeField]private float indicatorPosition;

    private Transform currentSelectedVehicle;
    void Update(){
        if(Input.GetMouseButtonDown(0)){
            IndicatorPositionUpdate();
        }
    }

    void IndicatorPositionUpdate(){
        Vector3 mousePos = Input.mousePosition;
        Ray mouseToRay = Camera.main.ScreenPointToRay(mousePos);
        if(Physics.Raycast(mouseToRay , out RaycastHit hit)){
            if(hit.transform.TryGetComponent<Vehicles>(out Vehicles component)){
                indicator.position = component.transform.position + Vector3.up * indicatorPosition;
                indicator.gameObject.SetActive(true);
                currentSelectedVehicle = component.transform;
                PlayerInputManager.Instance.SetCurrentVehicle(component);
            }
        }
    }
}
