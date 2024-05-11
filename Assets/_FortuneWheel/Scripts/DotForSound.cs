namespace Curiologix
{
    using UnityEngine;
    public class DotForSound : MonoBehaviour
    {
        public SpriteRenderer pointSprite;
        void Start()
        {
            if (pointSprite == null)
                pointSprite = GetComponent<SpriteRenderer>();
        }
        void OnCollisionEnter2D(Collision2D coll)
        {
            FortuneWheel.Instance.HitStart(pointSprite);
        }
    }
}