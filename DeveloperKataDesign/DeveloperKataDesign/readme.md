## Decorateur - type structure

Le patron d&eacute;corateur permet d'attacher ou d'enlever dynamiquement des responsabilit&eacute;s &agrave; un objet.
C'est une alternative &agrave; l'h&eacute;ritage. Ce patron est inspir&eacute; des poup&eacute;es russes. 
Un objet peut &ecirc;tre cach&eacute; &agrave; l'int&eacute;rieur d'un autre objet d&eacute;corateur qui lui rajoutera des fonctionnalit&eacute;s, 
l'ensemble peut &ecirc;tre d&eacute;cor&eacute; avec un autre objet qui lui ajoute des fonctionnalit&eacute;s et ainsi de suite. 
Cette technique n&eacute;cessite que l'objet d&eacute;cor&eacute; et ses d&eacute;corateurs impl&eacute;mentent la m&ecirc;me interface, qui est typiquement d&eacute;finie par une classe abstraite.

## Composite - type structure

Le patron composite permet de composer une hi&eacute;rarchie d'objets, 
et de manipuler de la m&ecirc;me manière un &eacute;l&eacute;ment unique, une branche, ou l'ensemble de l'arbre. 
Il permet en particulier de cr&eacute;er des objets complexes en reliant diff&eacute;rents objets selon une structure en arbre. 
Ce patron impose que les diff&eacute;rents objets aient une m&ecirc;me interface, ce qui rend uniformes les manipulations de la structure.
Par exemple dans un traitement de texte, les mots sont plac&eacute;s dans des paragraphes dispos&eacute;s dans des colonnes dans des pages ; 
pour manipuler l'ensemble, une classe composite impl&eacute;mente une interface. 
Cette interface est h&eacute;rit&eacute;e par les objets qui repr&eacute;sentent les textes, les paragraphes, les colonnes et les pages.

## State - type comportment

Ce patron permet &agrave; un objet de modifier son comportement lorsque son &eacute;tat interne change. 
Ce patron est souvent utilis&eacute; pour impl&eacute;menter une machine &agrave; &eacute;tats. 
Un exemple d'appareil &agrave; &eacute;tats est le lecteur audio - dont les &eacute;tats sont lecture, enregistrement, pause et arr&ecirc;t. 
Selon ce patron il existe une classe machine &agrave; &eacute;tats, et une classe pour chaque &eacute;tat. 
Lorsqu'un &eacute;v&eacute;nement provoque le changement d'&eacute;tat, la classe machine &agrave; &eacute;tats se relie &agrave; 
un autre &eacute;tat et modifie ainsi son comportement.

## Builder - type cr&eacute;ation

Ce pattern construit un objet complexe en utilisant des objets simples avec une approche &eacute;tape par &eacute;tape. 
Il est très utile quand les propri&eacute;t&eacute;s sont "strict" (immutable) ce qui permet de les configurer dans des &eacute;tapes plus souple. 
De plus il &eacute;vite d'avoir &agrave; manipuler/comprendre/retenir les constructeurs avec beaucoup d'arguments (surtout si les arguments sont optionnels). 
Enfin il est possible pour le client de r&eacute;utiliser le builder pour cr&eacute;er des instances similaires.
Il est souvent utilis&eacute; dans les tests unitaires quand il faut cr&eacute;er plusieurs instances d'un objet complexe avec des valeurs diff&eacute;rentes.
