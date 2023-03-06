using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SwordManager : MonoBehaviour
{
    [SerializeField] private Transform mergeObjParentTrm;

    [SerializeField] private MergeSword mergeSword;

    public SwordListSO swordListSO;
    void Start()
    {

    }

    void Update()
    {
        
    }

    public void MakeSword()
    {
        MergeSword mergeObj = Instantiate(mergeSword, transform.position, Quaternion.identity);
        mergeObj.transform.SetParent(mergeObjParentTrm);
        mergeObj.SwordSO = swordListSO.swordList[GameManager.Instance.UserInfo.swordLevel];
        Debug.Log(mergeObj.SwordSO);
        mergeObj.UpdateUI();
    }
}
