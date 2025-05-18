using UnityEngine;

public class NextPage : MonoBehaviour
{

    [SerializeField] private GameObject firstPage;
    [SerializeField] private GameObject page1;
    [SerializeField] private GameObject page2;
    [SerializeField] private GameObject page3;
    [SerializeField] private GameObject page4;
    [SerializeField] private GameObject page5;
    [SerializeField] private GameObject page6;
    [SerializeField] private GameObject page7;
    [SerializeField] private GameObject page8;
    [SerializeField] private GameObject page9;
    [SerializeField] private GameObject page10;
   public void CloseFirstPage()
    {
        firstPage.SetActive(false);
    }

    public void NextPagee()
    {
        if(page1.activeSelf)
        {
            page1.SetActive(false);
            page2.SetActive(true);

        }
        else if(page2.activeSelf)
        {
            page2.SetActive(false);
            page3.SetActive(true);
        }
        else if (page3.activeSelf)
        {
            page3.SetActive(false);
            page4.SetActive(true);
        }
        else if (page4.activeSelf)
        {
            page4.SetActive(false);
            page5.SetActive(true);
        }
        else if (page5.activeSelf)
        {
            page5.SetActive(false);
            page6.SetActive(true);
        }

    }

    public void PreviousPage()
    {

        if (page1.activeSelf)
        {
        

        }
        else if (page2.activeSelf)
        {
            page1.SetActive(true);
            page2.SetActive(false);

        }
        else if (page3.activeSelf)
        {
            page2.SetActive(true);
            page3.SetActive(false);
        }
        else if (page4.activeSelf)
        {
            page3.SetActive(true);
            page4.SetActive(false);
        }
        else if (page5.activeSelf)
        {
            page4.SetActive(true);
            page5.SetActive(false);
        }
        else if (page6.activeSelf)
        {
            page5.SetActive(true);
            page6.SetActive(false);
        }
    }


}
