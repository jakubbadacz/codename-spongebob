
public class NavModel {

    private float xPos = 0;
    private float yPos = 0;
    private int velocity = 1;

    public float GetPositionX()
    {
        return xPos;
    }

    public void SetPositionX(float xPos)
    {
        this.xPos = xPos; 
    }

    public float GetPositionY()
    {
        return yPos;
    }


    public void SetPositionY(float yPos)
    {
        this.yPos = yPos;
    }


    public int GetVelocity()
    {
        return velocity;
    }
}
