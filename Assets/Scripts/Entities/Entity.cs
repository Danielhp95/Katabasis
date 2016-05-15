
public abstract class Entity
{

    // Speed dictates the readiness at the beginning of a battle.
    public float speed { get; set; }

    protected int maxHealth;
    public int health { 
        get; 
        set{ health = (value >= maxHealth) ? maxHealth : value ;}
    }

    protected string name;

    abstract public string getName();

    public bool isDead()
    {
        return health <= 0;
    }

    // TODO: put interesting stuff in this function
    /*
        Reduces health by the input amount. Health cannot go below 0.
    */
    public void takeDamage(int damage)
    {
        health = (damage < health) ? (health - damage) : 0;
    }


}