using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public int butterfliesCount = 0; // 觸碰籤詩的數量
    public ButterflyGenerator butterflyGenerator; 


     void Start()
    {
        if (butterflyGenerator == null)
        {
            butterflyGenerator = FindObjectOfType<ButterflyGenerator>();
        }
    }


    public void CountButterflies()
    {
        butterfliesCount++;
    }

    public void OnTriggerEnter(Collider butterflies)
    {
        if (butterfliesCount >= 5)
        {
            SceneManager.LoadScene(butterflies.gameObject.GetComponent<SceneInfo>().SceneName); // 載入下一個場景
        }
        else
        {
            CountButterflies();
        }
    }
        
}
