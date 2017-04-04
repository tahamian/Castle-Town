using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfrastructureHandler : MonoBehaviour
{
    private float InfrastructureSilderGet;
    private Text InfrastructureValueGet;
    // Use this for initialization
    void Start()
    {
        InfrastructureSilderGet = GameObject.Find("Infrastructure Slider").GetComponent<Slider>().value;
        InfrastructureValueGet = GameObject.Find("Infrastructure Value").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        InfrastructureSilderGet = GameObject.Find("Infrastructure Slider").GetComponent<Slider>().value;
        InfrastructureValueGet.text = Mathf.Round(InfrastructureSilderGet).ToString();
    }
}
