# Employee Web API

Welcome to the Employee Web API project! This README will guide you through the setup, structure, and usage of the project. This application is developed using ASP.NET Core and provides a robust platform for managing employee data through a web API.

## Project Overview

The Employee Web API is a comprehensive web application that includes the following key features:

- **CRUD Operations**: Create, read, update, and delete employee records.
- **User Authentication**: Secure login and registration system.
- **Search and Filter**: Easily find and filter employee records.
- **Documentation**: Comprehensive API documentation using Swagger.

## Features

### CRUD Operations

- **Create**: Add new employee records.
- **Read**: Retrieve employee details.
- **Update**: Modify existing employee records.
- **Delete**: Remove employee records.

### User Authentication

- Secure login and registration system to manage user access.

### Search and Filter

- Efficiently search and filter through employee records.

### Documentation

- API documentation with Swagger for easy integration and testing.

## Getting Started

### Prerequisites

- Visual Studio 2022
- .NET 8 SDK
- SQL Server Management Studio

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/krispyarena/emp-web-api.git
   cd emp-web-api
   ```

2. **Setup the Database**
   - Update the connection string in `appsettings.json` with your SQL Server instance.
   - Apply migrations to create the database schema.
   ```bash
   dotnet ef database update
   ```

3. **Run the Application**
   - Open the solution in Visual Studio.
   - Build the solution to restore dependencies.
   - Run the application.

### Usage

- Navigate to the application URL in your browser.
- Use the Swagger UI to explore and test the API endpoints.

### Deployment

#### Deploying to Azure

- Follow the official [Microsoft Azure documentation](https://docs.microsoft.com/en-us/azure/app-service/) to deploy the application to Azure.

#### Deploying to IIS

- Follow the official [Microsoft IIS documentation](https://docs.microsoft.com/en-us/iis/) to deploy the application to IIS.

## Contributing

If you would like to contribute to this project, please fork the repository and create a pull request. We welcome all contributions that improve the project.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Contact

For any inquiries or feedback, please contact at krispy.arena@gmail.com or create an issue on this repository.
