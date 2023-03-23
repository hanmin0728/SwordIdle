using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class MergeSword : MonoBehaviour, IDragHandler, IDropHandler
{
    private SwordSO swordSO;
    public SwordSO SwordSO { get { return swordSO; } set { swordSO = value; } }

    public Image image;
    public TextMeshProUGUI levelText;


    private bool isDragging = false;

    private void Awake()
    {
        image = transform.GetChild(0).GetComponent<Image>();
        levelText = transform.GetChild(1).GetComponent<TextMeshProUGUI>();
    }

    
    
    public void UpdateUI()
    {
        image.sprite = swordSO.swordSprite;
        levelText.text = swordSO.swordLevel.ToString();
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("�巡����");
        isDragging = true;
        //Vector3 mousePos = Camera.main.WorldToScreenPoint(Input.mousePosition);
        //mousePos.z = 0;

        //transform.position = mousePos;
        transform.position = Input.mousePosition;
    }

    public void OnDrop(PointerEventData eventData)
    {
        isDragging = false;

        Debug.Log("�巡�� ����");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("�浹��");
        if (isDragging && collision.gameObject.GetComponent<MergeSword>().swordSO.swordLevel == this.swordSO.swordLevel)
        {
            SwordManager.Instance.NextLevelSword(swordSO.swordLevel);

            Destroy(this.gameObject);
            Destroy(collision.gameObject);

            Debug.Log("�����Ŷ� ��ĥ�� ����");
        }
        else
        {
            Debug.Log("������ �޶� ��ĥ�� ����");
        }
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    Debug.Log("�浹��");
    //    if (collision.gameObject.GetComponent<MergeSword>().swordSO.swordLevel == this.swordSO.swordLevel)
    //    {
    //        Debug.Log("�����Ŷ� ��ĥ�� ����");
    //    }
    //    else
    //    {
    //        Debug.Log("������ �޶� ��ĥ�� ����");
    //    }
    //}

}
