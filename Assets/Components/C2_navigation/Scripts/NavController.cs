using UnityEngine;
using UnityEngine.UI;

public class NavController : MonoBehaviour
{

    private NavModel navModel;

    void Awake()
    {
        navModel = new NavModel();
    }


    public NavModel GetNavModel()
    {
        return navModel;
    }

    public void Forward() {

        float x = GameObject.Find("Ship").transform.position.x;
        float y = GameObject.Find("Ship").transform.position.y;

        GameObject.Find("Ship").transform.position = new Vector3(x, y+10);

        navModel.SetPositionY(y);
    }

    public void Backwards()
    {
        float x = GameObject.Find("Ship").transform.position.x;
        float y = GameObject.Find("Ship").transform.position.y;

        GameObject.Find("Ship").transform.position = new Vector3(x, y-10);

        navModel.SetPositionY(y);
    }

    public void Left()
    {
        float x = GameObject.Find("Ship").transform.position.x;
        float y = GameObject.Find("Ship").transform.position.y;

        GameObject.Find("Ship").transform.position = new Vector3(x-10, y);

        navModel.SetPositionX(x);
    }

    public void Right()
    {
        float x = GameObject.Find("Ship").transform.position.x;
        float y = GameObject.Find("Ship").transform.position.y;
        x += 10;

        GameObject.Find("Ship").transform.position = new Vector3(x, y);

        navModel.SetPositionX(x);
    }

}