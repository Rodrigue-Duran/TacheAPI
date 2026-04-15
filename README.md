
-----

# 🧩 TacheAPI

## 📌 Présentation

**TacheAPI** est une API REST de gestion de tâches développée avec **ASP.NET Core**. Elle permet de gérer le cycle de vie complet d'une tâche de manière intuitive.

> **Workflow :** Création ➜ Consultation ➜ Modification ➜ Finalisation ➜ Suppression

-----

## 🎯 Objectifs du projet

Ce projet a été conçu pour mettre en pratique les concepts suivants :

  * **ASP.NET Core Web API** (Routing, Dependency Injection)
  * **Entity Framework Core** (Code First)
  * **Architecture en couches** (Controller / Service / Repository)
  * **Persistance de données** avec SQLite

-----

## ⚙️ Fonctionnalités

  * ✅ Créer une tâche
  * ✅ Lister toutes les tâches
  * ✅ Récupérer une tâche par son ID
  * ✅ Modifier les informations d'une tâche
  * ✅ Supprimer une tâche
  * ✅ Marquer une tâche comme terminée (Endpoint dédié)

-----

## 🧠 Architecture & Base de données

### Flux de données

`Controller` ➜ `Service` ➜ `Repository` ➜ `Database`

### Détails techniques

  * **Type :** SQLite
  * **Fichier :** `taches.db`
  * **Initialisation :** La base est créée automatiquement via EF Core lors du premier lancement.

-----

## 🚀 Installation et exécution

### 1\. Cloner le projet

```bash
git clone https://github.com/Rodrigue-Duran/TacheAPI.git
```

### 2\. Accéder au répertoire

> [\!IMPORTANT]
> Vous devez vous situer dans le dossier contenant le fichier `.csproj`.

```bash
cd TacheAPI
```

### 3\. Restaurer et lancer

```bash
dotnet restore
dotnet run
```

### 4\. Accéder à l'interface

Une fois l'application lancée, ouvrez votre navigateur à l'adresse suivante :
👉 [https://localhost:7117/swagger](https://www.google.com/search?q=https://localhost:7117/swagger)

-----

## 🧪 Documentation de l'API (Endpoints)

| Méthode | Endpoint | Description |
| :--- | :--- | :--- |
| `GET` | `/api/Tache` | Récupérer toutes les tâches |
| `GET` | `/api/Tache/{id}` | Récupérer une tâche spécifique |
| `POST` | `/api/Tache` | Créer une nouvelle tâche |
| `PUT` | `/api/Tache/{id}` | Mettre à jour une tâche |
| `DELETE` | `/api/Tache/{id}` | Supprimer une tâche |
| `POST` | `/api/Tache/{id}/finish` | Clôturer une tâche |

### Exemple de corps de requête (POST/PUT)

```json
{
  "titre": "Apprendre ASP.NET Core",
  "description": "Construire une API REST",
  "statut": 0,
  "dateDeCreation": "2026-04-15T10:00:00"
}
```

-----

## 📦 Modèle de données & Statuts

**Objet Tâche :**

  * `id` (int)
  * `titre` (string)
  * `description` (string)
  * `statut` (int) : `0` = Créée, `1` = Terminée
  * `dateDeCreation` (DateTime)
  * `dateDeFin` (DateTime?)

-----

## 🚀 Améliorations futures

  * [ ] Implémentation de l'authentification **JWT**
  * [ ] Utilisation de **DTOs** (Data Transfer Objects) pour isoler le modèle
  * [ ] Ajout de la **Pagination** et de filtres
  * [ ] Mise en place de **Logging** (Serilog)
  * [ ] Déploiement Cloud (Azure/AWS)

-----

## 👤 Auteur

**Rodrigue NGUETSA**

> "Apprendre en construisant, progresser en pratiquant."
