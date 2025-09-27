# Product Requirements Document (PRD)  
## Outil de tirage au sort (Blazor WASM)

### 1. Objectif
Permettre à un utilisateur de sélectionner un élément aléatoire à partir d’une liste saisie manuellement ou importée.  
Fonctionne entièrement côté client, sans serveur.  

---

### 2. Utilisateurs cibles
- Organisateurs d’événements souhaitant tirer au sort des participants.  
- Enseignants ou animateurs voulant choisir un élève ou une équipe au hasard.  
- Toute personne désirant faire un tirage aléatoire rapide.  

---

### 3. Fonctionnalités principales
1. **Saisie de la liste**
   - Entrée manuelle des éléments (séparés par virgule ou ligne).  
   - Option d’importer un fichier texte (.txt ou .csv).  

2. **Tirage aléatoire**
   - Bouton “Tirer au sort” qui sélectionne un élément de manière aléatoire.  
   - Affichage immédiat de l’élément tiré.  

3. **Historique**
   - Liste des éléments déjà tirés dans la session (optionnel).  
   - Possibilité de réinitialiser l’historique.  

4. **Interface simple**
   - UI responsive adaptée mobile et desktop.  
   - Retour visuel pour le tirage (animation simple, surlignage).  

---

### 4. Fonctionnalités secondaires (optionnelles)
- Tirage multiple simultané (ex. 3 gagnants).  
- Option “remettre les éléments tirés dans le pool” ou “tirage sans remise”.  
- Thème clair/sombre.  
- Export des résultats en fichier texte.  

---

### 5. Contraintes techniques
- Framework : **Blazor WebAssembly** (C#).  
- UI : Bootstrap ou TailwindCSS.  
- Hébergement : GitHub Pages.  
- Stockage optionnel via `localStorage` pour l’historique.  

---

### 6. Architecture
- **Components** :
  - `DrawList.razor` : saisie et affichage de la liste.  
  - `DrawResult.razor` : résultat du tirage avec animation.  

- **Services** :
  - `DrawService.cs` : logique de tirage aléatoire, gestion de l’historique.  

---

### 7. Flux utilisateur
1. L’utilisateur saisit ou importe une liste d’éléments.  
2. L’utilisateur clique sur “Tirer au sort”.  
3. L’élément tiré apparaît immédiatement.  
4. L’utilisateur peut répéter le tirage, réinitialiser ou exporter les résultats.  

---

### 8. Roadmap
- **MVP (Version 1)** : saisie manuelle + tirage unique + résultat affiché.  
- **V2** : import de fichiers, tirage multiple, historique.  
- **V3** : export des résultats, thèmes, animations avancées.  

---

### 9. Critères de réussite
- Tirage aléatoire correct et visible immédiatement.  
- Interface simple et responsive.  
- Fonctionne entièrement côté client sur GitHub Pages.
