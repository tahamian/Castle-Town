using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EducationHandler : MonoBehaviour
{
    private float EducationSilderGet;
    private Text EducationValueGet;
    // Use this for initialization
    void Start()
    {
        EducationSilderGet = GameObject.Find("Education Slider").GetComponent<Slider>().value;
        EducationValueGet = GameObject.Find("Education Value").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        EducationSilderGet = GameObject.Find("Education Slider").GetComponent<Slider>().value;
        EducationValueGet.text = Mathf.Round(EducationSilderGet).ToString();
    }
}
