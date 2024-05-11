namespace Curiologix
{
    using UnityEngine;
    public class WheelPart : MonoBehaviour
    {
        public SpriteRenderer spRend;
        public TextMesh valueText;
        public DotForSound[] pointCollider;
        int myIndex;
        void Start()
        {
            myIndex = transform.GetSiblingIndex();
            valueText.text = FortuneWheelConfig.Instance.prizes[myIndex].ToString();
        }
        void OnTriggerEnter2D(Collider2D other)
        {
            FortuneWheel.Instance.SelectedReward = transform.GetSiblingIndex();
        }
    }
}