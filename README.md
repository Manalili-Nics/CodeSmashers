# Smart Waste Management System - SDG 12: Responsible Consumption and Production

## 📌 SDG 12 Justification
This project directly addresses **United Nations Sustainable Development Goal 12: Responsible Consumption and Production** by:

- **Promoting Waste Reduction**: Enables households to track their daily waste production, encouraging mindful consumption habits.
- **Data-Driven Decisions**: Provides analytics on waste patterns to help communities identify areas for improvement.
- **Educational Tool**: Raises awareness about waste segregation and recycling through the knowledge base module.
- **Community Engagement**: The forum feature allows users to share waste reduction tips and best practices.

The system empowers individuals and communities to take actionable steps toward sustainable waste management, aligning with SDG Target 12.5: "Substantially reduce waste generation through prevention, reduction, recycling and reuse."

---

## 📖 Project Description
A Windows Forms application that helps households track, monitor, and analyze their waste production. Features include:
- User authentication system
- Waste entry logging (type, amount, date)
- Real-time total waste calculation
- Report generation and CSV export
- Knowledge base for waste management education
- Community forum for sharing tips

---

## 🛠️ Installation Guide

### Prerequisites
- Windows OS
- [.NET 10.0 SDK](https://dotnet.microsoft.com/download)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) (or later)

### Steps
1. Clone the repository:
   ```bash
   git clone https://github.com/Manalili-Nics/CodeSmashers.git
   ```

2. Open the project:
   ```bash
   cd CodeSmashers/CODE/SmartWaste.UI
   ```

3. Restore NuGet packages:
   ```bash
   dotnet restore
   ```

4. Build and run:
   ```bash
   dotnet run
   ```

5. Login credentials:
   - **Username:** admin
   - **Password:** admin

---

## 👥 Development Team
**Group:** CodeSmashers

| Name | Role | Responsibilities |
|------|------|------------------|
| **Sabio, Khim Axelle P.** | **Project Leader** | Lead Developer (UI/UX), Self-Assessment Module Architecture |
| **Manalili, Nicole N.** | **Developer** | Forum Logic, GitHub Management, Logic Optimization |
| **Gamao, Shin Adrian B.** | **Developer** | Knowledge Base Compilation, Testing, Content Modules |
| **Quilang, Marvin Don A.** | **Developer** | Data Structures Integration, Educational Resources |

---

## 📂 Project Structure
```
CodeSmashers/
├── .gitignore
├── README.md
├── CODE/
│   └── SmartWaste.UI/
│       ├── DatabaseHelper.cs
│       ├── LoginForm.cs
│       ├── MainDashboard.cs
│       ├── ReportForm.cs
│       ├── Program.cs
│       └── SmartWaste.UI.csproj
├── INPUT_DATA/
│   ├── initial_seed.json
│   └── SmartWaste.db
└── DOCUMENTATION/
    ├── SDAD_CodeSmashers.pdf
    ├── Flowchart_CoreAlgorithm.png
    └── Database_Schema_ERD.png
```

---

## 🚀 Features
- ✅ User Login System
- ✅ Waste Entry Management
- ✅ Real-time Waste Calculation
- ✅ Report Generation (CSV Export)
- ✅ Data Persistence (SQLite)
- ✅ Responsive UI Design

---

## 📄 License
This project is created for academic purposes as part of IT Elective 2.
