using UnityEngine;
using UnityEngine.Events;

public class DetectionScript : MonoBehaviour
{
    public UnityEvent dartCollision;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Target Board") 
        {
            dartCollision.Invoke();
            Destroy(gameObject);
        }
    }

    public void TestMethod()
    {
        print("Dirts Collided");
    }
}
