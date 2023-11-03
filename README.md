# TechProsNG Backend Task

This repository contains the code for the TechProsNG Backend Task, which involves the development of a RESTful API for user authentication, course enrollment, and user information retrieval.

## Table of Contents

- [Introduction](#introduction)
- [Task Overview](#task-overview)
- [Approach](#approach)
- [Project Structure](#project-structure)
- [API Endpoints](#api-endpoints)
- [How to Run](#how-to-run)
- [API Documentation](#api-documentation)
- [Contributors](#contributors)
- [License](#license)

## Introduction

This project is a RESTful API implemented in C# using ASP.NET Core, and it includes features for user registration, user login, course enrollment, and user information retrieval.

## Task Overview

The task involves creating an API for user authentication, course enrollment, and user information retrieval. The specific functionalities include:
- User registration with email and password.
- User login with email and password.
- Enrolling users in courses.
- Retrieving user information, including enrolled courses.

## Approach

We've followed best practices in software development, including using the repository pattern for data access and structuring our code in a maintainable and scalable way. We've implemented user authentication using ASP.NET Core Identity and JWT for secure user login. The project has been thoroughly tested to ensure it functions as expected.

## Project Structure

The project is organized into the following components:
- **Controllers**: These handle incoming HTTP requests and contain the API endpoints for user registration, login, course enrollment, and user information retrieval.
- **Services**: These encapsulate the business logic and provide an interface for interacting with the database.
- **Repositories**: These handle data access, including CRUD operations for users, courses, and enrollments.
- **Models**: These define the data structures used in the application.

## API Endpoints

The API endpoints and methods are as follows:
- `POST /api/user/register`: Register a new user with an email and password.
- `POST /api/user/login`: Authenticate and log in a user with email and password.
- `GET /api/course`: Retrieve a list of available courses.
- `GET /api/course/{id}`: Retrieve a specific course by ID.
- `POST /api/course/enroll`: Enroll a user in a course.

Please refer to the code and source files for detailed information about each endpoint and its expected responses.

## How to Run

To run this project locally, follow these steps:
1. Clone the repository to your local machine.
2. Set up your database connection and connection string in the `appsettings.json` file.
3. Build and run the project using your preferred development environment or command line tools.

## API Documentation

We've used Swagger for automatic API documentation. You can access the Swagger UI at `/swagger` to explore and test the API endpoints interactively.

## License

