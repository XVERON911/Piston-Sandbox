using UnityEngine;
using UnityEngine.UIElements;

public class UI_Controller : MonoBehaviour
{
   [SerializeField] private UIDocument gameplayUIDocument;
   private Slider throttleSlider;
   private Slider torqueSlider;
    void Start()
    {
        throttleSlider = gameplayUIDocument.rootVisualElement.Q("throttleSlider") as Slider;
        torqueSlider = gameplayUIDocument.rootVisualElement.Q("torqueSlider") as Slider;

        throttleSlider.RegisterValueChangedCallback(handleThrottleSlider);

        torqueSlider.RegisterValueChangedCallback(handleTorqueSlider);
    }

    private void handleThrottleSlider(ChangeEvent<float> evt)
    {
        float newValue = evt.newValue;
        TookInput.ThrottleValue = newValue;
    }

    private void handleTorqueSlider(ChangeEvent<float> evt)
    {
        float newValue = evt.newValue;
        TookInput.TorqueValue = newValue;
    }


    void Update()
    {
        
    }
}
