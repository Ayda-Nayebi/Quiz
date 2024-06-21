using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class LoadingPanel : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private float sliderFillSpeed;
    [SerializeField] private Slider loadingSlider;
   
  
    void Update()
    {
        FillBar();
    }

    private void FillBar()
    {
        loadingSlider.value += sliderFillSpeed;

        if (loadingSlider.value == 1)
        {
            gameObject.SetActive(false);
            mainMenu.SetActive(true);
        }
    }
}
