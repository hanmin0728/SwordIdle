using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class MergeSword : MonoBehaviour
{
    private SwordSO swordSO;
    public SwordSO SwordSO { get { return swordSO; } set { swordSO = value; } }

    public Image image;
    public TextMeshProUGUI levelText;


    private bool isClick = false;

    private void Awake()
    {
        image = transform.GetChild(0).GetComponent<Image>();
        levelText = transform.GetChild(1).GetComponent<TextMeshProUGUI>();
    }

    private void OnMouseDown()
    {
        isClick = false;   
    }
    private void OnMouseDrag()
    {
        
    }

    private void OnMouseUp()
    {
        isClick = true;    
    }

    public void UpdateUI()
    {
        image.sprite = swordSO.swordSprite;
        levelText.text = swordSO.swordLevel.ToString();
    }
}
