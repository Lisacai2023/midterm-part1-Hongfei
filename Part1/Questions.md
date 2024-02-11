### Part 1
[Page1](Training/Page1.md)

#### Q1: What does it mean to create an "instance" of an object?
Allocating the memory and initialazing a specific object base on the class.
#### Q2: What does it mean when we say "Create a local variable"?
It means creating a variable. It is only access within the declare scope, can
can be accessed from outside of scope.

#### Q3: The static keyword is a modifier, what does this modifier do to the members (fields, constructor, properties, and methods) of a class?
When this modifier add to the members of class,
can directly access the members by using class name and share
among all object related this class. 

#### Q4: Do you need an instance of an object to call a static method?
No,using class to a static method
#### Q5: Can you create an instance of a static class?
No, cannot create an instance of a static class
#### Q6: Can you manually call a static constructor? When is it called?
No,using class to call a static constructor.
#### Q7: Did you have to create an instance of MyDatabase to access Data? Why?
Don't need,because MyDatabase type is static, using class name to call it.
#### Q8: When you ran your code the line "This list is loading" appeared. Where did that come from and why did it appear when it did?
It come from Mydatabase class,becase the main class
call MyDatabase.Data to display data from the static class

### Part 2
[Page2](Training/Page2.md)

#### Q9: What is encapsulation?
Encapsulation is data or method within a class,using access
modifier to access inside data.
#### Q10: What are the other two, or 3 depending on the source, pillars of object-oriented programming?
Inheritance and Polymorphism.
#### Q11: After our refactor of Product, it only has fields that are _blank_ among all the Objects in the database.
The Product class will be as base class, and others class inherited with Product class.
#### Q11: After our refactor of Product, it only has fields that are _blank_ among all the Objects in the database.
The Product class will be as base class, and others class inherited with Product class.
#### Q12: We made our DisplayProductInfo() method `virtual`. What does virtual do?
Virtual gives permission to override a method that's being inherited
#### Q13: Why do you think we made that method virtual ( only wrong answer is a blank answer. Give it a shot. )?
Give inherited class to override a method
#### Q14: What does dervied mean in the context of inheritance?
These classes are inherited with product class.
#### Q15: Is one class is derived, the class that it derives from is considered the "b___" class. What is it?
Base class.
#### Q16: When inheriting from a parent class, which class member ( field, constructor, properties, or method ) do you HAVE to create in your child class?
It have to create their own members in the child class.
#### Q17: Our constructor has the syntax `public Groceries(string name, double price, string expiryDate) : base(name, price)`. What is this for?
Name and price are inheried from base class, and ExporyDate is belong to Groceries class.
#### Q18: For our DisplayProductInfo() we now used the word `override` instead of `virtual`. Why is that? And what happens if we take the word `virtual` away from the method inside of Product?
Take the word virtual away the override method will do not work.
#### Q19: Because we inherited from Parent, what class members did we get access to in Groceries?
Name, price.
#### Q20: What access modifier is needed for everything in your project to have access to class members ( there are 2 that would work )?
Public and internal
#### Q21: When each instanced object called `DisplayProductInfo()` the output was different based on the object. Why is that?
Each class has their own field properties. They inherited Name and Price 
from base class and also add their own properties.

## Part 3
[Page3](Training/Page3.md)

#### Q22: What does the abstract keyword do exactly? What does it prevent?
The abstract keyword is a modifier for classes.
Prevent create instances of the class.
#### Q23: The abstract method no longer has a body, why is that? We also removed the word virtual, how do virtual and abstract relate?
Abstract method is related with override method. Child class method will do their own action.
#### Q24: We turned our constructor's accessible type to `protected`. What objects have access to the constructor now that it's `protected`. And since we turned our class `abstract` why doesn't it matter that we can't create a new instance of `Product` in main?
Protected means allow child class to access constractor. Abstract product class cannot create
an instance of the class.
#### Q25: The other classes didn't need to be changed. Specifically, the DisplayProductInfo() didn't need any changing when we swapped our method from virtual to abstract. Why?
Becase the product class is bass class.Use abstract method
can allow other child class method to override.

## Part 4
[Page4](Training/Page4.md)

#### Q26: We set our set to private. What does private mean? And why might we want to set our set to private for our connection string (take a guess)?
Set private to restrict access, can prevent data from editing.

## Part 5
[Page5](Training/Page5.md)

#### Q27: What method is used to get the TYPE of an instance of an object?
GetType()
#### Q28: What method can we use to check if one type is another?
Typeof()