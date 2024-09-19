# Hospital Registration System

## Project Description

The **Hospital Registration System** is a simple C# application with a graphical user interface (GUI) for managing hospital records. This project allows users to perform **CRUD** (Create, Read, Update, Delete) operations on hospital data, including fields such as **Hospital ID**, **Name**, **Address**, and **Email**.

The system features an intuitive interface that allows users to input hospital details and manage them using buttons to insert, update, or delete records.

## Features

- **Insert:** Allows users to add a new hospital record.
- **Update:** Modify details of an existing hospital record.
- **Delete:** Remove a hospital entry from the system.
- **Display Records:** A text area at the bottom to display or list the hospital records.

## GUI Layout
![Screenshot 2024-09-19 210457](https://github.com/user-attachments/assets/4badb137-3498-414b-9d8f-830c014a47f7)

The graphical interface includes the following components:

1. **Text Fields:**
   - Hospital ID
   - Name
   - Address
   - Email
2. **Buttons:**
   - **Insert:** Adds new hospital information.
   - **Update:** Updates the selected hospital record.
   - **Delete:** Deletes the selected hospital record.
3. **Display Area:** A section at the bottom of the window for showing hospital data or status messages.

## Database Schema

Table:
CREATE TABLE [dbo].[HospitalTable] ( </br>
    [Hospital_ID] INT           NOT NULL,</br>
    [Name]        VARCHAR (50)  NOT NULL,</br>
    [Address]     VARCHAR (100) NOT NULL,</br>
    [Email]       VARCHAR (50)  NOT NULL,</br>
    PRIMARY KEY CLUSTERED ([Hospital_ID] ASC)</br>
);

## Requirements

- **Programming Language:**
  - C# (.NET Framework or .NET Core)
  
- **Development Environment:**
  - Visual Studio (Recommended)
  
- **Framework:**
  - **Windows Forms (WinForms)** or **Windows Presentation Foundation (WPF)**, depending on the chosen UI framework.

- **Database (Optional):**
  - You may need **SQL Server**, **SQLite**, or another data storage mechanism to store hospital records persistently.

## How to Run the Project

1. **Clone the Repository:**
   - Clone or download the project files from the repository.
   
2. **Open in Visual Studio:**
   - Open the solution file (`.sln`) in **Visual Studio**.
   
3. **Build the Project:**
   - Ensure all required dependencies and NuGet packages are installed.
   - Build the project using `Ctrl + Shift + B` or select `Build Solution` from the `Build` menu.

4. **Run the Project:**
   - Run the project by pressing `F5` or by clicking the **Start** button in Visual Studio.

5. **Usage:**
   - The GUI window will open, allowing you to input hospital information and perform Insert, Update, and Delete operations.
   - The records will be shown in the display area at the bottom of the window.



## Future Enhancements

- **Database Integration:** Add a database connection (e.g., SQL Server, SQLite) for persistent data storage.
- **Search Functionality:** Implement a search feature to allow users to find hospitals by name or ID.
- **Data Validation:** Add validation to ensure correct input (e.g., valid email address formats, required fields).
- **Error Handling:** Provide better error handling and user feedback (e.g., showing errors for duplicate IDs).
