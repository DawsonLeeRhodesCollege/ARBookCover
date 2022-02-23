using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VBTN : MonoBehaviour
{
    public GameObject BookDescription; // text for AR button state = off
    public GameObject ReviewDescription; // text for AR button state = on
    public VirtualButtonBehaviour VirtualButton; // our virtual button

    void Start()
    {
        VirtualButton.RegisterOnButtonPressed(OnButtonPressed);
        VirtualButton.RegisterOnButtonReleased(OnButtonReleased);
        ReviewDescription.SetActive(false); // review description text is not shown by default
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        BookDescription.SetActive(false); // do not show book description text
        ReviewDescription.SetActive(true); // show review description text
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        ReviewDescription.SetActive(false); // do not show review description text
        BookDescription.SetActive(true); // show book description text
    }
}
