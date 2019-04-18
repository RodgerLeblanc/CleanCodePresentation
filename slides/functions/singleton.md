### As-tu vraiment besoin d'un Singleton?
![](images/code/singletonBad.png?raw=true)![](images/code/singletonGood.png?raw=true)

Note:
- Difficile à mocker
- Chaque classe qui utilise ton Singleton dépend donc d'une classe concrète
- Conserve un état, oblige les tests à rouler dans un ordre précis
