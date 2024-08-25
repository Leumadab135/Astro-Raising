using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] private Slider _energySlider;
    [SerializeField] private TextMeshProUGUI _textSlider;
    [SerializeField] private Jetpack _jetpack;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _energySlider.value = _jetpack.Energy;
        _textSlider.text = ((int)_jetpack.transform.position.y).ToString();
    }
}
