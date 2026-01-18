using UnityEngine;

public abstract class ViewBase : MonoBehaviour
{
    public void SetActive(bool isActive)
    {
        gameObject.SetActive(isActive);
    }
}
