using UnityEngine;

public class AndroidSquareCamElimination : MonoBehaviour {
	void Start ()
    {
        //hope this will help to eliminate square camera on start...
        ARToolkitHelper.OpenCamera();
	    ARToolkitHelper.StartCapture();

	}
}
