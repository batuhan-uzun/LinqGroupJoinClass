# LinqGroupJoinClass - LINQ Group Join Example

This project demonstrates how to use LINQ `group join` in a C# Console Application. The example focuses on grouping students by their respective classes and listing each class with its students.

## Project Structure

### Classes

- **`Class`**: Represents the `Classes` table with the following properties:
  - `ClassId` (int): Unique identifier for the class.
  - `ClassName` (string): Name of the class.

- **`Student`**: Represents the `Students` table with the following properties:
  - `StudentId` (int): Unique identifier for the student.
  - `StudentName` (string): Name of the student.
  - `ClassId` (int): Foreign key linking the student to a class.

### Example Data

#### Classes Table
| ClassId | ClassName   |
|---------|-------------|
| 1       | Matematik   |
| 2       | Türkçe      |
| 3       | Kimya       |

#### Students Table
| StudentId | StudentName | ClassId |
|-----------|-------------|---------|
| 1         | Ali         | 1       |
| 2         | Ayşe        | 2       |
| 3         | Mehmet      | 1       |
| 4         | Fatma       | 3       |
| 5         | Ahmet       | 2       |

## How It Works

1. **Data Initialization**: Two lists (`classes` and `students`) are created to simulate the `Classes` and `Students` tables.
2. **LINQ Group Join Query**:
   - Groups students by their respective classes using the `ClassId` field.
   - Outputs the class name along with the names of students belonging to that class.
3. **Output**:
   - Displays each class name followed by its associated students.

### Sample Output
When the program is executed, the following output is displayed:

```
Classes and their Students:
Class: Matematik
  Student: Ali
  Student: Mehmet
Class: Türkçe
  Student: Ayşe
  Student: Ahmet
Class: Kimya
  Student: Fatma
```

## Usage

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/linq-group-join-class.git
   ```
2. Open the project in your preferred IDE (e.g., Visual Studio).
3. Build and run the application.

## Prerequisites

- .NET SDK (Core or Framework, compatible with C#)
- A code editor like Visual Studio, Visual Studio Code, or Rider.

## Features

- Demonstrates LINQ `group join` to group data from multiple sources.
- Provides a simple simulation of relational database functionality using C# collections.

## Author

Created by **Batuhan Uzun**
