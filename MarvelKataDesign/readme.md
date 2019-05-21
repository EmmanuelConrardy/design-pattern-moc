# Proxy

Ce patron est un substitut d'un objet, qui permet de contr&ocirc;ler l'utilisation de ce dernier. 
Un proxy est un objet destin&eacute; &agrave; prot&eacute;ger un autre objet. Le proxy a la m&ecirc;me interface que l'objet &agrave; prot&eacute;ger. 
Un proxy peut &ecirc;tre cr&eacute;&eacute; par exemple pour permettre d'implementer du cache (cache proxy). 
Le proxy peut &eacute;galement &ecirc;tre cr&eacute;&eacute; dans le but de retarder la cr&eacute;ation de l'objet prot&eacute;g&eacute; - qui sera cr&eacute;&eacute; imm&eacute;diatement avant d'&ecirc;tre utilis&eacute;. 
Dans sa forme la plus simple, un proxy ne protège rien du tout et transmet tous les appels de m&eacute;thode &agrave; l'objet cible.