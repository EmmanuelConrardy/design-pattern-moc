## Singleton - type cr&eacute;ation
Ce patron vise &agrave; assurer qu'il n'y a toujours qu'une seule instance d'une classe en fournissant une interface pour la manipuler. 
C'est un des patrons les plus simples. L'objet qui ne doit exister qu'en une seule instance comporte une m&eacute;thode pour obtenir cette unique instance 
et un m&eacute;canisme pour emp&ecirc;cher la cr&eacute;ation d'autres instances.

## Observer - type comportement
Ce patron &eacute;tablit une relation un &agrave; plusieurs entre des objets, où lorsqu'un objet change, plusieurs autres objets sont avis&eacute;s du changement. 
Dans ce patron, un objet le sujet tient une liste des objets d&eacute;pendants des observateurs qui seront avertis des modifications apport&eacute;es au sujet. 
Quand une modification est apport&eacute;e, le sujet &eacute;met un message aux diff&eacute;rents observateurs. 
Le message peut contenir une description d&eacute;taill&eacute;e du changement. 
Dans ce patron, un objet observer comporte une m&eacute;thode pour inscrire des observateurs. 
Chaque observateur comporte une m&eacute;thode Notify. Lorsqu'un message est &eacute;mis, l'objet appelle la m&eacute;thode Notify de chaque observateur inscrit.

## Factory methode - type cr&eacute;ation
Ce patron d&eacute;finie une interface ou une classe abstraite pour cr&eacute;er un objet, mais laisse les sous-classes d&eacute;cider de l'impl&eacute;mentation.
Ce qui permet d'harmoniser entre toutes les sous-classe "comment" se fait l'instanciation (via l'interface et sa methode) 
et laisse la responsabilit&eacute; du "quoi" et "o&ugrave;" sont mise &agrave; jour les propri&eacute;t&eacute;s dans les classes filles.