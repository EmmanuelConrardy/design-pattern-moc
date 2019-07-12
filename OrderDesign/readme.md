## Strategy - type comportemental
Ce pattern permet de choisir un algorithme parmi une famille en fonction d'un point sensible d'un contexte donn&eacute;. Les algorithmes sont dans des classes concr&egrave;tes distinctes et sont interchangeables.

https://refactoring.guru/design-patterns/strategy

## Chain of responsability - type comportemental
Chain of Responsibility ou "COR" est un design comportemental qui te laisse passer une requ&ecirc;te le long d'une chaine de "Handlers" aka "des objets qui g&egrave;rent la requ&ecirc;te". Chaque "Handlers" decide si il execute ou pas son processus sinon de passer la gestion au "handler" suivant.
Le risque de ce design est que la requête peut ne pas être trait&eacute;e.

https://refactoring.guru/design-patterns/chain-of-responsibility