# Database Schema - Smart Waste Management System

## 1. Users Table
| Field Name | Data Type | Description |
|------------|-----------|-------------|
| UserID | INT | Unique ID for each system user (PK) |
| Username | VARCHAR(50) | User login name ("admin") |
| Password | VARCHAR(255) | Encrypted string |
| Role | VARCHAR(20) | Admin/Staff |

## 2. WasteRecords Table
| Field Name | Data Type | Description |
|------------|-----------|-------------|
| RecordID | INT | Unique ID for each entry (PK) |
| HouseholdName | VARCHAR(100) | Name of household |
| WasteType | VARCHAR(50) | Paper/Plastic/Food |
| WasteAmount | FLOAT | Weight in kg |
| EntryDate | DATE | Date of entry |
| AddedBy | INT | Reference to UserID (FK) |
