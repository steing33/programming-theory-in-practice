using UnityEngine;

// INHERIRTANCE
public abstract class Person_base : MonoBehaviour
{
    [SerializeField] protected string _name;
    [SerializeField] protected int _age;

    // ENCAPSULATION
    public string Name { get => _name; }
    public int Age { get => _age; }

    // POLYMORPHISM
    public virtual void SayHi() // subclass has an option to implement
    {
        Debug.Log($"Hi, I'm {_name} and I'm {_age} years old. I'm just a normal everyday person.");
    }
    public abstract void Attack(); // subclass must implement this

    // this runs for any subclass that doesn't implement Start()
    private void Start() {
        Debug.Log("base_class start");

        // ABSTRACTION
        abstraction();
    }

    private void abstraction()
    {
        SayHi();
        Attack();
    }
}

