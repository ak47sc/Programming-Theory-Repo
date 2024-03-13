using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VehicleSeletionManager : MonoBehaviour
{
    [SerializeField]private Transform _indicator;
    [SerializeField]private GameObject _driveButton;
    [SerializeField]private GameObject _driveText;
    [SerializeField]private float indicatorPosition;

    private Transform currentSelectedVehicle;
    private bool isSelected;

    void Update(){
        if(Input.GetMouseButtonDown(0) && !isSelected){
            IndicatorPositionUpdate();
        }
    }

    void IndicatorPositionUpdate(){
        Vector3 mousePos = Input.mousePosition;
        Ray mouseToRay = Camera.main.ScreenPointToRay(mousePos);
        if(Physics.Raycast(mouseToRay , out RaycastHit hit)){
            if(hit.transform.TryGetComponent<Vehicles>(out Vehicles component)){
                _indicator.position = component.transform.position + Vector3.up * indicatorPosition;
                _indicator.gameObject.SetActive(true);
                currentSelectedVehicle = component.transform;
                PlayerInputManager.Instance.SetCurrentVehicle(component);
                _driveButton.SetActive(true);
            }
        }
    }

    public void StartToDrive(GameObject button){
        PlayerInputManager.Instance.StartToDrive();
        _indicator.gameObject.SetActive(false);
        button.SetActive(false);
        isSelected = true;
        _driveText.SetActive(false);
    }

    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
