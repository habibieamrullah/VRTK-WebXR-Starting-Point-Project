using Zinnia.Action;
using WebXR;

public class WebThumb : BooleanAction
{
   
    public WebXRController controller;

    // Update is called once per frame
    void Update()
    {
        Receive(controller.GetButton(WebXRController.ButtonTypes.Thumbstick));
    }
}
