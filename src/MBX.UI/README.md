# MBXUI - Frontend for MesBaX

[![Build Status](https://img.shields.io/badge/build-passing-brightgreen.svg)](<LINK_TO_YOUR_CI/CD_BUILD_STATUS>)
[![License](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](LICENSE)

**MBXUI** is the frontend application for **MesBaX**, an advanced e-commerce platform providing powerful sales and business analytics solutions. This project is built with **Angular 16.2.16** and provides a modern, responsive, and user-friendly interface for interacting with the MesBaX backend.

## 🚀 Key Features

*   **Modern UI/UX:** Leverages Angular Material for a consistent and intuitive user experience.
*   **Responsive Design:** Adapts seamlessly to different screen sizes (desktops, tablets, and mobile devices).
*   **Component-Based Architecture:** Built using reusable and modular components for maintainability and scalability.
*   **State Management:** Employs NgRx (or another state management library) for efficient data flow and predictable state changes (optional).
*   **Secure Authentication:** Integrates with MesBaX backend for secure user authentication and authorization using JWT (JSON Web Tokens).
*   **Real-time Updates:** Utilizes WebSockets (or other real-time technologies) for live data updates (optional).

## 🛠️ Prerequisites

Before you begin, ensure you have met the following requirements:

*   **Node.js:** [Download and install Node.js](https://nodejs.org/) (LTS version recommended).
*   **npm:** npm is distributed with Node.js - which means that when you download Node.js, you automatically get npm installed on your computer.
*   **Angular CLI:** Install globally using npm:
    ```bash
    npm install -g @angular/cli
    ```
*   **MesBaX Backend:** The MesBaX backend API must be running and accessible. Refer to the [MesBaX Backend README](<LINK_TO_MESBAX_BACKEND_README>) for instructions on setting up and running the backend.

## 💻 Installation

1. **Clone the repository:**

    ```bash
    git clone <https://github.com/phamtiendungcw/MesBaX>
    cd MesBaX/src/MesBaX-UI
    ```

2. **Install dependencies:**

    ```bash
    npm install
    ```

## ⚙️ Configuration

*   **API Endpoint:** Configure the base URL of the MesBaX backend API in the `src/environments/environment.ts` and `src/environments/environment.prod.ts` files:
    ```typescript
    export const environment = {
        production: false,
        apiUrl: 'http://localhost:5000/api' // Replace with your backend API URL
    };

    export const environment = {
        production: true,
        apiUrl: 'https://api.mesbax.com/api' // Replace with your production backend API URL
    };
    ```
*   **(Optional) Other configurations:** Configure other settings such as authentication details, third-party API keys, etc., as needed, within the `src/environments` files or dedicated configuration services.

## 🖥️ Development server

Run `ng serve` for a dev server. Navigate to `http://localhost:4200/`. The application will automatically reload if you change any of the source files.

*   For a production build and serve use: `ng serve --configuration production`

## 🏗️ Build

Run `ng build` to build the project. The build artifacts will be stored in the `dist/` directory.

*   Use `ng build --configuration production` for a production build.

## 🧪 Running unit tests

Run `ng test` to execute the unit tests via [Karma](https://karma-runner.github.io).

*   Use `ng test --code-coverage` to generate code coverage report.

## 🌐 Running end-to-end tests

Run `ng e2e` to execute the end-to-end tests via a platform of your choice (e.g., Protractor, Cypress). To use this command, you need to first add a package that implements end-to-end testing capabilities.

*   **Note:** This project currently uses <Cypress/Protractor/Other>. You might need to configure the e2e tests according to your chosen platform.

## 🗂️ Project Structure

```plaintext
MesBaX-UI/
├── e2e/ # End-to-end tests
├── node_modules/ # Node.js modules
├── src/
│ ├── app/ # Application source code
│ │ ├── core/ # Core modules (services, interceptors, etc.)
│ │ ├── shared/ # Shared modules, components, directives, pipes
│ │ ├── modules/ # Feature modules (e.g., product, order, customer)
│ │ ├── app.component.* # Main application component
│ │ ├── app.module.ts # Main application module
│ │ └── app-routing.module.ts # Main application routing
│ ├── assets/ # Static assets (images, fonts, etc.)
│ ├── environments/ # Environment-specific configuration
│ ├── index.html # Main HTML file
│ ├── main.ts # Application entry point
│ ├── polyfills.ts # Polyfills for browser compatibility
│ ├── styles.scss # Global styles
│ └── test.ts # Unit test entry point
├── .angular.json # Angular CLI configuration
├── .editorconfig # Editor configuration
├── .gitignore # Git ignore file
├── karma.conf.js # Karma configuration
├── package.json # Project dependencies and scripts
├── README.md # Project README
├── tsconfig.app.json # TypeScript configuration for the application
├── tsconfig.json # TypeScript configuration
└── tsconfig.spec.json # TypeScript configuration for tests
```

## 🤝 Contributing

We welcome contributions! Please see the [CONTRIBUTING.md](CONTRIBUTING.md) file in the main MesBaX repository for guidelines on how to contribute to this project.

## 📜 License

This project is licensed under the Apache 2.0 License - see the [LICENSE](LICENSE) file for details.

## 📧 Contact
For inquiries, please contact the development team at **[mesbaxdev@gmail.com](mailto:mesbaxdev@gmail.com)**.

## Further help

To get more help on the Angular CLI use `ng help` or go check out the [Angular CLI Overview and Command Reference](https://angular.io/cli) page.
