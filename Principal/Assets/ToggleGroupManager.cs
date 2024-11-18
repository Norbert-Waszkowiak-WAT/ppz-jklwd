using UnityEngine;
using UnityEngine.UI;

public class ToggleGroupManager : MonoBehaviour
{
    public Toggle toggleOn; 
    public Toggle toggleOff;

    void Start() {
        toggleOn.onValueChanged.AddListener(OnToggleOnChanged);
        toggleOff.onValueChanged.AddListener(OnToggleOffChanged);
    }

    void OnToggleOnChanged(bool isOn) {
        if (isOn) {
            toggleOff.isOn = false; 
        }
        else {
            if(!toggleOff.isOn){
                toggleOn.isOn = true;
            }
        }
    }

    void OnToggleOffChanged(bool isOn) {
        if (isOn) {
            toggleOn.isOn = false; 
        }
        else {
            if(!toggleOn.isOn){
                toggleOff.isOn = true;
            }
        }
    }
}
