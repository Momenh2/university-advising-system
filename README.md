# University Advising System

A comprehensive web-based academic management system designed for universities to streamline student advising, course registration, and administrative processes. Built with ASP.NET Web Forms and SQL Server.

## 📋 Table of Contents

- [Overview](#overview)
- [Features](#features)
- [Technology Stack](#technology-stack)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Configuration](#configuration)
- [Usage](#usage)
- [User Roles](#user-roles)
- [Database Schema](#database-schema)
- [API Documentation](#api-documentation)
- [Development](#development)
- [Testing](#testing)
- [Deployment](#deployment)
- [Contributing](#contributing)
- [License](#license)
- [Support](#support)

## 🎯 Overview

The University Advising System is a comprehensive academic management platform that facilitates the interaction between students, academic advisors, and administrators. The system manages the entire academic lifecycle from course registration to graduation planning, with role-based access control ensuring appropriate permissions for different user types.

### Key Benefits

- **Streamlined Academic Processes**: Automates course registration, advising sessions, and graduation planning
- **Role-Based Access Control**: Secure access for students, advisors, and administrators
- **Comprehensive Reporting**: Detailed academic records and transcript management
- **Financial Integration**: Payment tracking and installment management
- **Real-time Updates**: Dynamic course availability and registration status

## ✨ Features

### Student Features
- 🔐 Secure login and registration
- 📚 View available courses and course details
- 📝 Request course registrations
- ⏰ Request extra credit hours
- 📋 View and track graduation plans
- 📊 Access academic transcripts
- 💳 View payment status and installments
- 🔍 Search and filter course offerings

### Advisor Features
- 👥 Manage assigned students
- 📋 Create and modify graduation plans
- 📝 Insert courses into graduation plans
- 📅 Update graduation dates
- ❌ Delete courses from plans
- 📊 View student transcripts
- ✅ Approve/reject student requests
- 📋 Manage pending requests
- 📈 Track student progress

### Administrator Features
- 🗑️ Delete courses and course slots
- 📝 Add makeup exams
- 💰 Manage payments and installments
- 📊 Update student financial status
- 👥 View all active students
- 📋 View all graduation plans
- 📊 Generate comprehensive reports
- 🎓 Manage semesters and course offerings
- 🔗 Link students with advisors

## 🛠️ Technology Stack

### Frontend
- **ASP.NET Web Forms** - Server-side web framework
- **C#** - Primary programming language
- **HTML/CSS** - Markup and styling
- **JavaScript** - Client-side interactions

### Backend
- **.NET Framework 4.8** - Runtime environment
- **ASP.NET** - Web application framework
- **C#** - Server-side logic
- **ADO.NET** - Data access layer

### Database
- **SQL Server LocalDB** - Database engine
- **Stored Procedures** - Database operations
- **Entity Framework** - ORM (if applicable)

### Development Tools
- **Visual Studio** - IDE
- **IIS Express** - Local web server
- **NuGet** - Package management

## 📋 Prerequisites

Before running this application, ensure you have the following installed:

### Required Software
- **Visual Studio 2019/2022** (Community, Professional, or Enterprise)
- **SQL Server LocalDB** (included with Visual Studio)
- **.NET Framework 4.8** (usually pre-installed with Visual Studio)
- **IIS Express** (included with Visual Studio)

### System Requirements
- **Operating System**: Windows 10/11 or Windows Server 2016+
- **RAM**: Minimum 4GB, Recommended 8GB+
- **Storage**: At least 2GB free space
- **Browser**: Modern web browser (Chrome, Firefox, Edge, Safari)

## 🚀 Installation

### Step 1: Clone the Repository
```bash
git clone <repository-url>
cd DB1
```

### Step 2: Open in Visual Studio
1. Open Visual Studio
2. Open the solution file: `WebApplication1/WebApplication1.sln`
3. Wait for Visual Studio to restore NuGet packages

### Step 3: Database Setup
1. Ensure SQL Server LocalDB is running
2. The application will automatically create the database on first run
3. Alternatively, you can run the database scripts manually

### Step 4: Build and Run
1. Press `F5` or click "Start Debugging"
2. The application will open in your default browser
3. Navigate to the application URL (typically `https://localhost:44392`)

## ⚙️ Configuration

### Database Connection
The application uses the following connection string (configured in `Web.config`):

```xml
<connectionStrings>
    <add name="Advising_System"
         connectionString="server=(localdb)\MSSQLLocalDB;Initial Catalog=Advising_System;Integrated Security=True" />
</connectionStrings>
```

### Application Settings
Key configuration options in `Web.config`:

```xml
<system.web>
    <compilation debug="true" targetFramework="4.8" />
    <httpRuntime targetFramework="4.8" />
</system.web>
```

### Customization
- **Database Name**: Change `Initial Catalog=Advising_System` in connection string
- **Server**: Modify `server=(localdb)\MSSQLLocalDB` for different SQL Server instances
- **Authentication**: Update `Integrated Security=True` for SQL authentication

## 📖 Usage

### Getting Started
1. **Access the Application**: Navigate to the application URL
2. **Select Role**: Choose your role (Student, Advisor, or Admin)
3. **Login**: Enter your credentials
4. **Navigate**: Use the interface to access desired features

### Common Workflows

#### Student Workflow
1. Register/Login as a student
2. View available courses
3. Request course registration
4. Track graduation plan progress
5. View academic transcript

#### Advisor Workflow
1. Login as an advisor
2. View assigned students
3. Create/modify graduation plans
4. Approve/reject student requests
5. Monitor student progress

#### Administrator Workflow
1. Login as administrator
2. Manage courses and slots
3. Handle payments and installments
4. Generate reports
5. Manage system settings

## 👥 User Roles

### Student Role
- **Purpose**: Academic planning and course management
- **Permissions**: View courses, request registrations, access transcripts
- **Access Level**: Limited to personal academic information

### Advisor Role
- **Purpose**: Student advising and academic planning
- **Permissions**: Manage graduation plans, approve requests, view student data
- **Access Level**: Access to assigned students' information

### Administrator Role
- **Purpose**: System administration and management
- **Permissions**: Full system access, course management, financial operations
- **Access Level**: Complete system access

## 🗄️ Database Schema

The system uses a comprehensive database schema with the following key entities:

### Core Tables
- **Students**: Student information and academic records
- **Advisors**: Advisor profiles and assignments
- **Courses**: Course catalog and offerings
- **Graduation_Plans**: Academic planning data
- **Requests**: Student requests and approvals
- **Payments**: Financial transaction records

### Relationships
- Students are assigned to Advisors
- Courses are linked to Graduation Plans
- Requests connect Students to Advisors
- Payments are associated with Students

## 🔌 API Documentation

### Authentication Endpoints
- `POST /Login.aspx` - User authentication
- `POST /Register.aspx` - User registration
- `GET /Logout` - Session termination

### Student Endpoints
- `GET /courses.aspx` - View available courses
- `POST /course_request.aspx` - Submit course requests
- `GET /transcript.aspx` - View academic transcript

### Advisor Endpoints
- `GET /advisor.aspx` - Advisor dashboard
- `POST /graduation_plan.aspx` - Manage graduation plans
- `GET /pending_requests.aspx` - View pending requests

### Administrator Endpoints
- `GET /Admin2.aspx` - Admin dashboard
- `POST /course_management.aspx` - Course operations
- `GET /reports.aspx` - Generate reports

## 💻 Development

### Project Structure
```
WebApplication1/
├── WebApplication1/
│   ├── *.aspx              # Web pages
│   ├── *.aspx.cs           # Code-behind files
│   ├── *.aspx.designer.cs  # Designer files
│   ├── Web.config          # Configuration
│   ├── packages.config     # NuGet packages
│   └── Properties/         # Assembly info
├── packages/               # NuGet packages
└── WebApplication1.sln     # Solution file
```

### Key Files
- **First_Page.aspx**: Application entry point
- **Login_Student.aspx**: Student authentication
- **advisor.aspx**: Advisor dashboard
- **Admin2.aspx**: Administrator dashboard
- **Web.config**: Application configuration

### Development Guidelines
1. **Code Style**: Follow C# coding conventions
2. **Naming**: Use descriptive names for controls and variables
3. **Error Handling**: Implement proper exception handling
4. **Security**: Validate all user inputs
5. **Performance**: Optimize database queries

## 🧪 Testing

### Unit Testing
- Test individual components and methods
- Mock database connections for isolated testing
- Verify business logic correctness

### Integration Testing
- Test complete user workflows
- Verify database operations
- Test role-based access control

### User Acceptance Testing
- Test with actual users
- Verify all features work as expected
- Validate user experience

## 🚀 Deployment

### Development Deployment
1. Build the solution in Visual Studio
2. Run locally using IIS Express
3. Test all functionality

### Production Deployment
1. **Prerequisites**:
   - Windows Server with IIS
   - SQL Server (not LocalDB)
   - .NET Framework 4.8

2. **Deployment Steps**:
   ```bash
   # Build release version
   msbuild WebApplication1.sln /p:Configuration=Release
   
   # Deploy to IIS
   # Copy files to IIS web directory
   # Configure application pool
   # Set up database connection
   ```

3. **Configuration**:
   - Update connection string for production database
   - Configure IIS application pool
   - Set up SSL certificates
   - Configure security settings

### Environment Variables
- `DATABASE_CONNECTION` - Production database connection
- `DEBUG_MODE` - Enable/disable debug features
- `LOG_LEVEL` - Application logging level

## 🤝 Contributing

We welcome contributions to improve the University Advising System!

### How to Contribute
1. **Fork** the repository
2. **Create** a feature branch (`git checkout -b feature/amazing-feature`)
3. **Commit** your changes (`git commit -m 'Add amazing feature'`)
4. **Push** to the branch (`git push origin feature/amazing-feature`)
5. **Open** a Pull Request

### Contribution Guidelines
- Follow existing code style and conventions
- Add appropriate comments and documentation
- Test your changes thoroughly
- Update documentation as needed
- Ensure all tests pass

### Code Review Process
1. Submit pull request with detailed description
2. Code review by maintainers
3. Address feedback and make changes
4. Final approval and merge

## 🛡️ License

This project is licensed under the [MIT License](LICENSE).

---

## 🙌 Author

**Momen H.**  
📂 [GitHub Profile »](https://github.com/Momenh2)


## 📈 Roadmap

### Upcoming Features
- [ ] Mobile-responsive design
- [ ] Real-time notifications
- [ ] Advanced reporting dashboard
- [ ] API for third-party integrations
- [ ] Enhanced security features

### Version History
- **v1.0.0** - Initial release with core functionality
- **v1.1.0** - Enhanced user interface
- **v1.2.0** - Improved performance and security

---

**Note**: This system is designed for educational institutions and should be deployed in a secure environment with proper access controls and data protection measures in place. 
