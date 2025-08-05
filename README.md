# University Advising System

A comprehensive web-based academic management system designed for universities to streamline student advising, course registration, and administrative processes. Built with ASP.NET Web Forms and SQL Server.

## 📋 Table of Contents

- [Overview](#overview)
- [Features](#features)
- [Technology Stack](#technology-stack)
- [Database Schema](#database-schema)
- [Stored Procedures & Functions](#stored-procedures--functions)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Configuration](#configuration)
- [Usage](#usage)
- [User Roles](#user-roles)
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
- **Advanced Database Design**: Comprehensive schema with stored procedures and functions

## ✨ Features

### Student Features
- 🔐 Secure login and registration with financial status validation
- 📚 View available courses and course details for current semester
- 📝 Request course registrations with prerequisite validation
- ⏰ Request extra credit hours (up to 3 hours with GPA < 3.7)
- 📋 View and track graduation plans
- 📊 Access academic transcripts
- 💳 View payment status and upcoming installments
- 🔍 Search and filter course offerings
- 📝 Register for makeup exams (first and second attempts)
- 👨‍🏫 Choose instructors for selected courses
- 📋 View required and optional courses based on academic standing

### Advisor Features
- 👥 Manage assigned students by major
- 📋 Create and modify graduation plans (for students with ≥157 hours)
- 📝 Insert courses into graduation plans
- 📅 Update graduation dates
- ❌ Delete courses from plans
- 📊 View student transcripts
- ✅ Approve/reject student requests (course and credit hour requests)
- 📋 Manage pending requests
- 📈 Track student progress
- 🎯 View students with their current courses

### Administrator Features
- 🗑️ Delete courses and course slots
- 📝 Add makeup exams
- 💰 Manage payments and installments
- 📊 Update student financial status based on payment history
- 👥 View all active students
- 📋 View all graduation plans
- 📊 Generate comprehensive reports
- 🎓 Manage semesters and course offerings
- 🔗 Link students with advisors
- 📚 Add new courses and semesters
- 👨‍🏫 Link instructors to courses and slots
- 💳 Issue installments for payments

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
- **User-Defined Functions** - Complex business logic
- **Views** - Optimized data retrieval

### Development Tools
- **Visual Studio** - IDE
- **IIS Express** - Local web server
- **NuGet** - Package management

## 🗄️ Database Schema

### Core Tables

#### **Student Management**
- **Student**: Student information, GPA, financial status, advisor assignment
- **Student_Phone**: Multiple phone numbers per student
- **Advisor**: Advisor profiles and contact information

#### **Academic Structure**
- **Course**: Course catalog with prerequisites and credit hours
- **PreqCourse_course**: Prerequisite relationships between courses
- **Semester**: Academic periods with start/end dates
- **Course_Semester**: Course offerings per semester

#### **Academic Records**
- **Student_Instructor_Course_take**: Student course enrollments and grades
- **Instructor**: Faculty information
- **Instructor_Course**: Instructor-course assignments
- **Slot**: Course time slots and locations

#### **Graduation Planning**
- **Graduation_Plan**: Student graduation plans
- **GradPlan_Course**: Courses included in graduation plans

#### **Requests & Approvals**
- **Request**: Student requests (course, credit hours) with approval status
- **MakeUp_Exam**: Makeup exam scheduling
- **Exam_Student**: Student makeup exam registrations

#### **Financial Management**
- **Payment**: Student payment records
- **Installment**: Payment installment tracking

### Key Relationships
- Students are assigned to Advisors (1:1)
- Courses have prerequisites (Many:Many via PreqCourse_course)
- Students enroll in courses through Student_Instructor_Course_take
- Graduation plans link students, advisors, and courses
- Payments are associated with students and semesters

### Database Views
- **view_Students**: Active students with accepted financial status
- **view_Course_prerequisites**: Courses with their prerequisites
- **Instructors_AssignedCourses**: All instructors with assigned courses
- **Student_Payment**: Payments with student details
- **Courses_Slots_Instructor**: Course slots with instructor information
- **Courses_MakeupExams**: Courses with makeup exam details
- **Students_Courses_transcript**: Student academic transcripts
- **Semster_offered_Courses**: Semester course offerings
- **Advisors_Graduation_Plan**: Graduation plans with advisor information

## 🔧 Stored Procedures & Functions

### Authentication & Registration
- **Procedures_StudentRegistration**: Student registration with output ID
- **Procedures_AdvisorRegistration**: Advisor registration
- **FN_StudentLogin**: Student login with financial status check
- **FN_AdvisorLogin**: Advisor login validation

### Administrator Functions
- **Procedures_AdminListStudents**: List all students
- **Procedures_AdminListAdvisors**: List all advisors
- **AdminListStudentsWithAdvisors**: Students with advisor assignments
- **AdminAddingSemester**: Add new academic semesters
- **Procedures_AdminAddingCourse**: Add new courses
- **Procedures_AdminLinkInstructor**: Link instructors to course slots
- **Procedures_AdminLinkStudent**: Link students to courses
- **Procedures_AdminLinkStudentToAdvisor**: Assign students to advisors
- **Procedures_AdminAddExam**: Add makeup exams
- **Procedures_AdminIssueInstallment**: Generate payment installments
- **Procedures_AdminDeleteCourse**: Delete courses and related slots
- **FN_AdminCheckStudentStatus**: Check student financial status
- **Procedure_AdminUpdateStudentStatus**: Update student financial status
- **Procedures_AdminDeleteSlots**: Delete slots for non-offered courses

### Advisor Functions
- **Procedures_AdvisorCreateGP**: Create graduation plans (≥157 hours required)
- **Procedures_AdvisorAddCourseGP**: Add courses to graduation plans
- **Procedures_AdvisorUpdateGP**: Update graduation dates
- **Procedures_AdvisorDeleteFromGP**: Remove courses from graduation plans
- **FN_Advisors_Requests**: Get advisor's pending requests
- **Procedures_AdvisorApproveRejectCHRequest**: Approve/reject credit hour requests
- **Procedures_AdvisorViewAssignedStudents**: View assigned students by major
- **FN_check_prerequiste**: Check course prerequisites
- **Procedures_AdvisorApproveRejectCourseRequest**: Approve/reject course requests
- **Procedures_AdvisorViewPendingRequests**: View pending requests

### Student Functions
- **Procedures_StudentaddMobile**: Add phone numbers
- **FN_SemsterAvailableCourses**: View available courses for semester
- **Procedures_StudentSendingCourseRequest**: Submit course requests
- **Procedures_StudentSendingCHRequest**: Submit credit hour requests
- **FN_StudentViewGP**: View graduation plan details
- **FN_StudentUpcoming_installment**: View next payment deadline
- **FN_StudentViewSlot**: View course slots with instructor details
- **Procedures_StudentRegisterFirstMakeup**: Register for first makeup exam
- **FN_StudentCheckSMEligibility**: Check second makeup eligibility
- **Procedures_StudentRegisterSecondMakeup**: Register for second makeup exam
- **FN_StudentFailedAndNotEligibleCourse**: Failed courses not eligible for makeup
- **FN_StudentUnattendedCourses**: Courses not yet taken
- **Procedures_ViewRequiredCourses**: View required courses
- **Procedures_ViewOptionalCourse**: View optional courses
- **Procedures_ViewMS**: View missing/remaining courses
- **Procedures_Chooseinstructor**: Choose instructor for course

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

### Step 2: Database Setup
1. Open SQL Server Management Studio or Visual Studio
2. Connect to your SQL Server instance
3. Execute the `SqlQuery_1.sql` file to create the database and all objects
4. The script will create:
   - Database: `Advising_System`
   - All tables, views, stored procedures, and functions
   - Sample data (if included)

### Step 3: Open in Visual Studio
1. Open Visual Studio
2. Open the solution file: `WebApplication1/WebApplication1.sln`
3. Wait for Visual Studio to restore NuGet packages

### Step 4: Configure Database Connection
1. Open `Web.config`
2. Verify the connection string points to your database:
```xml
<connectionStrings>
    <add name="Advising_System"
         connectionString="server=(localdb)\MSSQLLocalDB;Initial Catalog=Advising_System;Integrated Security=True" />
</connectionStrings>
```

### Step 5: Build and Run
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
1. Register/Login as a student (financial status must be active)
2. View available courses for current semester
3. Request course registration (prerequisites checked automatically)
4. Request extra credit hours (if eligible)
5. View graduation plan and track progress
6. Register for makeup exams if needed
7. View academic transcript and payment status

#### Advisor Workflow
1. Login as an advisor
2. View assigned students by major
3. Create/modify graduation plans (for eligible students)
4. Approve/reject student requests
5. Monitor student progress and academic standing
6. Manage course assignments in graduation plans

#### Administrator Workflow
1. Login as administrator
2. Manage courses, semesters, and instructors
3. Link students with advisors
4. Handle payments and installments
5. Update student financial status
6. Generate comprehensive reports
7. Manage makeup exams and course offerings

## 👥 User Roles

### Student Role
- **Purpose**: Academic planning and course management
- **Permissions**: View courses, request registrations, access transcripts
- **Access Level**: Limited to personal academic information
- **Financial Requirements**: Must have active financial status to login

### Advisor Role
- **Purpose**: Student advising and academic planning
- **Permissions**: Manage graduation plans, approve requests, view student data
- **Access Level**: Access to assigned students' information
- **Graduation Plan Requirements**: Students must have ≥157 acquired hours

### Administrator Role
- **Purpose**: System administration and management
- **Permissions**: Full system access, course management, financial operations
- **Access Level**: Complete system access
- **Financial Management**: Can update student status based on payment history

## 🔌 API Documentation

### Authentication Endpoints
- `POST /Login.aspx` - User authentication
- `POST /Register.aspx` - User registration
- `GET /Logout` - Session termination

### Student Endpoints
- `GET /courses.aspx` - View available courses
- `POST /course_request.aspx` - Submit course requests
- `GET /transcript.aspx` - View academic transcript
- `POST /credit_hour_request.aspx` - Submit credit hour requests
- `GET /graduation_plan.aspx` - View graduation plan
- `POST /makeup_exam.aspx` - Register for makeup exams

### Advisor Endpoints
- `GET /advisor.aspx` - Advisor dashboard
- `POST /graduation_plan.aspx` - Manage graduation plans
- `GET /pending_requests.aspx` - View pending requests
- `POST /approve_request.aspx` - Approve/reject requests

### Administrator Endpoints
- `GET /Admin2.aspx` - Admin dashboard
- `POST /course_management.aspx` - Course operations
- `GET /reports.aspx` - Generate reports
- `POST /payment_management.aspx` - Payment operations

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
├── SqlQuery_1.sql         # Database schema and procedures
└── WebApplication1.sln     # Solution file
```

### Key Files
- **First_Page.aspx**: Application entry point
- **Login_Student.aspx**: Student authentication
- **advisor.aspx**: Advisor dashboard
- **Admin2.aspx**: Administrator dashboard
- **Web.config**: Application configuration
- **SqlQuery_1.sql**: Complete database schema and business logic

### Development Guidelines
1. **Code Style**: Follow C# coding conventions
2. **Naming**: Use descriptive names for controls and variables
3. **Error Handling**: Implement proper exception handling
4. **Security**: Validate all user inputs
5. **Performance**: Use stored procedures for database operations
6. **Database**: Follow the established schema and procedure patterns

## 🧪 Testing

### Unit Testing
- Test individual stored procedures and functions
- Mock database connections for isolated testing
- Verify business logic correctness
- Test authentication and authorization

### Integration Testing
- Test complete user workflows
- Verify database operations and constraints
- Test role-based access control
- Validate financial status checks

### User Acceptance Testing
- Test with actual users from each role
- Verify all features work as expected
- Validate user experience and workflows
- Test edge cases and error scenarios

## 🚀 Deployment

### Development Deployment
1. Build the solution in Visual Studio
2. Run locally using IIS Express
3. Test all functionality with sample data

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
   - Ensure proper database permissions

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
- Follow database schema conventions

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
- [ ] Email notifications for requests
- [ ] Calendar integration for course schedules
- [ ] Advanced analytics and reporting

### Version History
- **v1.0.0** - Initial release with core functionality
- **v1.1.0** - Enhanced user interface
- **v1.2.0** - Improved performance and security
- **v1.3.0** - Complete database schema and stored procedures

---

