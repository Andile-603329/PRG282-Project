# Boabab Wild Life Rehabilitation Center

**Team:**
- Andile Mahlangu 603329
- Marno van Wyk 603340
- Omolemo Letswalo 603370
- Armand Bosman 603207

An application for managing wildlife rehabilitation records.

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

## Classes

-Animal Class:
	the Animal class serves as the core data model for the WildLife Rehabilitation Center application,
	it captures essential details about each animal admitted including identifiers (AnimalID), biological information (Species,Age,Gender),
	and health tracking (RecoverScore, Status).
	This class provides a structured foundation for storing, retrieving, and managing animal records across the system.


-AnimalRepository Class:
	The AnimalRepository class manages persistence and retrieval of animal records using a text file (Animals.txt).
	It provides methods to seed initial data, save individual animals,LoadAnimals method that converts a list of Animal objects into a DataTable,
	making it easy to bind records to UI components such as grids.
	This class acts as the data access layer, ensuring consistent storage and retrieval of animal information across the application.

-AnimalService Class:
	The AnimalService class coordinates the business logic between the user interface and the data repository. 
	It handles the implementation for updating existing records (`UpdateAnimal`), removing records (`DeleteAnimal`), 
	and ensuring data integrity and file synchronization through the repository layer.
	

## Add Animal Feature

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

## Update, Delete, and Search Features

This module handles record management, modification, removal, and real-time filtering within the Baobab Ridge Wildlife Rehabilitation Records System.

**What it does:**
- Update Feature: Repurposes the entry form using an upsert pattern to load, edit, and save existing animal data while protecting the primary key (`AnimalID`).
- Delete Feature: Allows users to select an animal from the data grid, prompts a confirmation dialog to prevent accidental data loss, and removes the record.
- File Rewrite Strategy: Because records are stored in a flat text file (`animals.txt`), update and delete operations load the full dataset, modify or remove the target record in memory, and safely rewrite the entire file.
- Simultaneous Multi-Field Search: Provides a real-time search box that filters across all record properties (ID, name, species, gender, age, date admitted, and recovery score) simultaneously without type-mismatch errors.

**Recovery Score Classification**

| Recovery Score | Status | Housing Unit |
|---|---|---|
| 0–19 | Critical | Intensive Care Unit |
| 20–39 | Serious | High-Dependency Ward |
| 40–59 | Stable | Recovery Ward |
| 60–79 | Recovering | Outdoor Enclosure |
| 80–100 | Release-Ready | Pre-Release Camp |

**File Format**

Each animal record must be saved using this format:

ID|Name|Species|Age|Score|Status|Housing Unit

Example:

WR-0001|Thabo|African Penguin|4|85|Release-Ready|Pre-Release Camp

