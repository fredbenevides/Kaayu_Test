using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConceptsTexts : MonoBehaviour
{
    [SerializeField]
    private Text text;

    public void EncapsulationText()
    {
        text.text = "Encapsulation is an object oriented programming pillar that consists in" +
                    "controlling the visibility of implementation details of a class. It is done by" +
                    " using the access specifiers Public, Private, Protected, Internal and Protected internal (in C#)." +
                    "\n\n- Public access specifier allows a class to expose its member variables and member functions to " +
                    "other functions and objects.Any public member can be accessed from outside the class." +
                    "\n- Private access specifier allows a class to hide its member variables and member " +
                    "functions from other functions and objects.Only functions of the same class can access its private " +
                    "members.Even an instance of a class cannot access its private members." +
                    "\n- Protected access specifier allows a child class to access the member variables and member " +
                    "functions of its base class. This way it helps in implementing inheritance." +
                    "\n- Internal access specifier allows a class to expose its member variables and member functions " +
                    "to other functions and objects in the current assembly.In other words, any member with internal access " +
                    "specifier can be accessed from any class or method defined within the application in which the member is defined." +
                    "\n-The protected internal access specifier allows a class to hide its member variables and member functions from " +
                    "other class objects and functions, except a child class within the same application.This is also used while implementing inheritance.";
    }

    public void PolymorphismText()
    {
        text.text = "Polymorphism is one of the pillars of object-oriented programming. " +
                    "It has two different aspects:" +
                    "\n\n- At run time, objects of a derived class may be treated as objects " +
                    "of a base class, for instance, in collections or arrays. When this happens, " +
                    "the object's declared type is no longer identical to its run-time type." +
                    "\n\n- Base classes may define and implement virtual methods, and derived " +
                    "classes can override them, which means they provide their own definition and " +
                    "implementation. At run-time, when client code calls the method, the CLR looks " +
                    "up the run-time type of the object, and invokes that override of the virtual method. "+
                    "Thus in your source code you can call a method on a base class, and cause a derived class's "+
                    "version of the method to be executed.";
    }

    public void InheritanceText()
    {
        text.text = "Inheritance is a pillar of object-oriented programming languages that allows "+
                    "you to define a base class that provides specific functionality (data and behavior) "+
                    "and to define derived classes that either inherit or override that functionality." +
                    "\n\nInheritance is one of the fundamental attributes of object-oriented programming. " +
                    "It allows you to define a child class that reuses (inherits), extends, or modifies the " +
                    "behavior of a parent class. The class whose members are inherited is called the base class. " +
                    "The class that inherits the members of the base class is called the derived class.";
    }

    public void AbstractionText()
    {
        text.text = "The use abstraction in a class indicates that class is not intended to be instantiated on its own, " +
                    "it will serve as a base class for other classes. Members marked as abstract must be implemented by a " +
                    "concret class that derive from the abstract class." +
                    "\n\nAbstract classes remarkable features: " +
                    "\n\n- An abstract class cannot be instantiated." +
                    "\n\n- An abstract class may contain abstract methods and accessors." +
                    "\n\n- It is not possible to modify an abstract class with the sealed modifier " +
                    "because the two modifiers have opposite meanings.The sealed modifier prevents " +
                    "a class from being inherited and the abstract modifier requires a class to be inherited." +
                    "\n\n- A non-abstract class derived from an abstract class must include actual implementations " +
                    "of all inherited abstract methods and accessors.";
    }
}
