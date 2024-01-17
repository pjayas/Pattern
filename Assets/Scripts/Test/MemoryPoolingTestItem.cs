using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryPoolingTestItem : MonoBase
{
    public float time;

    public override void Open()
    {
        base.Open();
        time = 0f;
        transform.position = new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), 10f);
    }

    public override void UpdateLogic()
    {
        base.UpdateLogic();
        time += Time.deltaTime;
        if (time > 1f)
        {
            Close();
        }
    }
}