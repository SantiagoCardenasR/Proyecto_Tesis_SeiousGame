using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OnVisible : MonoBehaviour
{
    public Canvas canvas;
    private void OnBecameVisible()
    {
        canvas.enabled = true;
    }

    private void OnBecameInvisible()
    {
        canvas.enabled = false;
    }
}
