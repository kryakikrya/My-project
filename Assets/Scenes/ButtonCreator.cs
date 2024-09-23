using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonCreator : MonoBehaviour
{
    [SerializeField] private int levelCount;
    [SerializeField] private GameObject _prefabLevels;
    [SerializeField] private RectTransform root;
    [SerializeField] private GameObject _PanePlay;
    [SerializeField] private GameObject _PanelExitMainMenu;
    [SerializeField] private GameObject _ButtonPlay;
    // Start is called before the first frame update
    void Start()
    {
        FillLevelMenu();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void FillLevelMenu()
    {
        for (int i = 0; i < levelCount; i++)
        {
            GameObject levelButton = Instantiate(_prefabLevels, root);
            if (levelButton.TryGetComponent(out Level_Changer levelButtonView)) {
                levelButtonView.SetupLevelButton(i + 1, UnityEngine.Random.Range(0, 4));
            }
        }

    }
    public void ClearLevelMenu()
    {
        for (int i = 0; i < root.childCount; i++)
        {
            Destroy(root.GetChild(i).gameObject);
        }
    }

    public void Play()
    {
        _PanePlay.SetActive(false);
        _PanelExitMainMenu.SetActive(true);
        _ButtonPlay.SetActive(true);
    }
    public void ExitToMain()
    {
        _PanePlay.SetActive(true);
        _PanelExitMainMenu.SetActive(false);
        _ButtonPlay.SetActive(true);
    }
}
