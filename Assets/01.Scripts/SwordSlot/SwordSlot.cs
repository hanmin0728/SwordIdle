using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class SwordSlot : MonoBehaviour
{
    private SwordSO _swordSO;
    public SwordSO SwordSO 
    { 
        get { return _swordSO; } 
        set 
        {
            _backgroundImage.color = new Color(1, 1, 1, 1);
            _swordImage.sprite = _swordSO.swordSprite;
            _levelText.text = _swordSO.swordLevel.ToString();

        } 
    }

    private TextMeshProUGUI _levelText;
    private Image _swordImage;
    private Image _backgroundImage;
    private void Awake()
    {
        _levelText = transform.Find("BackgroundImage/SwordLevelText").GetComponent<TextMeshProUGUI>();
        _swordImage = transform.Find("BackgroundImage/SwordImage").GetComponent<Image>();
        _backgroundImage = transform.Find("BackgroundImage").GetComponent<Image>();
    }

    void Start()
    {
       
    }

    void Update()
    {
        
    }
}
