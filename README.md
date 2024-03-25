# Digital Employment Connect Platform

## Introduction
The Digital Employment Connect Platform serves as a dynamic bridge between job seekers and employers, streamlining the job search and recruitment process. It is designed to be user-friendly, efficient, and secure, leveraging the power of .NET Core, SQL, and AWS.

## Features
- Profile management for job seekers and employers.
- Job postings and application management.
- Secure authentication and user authorization.
- RESTful API for seamless front-end and back-end integration.
- Scalable architecture deployed on AWS for robustness and security.

## Technical Stack
- **Back-End:** .NET Core
- **Database:** SQL Server
- **Cloud Services:** AWS (S3, EC2)
- **Containerization:** Docker
- **API:** RESTful services

## Project Structure
- **Controllers/**: REST API controllers handling HTTP requests.
- **DTOs/**: Data Transfer Objects for encapsulating data and sending it from the API.
- **Mappings/**: AutoMapper configuration for object-object mapping.
- **Models/**: Entity models representing the database structure.
- **Services/**: Business logic services for handling data operations.
- **appsettings.json**: Configuration settings for the application.
- **Dockerfile**: Container configuration file for Docker.
- **Program.cs & Startup.cs**: Entry points for configuring and running the .NET Core application.

## Data Modeling
The project includes a comprehensive data model tailored for employment connectivity. The ER Diagram in the documentation visually represents the `JobSeeker` and `JobOffer` entities, detailing attributes and relationships essential for the platform's functionality.

### Entities
- **JobSeeker**: Represents individuals seeking employment, with attributes such as ID, Name, Email, Skills, and Location.
- **JobOffer**: Represents employment opportunities posted by employers, with details like ID, Job Name, Title, Required Experience and Skills, and Salary.

## Reflections and Learning
Throughout the development of this platform, significant learning milestones were achieved. Proficiency was gained in .NET Core and SQL for robust back-end development. Cloud deployment knowledge was deepened, particularly with AWS services, enhancing the platform's scalability and reliability. The implementation of secure authentication mechanisms was another critical area of development, ensuring the safeguarding of user data.

Challenges such as ensuring data security were met with the adoption of HTTPS protocols and encryption techniques. The complexity of the system was managed to maintain user accessibility and a seamless experience.

The collaborative nature of the project honed team communication and project management skills, setting a foundation for future team-oriented endeavors.

## Getting Started
To get a local copy up and running follow these simple steps.

### Prerequisites
Before you begin, ensure you have met the following requirements:
- .NET Core 3.1 SDK or later
- SQL Server running locally or remotely with the necessary permissions
- Docker installed and running if you wish to containerize the application

### Installation

1. **Clone the repository**
   ```sh
   git clone https://github.com/beyuneek/Digital-Employment-Connect-Platform.git
   cd DigitalEmploymentConnectPlatform


## Acknowledgments
- Special thanks to Centennial College and all project contributors.
- Appreciation for the mentors and peers who provided guidance and support.

## Contact
- **Developer:** Parth sharma 
- **Email:** Parthsharma11847@gmail.com
  
