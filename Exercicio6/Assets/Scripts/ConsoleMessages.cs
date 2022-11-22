using UnityEngine;

public class ConsoleMessages : MonoBehaviour
{
    private EventMaster em;

    private void Awake()
    {
        em = GetComponent<EventMaster>();
    }
    private void ShowConsoleMessage(char key)
    {
        Debug.Log($"{key} was pressed");
    }
   
}
