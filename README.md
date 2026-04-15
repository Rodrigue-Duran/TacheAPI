 **README.md complet, orienté “utilisateur + recruteur”** 👇

---

````md
# 🧩 TacheAPI

![.NET](https://img.shields.io/badge/.NET-10.0-blueviolet)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET_Core-Web_API-512BD4)
![EF Core](https://img.shields.io/badge/Entity_Framework-Core-green)
![SQLite](https://img.shields.io/badge/Database-SQLite-lightgrey)
![Status](https://img.shields.io/badge/status-active-success)

---

# 📌 Présentation de l’application

**TacheAPI** est une application backend permettant de gérer des tâches.

Elle permet de :
- créer des tâches
- consulter les tâches
- modifier des tâches
- supprimer des tâches
- marquer une tâche comme terminée

Chaque tâche suit un cycle de vie simple :  
👉 création → modification → finalisation → suppression

---

# 👤 À qui s’adresse ce projet ?

- Développeurs débutants en backend
- Étudiants en apprentissage ASP.NET Core
- Toute personne voulant comprendre une API REST simple

---

# ⚙️ Fonctionnalités principales

✔ Création de tâches  
✔ Liste des tâches  
✔ Détail d’une tâche  
✔ Mise à jour  
✔ Suppression  
✔ Finalisation d’une tâche  

---

# 🧠 Comment fonctionne l’application ?

L’application est une API REST.

👉 Cela signifie qu’elle ne possède pas d’interface graphique propre  
👉 Elle est utilisée via des outils comme :

- Swagger
- Postman
- ou une application frontend

---

# 🚀 Comment utiliser l’application ?

## 1️⃣ Lancer le projet

Clone le projet :

```bash
git clone https://github.com/ton-repo/TacheAPI.git
cd TacheAPI
````

Lancer l’API :

```bash
dotnet run
```

---

## 2️⃣ Ouvrir l’API

Une fois lancée, ouvre ton navigateur :

```text
https://localhost:7117/swagger
```

👉 C’est l’interface de test de l’API

---

# 🧪 Tester l’API (GUIDE SIMPLE)

## 🟢 Créer une tâche

* Clique sur `POST /Tache`
* Clique sur **Try it out**
* Remplis :

```json
{
  "titre": "Apprendre ASP.NET",
  "description": "Comprendre les API REST",
  "statut": 0,
  "dateDeCreation": "2026-04-15T10:00:00",
  "dateDeFin": null
}
```

* Clique **Execute**

---

## 🔵 Voir toutes les tâches

* Clique sur `GET /Tache`
* Clique **Execute**

---

## 🔵 Voir une tâche

* Clique sur `GET /Tache/{id}`
* Mets un id (ex: 1)
* Clique Execute

---

## 🟡 Modifier une tâche

* Clique sur `PUT /Tache/{id}`
* Modifie les champs

---

## 🔴 Supprimer une tâche

* Clique sur `DELETE /Tache/{id}`

---

## 🟣 Terminer une tâche

* Clique sur :

```
POST /Tache/{id}/finish
```

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

# 🏗️ Architecture

L’application est construite en couches :

```
Controller → Service → Repository → Database
```

---

# 🗄️ Base de données

* SQLite
* fichier : `taches.db`
* générée automatiquement via Entity Framework

---

# 📖 Documentation API

L’API est documentée automatiquement via Swagger :

👉 `/swagger`

---

# 🚧 Améliorations futures

* Authentification JWT
* Pagination
* Filtrage des tâches
* DTOs
* Logs
* Déploiement cloud

---

# 👨‍💻 Auteur

Projet réalisé dans un but d’apprentissage backend avec ASP.NET Core.

💡 “Apprendre en construisant, progresser en pratiquant.”

```

---

# 🧠 Ce que tu viens d’obtenir

✔ README orienté utilisateur  
✔ guide d’utilisation simple  
✔ guide technique  
✔ guide test Swagger  
✔ prêt GitHub / portfolio  

---


