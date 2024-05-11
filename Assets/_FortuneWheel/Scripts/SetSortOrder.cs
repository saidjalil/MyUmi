namespace Curiologix
{
    using UnityEngine;
    [ExecuteInEditMode]
    public class SetSortOrder : MonoBehaviour
    {
        public int layerID = 8;
        void Start()
        {
            GetComponent<Renderer>().sortingOrder = layerID;
        }
    }
}