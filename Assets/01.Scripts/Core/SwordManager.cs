using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SwordManager : MonoSingleTon<SwordManager>
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
        mergeObj.SwordSO = swordListSO.swordList[GameManager.Instance.userInfo.swordLevel];
        Debug.Log(mergeObj.SwordSO);
        mergeObj.UpdateUI();
    }

    public void NextLevelSword(int level)
    {
        if (level >= swordListSO.swordList.Count)
        {
            return;
        }

        MergeSword mergeObj = Instantiate(mergeSword, transform.position, Quaternion.identity);
        mergeObj.transform.SetParent(mergeObjParentTrm);
        mergeObj.SwordSO = swordListSO.swordList[level];
        Debug.Log(mergeObj.SwordSO);
        mergeObj.UpdateUI();
    }
}
