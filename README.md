## Visual Studio Code (VSCode)

### Installation de .NET SDK

1. **Téléchargez et installez .NET SDK** :
   Rendez-vous sur la page de téléchargement de .NET :
   [Télécharger .NET SDK](https://dotnet.microsoft.com/fr-fr/download)

2. **Vérifiez l'installation** :
   Après l'installation, ouvrez un terminal ou PowerShell, et exécutez la commande suivante pour vérifier que .NET est bien installé et obtenir la version installée :

   ```bash
   dotnet --version
   ```

   Cela devrait renvoyer un numéro de version (par exemple, `8.0.x`).


3. **Positionnez-vous dans le bon répertoire** :
   Avant de lancer le projet, vous devez vous placer dans le répertoire racine du projet C#. Utilisez la commande suivante pour naviguer dans votre projet :

   ```bash
   cd votre/chemin/Livrables-projet-csharp-groupe-G/Projet_csharp/Projet_csharp
   ```

4. **Exécution du projet** :
   Une fois dans le répertoire du projet, exécutez la commande suivante pour démarrer l'application en mode surveillance (watch mode) :

   ```bash
   dotnet watch run
   ```

   Cette commande permet de recompiler et redémarrer automatiquement le projet à chaque modification du code.

---

## JetBrains Rider

### Installation du ASP.NET Core Hosting Bundle

Si vous utilisez **Rider** pour développer des applications ASP.NET Core, vous devez installer le **Hosting Bundle** ASP.NET Core pour IIS si vous souhaitez exécuter vos applications sur un serveur web IIS.


1. **Téléchargez le Hosting Bundle ASP.NET Core** :
   Rendez-vous sur la page de téléchargement officielle de .NET :
   [Télécharger le Hosting Bundle](https://dotnet.microsoft.com/en-us/download/dotnet)

    - Choisissez la version du .NET SDK que vous utilisez (par exemple .NET 7 ou .NET 8).
    - Téléchargez le **Hosting Bundle** correspondant à cette version.


2. **Installez le Bundle** :
    - Exécutez le fichier d’installation téléchargé.
    - Cela ajoutera le module IIS ASP.NET Core requis pour exécuter des applications ASP.NET Core sur un serveur IIS.


3. **Redémarrez l’ordinateur** :
    - Après avoir installé le bundle, redémarrez votre ordinateur pour que toutes les modifications de configuration soient prises en compte.


4. **Vérifiez l'installation** :
   Après l'installation, ouvrez un terminal ou PowerShell, et exécutez la commande suivante pour vérifier que .NET est bien installé et obtenir la version installée :

   ```bash
   dotnet --version
   ```
   Cela devrait renvoyer un numéro de version (par exemple, `8.0.x`).


5. **Positionnez-vous dans le bon répertoire** :
   Avant de lancer le projet, vous devez vous placer dans le répertoire racine du projet C#. Utilisez la commande suivante pour naviguer dans votre projet :

   ```bash
   cd votre/chemin/Livrables-projet-csharp-groupe-G/Projet_csharp/Projet_csharp
   ```


6. **Exécution du projet** :
   Une fois que vous êtes dans le répertoire de votre projet C#, exécutez la commande suivante pour démarrer l'application en mode surveillance (watch mode) :
    
   ```bash
   dotnet watch run
   ```

---
