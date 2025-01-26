using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour
{
    public enum Progress { 퀘스트받기전, 퀘스트받음_수행X, 퀘스트받음_수행O, 퀘스트완료 };
    public Progress eProgress = Progress.퀘스트받기전;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
