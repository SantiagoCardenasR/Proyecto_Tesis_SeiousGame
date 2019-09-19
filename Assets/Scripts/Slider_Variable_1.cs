using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slider_Variable_1 : MonoBehaviour
{
    public Slider variable1_slider;
    public Image fill;
    private float counter = 0;
    private void Awake()
    {
        variable1_slider = gameObject.GetComponent<Slider>();
    }
    // Start is called before the first frame update
    void Start()
    {
        variable1_slider.wholeNumbers = true;
        variable1_slider.minValue = 0;
        variable1_slider.maxValue = 100;
        variable1_slider.value = counter;
    }

    // Update is called once per frame
    void Update()
    {
        if (variable1_slider.value <= 30)
        {
            counter++;
            fill.color = Color.red;
        }
        else
            if (variable1_slider.value >= 31 && variable1_slider.value <= 70)
        {
            counter++;
            fill.color = Color.blue;
        }
        else
        if (variable1_slider.value >= 71 && variable1_slider.value <= 100)
        {
            counter++;
            fill.color = Color.green;
        }

        if (counter == 100)
        {
            counter = 0;
        }

        variable1_slider.value = counter;
    }
}
