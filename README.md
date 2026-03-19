# Smart Waste Management System - SDG 12: Responsible Consumption and Production

## 📌 SDG 12 Justification
SDG 12: Responsible Consumption and Production
Our Commitment to the United Nations Sustainable Development Goals
The Smart Waste Management System is proudly aligned with UN Sustainable Development Goal 12: "Ensure sustainable consumption and production patterns." This goal calls for urgent action to reduce our ecological footprint by changing how we produce, consume, and dispose of resources.

🌍 The Global Challenge
According to the World Bank, global waste generation is expected to reach 3.4 billion tons by 2050 – a 70% increase from current levels. Developing countries face the greatest challenges in managing this waste effectively, leading to:

🏭 Environmental pollution and ecosystem degradation

💰 Economic losses from unrecovered resources

🏥 Public health risks from improper waste disposal

📉 Inefficient resource utilization


💡 Our Solution's Impact
SDG Target	How Our System Addresses It
12.5: Substantially reduce waste generation through prevention, reduction, recycling and reuse	Enables households to track waste patterns, encouraging mindful consumption and waste reduction
12.8: Ensure people have relevant information and awareness for sustainable development	Provides real-time data and reports that educate users about their waste footprint
12.A: Support developing countries to strengthen scientific and technological capacity	Digitizes manual waste tracking, making data collection accessible and efficient

📊 Measurable Contributions
Through our system, users can:

✅ Track daily waste generation by type (Paper, Plastic, Food)

✅ Analyze patterns over time to identify reduction opportunities

✅ Report on progress with downloadable CSV data for further analysis

✅ Engage communities in collective waste reduction efforts




---

## 📖 Project Description
A Windows Forms application that helps households track, monitor, and analyze their waste production. Features include:
- User authentication system
- Waste entry logging (type, amount, date)
- Real-time total waste calculation
- Report generation and CSV export
- Knowledge base for waste management education
- Community forum for sharing tips


The Smart Waste Management System is a Windows Forms application designed to digitize and streamline household waste tracking. It provides an intuitive interface for logging waste entries, real-time calculation of total waste collected, and comprehensive reporting features including CSV export. Built with a clean 3-tier architecture, the system ensures data integrity through SQLite database integration while maintaining user-friendly experience through responsive UI design. This project aims to empower individuals and communities to make data-driven decisions in their waste reduction efforts, contributing to a more sustainable future.

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
