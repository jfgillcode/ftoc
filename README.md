# Convertisseur de Température (Fahrenheit ↔ Celsius)

Ce projet est un simple programme console en C# qui permet à l'utilisateur de convertir des températures entre les échelles Fahrenheit et Celsius.
## Fonctionnalités

Le programme offre un menu interactif avec les options suivantes :
- Convertir des degrés Fahrenheit en degrés Celsius
- Convertir des degrés Celsius en degrés Fahrenheit
- Quitter le programme

## Comment utiliser

Prérequis : Assurez-vous d'avoir le SDK .NET installé sur votre machine. Vous pouvez le télécharger depuis dotnet.microsoft.com.

Télécharger le programme et exécuter :

```sh
git clone https://github.com/jfgillcode/ftoc.git
cd ftoc
dotnet run
```

Interagir avec le programme et suivez les instructions affichées à l'écran.
    
    Entrez 1 pour convertir de Fahrenheit en Celsius.
    Entrez 2 pour convertir de Celsius en Fahrenheit.
    Entrez 3 pour quitter le programme.

Après chaque conversion, le programme affiche le résultat

## Formules de conversion utilisées

Fahrenheit (F) en Celsius (C) :

$C = (F - 32) \times \frac{5}{9}$

Celsius (C) en Fahrenheit (F) :

$F = C \times \frac{9}{5} + 32$

## Améliorations futures possibles

- Boucle de menu : Le programme actuel quitte après une seule conversion. Une boucle (while) autour du menu principal permettrait à l'utilisateur d'effectuer plusieurs conversions sans redémarrer le programme, jusqu'à ce qu'il choisisse explicitement de quitter.

- Modularité : Séparer la logique de conversion (les formules) dans des fonctions ou méthodes dédiées (ConvertFahrenheitToCelsius(), ConvertCelsiusToFahrenheit()) rendrait le code plus propre et plus facile à maintenir.

## Licence :

Ce projet est sous licence MIT. Pour plus de détails, consultez le fichier LICENSE (si vous en créez un).