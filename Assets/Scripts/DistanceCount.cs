using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DistanceCount : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI distanceText;
    [SerializeField] private Transform playerTransform;

    private Vector2 startingPosition;
    public void Start()
    {
        startingPosition = playerTransform.position;
    }
    private void Update()
    {
        Vector2 distance =  (Vector2) playerTransform.position - startingPosition;
        distance.y = 0f;

        if (distance.x < 0)
        {
            distance.x = 0;
        }
        distanceText.text = distance.x.ToString("F0") + "m";

        
    }

}
