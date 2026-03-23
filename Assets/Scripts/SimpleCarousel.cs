using UnityEngine;

public class SimpleCarousel : MonoBehaviour
{
    public GameObject[] items;
    private int currentIndex = 0;

    void Start()
    {
        ShowItem(currentIndex);
    }

    public void Next()
    {
        items[currentIndex].SetActive(false);

        currentIndex++;
        if (currentIndex >= items.Length)
            currentIndex = 0; // loop back

        ShowItem(currentIndex);
    }

    public void Previous()
    {
        items[currentIndex].SetActive(false);

        currentIndex--;
        if (currentIndex < 0)
            currentIndex = items.Length - 1; // loop back

        ShowItem(currentIndex);
    }

    void ShowItem(int index)
    {
        items[index].SetActive(true);
    }
}