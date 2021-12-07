using System.Transactions;
using UnityEngine;

public class Target : MonoBehaviour
{

    [SerializeField] GameObject target;
    [SerializeField] int numberOfTargets;
    [SerializeField] Transform parent;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numberOfTargets; i++)
        {

            Vector3 position = new Vector3(Random.Range(-960 / 2, 960 / 2), Random.Range(-600 / 2, 600 / 2), 0);
            Instantiate(target, position, Quaternion.identity, parent);

        }
    }


    void OnMouseDown()
    {
        // Destroy the gameObject after clicking on it
        Destroy(this.target);
    }




}
