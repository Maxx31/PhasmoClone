using Items.Logic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ghosts.EnvIneraction
{
    public class GhostItemInteraction : MonoBehaviour
    {

        [SerializeField]
        private float _itemsThrowRadius;

        private void Start()
        {
            StartCoroutine(ItemInteraction());
        }


        private IEnumerator ItemInteraction()
        {
            while (true)
            {
                InteractWithIPickupable();
                yield return new WaitForSeconds(3f);
            }

        }


        private void InteractWithIPickupable()
        {
            Collider[] hitColliders = Physics.OverlapSphere(transform.position, _itemsThrowRadius);

            for(int i = 0; i< hitColliders.Length;i++)
            {
                if(hitColliders[i] is IPickupable)
                {
                    Debug.Log("Find " + hitColliders[i].name);
                }
            }
        }
    }
}