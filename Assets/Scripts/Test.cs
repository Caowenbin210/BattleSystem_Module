using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    Coroutine coroutine;
    private void Start()
    {
        MonoManager.Instance.AddUpdateListener(TestUpdate);
        coroutine = MonoManager.Instance.StartCoroutine(Do());
    }

    private void TestUpdate()
    {
        Debug.Log(Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.A))
        {
            MonoManager.Instance.RemoveUpdateListener(TestUpdate);
            MonoManager.Instance.StopCoroutine(coroutine);
        }
    }

    private IEnumerator Do()
    {
        yield return new WaitForSeconds(3F);
        Debug.Log("–≠≥Ã≤‚ ‘ÕÍ±œ£°");
    }
}
