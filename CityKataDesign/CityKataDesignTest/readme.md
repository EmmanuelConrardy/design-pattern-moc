## Prototype - type creational

Prototype est utilis&eacute; lorsque la cr&eacute;ation d'une instance est complexe ou consommatrice en temps. Plutôt que cr&eacute;er plusieurs instances de la classe, on copie la premi&egrave;re instance et on modifie la copie de façon appropri&eacute;e.

https://refactoring.guru/design-patterns/Prototype

## Visitor - type comportemental

Ce pattern repr&eacute;sente une op&eacute;ration &agrave; effectuer sur un ensemble d'objets. 
Il permet de modifier l'op&eacute;ration sans changer l'objet concern&eacute; ni la structure. 
Selon ce pattern, les objets &agrave; modifier sont pass&eacute;s en param&egrave;tre &agrave; une classe tierce qui effectuera des modifications. Une classe abstraite Visitor d&eacute;finit l'interface de la classe tierce. Ce pattern est utilis&eacute; notamment pour manipuler un jeu d'objets, où les objets peuvent avoir diff&eacute;rentes interfaces, qui ne peuvent pas être modifi&eacute;s

https://refactoring.guru/design-patterns/visitor

## Adapter - type Structure

Ce pattern permet aux objets avec des interfaces incompatibles de collaborer.

Un objet adaptateur sert de liaison entre les objets manipul&eacute;s et un programme les utilisant, permettant la communication entre classes. Il est utilis&eacute; pour convertir l'interface d'un objet vers une autre interface, attendue par le client pour utiliser l'objet en question.

https://refactoring.guru/design-patterns/adapter