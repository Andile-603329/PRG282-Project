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

-AnimalRepository class
	The AnimalRepository class manages persistence and retrieval of animal records using a text file (Animals.txt).
	It provides methods to seed initial data, save individual animals,LoadAnimals method that converts a list of Animal objects into a DataTable,
	making it easy to bind records to UI components such as grids.
	This class acts as the data access layer, ensuring consistent storage and retrieval of animal information across the application.
