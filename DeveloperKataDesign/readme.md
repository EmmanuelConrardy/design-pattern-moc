Ubiquitous language
A developer use a working computer and his skill to complete a task
A developer consume energies to complete a task
A computer work if all components (mother board, hard drive, Memory, graphic card, network card, screen, power supply unit) are installed and functional
A developer drink coffee to restore his energies
A developer state vary when his energies is low and it's harder to complete his task
A coffe can add some toping in the coffe like milk or sugar, it's more effective.

Pattern used : State, Composite, Decorator

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

Computer efficiency
Given a computer
And a MotherBoard 4 hearts efficacity 0.8
And a Hard drive efficacity 0.2
And a Memory with two 8gb ram efficacity 0.4
And a GraphicCard efficacity 0.2
And a NetwokCard efficacity 0.2
And a PowerSupply efficacity 0.2
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


