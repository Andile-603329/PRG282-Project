# Baobab Wild Life Rehabilitation Center

An application for managing wildlife rehabilitation records.

**Team:**
- Andile Mahlangu 603329
- Marno van Wyk 603340
- Omolemo Letswalo 603370
- Armand Bosman 603207

## 📑 Table of Contents
- [Technologies](#technologies)
- [Project Structure](#project-structure)
- [Requirements](#requirements)
- [Core Classes](#core-classes)
  - [Animal Class](#animal-class)
  - [AnimalRepository Class](#animalrepository-class)
  - [AnimalService](#animalservice-class)
- [Features](#features)
  - [Add Animal](#add-animal-feature)
  - [Update Animal](#update-animal-feature)
  - [Delete Animal](#delete-animal-feature)
  - [Multi-Field Search](#multi-field-search-feature)
  - [Automatic Recovery Score Classification](#automatic-recovery-score-feature)
- [File Storage Format](#file-storage-format)

## Technologies
- C# WinForms
- Github
- TextFile storage

## Project Structure
- Presentation: Windows Forms UI
- Business: Validation, Classification and services
- Data: File Storage and repository logic

## Requirements
- .NET 8.0 or above

## Core Classes

### Animal Class:
the Animal class serves as the core data model for the WildLife Rehabilitation Center application, it captures essential details about each animal admitted including identifiers (AnimalID), biological information (Species,Age,Gender), and health tracking (RecoverScore, Status). This class provides a structured foundation for storing, retrieving, and managing animal records across the system.

### AnimalRepository Class:
The AnimalRepository class manages persistence and retrieval of animal records using a text file (Animals.txt). It provides methods to seed initial data, save individual animals,LoadAnimals method that converts a list of Animal objects into a DataTable, making it easy to bind records to UI components such as grids. This class acts as the data access layer, ensuring consistent storage and retrieval of animal information across the application.

### AnimalService Class: 
The AnimalService class coordinates the business logic between the user interface and the data repository.  It handles the implementation for updating existing records (`UpdateAnimal`), removing records (`DeleteAnimal`),  and ensuring data integrity and file synchronization through the repository layer.
	
## Features
### Add Animal Feature

This feature allows the user to add a new animal to the Baobab Ridge Wildlife Rehabilitation Records System.

**What it does:**
- Allows the user to enter the Animal ID, name, species, age, and recovery score.
- Checks that all fields contain valid information before saving.
- Checks that the Animal ID follows the required format (`WR-0001`) and is not already in use.
- Checks that the name and species contain between 1 and 30 characters and do not contain the `|` character.
- Checks that the age and recovery score are whole numbers between 0 and 100.
- Calculates the animal's status and housing unit based on its recovery score.
- Saves the animal's information to `animals.txt` when all validation checks pass.
- Displays an error message if the information is invalid.

### Update Animal Feature

This feature allows users to modify existing animal records in the Baobab Ridge Wildlife Rehabilitation Records System.

**What it does:**
- Repurposes the entry form using an upsert pattern to load, edit, and save existing animal data.
- Protects the primary key by locking the `AnimalID` field during updates.
- Loads the full dataset, modifies the target record in memory, and safely rewrites the entire `animals.txt` file via the repository layer.


### Delete Animal Feature

This feature allows users to remove obsolete or incorrect animal records from the system.

**What it does:**
- Allows users to select an animal row directly from the data grid.
- Prompts a confirmation dialog box to prevent accidental data loss before executing.
- Removes the record from the dataset in memory and rewrites `animals.txt` to reflect the removal.


### Multi-Field Search Feature

This feature provides real-time filtering capabilities across all record attributes simultaneously.

**What it does:**
- Filters records instantly as the user types into the search box.
- Searches across all properties concurrently (Animal ID, Name, Species, Gender, Age, Date Admitted, and Recovery Score).
- Safely handles numeric and date fields alongside text strings to avoid type-mismatch exceptions.

## Automatic Recovery Score Feature
**Recovery Score Classification**

| Recovery Score | Status | Housing Unit |
|---|---|---|
| 0–19 | Critical | Intensive Care Unit |
| 20–39 | Serious | High-Dependency Ward |
| 40–59 | Stable | Recovery Ward |
| 60–79 | Recovering | Outdoor Enclosure |
| 80–100 | Release-Ready | Pre-Release Camp |

## File Storage Format

Each animal record must be saved using this format:

`ID|Name|Species|Age|Score|Status|Housing Unit`

Example:

```text
WR-0001|Thabo|African Penguin|4|85|Release-Ready|Pre-Release Camp

