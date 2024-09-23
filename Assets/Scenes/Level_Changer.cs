using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Level_Changer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI levelIdLabel;
    [SerializeField] private List<GameObject> stars;
    // Start is called before the first frame update
    public void SetupLevelButton(int levelId, int startsCount)
    {
        levelIdLabel.text = $"{levelId}";
        SetupStars(startsCount);
    }
    public void SetupStars(int starsCount)
    {
        for (int i = 0; i < stars.Count; i++)
        {
            stars[i].SetActive(i < starsCount);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
