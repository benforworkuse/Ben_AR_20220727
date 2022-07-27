
using UnityEngine;

namespace Ben
{
    public class CardManager : MonoBehaviour
    {
        [SerializeField, Header("KID 圖片")] private DefaultObserverEventHandler observerKID;

        private void Awake()
        {
            observerKID.OnTargetFound.AddListener(CardFound);
            observerKID.OnTargetLost.AddListener(CardLost);
        }
        private void CardFound()
        {
            print("<color=yellow>找到卡片</color>");
        }
        private void CardLost()
        {
            print("<color=red>卡片辨識失敗</color>");
        }
    }
}

