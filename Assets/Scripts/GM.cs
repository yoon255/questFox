using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GM : MonoBehaviour
{
    #region �̱���
    static public GM instance;

    private void Awake()
    {
        instance = this;
    }
    #endregion

    public enum Progress { ����Ʈ�ޱ���, ����Ʈ����_����X, ����Ʈ����_����O, ����Ʈ�Ϸ� };
    public Progress eProgress = Progress.����Ʈ�ޱ���;
    public TextMeshProUGUI display;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        display.text = eProgress.ToString();    
    }
}
