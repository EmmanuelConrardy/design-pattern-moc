Ubiquitous language
The City has three Areas Services : a Political area, an Army area, an Educational area.
Each area are represented by a "complex" service who are release one time by year.
Political area has a PartyName, a Gouvernor and Meetings
Army area has a Name, a Size and Sergents. 
    Sergent has a Name and a Seniority.
Educational has a School Name, a Director, Educators.
    Educator hase a Name and a Degree.
In Educational we have a method To Add Educators.
We should be able to extract a Report from all this area to know the Status of the City.

Note from the tech lead : "The release is near you have to code the report of the city but we don't want you to interfer with our testing we must respect the scheduled !"

Then our City need lot of 100 Buildings and at least 300 Houses.

When needed Serget can be Educator.


Pattern used : Visitor, Adapter, Prototype

Some example to start with :

Builder/Composite :
Computer is working:

Given a computer 
And a MotherBoard installed
And a Har Drive installed
And a GraphicCard installed
And a Memory installed
And a NetwokCard installed
And a Screen installed
And a PowerSupply installed
When we start this cumputer
Then the computer is working

Computer scoring
Given a computer
And a MotherBoard 4 hearts score 0.8
And a Hard drive score 0.2
And a Memory with two 8gb ram score 0.4
And a GraphicCard score 0.2
And a NetwokCard score 0.2
And a PowerSupply score 0.2
When we check the effiency
Then the effiency equal 2

State:
Dev Complete work on a task and change his state

Given a skill level 3 Dev with 5 energies
And his state is normal
And a working computer attach to him with an efficiency of 2
And a Task with 12 remaining points
When he work on it
Then his energies equal 3
And his state is low
And the task has 7 remaining points

Given a skill level 4 Dev withwith 3 energies, result outcome a divided by two
And his state is low
And a working computer attach to him with an efficiency of 2
And a Task with 12 remaining points
When he work on it
Then his energies equal 1
And his state is low
And the task has 9 remaining points

Decorator:
Developer drink coffee to restore his energies
Given a developer with 1 energies
When he drink a coffee
Then his energie equal 6

Developer drink coffee with milk to restore his energies
Given a developer with 1 energies
When he drink a coffee with milk
Then his energie equal 7

Developer drink coffee with sugar to restore his energies
Given a developer with 1 energies
When he drink a coffee with milk
Then his energie equal 9


