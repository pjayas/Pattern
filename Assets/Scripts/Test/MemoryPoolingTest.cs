using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryPoolingTest : MonoBehaviour
{
    MemoryPooling<MemoryPoolingTestItem> m_pooling;
    MemoryPoolingTestItem m_lastItem;
    void Start()
    {
        m_pooling = new MemoryPooling<MemoryPoolingTestItem>(transform, 5);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            m_lastItem = m_pooling.Get("memoryPoolingTestItem", item => item.AddComponent<MemoryPoolingTestItem>());
            m_lastItem.Open();
        }

        m_pooling.UpdateLogic();
    }
}