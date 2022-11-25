using Zinnia.Action;
using WebXR;


public class WebGrip : BooleanAction
{
    public WebXRController controller;

    // Update is called once per frame
    void Update()
    {
        Receive(controller.GetButton(WebXRController.ButtonTypes.Grip));
    }
}
