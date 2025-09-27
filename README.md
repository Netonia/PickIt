# PickIt

Un outil de tirage au sort simple et efficace, développé avec Blazor WebAssembly.

## 🎯 Fonctionnalités

- **Saisie manuelle** : Entrez vos éléments séparés par des virgules ou des lignes
- **Tirage aléatoire** : Bouton "Tirer au sort" qui sélectionne un élément au hasard
- **Interface responsive** : Fonctionne parfaitement sur mobile et desktop
- **Aucun serveur requis** : Fonctionne entièrement côté client

## 🚀 Utilisation

1. Saisissez vos éléments dans la zone de texte (séparés par des virgules ou des lignes)
2. Cliquez sur "Tirer au sort"
3. Le résultat s'affiche immédiatement avec la date et l'heure
4. Utilisez "Effacer" pour recommencer

## 🛠️ Technologies

- **Framework** : Blazor WebAssembly (.NET 9)
- **UI** : Bootstrap 5 + Bootstrap Icons
- **Hébergement** : GitHub Pages

## 🏗️ Développement

```bash
# Cloner le projet
git clone https://github.com/Netonia/PickIt.git
cd PickIt/PickIt

# Restaurer les dépendances
dotnet restore

# Lancer en développement
dotnet run
```

## 📦 Déploiement

Le projet se déploie automatiquement sur GitHub Pages via GitHub Actions à chaque push sur la branche main.

## 📋 Roadmap

- **V1 (MVP)** ✅ : Saisie manuelle + tirage unique + résultat affiché
- **V2** : Import de fichiers, tirage multiple, historique
- **V3** : Export des résultats, thèmes, animations avancées