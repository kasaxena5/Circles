using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Header("Prefabs")]
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private Image fuelBar;
    [SerializeField] private FloatReference fuel;
    [SerializeField] private IntReference score;

    void Start()
    {
        score.value = 0;
    }

    void Update()
    {
        scoreText.SetText("Score: " + score.value);
        fuelBar.rectTransform.sizeDelta = new Vector2(fuel.value, fuelBar.rectTransform.sizeDelta.y);
    }
}
