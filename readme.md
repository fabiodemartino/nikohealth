**Angular 16 and C# API Application**
Welcome to the documentation for the Angular 16 and C# API application! This application combines the power of the Angular framework for the frontend and utilizes C# for building a robust API on the backend. This document will provide you with essential information to get started, understand the project structure, and contribute to the development of this application.

**Table of Contents**
**Introduction**
**Features**
**Prerequisites**
**Installation**
**Project Structure**
**Usage**
**Contributing**
**License**

**Introduction**
This application serves as an example of how to integrate the Angular 16 frontend with a C# backend API. It demonstrates best practices for creating a modern web application that separates the user interface logic from the server-side logic. Angular 16 provides a robust framework for building dynamic and responsive user interfaces, while C# offers a powerful platform for building RESTful APIs.

**Features**
**Angular 16 Frontend**: Utilize the power of Angular 16 to create a seamless and interactive user experience.

**C# API Backend**: Develop a reliable backend using C# to handle data processing, authentication, and more.

**RESTful API**: Design a RESTful API architecture to ensure smooth communication between the frontend and backend.

**Modular Project Structure**: The project is organized into distinct modules, promoting code maintainability and scalability.

**Authentication and Security:** Not implemented due to limited time

**Prerequisites**
Before you begin, ensure you have the following prerequisites:

**Node.js:** Make sure you have Node.js installed. You can download it from nodejs.org.

**Angular CLI:** Install the Angular CLI globally by running: npm install -g @angular/cli.

**Visual Studio or Visual Studio Code:** You will need a code editor to work on the C# backend. Visual Studio and Visual Studio Code are recommended options.

**.NET SDK**: Install the .NET SDK for C# development. You can download it from dotnet.microsoft.com.

**Installation**
Clone this repository to your local machine: git clone https://github.com/fabiodemartino/nikohealth.

**Navigate to the frontend directory**: cd nikohealth.UI and run npm install to install frontend dependencies.

Navigate to the backend directory nikohealth.Api using Visual Studio open the nikohealth.Api solution file.
Build the solution and run it

After that run the User interface with the ng serve command using Visual Studio code.

**Project Structure**
The project is structured as follows:

The **nikohealth.UI**: Contains the Angular 16 frontend code.

src: Source code for the frontend application.
angular.json: Angular configuration file.
...
The **nikohealth.Api**: Houses the C# API backend code.

Controllers: Contains API controller classes.
Models: Defines data models used by the application.
appsettings.json: Configuration settings for the backend.
...
**Usage**
Start the frontend development server: In the frontend directory, run ng serve. Access the app at http://localhost:4200.

Run the C# backend: Build and run the backend using Visual Studio or Visual Studio Code. The API will be accessible at https://localhost:7169 or http://localhost:5169

Begin developing: Use the example components and API endpoints as a starting point to build your application.

License
This project is licensed under the MIT License.

Feel free to explore, experiment, and build upon this Angular 16 and C# API application. If you encounter any issues or have questions, please don't hesitate to reach out!