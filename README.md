# BMI Calculator 2.0 💻

<div align="center">
  <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white" alt="C#">
  <img src="https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white" alt=".NET">
  <img src="https://img.shields.io/badge/Visual_Studio-5C2D91?style=for-the-badge&logo=visual%20studio&logoColor=white" alt="Visual Studio">
  <br>
  <img src="https://img.shields.io/github/license/patel5d2/Patel5d2_BMI_2?style=for-the-badge" alt="License">
  <img src="https://img.shields.io/github/stars/patel5d2/Patel5d2_BMI_2?style=for-the-badge" alt="Stars">
  <img src="https://img.shields.io/github/forks/patel5d2/Patel5d2_BMI_2?style=for-the-badge" alt="Forks">
  <img src="https://img.shields.io/github/issues/patel5d2/Patel5d2_BMI_2?style=for-the-badge" alt="Issues">
</div>

## 🎯 Overview

A professional BMI (Body Mass Index) Calculator application built with C# and .NET Framework. This desktop application provides accurate BMI calculations with a user-friendly Windows Forms interface, comprehensive health insights, and detailed reporting features.

## ✨ Features

- 🧮 **Accurate BMI Calculation**: Uses the standard BMI formula (weight/height²)
- 🖥️ **Desktop Application**: Native Windows application with intuitive GUI
- 🎨 **Modern Interface**: Clean, professional Windows Forms design
- 📊 **Health Categories**: Displays BMI categories with color-coded results
- 🔄 **Dual Unit Support**: Supports both Metric (kg/cm) and Imperial (lbs/ft) units
- 💾 **Data Persistence**: Save and load previous calculations
- 📈 **Progress Tracking**: Track BMI changes over time
- 🖨️ **Report Generation**: Generate and export BMI reports
- ⚠️ **Input Validation**: Comprehensive error handling and validation
- 🏥 **Health Recommendations**: Provides health advice based on BMI results

## 🚀 Quick Start

### Prerequisites

- **Operating System**: Windows 7 or later
- **.NET Framework**: 4.7.2 or higher
- **Visual Studio**: 2019 or later (for development)
- **RAM**: Minimum 512MB
- **Storage**: 50MB free space

### Installation

#### Option 1: Download Release (Recommended)
1. Go to the [Releases](https://github.com/patel5d2/Patel5d2_BMI_2/releases) page
2. Download the latest `BMI_Calculator_Setup.exe`
3. Run the installer and follow the setup wizard
4. Launch the application from Start Menu

#### Option 2: Build from Source
1. **Clone the repository**
   ```bash
   git clone https://github.com/patel5d2/Patel5d2_BMI_2.git
   ```

2. **Open in Visual Studio**
   ```bash
   cd Patel5d2_BMI_2
   start Patel5d2_BMI_Calculator2.sln
   ```

3. **Build and Run**
   - Press `F5` or click "Start Debugging"
   - Or build using: `Build > Build Solution`

## 📱 Usage Guide

### Basic BMI Calculation

1. **Launch the Application**
   - Open BMI Calculator from your desktop or Start Menu

2. **Enter Your Information**
   - **Weight**: Enter your weight in kg or lbs
   - **Height**: Enter your height in cm or ft/inches
   - **Units**: Select Metric or Imperial system

3. **Calculate BMI**
   - Click the "Calculate BMI" button
   - View your BMI result with category classification

4. **Interpret Results**
   - Check the color-coded BMI category
   - Read personalized health recommendations
   - View your BMI on the health scale

### Advanced Features

- **Save Results**: Click "Save" to store your calculation
- **View History**: Access "History" to see previous calculations
- **Generate Report**: Use "Export" to create a detailed BMI report
- **Settings**: Customize units, themes, and preferences

## 📊 BMI Categories & Health Ranges

| BMI Range | Category | Health Status | Color Code |
|-----------|----------|---------------|------------|
| < 18.5 | Underweight | ⚠️ May indicate malnutrition | 🔵 Blue |
| 18.5 - 24.9 | Normal Weight | ✅ Healthy weight range | 🟢 Green |
| 25.0 - 29.9 | Overweight | ⚠️ Increased health risks | 🟡 Yellow |
| 30.0 - 34.9 | Obese Class I | 🔴 High health risks | 🟠 Orange |
| 35.0 - 39.9 | Obese Class II | 🔴 Very high health risks | 🔴 Red |
| ≥ 40.0 | Obese Class III | 🆘 Extremely high health risks | 🟣 Purple |

## 🏗️ Project Structure

```
Patel5d2_BMI_2/
├── Patel5d2_BMI_Calculator2/           # Main application folder
│   ├── Forms/                          # Windows Forms
│   │   ├── MainForm.cs                 # Main calculator interface
│   │   ├── HistoryForm.cs              # BMI history viewer
│   │   ├── SettingsForm.cs             # Application settings
│   │   └── AboutForm.cs                # About dialog
│   ├── Models/                         # Data models
│   │   ├── BMICalculation.cs           # BMI calculation logic
│   │   ├── UserProfile.cs              # User data model
│   │   └── HealthCategory.cs           # Health category definitions
│   ├── Services/                       # Business logic
│   │   ├── BMICalculatorService.cs     # Core calculation service
│   │   ├── DataStorageService.cs       # Data persistence
│   │   └── ReportService.cs            # Report generation
│   ├── Utils/                          # Utility classes
│   │   ├── UnitConverter.cs            # Unit conversion utilities
│   │   ├── Validator.cs                # Input validation
│   │   └── Constants.cs                # Application constants
│   ├── Resources/                      # Application resources
│   │   ├── Images/                     # Icons and images
│   │   └── Themes/                     # UI themes
│   ├── App.config                      # Application configuration
│   ├── Program.cs                      # Application entry point
│   └── AssemblyInfo.cs                 # Assembly information
├── .gitattributes                      # Git attributes
├── .gitignore                          # Git ignore rules
├── LICENSE.txt                         # MIT License
├── Patel5d2_BMI_Calculator2.sln       # Visual Studio solution
└── README.md                           # Project documentation
```

## 🧮 BMI Calculation Formula

### Metric System
```csharp
BMI = weight (kg) / (height (m))²
```

### Imperial System
```csharp
BMI = (weight (lbs) / (height (inches))²) × 703
```

### Code Example
```csharp
public class BMICalculator
{
    public double CalculateBMI(double weight, double height, UnitSystem units)
    {
        if (units == UnitSystem.Imperial)
        {
            return (weight / (height * height)) * 703;
        }
        else // Metric
        {
            double heightInMeters = height / 100; // Convert cm to m
            return weight / (heightInMeters * heightInMeters);
        }
    }
}
```

## 🛠️ Technologies Used

- **Programming Language**: C# 8.0+
- **Framework**: .NET Framework 4.7.2
- **UI Framework**: Windows Forms
- **IDE**: Visual Studio 2019/2022
- **Data Storage**: XML/JSON for local data persistence
- **Version Control**: Git
- **Documentation**: XML Documentation Comments

## 🔧 Development Setup

### Development Requirements
- Visual Studio 2019 or later with .NET desktop development workload
- .NET Framework 4.7.2 Developer Pack
- Git for version control

### Getting Started with Development

1. **Fork the repository**
2. **Clone your fork**
   ```bash
   git clone https://github.com/yourusername/Patel5d2_BMI_2.git
   ```
3. **Open solution in Visual Studio**
4. **Restore NuGet packages** (if any)
5. **Build and run** the project

### Coding Standards
- Follow C# naming conventions
- Use XML documentation for public methods
- Implement proper error handling
- Write unit tests for business logic
- Use meaningful variable and method names

## 🧪 Testing

### Manual Testing Checklist
- [ ] BMI calculation accuracy for both unit systems
- [ ] Input validation for edge cases
- [ ] UI responsiveness and usability
- [ ] Data persistence functionality
- [ ] Report generation features

### Test Cases
```csharp
// Example test cases
Weight: 70kg, Height: 175cm → Expected BMI: 22.86 (Normal)
Weight: 150lbs, Height: 5'9" → Expected BMI: 22.13 (Normal)
Invalid inputs → Should show appropriate error messages
```

## 📈 Features Roadmap

### Version 2.1 (Planned)
- [ ] **Multi-language Support**: English, Spanish, French
- [ ] **Dark Theme**: Modern dark UI theme
- [ ] **BMI Trends**: Graphical BMI tracking over time
- [ ] **Goal Setting**: Set and track BMI goals

### Version 2.2 (Future)
- [ ] **Cloud Sync**: Sync data across devices
- [ ] **Advanced Metrics**: Body fat percentage calculations
- [ ] **Reminder System**: Health check reminders
- [ ] **Export Options**: PDF, Excel report formats

### Version 3.0 (Long-term)
- [ ] **Web Version**: Cross-platform web application
- [ ] **Mobile App**: Android/iOS companion app
- [ ] **Doctor Integration**: Share reports with healthcare providers
- [ ] **AI Recommendations**: Personalized health suggestions

## 🤝 Contributing

Contributions are welcome! Here's how you can help:

### How to Contribute
1. **Fork** the repository
2. **Create** a feature branch (`git checkout -b feature/AmazingFeature`)
3. **Commit** your changes (`git commit -m 'Add some AmazingFeature'`)
4. **Push** to the branch (`git push origin feature/AmazingFeature`)
5. **Open** a Pull Request

### Contribution Guidelines
- Follow the existing code style and conventions
- Add unit tests for new features
- Update documentation as needed
- Test your changes thoroughly
- Write clear commit messages

### Types of Contributions Needed
- 🐛 Bug fixes
- ✨ New features
- 📚 Documentation improvements
- 🎨 UI/UX enhancements
- 🧪 Test coverage improvements
- 🌐 Translations

## 🐛 Bug Reports & Feature Requests

### Reporting Bugs
Found a bug? Please help us by:
1. Checking if the issue already exists
2. Creating a detailed bug report with:
   - Steps to reproduce
   - Expected vs actual behavior
   - Screenshots (if applicable)
   - System information

### Feature Requests
Have an idea for improvement?
1. Check existing feature requests
2. Create a new issue with the "enhancement" label
3. Describe the feature and its benefits
4. Provide mockups or examples if possible

## 📦 Deployment

### Creating a Release Build
1. Update version number in `AssemblyInfo.cs`
2. Build in Release configuration
3. Test the release build thoroughly
4. Create installer using setup project or ClickOnce
5. Tag the release in Git

### Distribution
- GitHub Releases for source code and binaries
- Microsoft Store (future consideration)
- Portable executable for easy distribution

## 🔒 Security

### Data Privacy
- All user data is stored locally
- No personal information is transmitted
- Optional data export for user control

### Input Validation
- Comprehensive input sanitization
- Protection against invalid data
- Error handling for edge cases

## 📄 License

This project is licensed under the MIT License - see the [LICENSE.txt](LICENSE.txt) file for details.

### MIT License Summary
- ✅ Commercial use
- ✅ Modification
- ✅ Distribution
- ✅ Private use
- ❌ Liability
- ❌ Warranty

## 👨‍💻 Author

**Dharmin Patel**

<div align="center">
  <a href="https://github.com/patel5d2">
    <img src="https://img.shields.io/badge/GitHub-100000?style=for-the-badge&logo=github&logoColor=white" alt="GitHub"/>
  </a>
  <a href="https://www.linkedin.com/in/dharmin-patel-a2804621b/">
    <img src="https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white" alt="LinkedIn"/>
  </a>
  <a href="https://dharmin.vercel.app">
    <img src="https://img.shields.io/badge/Portfolio-FF5722?style=for-the-badge&logo=todoist&logoColor=white" alt="Portfolio"/>
  </a>
  <a href="mailto:dharminp976@gmail.com">
    <img src="https://img.shields.io/badge/Gmail-D14836?style=for-the-badge&logo=gmail&logoColor=white" alt="Gmail"/>
  </a>
</div>

- 🎓 Student specializing in Cybersecurity & Software Development
- 💼 4+ Years of coding experience
- 🔍 Passionate about creating user-friendly applications
- 📍 Based in Ohio

## 🙏 Acknowledgments

- **Health Organizations**: WHO, CDC for BMI standards and guidelines
- **Microsoft**: For the excellent .NET Framework and Visual Studio IDE
- **Community**: Stack Overflow and .NET community for support
- **Testers**: Beta testers who provided valuable feedback
- **Contributors**: All contributors who helped improve this project

## 📊 Project Statistics

<div align="center">
  <img src="https://img.shields.io/github/languages/top/patel5d2/Patel5d2_BMI_2?style=for-the-badge" alt="Top Language">
  <img src="https://img.shields.io/github/languages/count/patel5d2/Patel5d2_BMI_2?style=for-the-badge" alt="Language Count">
  <img src="https://img.shields.io/github/repo-size/patel5d2/Patel5d2_BMI_2?style=for-the-badge" alt="Repo Size">
  <img src="https://img.shields.io/github/last-commit/patel5d2/Patel5d2_BMI_2?style=for-the-badge" alt="Last Commit">
  <img src="https://img.shields.io/github/commit-activity/m/patel5d2/Patel5d2_BMI_2?style=for-the-badge" alt="Commit Activity">
</div>

## 🔗 Related Projects

- [Memory Game](https://github.com/patel5d2/Memory-Game) - Interactive web-based memory game
- [Other Projects](https://github.com/patel5d2?tab=repositories) - Browse all repositories

## 📚 Additional Resources

### Health Information
- [BMI Information - CDC](https://www.cdc.gov/healthyweight/assessing/bmi/)
- [WHO BMI Classification](https://www.who.int/news-room/fact-sheets/detail/obesity-and-overweight)
- [Healthy Weight Guidelines - NIH](https://www.nhlbi.nih.gov/health/educational/lose_wt/BMI/bmicalc.htm)

### Development Resources
- [.NET Documentation](https://docs.microsoft.com/en-us/dotnet/)
- [Windows Forms Guide](https://docs.microsoft.com/en-us/dotnet/desktop/winforms/)
- [C# Programming Guide](https://docs.microsoft.com/en-us/dotnet/csharp/)

---

<div align="center">
  <h3>⭐ Star this repository if you found it helpful! ⭐</h3>
  <p><em>"Your health is an investment, not an expense."</em></p>
  
  **Made with ❤️ by Dharmin Patel**
  
  <sub>Built with C# • Powered by .NET • Designed for Health</sub>
</div>

