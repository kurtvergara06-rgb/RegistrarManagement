# Registrar Management System

**Team 4 - Registrar Management**  
**Batangas State University**  
**IT332 Final Project**

## Project Overview

The **Registrar Management System** is a C# Windows Forms application connected to **Firebase Realtime Database**. It manages registrar-related processes while integrating shared data from other teams or modules.

The four main modules are:

- Student Registration
- Academic Records
- Document Requests
- Student Clearances

The application uses a simple layered structure where **Forms** handle the user interface, **Services** handle CRUD operations and business logic, **Models** represent the data structure, **Helpers** provide reusable utilities, and **FirebaseService** handles communication with Firebase.

---

## Team 4 Responsibilities

### 1. Student Registration

Main functions:

- Load students from shared Student Management data
- Automatically display the student's program
- Select year level
- Select school year and semester
- Set registration status
- Prevent duplicate registration for the same student, school year, and semester
- Add, update, delete, search, and view registration records

Firebase node:

```text
student_registrations
```

Workflow:

```text
Select Student
      ↓
Load Student Program
      ↓
Select Year Level
      ↓
Select School Year and Semester
      ↓
Set Registration Status
      ↓
Save Registration
      ↓
student_registrations
```

---

### 2. Academic Records

Main functions:

- Load students from shared Student Management data
- Load program, school year, semester, and year level information
- Verify that a student has a valid registration
- Assign academic status
- Prevent duplicate academic records for the same student and academic term
- Add, update, delete, search, and view academic records

Possible statuses:

```text
Regular
Irregular
Probation
Graduating
Graduated
Inactive
```

Firebase node:

```text
academic_records
```

Workflow:

```text
Select Student
      ↓
Check Student Registration
      ↓
Select School Year and Semester
      ↓
Set Academic Status
      ↓
Save Academic Record
      ↓
academic_records
```

---

### 3. Document Requests

Supported document types may include:

```text
Certificate of Enrollment
Certificate of Registration
Transcript of Records
Certificate of Grades
Good Moral Certificate
Honorable Dismissal
Student Clearance
Diploma
Form 137
Other
```

Possible request statuses:

```text
Pending
Processing
Ready for Release
Released
Rejected
Cancelled
```

Main functions:

- Select a student
- Select document type
- Enter request purpose
- Set request date
- Manage request status
- Set release date when the request is released
- Add remarks
- Add, update, delete, search, and view requests

Firebase node:

```text
document_requests
```

Workflow:

```text
Select Student
      ↓
Choose Document Type
      ↓
Enter Purpose
      ↓
Set Request Status
      ↓
Set Release Date if Released
      ↓
Save Request
      ↓
document_requests
```

---

### 4. Student Clearances

Current fields:

```text
Student
Library Status
Medical Status
Registrar Status
Accounting Status
Overall Status
Remarks
```

The previous Guidance Status field was removed because no dedicated Guidance shared-data source currently exists in the project.

| Clearance Field | Source / Logic |
|---|---|
| Student | Shared `students` data |
| Library Status | Shared Library Team data when available |
| Medical Status | Shared `medical` node |
| Registrar Status | Controlled manually by Team 4 |
| Accounting Status | Automatically computed from `enrollments > TuitionFee > Balance` |
| Overall Status | Automatically calculated |
| Remarks | Additional Registrar notes |

Accounting Status logic:

```text
Balance <= 0
→ Cleared

Balance > 0
→ Not Cleared

No enrollment or tuition record
→ No Record
```

Overall Status logic:

```text
All required statuses are Cleared
→ Overall Status = Cleared

Any status is Not Cleared
→ Overall Status = Not Cleared

Any status is Pending or No Record
→ Overall Status = Pending
```

Workflow:

```text
Select Student
      ↓
Click Check Shared Status
      ↓
Get Library Status
Get Medical Status
Compute Accounting Status
      ↓
Registrar sets Registrar Status
      ↓
Calculate Overall Status
      ↓
Save Clearance Record
      ↓
student_clearances
```

---

# System Architecture

```text
Forms
  ↓
Services
  ↓
FirebaseService
  ↓
Firebase Realtime Database
```

## Forms

Forms handle:

- Button events
- Form loading
- Displaying records
- Reading user input
- Updating controls
- Showing validation messages
- Calling Services

Examples:

```text
StudentRegistrationForm
AcademicRecordsForm
DocumentRequestsForm
StudentClearancesForm
RegistrarDashboardForm
```

## Models

Models define the structure of the data used by the application.

Examples:

```text
Student
StudentRegistration
AcademicRecord
DocumentRequest
StudentClearance
AcademicOffering
MedicalClearance
LibraryClearance
```

## Services

Services act as the application's data-access and business-logic layer.

They handle:

- CRUD operations
- Firebase data retrieval
- Firebase data saving
- Firebase data deletion
- Shared data access
- Reusable business rules

General flow:

```text
Form
  ↓
Specific Service
  ↓
FirebaseService
  ↓
Firebase
```

## FirebaseService

`FirebaseService.cs` is the low-level service responsible for communicating with Firebase through HTTP requests.

Important methods:

```text
GetAllAsync<T>()
→ Reads Firebase object/dictionary nodes

GetListAsync<T>()
→ Reads Firebase array/list nodes

GetByIdAsync<T>()
→ Reads a specific record

PutAsync<T>()
→ Creates or updates a record

DeleteAsync()
→ Deletes a record
```

Example object/dictionary structure:

```json
{
  "student_registrations": {
    "REG-0001": {
      "studentId": "26-00001"
    }
  }
}
```

Example array/list structure:

```json
{
  "enrollments": [
    {
      "StudentID": "26-00001"
    }
  ]
}
```

---

# Project Folder Structure

```text
RegistrarManagement/
│
├── Forms/
│   ├── RegistrarDashboardForm.cs
│   ├── StudentRegistrationForm.cs
│   ├── AcademicRecordsForm.cs
│   ├── DocumentRequestsForm.cs
│   └── StudentClearancesForm.cs
│
├── Models/
│
├── Services/
│   ├── FirebaseService.cs
│   ├── StudentService.cs
│   ├── RegistrationService.cs
│   ├── AcademicRecordService.cs
│   ├── DocumentRequestService.cs
│   ├── ClearanceService.cs
│   └── SharedDataService.cs
│
├── Helpers/
│   ├── FirebaseConfig.cs
│   ├── IdGenerator.cs
│   ├── StringOrNumberConverter.cs
│   └── ValidationHelper.cs
│
├── Resources/
│
├── Program.cs
├── firebase.env
└── README.md
```

---

# Helpers

## FirebaseConfig.cs

Stores or loads Firebase connection settings such as the Firebase Base URL and Auth Secret.

The Firebase secret should never be committed publicly.

## IdGenerator.cs

Generates readable sequential IDs.

Preferred format:

```text
REG-0001
AR-0001
REQ-0001
CLR-0001
```

Meaning:

```text
REG → Student Registration
AR  → Academic Record
REQ → Document Request
CLR → Student Clearance
```

## StringOrNumberConverter.cs

Helps deserialize shared Firebase data when the same value may be stored as either a string or a number.

Example:

```json
"YearLevel": 2
```

or:

```json
"YearLevel": "2"
```

## ValidationHelper.cs

Provides reusable validation methods.

Current required-field helper:

```csharp
public static bool Required(params string?[] values) =>
    values.All(value => !string.IsNullOrWhiteSpace(value));
```

It returns `true` only when all provided values contain valid non-empty text.

---

# Services

## StudentService.cs

Handles shared student data.

Typical responsibilities:

```text
Get all students
Retrieve student information
Provide student records to Registrar forms
```

Team 4 should not manually create Student Management records.

## RegistrationService.cs

Handles Team 4 Student Registration data.

Firebase node:

```text
student_registrations
```

## AcademicRecordService.cs

Handles academic records.

Firebase node:

```text
academic_records
```

## DocumentRequestService.cs

Handles document requests.

Firebase node:

```text
document_requests
```

## ClearanceService.cs

Handles Student Clearance data and clearance-related business rules.

Main responsibilities:

```text
Read and save student_clearances
Read Library clearance data
Read Medical data
Read Enrollment and Tuition data
Compute Accounting Status
Calculate Overall Clearance Status
```

---

# Shared Firebase Data Integration

| Firebase Data | Usage in Registrar Management |
|---|---|
| `students` | Student selection and identity |
| `academicManagement/programs` | Program information |
| `academicManagement/academicofferings` | School year and semester information |
| `student_registrations` | Team 4 registration records |
| `academic_records` | Team 4 academic records |
| `document_requests` | Team 4 document request records |
| `student_clearances` | Team 4 clearance records |
| `medical` | Medical status / medical record information |
| `enrollments` | Enrollment and tuition balance information |
| `library_clearances` | Library clearance data when available |

## Data Ownership

```text
Student Management
→ Owns students

Academic Management
→ Owns programs and academic offerings

Medical Management
→ Owns medical data

Enrollment Management
→ Owns enrollment and tuition data

Library Management
→ Owns library clearance data

Registrar Management - Team 4
→ Owns student_registrations
→ Owns academic_records
→ Owns document_requests
→ Owns student_clearances
```

---

# CRUD Operations

| Operation | Meaning | Example |
|---|---|---|
| Create | Add new data | Add registration |
| Read | Retrieve data | Load students |
| Update | Modify existing data | Update academic record |
| Delete | Remove data | Delete clearance record |

The Forms call Services, and the Services perform CRUD operations through `FirebaseService`.

---

# Technologies Used

```text
C#
.NET
Windows Forms
Firebase Realtime Database
Firebase REST API
HttpClient
System.Text.Json
LINQ
Visual Studio
```

---

# User Interface Design

The application uses a consistent Batangas State University-inspired design.

Main UI characteristics:

```text
BatStateU maroon header
University logo
Consistent page titles and subtitles
White card-based form layout
Rounded action buttons
Maroon DataGridView headers
Search panel
Consistent footer
```

---

# Setup Instructions

You can set up the project either by **downloading the ZIP file** or by **cloning the repository using Git**.

## Option A: Download as ZIP File

### 1. Download the Project

Download the project repository as a ZIP file.

### 2. Extract the ZIP File

Right-click the downloaded ZIP file and select:

```text
Extract All
````

Open the extracted project folder.

### 3. Open the Project in Visual Studio

Inside the extracted folder, find the project file that ends with:

```text
.csproj
```

Example:

```text
RegistrarManagement.csproj
```

Double-click the `.csproj` file to open the project in Visual Studio.

### 4. Configure Firebase

Create or update:

```text
firebase.env
```

with the required Firebase configuration.

Make sure the Firebase Base URL and authentication settings are correct before running the system.

Do not upload or commit real Firebase secrets to a public repository.

### 5. Restore Dependencies

Visual Studio will usually restore the required .NET dependencies automatically.

If needed, restore the required packages through Visual Studio or NuGet Package Manager.

### 6. Build the Project

In Visual Studio, select:

```text
Build
→ Build Solution
```

Make sure there are no build errors.

### 7. Run the Application

Click the Start button in Visual Studio or press:

```text
F5
```

---

## Option B: Clone the Project Using Git

### 1. Clone the Repository

Open Command Prompt, PowerShell, Git Bash, or the Visual Studio terminal.

Run:

```bash
git clone <repository-url>
```

Example:

```bash
git clone https://github.com/username/repository-name.git
```

Replace the example URL with the actual GitHub repository URL.

### 2. Open the Project Folder

Go to the cloned project folder:

```bash
cd repository-name
```

### 3. Open the Project in Visual Studio

Find the project file that ends with:

```text
.csproj
```

Example:

```text
RegistrarManagement.csproj
```

Double-click the `.csproj` file or open it directly in Visual Studio.

### 4. Configure Firebase

Create or update:

```text
firebase.env
```

with the required Firebase configuration.

Do not commit Firebase authentication secrets or other sensitive credentials to GitHub.

### 5. Restore Dependencies

Visual Studio should restore the required .NET dependencies automatically.

If dependencies are missing, restore them through Visual Studio or NuGet Package Manager.

### 6. Build the Project

In Visual Studio, select:

```text
Build
→ Build Solution
```

### 7. Run the Application

Click the Start button or press:

```text
F5
```

The Registrar Management System should now start.

```

Then click **Preview** first to make sure the formatting looks correct, and after that click **Commit changes...**.
```

# Important Notes

- Students shown in Registrar dropdowns come from the shared `students` node.
- Team 4 should not manually create student profiles owned by Student Management.
- Shared records may only appear after another team saves them to Firebase.
- `enrollments` is currently stored as a JSON array/list.
- Many other Firebase nodes are stored as JSON objects/dictionaries.
- Medical data currently uses the field `Status`.
- Accounting Status is derived from `TuitionFee.Balance`.
- Guidance Status was removed because no dedicated Guidance shared-data source currently exists.
- Library Status depends on the actual structure provided by the Library team.
- Existing old record IDs may remain unchanged while newly created records use the new sequential ID format.
- Firebase credentials and secrets should not be committed publicly.

---

# Future Improvements

```text
Role-based authentication and authorization
Automatic real-time synchronization
Improved clearance integration
Better validation rules
Audit trail and activity logs
Report generation
PDF export
Excel export
Notification system
Improved search and filters
Dashboard analytics
```

---

# Screenshots

Suggested screenshots:

```text
1. Registrar Dashboard
2. Student Registration
3. Academic Records
4. Document Requests
5. Student Clearances
```

Example:

```markdown
## Registrar Dashboard

![Registrar Dashboard](screenshots/dashboard.png)
```

---

# System Review Summary

Core architecture:

```text
User
  ↓
Form
  ↓
Service
  ↓
FirebaseService
  ↓
Firebase Realtime Database
```

Layer responsibilities:

```text
Forms
→ UI and interaction logic

Models
→ Data structure

Services
→ CRUD, data access, and business logic

Helpers
→ Reusable utility functions

FirebaseService
→ HTTP communication with Firebase

Firebase
→ Shared database
```

Team 4 core responsibility:

```text
Student Registration
Academic Records
Document Requests
Student Clearances
```

---

# Team Members

**Team 4 - Registrar Management**

```text
Kurt Allen L. Vergara
Rafael Luis C. Nabong
Member 3
Member 4
```

---

# Academic Use

This project was developed for academic purposes as part of the IT332 Final Project at Batangas State University.
