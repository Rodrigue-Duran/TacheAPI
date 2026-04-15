````md
# 🧩 TacheAPI

![.NET](https://img.shields.io/badge/.NET-10.0-blueviolet)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET_Core-Web_API-512BD4)
![Entity Framework Core](https://img.shields.io/badge/EF_Core-ORM-green)
![SQLite](https://img.shields.io/badge/Database-SQLite-lightgrey)
![Status](https://img.shields.io/badge/status-active-success)

---

# 📌 Présentation

TacheAPI est une API REST de gestion de tâches développée avec ASP.NET Core.

Elle permet de gérer le cycle complet d’une tâche :

👉 création → consultation → modification → finalisation → suppression

---

# 🎯 Objectif du projet

Ce projet a été réalisé dans un but d’apprentissage afin de maîtriser :

- ASP.NET Core Web API
- Entity Framework Core
- Architecture en couches (Controller / Service / Repository)
- Gestion d’une base de données SQLite

---

# ⚙️ Fonctionnalités

✔ Créer une tâche  
✔ Récupérer toutes les tâches  
✔ Récupérer une tâche par ID  
✔ Modifier une tâche  
✔ Supprimer une tâche  
✔ Marquer une tâche comme terminée  

---

# 🧠 Architecture

Controller → Service → Repository → Database

---

# 🗄️ Base de données

- Type : SQLite  
- Fichier : `taches.db`  
- Créée automatiquement via Entity Framework Core

---

# 🚀 Installation et exécution

## 1️⃣ Cloner le projet

```bash
git clone https://github.com/Rodrigue-NGUETSA/TacheAPI.git
````

---

## 2️⃣ Aller dans le dossier du projet

⚠️ Important : tu dois entrer dans le dossier qui contient le fichier `.csproj`

```bash
cd TacheAPI
```

Vérifie que tu vois bien :

```
TacheAPI.csproj
```

---

## 3️⃣ Restaurer les dépendances

```bash
dotnet restore
```

---

## 4️⃣ Lancer l’application

```bash
dotnet run
```

---

## 5️⃣ Accéder à Swagger

Ouvre ton navigateur :

```
https://localhost:7117/swagger
```

---

# 🧠 Important à savoir

* `dotnet run` doit être exécuté dans le dossier du `.csproj`
* sinon tu auras l’erreur : *No project to run found*

---

# 🧪 Tester l’API

## 🟢 Créer une tâche

POST `/api/Tache`

```json
{
  "titre": "Apprendre ASP.NET Core",
  "description": "Construire une API REST",
  "statut": 0,
  "dateDeCreation": "2026-04-15T10:00:00",
  "dateDeFin": null
}
```

---

## 🔵 Voir toutes les tâches

GET `/api/Tache`

---

## 🔵 Voir une tâche

GET `/api/Tache/{id}`

---

## 🟡 Modifier une tâche

PUT `/api/Tache/{id}`

---

## 🔴 Supprimer une tâche

DELETE `/api/Tache/{id}`

---

## 🟣 Terminer une tâche

POST `/api/Tache/{id}/finish`

---

# 📦 Modèle de données

```json
{
  "id": 1,
  "titre": "string",
  "description": "string",
  "statut": 0,
  "dateDeCreation": "2026-04-15T10:00:00",
  "dateDeFin": null
}
```

---

# 📌 Statuts

| Statut   | Valeur |
| -------- | ------ |
| Creee    | 0      |
| Terminee | 1      |

---

# 📖 Swagger

Documentation disponible ici :

[https://localhost:7117/swagger](https://localhost:7117/swagger)

---

# 🚀 Améliorations futures

* Authentification JWT
* DTOs
* Pagination
* Filtrage avancé
* Logging
* Déploiement cloud

---

# 👤 Auteur

Rodrigue NGUETSA

💡 Apprendre en construisant, progresser en pratiquant.

```
```
